
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HikingApp.Data;
using HikingApp.Models;
using System.Security.Claims;

namespace HikingApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HikeLikesController : ControllerBase
{
    private readonly HikingAppDbContext _dbContext;

    public HikeLikesController(HikingAppDbContext context)
    {
        _dbContext = context;
    }

    [HttpPost("{hikeId}")]
    [Authorize]
    public IActionResult ToggleHikeLike(int hikeId)
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (identityUserId == null) return Unauthorized();

        var userProfile = _dbContext.UserProfiles.FirstOrDefault(up => up.IdentityUserId == identityUserId);
        if (userProfile == null) return Unauthorized();

        var hike = _dbContext.Hikes.FirstOrDefault(h => h.Id == hikeId);
        if (hike == null) return NotFound("Hike not found.");

        if (hike.UserProfileId == userProfile.Id)
        {
            return BadRequest("You cannot like your own hike.");
        }

        var existingLike = _dbContext.HikeLikes
            .FirstOrDefault(l => l.HikeId == hikeId && l.UserProfileId == userProfile.Id);

        if (existingLike != null)
        {
            _dbContext.HikeLikes.Remove(existingLike);
            _dbContext.SaveChanges();
            return Ok(new { status = "unliked" });
        }

        var newLike = new HikeLike
        {
            HikeId = hikeId,
            UserProfileId = userProfile.Id
        };

        _dbContext.HikeLikes.Add(newLike);
        _dbContext.SaveChanges();

        return Ok(new { status = "liked" });
    }






    [HttpGet("{hikeId}/count")]
    [Authorize]
    public IActionResult GetLikeCount(int hikeId)
    {
        var hike = _dbContext.Hikes.FirstOrDefault(h => h.Id == hikeId);
        if (hike == null)
        {
            return NotFound("Hike not found.");
        }

        int count = _dbContext.HikeLikes.Count(l => l.HikeId == hikeId);
        return Ok(count);
    }

}
