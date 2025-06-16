using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using HikingApp.Data;

var builder = WebApplication.CreateBuilder(args);

// ----------------------------
// Add services to the container
// ----------------------------

// Configure JSON serialization to ignore circular references
builder.Services.AddControllers().AddJsonOptions(opts =>
{
    opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Enable Swagger (for dev/testing)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//  Add CORS policy that allows credentials from your frontend
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Frontend dev server
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials(); // Important for cookies!
    });
});

// Configure cookie-based authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.Cookie.Name = "HikingAppLoginCookie";
        options.Cookie.SameSite = SameSiteMode.Strict;
        options.Cookie.HttpOnly = true;
        options.Cookie.MaxAge = TimeSpan.FromDays(7);
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = TimeSpan.FromHours(24);

        // Prevent redirects for APIs
        options.Events.OnRedirectToLogin = context =>
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return Task.CompletedTask;
        };
        options.Events.OnRedirectToAccessDenied = context =>
        {
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            return Task.CompletedTask;
        };
    });

//  Configure Identity
builder.Services.AddIdentityCore<IdentityUser>(config =>
{
    config.Password.RequireDigit = false;
    config.Password.RequiredLength = 8;
    config.Password.RequireLowercase = false;
    config.Password.RequireNonAlphanumeric = false;
    config.Password.RequireUppercase = false;
    config.User.RequireUniqueEmail = true;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<HikingAppDbContext>();

//  Configure EF connection and PostgreSQL legacy behavior
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddNpgsql<HikingAppDbContext>(builder.Configuration["HikingAppDbConnectionString"]);

var app = builder.Build();

// ----------------------------
// Configure middleware pipeline
// ----------------------------

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//  Enable CORS BEFORE auth
app.UseCors();

// Auth must come after CORS
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
