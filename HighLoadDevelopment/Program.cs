using AutoMapper;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Extensions;
using HighLoadDevelopment.Interfaces;
using HighLoadDevelopment.JWT;
using HighLoadDevelopment.Libraries;
using HighLoadDevelopment.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JwtConfiguration>(builder.Configuration.GetSection(nameof(JwtConfiguration)));

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<MeetingService>();
builder.Services.AddTransient<VisitService>();

builder.Services.AddTransient<IJwtProvider, JwtProvider>();
builder.Services.AddTransient<IPasswordHasher, PasswordHasher>();

builder.Services.AddScoped<IAuthorizationHandler, PermissionsHandler>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnectionString"));
});



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
    {
        var jwt = builder.Configuration.GetSection(nameof(JwtConfiguration));

        var key = jwt.GetSection(nameof(JwtConfiguration.SecretKey));
        var issuer = jwt.GetSection(nameof(JwtConfiguration.Issuer));
        var audience = jwt.GetSection(nameof(JwtConfiguration.Audience));

        o.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = false,
            ValidIssuer = issuer.Value,

            ValidateAudience = true,
            ValidAudience = audience.Value,

            ValidateLifetime = true,
            RequireExpirationTime = true,

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(key.Value!))
        };


        o.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                string? token = context.Request.Cookies["NeToken"] ?? context.Request.Headers.Authorization;

                //context.Request.Cookies["NeToken"]

                if (token != null)
                {
                    context.Token = token.Replace("Bearer ", "");
                }

                Console.Write("Current token is: ");
                Console.WriteLine(context.Token);
                return Task.CompletedTask;
            }
        };
    });


builder.Services.ConfigureAuthorization();




var app = builder.Build();

app.UseHsts();
app.UseHttpsRedirection();

app.UseRouting();

app.UseStatusCodePages(async context => {

    var request = context.HttpContext.Request;
    var response = context.HttpContext.Response;

    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
    {
        response.Redirect("/authorize/login");
    }

    response.ContentType = "text/plain; charset=utf-8";
    await response.WriteAsync("Unexpected error with code: " + response.StatusCode);
});

app.UseStaticFiles();
app.UseDefaultFiles();


app.UseAuthentication();


app.UseAuthorization();


app.MapControllers();


/*app.MapGet("/AccessDenied", (context) =>
//{
//    context.Response.Headers.ContentType = "text/html";
//    context.Response.StatusCode = 403;
//    context.Response.SendFileAsync("wwwroot/html/accessDenied.html");
//    return Task.CompletedTask;
});*/

app.MapGet("/authorize/login", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    context.Response.StatusCode = 401;
    await context.Response.SendFileAsync("wwwroot/html/users/Authorize.html");
});


app.Run();