using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HikingApp.Models;
using HikingApp.Models.DTOs;
using HikingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace HikingApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DifficultyController : ControllerBase
{
    private readonly HikingAppDbContext _context;

    public DifficultyController(HikingAppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAllDifficulties()
    {
        return Ok(_context.Difficulties.ToList());
    }
}
