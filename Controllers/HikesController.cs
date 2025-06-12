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
    private readonly HikingAppDbContext _context;

    public HikesController(HikingAppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAllHikes()
    {
        List<Hike> hikes = _context.Hikes
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
                Location = hike.Location,
                Distance = hike.Distance,
                Difficulty = hike.Difficulty.Level,
                IsDogFriendly = hike.IsDogFriendly,
                UserFullName = $"{hike.UserProfile.FirstName} {hike.UserProfile.LastName}"
            };

            hikeDTOs.Add(newHikeDTO);
        }

        return Ok(hikeDTOs);
    }

    [HttpPost]
    [Authorize]
    public IActionResult CreateHike(CreateHikeDTO newHike)
    {
        Hike hike = new Hike
        {
            Title = newHike.Title,
            Description = newHike.Description,
            Location = newHike.Location,
            Distance = newHike.Distance,
            DifficultyId = newHike.DifficultyId,
            IsDogFriendly = newHike.IsDogFriendly,
            UserProfileId = newHike.UserProfileId
        };

        _context.Hikes.Add(hike);
        _context.SaveChanges();

        return Ok(hike);
    }


}
