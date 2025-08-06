using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HikingApp.Data;
using HikingApp.Models;
using Microsoft.EntityFrameworkCore;

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

    // GET: api/comments/hike/5
    [HttpGet("hike/{hikeId}")]
    [Authorize]
    public async Task<IActionResult> GetCommentsForHike(int hikeId)
    {
        var comments = await _dbContext.Comments
            .Include(c => c.UserProfile)
            .Where(c => c.HikeId == hikeId)
            .OrderByDescending(c => c.DatePosted)
            .ToListAsync();

        return Ok(comments);
    }

    // POST: api/comments
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> PostComment(Comment comment)
    {
        comment.DatePosted = DateTime.UtcNow;
        _dbContext.Comments.Add(comment);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCommentsForHike), new { hikeId = comment.HikeId }, comment);
    }
}
