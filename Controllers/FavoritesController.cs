using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HikingApp.Data;
using HikingApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        public IActionResult GetFavoritesByUser(int userId)
        {
            var favorites = _context.Favorites
                .Include(f => f.Hike)
                    .ThenInclude(h => h.UserProfile)
                .Include(f => f.Hike)
                    .ThenInclude(h => h.Difficulty) // if difficulty is a nav prop
                .Where(f => f.UserProfileId == userId)
                .Select(f => new
                {
                    f.Hike.Id,
                    f.Hike.Title,
                    f.Hike.Description,
                    f.Hike.Distance,
                    f.Hike.AddressLine1,
                    f.Hike.City,
                    f.Hike.State,
                    f.Hike.Zip,
                    f.Hike.IsDogFriendly,
                    f.Hike.IsKidFriendly,
                    f.Hike.IsHandicapAccessible,
                    f.Hike.HasRestrooms,
                    f.Hike.IsPaved,
                    f.Hike.IsGravel,
                    DifficultyLevel = f.Hike.Difficulty.Level,
                    UserFullName = f.Hike.UserProfile.FullName,
                    f.Hike.DateCreated
                })
                .ToList();

            return Ok(favorites);
        }




        [HttpPost]
        [Authorize]
        public IActionResult AddFavorite([FromBody] Favorite favorite)
        {
            favorite.UserProfile = null;
            favorite.Hike = null;

            bool exists = _context.Favorites.Any(f =>
                f.UserProfileId == favorite.UserProfileId &&
                f.HikeId == favorite.HikeId);

            if (exists)
            {
                return BadRequest("This hike is already favorited.");
            }

            Favorite newFavorite = new Favorite
            {
                UserProfileId = favorite.UserProfileId,
                HikeId = favorite.HikeId,
                DateFavorited = DateTime.Now
            };

            _context.Favorites.Add(newFavorite);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetFavoritesByUser),
                new { userId = newFavorite.UserProfileId }, newFavorite);
        }



        [HttpDelete]
        [Authorize]
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
