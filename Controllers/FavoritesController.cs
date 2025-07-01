using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HikingApp.Data;
using HikingApp.Models;
using System.Linq;

namespace HikingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoritesController : ControllerBase
    {
        private readonly HikingAppDbContext _context;

        public FavoritesController(HikingAppDbContext context)
        {
            _context = context;
        }


        [HttpGet("user/{userId}")]
        public IActionResult GetFavoritesByUser(int userId)
        {
            var favorites = _context.Favorites
                .Include(f => f.Hike)
                .Where(f => f.UserProfileId == userId)
                .Select(f => f.Hike)
                .ToList();

            return Ok(favorites);
        }


        [HttpPost]
        public IActionResult AddFavorite([FromBody] Favorite favorite)
        {
            var exists = _context.Favorites.Any(f => f.UserProfileId == favorite.UserProfileId && f.HikeId == favorite.HikeId);

            if (exists)
            {
                return BadRequest("This hike is already favorited.");
            }

            _context.Favorites.Add(favorite);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetFavoritesByUser), new { userId = favorite.UserProfileId }, favorite);
        }


        [HttpDelete]
        public IActionResult RemoveFavorite(int userId, int hikeId)
        {
            var favorite = _context.Favorites
                .FirstOrDefault(f => f.UserProfileId == userId && f.HikeId == hikeId);

            if (favorite == null)
            {
                return NotFound();
            }

            _context.Favorites.Remove(favorite);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
