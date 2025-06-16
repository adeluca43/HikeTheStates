using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HikingApp.Models;

namespace HikingApp.Data;

public class HikingAppDbContext : IdentityDbContext
{
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Hike> Hikes { get; set; }
    public DbSet<Difficulty> Difficulties { get; set; }



    public HikingAppDbContext(DbContextOptions<HikingAppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserProfile>().ToTable("UserProfiles");

        modelBuilder.Entity<UserProfile>()
      .Property(u => u.ImageLocation)
      .HasMaxLength(1000);

        modelBuilder.Entity<UserProfile>()
               .HasMany(up => up.Hikes)
               .WithOne(h => h.UserProfile)
               .HasForeignKey(h => h.UserProfileId);

        var hasher = new PasswordHasher<IdentityUser>();

        // Seed roles
        var adminRole = new IdentityRole
        {
            Id = "role-admin-0001",
            Name = "Admin",
            NormalizedName = "ADMIN"
        };

        modelBuilder.Entity<IdentityRole>().HasData(adminRole);

        // Seed users
        var user1 = new IdentityUser
        {
            Id = "1a111111-1111-1111-1111-111111111111",
            UserName = "admin@hiking.com",
            NormalizedUserName = "ADMIN@HIKING.COM",
            Email = "admin@hiking.com",
            NormalizedEmail = "ADMIN@HIKING.COM",
            PasswordHash = hasher.HashPassword(null, "Password1")
        };

        var user2 = new IdentityUser
        {
            Id = "2b222222-2222-2222-2222-222222222222",
            UserName = "user@hiking.com",
            NormalizedUserName = "USER@HIKING.COM",
            Email = "user@hiking.com",
            NormalizedEmail = "USER@HIKING.COM",
            PasswordHash = hasher.HashPassword(null, "Password1")
        };
        var user3 = new IdentityUser
        {
            Id = "3c333333-3333-3333-3333-333333333333",
            UserName = "sarah@email.com",
            NormalizedUserName = "SARAH@EMAIL.COM",
            Email = "sarah@email.com",
            NormalizedEmail = "SARAH@EMAIL.COM",
            PasswordHash = hasher.HashPassword(null, "Password1")
        };

        var user4 = new IdentityUser
        {
            Id = "4d444444-4444-4444-4444-444444444444",
            UserName = "josh@email.com",
            NormalizedUserName = "JOSH@EMAIL.COM",
            Email = "josh@email.com",
            NormalizedEmail = "JOSH@EMAIL.COM",
            PasswordHash = hasher.HashPassword(null, "Password1")
        };

        var user5 = new IdentityUser
        {
            Id = "5e555555-5555-5555-5555-555555555555",
            UserName = "amber@email.com",
            NormalizedUserName = "AMBER@EMAIL.COM",
            Email = "amber@email.com",
            NormalizedEmail = "AMBER@EMAIL.COM",
            PasswordHash = hasher.HashPassword(null, "Password1")
        };

        modelBuilder.Entity<IdentityUser>().HasData(user1, user2, user3, user4, user5);

        // Assign admin role to user1
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                UserId = user1.Id,
                RoleId = adminRole.Id
            }
        );

        // Seed UserProfiles
        modelBuilder.Entity<UserProfile>().HasData(
            new UserProfile
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Hiker",
                Email = "admin@hiking.com",
                IdentityUserId = user1.Id,
                ImageLocation = "https://i.pravatar.cc/150?img=47"
            },
            new UserProfile
            {
                Id = 2,
                FirstName = "Standard",
                LastName = "User",
                Email = "user@hiking.com",
                IdentityUserId = user2.Id,
                ImageLocation = "https://i.pravatar.cc/150?img=12"
            },
            new UserProfile
            {
                Id = 3,
                FirstName = "Sarah",
                LastName = "Woods",
                Email = "sarah@email.com",
                IdentityUserId = user3.Id,
                ImageLocation = "https://i.pravatar.cc/150?img=32"
            },
            new UserProfile
            {
                Id = 4,
                FirstName = "Josh",
                LastName = "Trail",
                Email = "josh@email.com",
                IdentityUserId = user4.Id,
                ImageLocation = "https://i.pravatar.cc/150?img=26"
            },
            new UserProfile
            {
                Id = 5,
                FirstName = "Amber",
                LastName = "Creek",
                Email = "amber@email.com",
                IdentityUserId = user5.Id,
                ImageLocation = "https://i.pravatar.cc/150?img=45"
            }
        );

        modelBuilder.Entity<Difficulty>().HasData(
            new Difficulty { Id = 1, Level = "Easy" },
            new Difficulty { Id = 2, Level = "Moderate" },
            new Difficulty { Id = 3, Level = "Challenging" },
            new Difficulty { Id = 4, Level = "Hard" }
        );

        modelBuilder.Entity<Hike>().HasData(
            new Hike { Id = 1, Title = "Forest Loop", Description = "Peaceful loop through tall trees.", Location = "123 Forest Ln, Nashville, TN 37011", Distance = 3.5, DifficultyId = 1, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-15), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = false, IsGravel = true },
            new Hike { Id = 2, Title = "River Edge Trail", Description = "Trail running alongside the riverbank.", Location = "456 River Rd, Knoxville, TN 37901", Distance = 4.2, DifficultyId = 2, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-20), IsDogFriendly = true, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = true },
            new Hike { Id = 3, Title = "Bluff Overlook", Description = "Scenic view from the bluff.", Location = "789 Bluff Dr, Chattanooga, TN 37401", Distance = 5.1, DifficultyId = 3, UserProfileId = 5, DateCreated = DateTime.Now.AddDays(-10), IsDogFriendly = false, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = false, IsGravel = false },
            new Hike { Id = 4, Title = "Lakeside Path", Description = "Flat path around the lake, great for families.", Location = "321 Lakeview Ave, Clarksville, TN 37040", Distance = 2.8, DifficultyId = 1, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-5), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = true, HasRestrooms = true, IsPaved = true, IsGravel = false },
            new Hike { Id = 5, Title = "Sunset Ridge", Description = "Challenging hike with rewarding sunset views.", Location = "654 Ridge Rd, Cookeville, TN 38501", Distance = 6.7, DifficultyId = 4, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-8), IsDogFriendly = false, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = false },
            new Hike { Id = 6, Title = "Waterfall Trail", Description = "Short hike to a beautiful waterfall.", Location = "987 Falls Blvd, Sparta, TN 38583", Distance = 1.9, DifficultyId = 1, UserProfileId = 5, DateCreated = DateTime.Now.AddDays(-3), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = false, IsGravel = true },
            new Hike { Id = 7, Title = "Rocky Path", Description = "Steep, rocky trail not for beginners.", Location = "159 Rock Ln, Tullahoma, TN 37388", Distance = 5.9, DifficultyId = 4, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-25), IsDogFriendly = false, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = false },
            new Hike { Id = 8, Title = "Birdwatch Loop", Description = "Great spot for birdwatching in spring.", Location = "753 Birdsong Ct, Columbia, TN 38401", Distance = 3.2, DifficultyId = 2, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-13), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = true, HasRestrooms = true, IsPaved = true, IsGravel = false },
            new Hike { Id = 9, Title = "Pine Hollow", Description = "Quiet trail through pine woods.", Location = "111 Pine Ln, Jackson, TN 38301", Distance = 4.5, DifficultyId = 2, UserProfileId = 5, DateCreated = DateTime.Now.AddDays(-17), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = true },
            new Hike { Id = 10, Title = "Creek Crossing", Description = "Cross several shallow creeks.", Location = "222 Creek Rd, Murfreesboro, TN 37130", Distance = 3.7, DifficultyId = 3, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-7), IsDogFriendly = true, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = true },
            new Hike { Id = 11, Title = "Meadow Breeze", Description = "Flat and open with wildflowers.", Location = "333 Meadow Pkwy, Brentwood, TN 37027", Distance = 2.2, DifficultyId = 1, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-2), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = true, HasRestrooms = true, IsPaved = true, IsGravel = false },
            new Hike { Id = 12, Title = "Valley Hike", Description = "Walk through a shady valley.", Location = "444 Valley Ln, Gallatin, TN 37066", Distance = 3.9, DifficultyId = 2, UserProfileId = 5, DateCreated = DateTime.Now.AddDays(-6), IsDogFriendly = false, IsKidFriendly = true, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = false, IsGravel = true },
            new Hike { Id = 13, Title = "Steep Steps", Description = "Hard stair climb through the canyon.", Location = "555 Step Hill Rd, Johnson City, TN 37601", Distance = 4.0, DifficultyId = 4, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-12), IsDogFriendly = false, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = false, IsGravel = false },
            new Hike { Id = 14, Title = "Maple Grove", Description = "Colorful in the fall with maples.", Location = "666 Maple St, Lebanon, TN 37087", Distance = 3.3, DifficultyId = 2, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-14), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = true },
            new Hike { Id = 15, Title = "Big Hill", Description = "Open climb with big views.", Location = "777 Hilltop Dr, Dickson, TN 37055", Distance = 6.0, DifficultyId = 3, UserProfileId = 5, DateCreated = DateTime.Now.AddDays(-11), IsDogFriendly = false, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = false, IsGravel = false },
            new Hike { Id = 16, Title = "Shady Creek", Description = "Cooling shade and shallow water.", Location = "888 Shady Trl, McMinnville, TN 37110", Distance = 2.6, DifficultyId = 1, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-18), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = true, HasRestrooms = true, IsPaved = false, IsGravel = true },
            new Hike { Id = 17, Title = "Historic Trail", Description = "Passes Civil War sites.", Location = "999 Heritage Way, Franklin, TN 37064", Distance = 3.8, DifficultyId = 2, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-19), IsDogFriendly = false, IsKidFriendly = true, IsHandicapAccessible = false, HasRestrooms = true, IsPaved = true, IsGravel = false },
            new Hike { Id = 18, Title = "Sunrise Summit", Description = "Best at dawn, steep but short.", Location = "1010 Dawn Dr, Oak Ridge, TN 37830", Distance = 2.4, DifficultyId = 3, UserProfileId = 5, DateCreated = DateTime.Now.AddDays(-4), IsDogFriendly = false, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = true },
            new Hike { Id = 19, Title = "Nature Walk", Description = "Educational signs along the path.", Location = "1111 Nature Ln, Smyrna, TN 37167", Distance = 2.0, DifficultyId = 1, UserProfileId = 3, DateCreated = DateTime.Now.AddDays(-1), IsDogFriendly = true, IsKidFriendly = true, IsHandicapAccessible = true, HasRestrooms = true, IsPaved = true, IsGravel = false },
            new Hike { Id = 20, Title = "Windy Ridge", Description = "Breezy and open, moderate challenge.", Location = "1212 Ridgecrest Rd, Spring Hill, TN 37174", Distance = 5.4, DifficultyId = 3, UserProfileId = 4, DateCreated = DateTime.Now.AddDays(-9), IsDogFriendly = true, IsKidFriendly = false, IsHandicapAccessible = false, HasRestrooms = false, IsPaved = false, IsGravel = true }
        );

    }
}


