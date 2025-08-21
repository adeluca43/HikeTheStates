using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HikingApp.Data;
using HikingApp.Models;
using HikingApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HikingApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentsController : ControllerBase
{
    private readonly HikingAppDbContext _dbContext;

    public CommentsController(HikingAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("hike/{hikeId}")]
    [Authorize]
    public async Task<IActionResult> GetCommentsForHike(int hikeId)
    {
        var comments = await _dbContext.Comments
            .Include(c => c.UserProfile)
            .Where(c => c.HikeId == hikeId)
            .OrderByDescending(c => c.DatePosted)
            .Select(c => new CommentDTO
            {
                Id = c.Id,
                Content = c.Content,
                DatePosted = c.DatePosted,
                HikeId = c.HikeId,
                UserId = c.UserProfile.Id,
                FirstName = c.UserProfile.FirstName,
                LastName = c.UserProfile.LastName
            })
            .ToListAsync();

        return Ok(comments);
    }


    [HttpPost]
    public async Task<IActionResult> PostComment([FromBody] Comment comment)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var hike = await _dbContext.Hikes.FindAsync(comment.HikeId);
        if (hike == null) return BadRequest("Invalid HikeId.");

        var userProfile = await _dbContext.UserProfiles.FindAsync(comment.UserProfileId);
        if (userProfile == null) return BadRequest("Invalid UserProfileId.");

        comment.DatePosted = DateTime.UtcNow;
        _dbContext.Comments.Add(comment);
        await _dbContext.SaveChangesAsync();

        var dto = new CommentDTO
        {
            Id = comment.Id,
            Content = comment.Content,
            DatePosted = comment.DatePosted,
            HikeId = comment.HikeId,
            UserId = userProfile.Id,
            FirstName = userProfile.FirstName,
            LastName = userProfile.LastName
        };

        return CreatedAtAction(nameof(GetCommentsForHike), new { hikeId = comment.HikeId }, dto);
    }



    [HttpDelete("{id:int}")]
    [Authorize]
    public async Task<IActionResult> DeleteComment(int id)
    {
        var comment = await _dbContext.Comments.FirstOrDefaultAsync(c => c.Id == id);
        if (comment == null) return NotFound();

        // Check if the user is the owner of the comment or an admin
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (identityUserId == null) return Unauthorized();

        var currentProfile = await _dbContext.UserProfiles
            .AsNoTracking()
            .SingleOrDefaultAsync(up => up.IdentityUserId == identityUserId);

        if (currentProfile == null) return Unauthorized();

        var isOwner = comment.UserProfileId == currentProfile.Id;
        var isAdmin = User.IsInRole("Admin");

        if (!isOwner && !isAdmin) return Forbid(); // 403

        _dbContext.Comments.Remove(comment);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }
}

