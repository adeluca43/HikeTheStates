using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HikingApp.Data;
using HikingApp.Models;
using HikingApp.Models.DTOs;

namespace HikingApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly HikingAppDbContext _dbContext;

    public UserProfileController(HikingAppDbContext context)
    {
        _dbContext = context;
    }
    [HttpGet("{id}/hikes")]
    [Authorize]
    public IActionResult GetUserProfileWithHikes(int id)
    {
        UserProfile userProfile = _dbContext.UserProfiles
            .Include(up => up.Hikes)
                .ThenInclude(h => h.Difficulty)
            .FirstOrDefault(up => up.Id == id);

        if (userProfile == null)
        {
            return NotFound();
        }

        UserProfileWithHikesDTO newDTO = new UserProfileWithHikesDTO
        {
            Id = userProfile.Id,
            FullName = userProfile.FullName,
            Email = userProfile.Email,
            ImageLocation = userProfile.ImageLocation,
            Hikes = userProfile.Hikes.Select(h => new HikeDTO
            {
                Id = h.Id,
                Title = h.Title,
                Description = h.Description,
                Location = h.Location,
                Distance = h.Distance,
                Difficulty = h.Difficulty.Level,
                IsDogFriendly = h.IsDogFriendly,
                IsKidFriendly = h.IsKidFriendly,
                IsHandicapAccessible = h.IsHandicapAccessible,
                HasRestrooms = h.HasRestrooms,
                IsPaved = h.IsPaved,
                IsGravel = h.IsGravel,
                UserProfileId = h.UserProfileId,
                UserFullName = userProfile.FullName,
                DateCreated = h.DateCreated
            }).ToList()

        };

        return Ok(newDTO);
    }


    [HttpPut("{id}")]
    [Authorize]
    public IActionResult UpdateUserProfile(int id, UpdateUserProfileDTO updatedProfile)
    {
        var userProfile = _dbContext.UserProfiles.FirstOrDefault(up => up.Id == id);

        if (userProfile == null) return NotFound();

        userProfile.FirstName = updatedProfile.FirstName;
        userProfile.LastName = updatedProfile.LastName;
        userProfile.Email = updatedProfile.Email;
        userProfile.ImageLocation = updatedProfile.ImageLocation;

        _dbContext.SaveChanges();

        return NoContent();
    }


    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetUserProfile(int id)
    {
        UserProfile userProfile = _dbContext.UserProfiles.FirstOrDefault(up => up.Id == id);

        if (userProfile == null) return NotFound();

        UserProfileDTO proDto = new UserProfileDTO
        {
            Id = userProfile.Id,
            FirstName = userProfile.FirstName,
            LastName = userProfile.LastName,
            Email = userProfile.Email,
            ImageLocation = userProfile.ImageLocation
        };

        return Ok(proDto);
    }
}