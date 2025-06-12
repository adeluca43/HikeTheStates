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

    }
}


