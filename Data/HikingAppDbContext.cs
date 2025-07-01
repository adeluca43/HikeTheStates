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
    public DbSet<HikeLike> HikeLikes { get; set; }
    public DbSet<Favorite> Favorites { get; set; }




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

    new Hike
    {
        Id = 1,
        Title = "Forest Loop",
        Description = "Peaceful loop through tall trees",
        AddressLine1 = "123 Forest Ln",
        City = "Nashville",
        State = "TN",
        Zip = "37011",
        Distance = 1.8,
        DifficultyId = 1,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-1),
        IsDogFriendly = true,
        IsKidFriendly = false,
        IsHandicapAccessible = true,
        HasRestrooms = false,
        IsPaved = true,
        IsGravel = false
    },

    new Hike
    {
        Id = 2,
        Title = "River Edge Trail",
        Description = "Trail running alongside the riverbank.",
        AddressLine1 = "456 River Rd",
        City = "Knoxville",
        State = "TN",
        Zip = "37901",
        Distance = 2.7,
        DifficultyId = 2,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-2),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 3,
        Title = "Bluff Overlook",
        Description = "Scenic view from the bluff",
        AddressLine1 = "789 Bluff Dr",
        City = "Chattanooga",
        State = "TN",
        Zip = "37401",
        Distance = 3.6,
        DifficultyId = 3,
        UserProfileId = 5,
        DateCreated = DateTime.Now.AddDays(-3),
        IsDogFriendly = true,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 4,
        Title = "Lakeside Path",
        Description = "Goes all the way around the lake!Lots of ducks!",
        AddressLine1 = "321 Lakeview Ave",
        City = "Clarksville",
        State = "TN",
        Zip = "37040",
        Distance = 4.5,
        DifficultyId = 4,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-4),
        IsDogFriendly = false,
        IsKidFriendly = false,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = true,
        IsGravel = true
    },

    new Hike
    {
        Id = 5,
        Title = "Sunset Ridge",
        Description = "Challenging hike with rewarding sunset views.",
        AddressLine1 = "654 Ridge Rd",
        City = "Cookeville",
        State = "TN",
        Zip = "38501",
        Distance = 5.4,
        DifficultyId = 1,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-5),
        IsDogFriendly = true,
        IsKidFriendly = true,
        IsHandicapAccessible = true,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 6,
        Title = "Waterfall Trail",
        Description = "steep, rocky trail, not for beginners.",
        AddressLine1 = "987 Falls Blvd",
        City = "Sparta",
        State = "TN",
        Zip = "38583",
        Distance = 2.7,
        DifficultyId = 2,
        UserProfileId = 5,
        DateCreated = DateTime.Now.AddDays(-6),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 7,
        Title = "Rocky Path",
        Description = "Lots of rocks and boulders on this trail",
        AddressLine1 = "159 Rock Ln",
        City = "Tullahoma",
        State = "TN",
        Zip = "37388",
        Distance = 3.6,
        DifficultyId = 3,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-7),
        IsDogFriendly = true,
        IsKidFriendly = false,
        IsHandicapAccessible = false,
        HasRestrooms = false,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 8,
        Title = "Birdwatch Loop",
        Description = "Great nature watching along the trail, lots of birds.",
        AddressLine1 = "753 Birdsong Ct",
        City = "Columbia",
        State = "TN",
        Zip = "38401",
        Distance = 4.5,
        DifficultyId = 4,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-8),
        IsDogFriendly = true,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = false,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 9,
        Title = "Pine Hollow",
        Description = "short path, great for kids, can be muddy.",
        AddressLine1 = "111 Pine Ln",
        City = "Jackson",
        State = "TN",
        Zip = "38301",
        Distance = 1.8,
        DifficultyId = 1,
        UserProfileId = 5,
        DateCreated = DateTime.Now.AddDays(-9),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = false,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 10,
        Title = "Creek Crossing",
        Description = "multiple creek crossings on path, water comes up to knee height.",
        AddressLine1 = "222 Creek Rd",
        City = "Murfreesboro",
        State = "TN",
        Zip = "37130",
        Distance = 2.7,
        DifficultyId = 2,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-10),
        IsDogFriendly = true,
        IsKidFriendly = false,
        IsHandicapAccessible = false,
        HasRestrooms = false,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 11,
        Title = "Meadow Breeze",
        Description = "Beautiful views of wild flowers!",
        AddressLine1 = "333 Meadow Pkwy",
        City = "Brentwood",
        State = "TN",
        Zip = "37027",
        Distance = 3.6,
        DifficultyId = 3,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-11),
        IsDogFriendly = true,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 12,
        Title = "Valley Hike",
        Description = "Steep hills, not very busy early in the morning.",
        AddressLine1 = "444 Valley Ln",
        City = "Gallatin",
        State = "TN",
        Zip = "37066",
        Distance = 4.5,
        DifficultyId = 4,
        UserProfileId = 5,
        DateCreated = DateTime.Now.AddDays(-12),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 13,
        Title = "Steep Steps",
        Description = "Trail has tons of steps!!",
        AddressLine1 = "555 Step Hill Rd",
        City = "Johnson City",
        State = "TN",
        Zip = "37601",
        Distance = 1.8,
        DifficultyId = 1,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-13),
        IsDogFriendly = true,
        IsKidFriendly = false,
        IsHandicapAccessible = true,
        HasRestrooms = false,
        IsPaved = true,
        IsGravel = false
    },

    new Hike
    {
        Id = 14,
        Title = "Maple Grove",
        Description = "big trees, lots of shade, great for a day hike!",
        AddressLine1 = "666 Maple St",
        City = "Lebanon",
        State = "TN",
        Zip = "37087",
        Distance = 2.7,
        DifficultyId = 2,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-14),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 15,
        Title = "Big Hill",
        Description = "Open climb with big views",
        AddressLine1 = "777 Hilltop Dr",
        City = "Dickson",
        State = "TN",
        Zip = "37055",
        Distance = 3.6,
        DifficultyId = 3,
        UserProfileId = 5,
        DateCreated = DateTime.Now.AddDays(-15),
        IsDogFriendly = true,
        IsKidFriendly = false,
        IsHandicapAccessible = false,
        HasRestrooms = false,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 16,
        Title = "Shady Creek",
        Description = "Cooling shade and shallow water.",
        AddressLine1 = "888 Shady Trl",
        City = "McMinnville",
        State = "TN",
        Zip = "37110",
        Distance = 4.5,
        DifficultyId = 4,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-16),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = false,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 17,
        Title = "Historic Trail",
        Description = "Passes Civil War Sites",
        AddressLine1 = "999 Heritage Way",
        City = "Franklin",
        State = "TN",
        Zip = "37064",
        Distance = 1.8,
        DifficultyId = 1,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-17),
        IsDogFriendly = true,
        IsKidFriendly = false,
        IsHandicapAccessible = true,
        HasRestrooms = false,
        IsPaved = true,
        IsGravel = false
    },

    new Hike
    {
        Id = 18,
        Title = "Sunrise Summit",
        Description = "Best at dawn, steep but short.",
        AddressLine1 = "1010 Dawn Dr",
        City = "Oak Ridge",
        State = "TN",
        Zip = "37830",
        Distance = 2.7,
        DifficultyId = 2,
        UserProfileId = 5,
        DateCreated = DateTime.Now.AddDays(-18),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = true
    },

    new Hike
    {
        Id = 19,
        Title = "Nature Walk",
        Description = "Educational signs along the way.",
        AddressLine1 = "1111 Nature Ln",
        City = "Smyrna",
        State = "TN",
        Zip = "37167",
        Distance = 3.6,
        DifficultyId = 3,
        UserProfileId = 3,
        DateCreated = DateTime.Now.AddDays(-19),
        IsDogFriendly = true,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = false
    },

    new Hike
    {
        Id = 20,
        Title = "Windy Ridge",
        Description = "Breezy and open, moderate challenge",
        AddressLine1 = "1212 Ridgecrest Rd",
        City = "Spring Hill",
        State = "TN",
        Zip = "37174",
        Distance = 4.5,
        DifficultyId = 4,
        UserProfileId = 4,
        DateCreated = DateTime.Now.AddDays(-20),
        IsDogFriendly = false,
        IsKidFriendly = true,
        IsHandicapAccessible = false,
        HasRestrooms = true,
        IsPaved = false,
        IsGravel = true
    }
);

    }
}

