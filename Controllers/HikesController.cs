using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HikingApp.Data;
using HikingApp.Models.DTOs;
using HikingApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HikingApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HikesController : ControllerBase
{
    private readonly HikingAppDbContext _dbContext;

    public HikesController(HikingAppDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAllHikes()
    {
        List<Hike> hikes = _dbContext.Hikes
            .Include(h => h.UserProfile)
            .Include(h => h.Difficulty)
            .ToList();

        List<HikeDTO> hikeDTOs = new List<HikeDTO>();

        foreach (Hike hike in hikes)
        {
            HikeDTO newHikeDTO = new HikeDTO
            {
                Id = hike.Id,
                Title = hike.Title,
                Description = hike.Description,
                AddressLine1 = hike.AddressLine1,
                City = hike.City,
                State = hike.State,
                Zip = hike.Zip,
                Distance = hike.Distance,
                Difficulty = hike.Difficulty.Level,
                IsDogFriendly = hike.IsDogFriendly,
                IsKidFriendly = hike.IsKidFriendly,
                IsHandicapAccessible = hike.IsHandicapAccessible,
                HasRestrooms = hike.HasRestrooms,
                IsPaved = hike.IsPaved,
                IsGravel = hike.IsGravel,
                UserProfileId = hike.UserProfileId,
                UserFullName = $"{hike.UserProfile.FirstName} {hike.UserProfile.LastName}",
                Latitude = hike.Latitude,
                Longitude = hike.Longitude,
                DateCreated = hike.DateCreated
            };

            hikeDTOs.Add(newHikeDTO);
        }

        return Ok(hikeDTOs);
    }
    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetHikeById(int id)
    {
        Hike hike = _dbContext.Hikes
            .Include(h => h.Difficulty)
            .Include(h => h.UserProfile)
            .FirstOrDefault(h => h.Id == id);

        if (hike == null)
        {
            return NotFound();
        }

        EditHikeDTO EditHikeDTO = new EditHikeDTO
        {
            Id = hike.Id,
            Title = hike.Title,
            Description = hike.Description,
            AddressLine1 = hike.AddressLine1,
            City = hike.City,
            State = hike.State,
            Zip = hike.Zip,
            Distance = hike.Distance,
            DifficultyId = hike.DifficultyId,
            DifficultyLevel = hike.Difficulty.Level,
            IsDogFriendly = hike.IsDogFriendly,
            IsKidFriendly = hike.IsKidFriendly,
            IsHandicapAccessible = hike.IsHandicapAccessible,
            HasRestrooms = hike.HasRestrooms,
            IsPaved = hike.IsPaved,
            IsGravel = hike.IsGravel,
            UserProfileId = hike.UserProfileId,
            UserFullName = $"{hike.UserProfile.FirstName} {hike.UserProfile.LastName}",
            DateCreated = hike.DateCreated
        };

        return Ok(EditHikeDTO);
    }

    [HttpPost]
    [Authorize]
    public IActionResult CreateHike(CreateHikeDTO newHike)
    {
        Hike hike = new Hike
        {
            Title = newHike.Title,
            Description = newHike.Description,
            AddressLine1 = newHike.AddressLine1,
            City = newHike.City,
            State = newHike.State,
            Zip = newHike.Zip,
            Distance = newHike.Distance,
            DifficultyId = newHike.DifficultyId,
            IsDogFriendly = newHike.IsDogFriendly,
            IsKidFriendly = newHike.IsKidFriendly,
            IsHandicapAccessible = newHike.IsHandicapAccessible,
            HasRestrooms = newHike.HasRestrooms,
            IsPaved = newHike.IsPaved,
            IsGravel = newHike.IsGravel,
            UserProfileId = newHike.UserProfileId,
            Latitude = newHike.Latitude,
            Longitude = newHike.Longitude,
            DateCreated = DateTime.Now

        };

        _dbContext.Hikes.Add(hike);
        _dbContext.SaveChanges();

        return Ok(hike);
    }

    [HttpDelete("{id}")]
    [Authorize]
    public IActionResult DeleteHike(int id)
    {
        Hike hikeToDelete = _dbContext.Hikes.FirstOrDefault(h => h.Id == id);

        if (hikeToDelete == null)
        {
            return NotFound();
        }
        _dbContext.Hikes.Remove(hikeToDelete);
        _dbContext.SaveChanges();

        return NoContent();
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult UpdateHike(int id, [FromBody] CreateHikeDTO updatedHike)
    {
        Hike existingHike = _dbContext.Hikes.FirstOrDefault(h => h.Id == id);

        if (existingHike == null)
        {
            return NotFound();
        }

        existingHike.Title = updatedHike.Title;
        existingHike.Description = updatedHike.Description;
        existingHike.AddressLine1 = updatedHike.AddressLine1;
        existingHike.City = updatedHike.City;
        existingHike.State = updatedHike.State;
        existingHike.Zip = updatedHike.Zip;
        existingHike.Distance = updatedHike.Distance;
        existingHike.DifficultyId = updatedHike.DifficultyId;
        existingHike.IsDogFriendly = updatedHike.IsDogFriendly;
        existingHike.IsKidFriendly = updatedHike.IsKidFriendly;
        existingHike.IsHandicapAccessible = updatedHike.IsHandicapAccessible;
        existingHike.HasRestrooms = updatedHike.HasRestrooms;
        existingHike.IsPaved = updatedHike.IsPaved;
        existingHike.IsGravel = updatedHike.IsGravel;

        _dbContext.SaveChanges();

        return NoContent();
    }
}
