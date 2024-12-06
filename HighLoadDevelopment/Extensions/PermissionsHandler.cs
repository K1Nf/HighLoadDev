using HighLoadDevelopment.DataBaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace HighLoadDevelopment.Extensions
{
    public class PermissionsHandler(AppDbContext context, IHttpContextAccessor httpContextAccessor) : AuthorizationHandler<PermissionRequirements>
    {
        private readonly AppDbContext _context = context;
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;


        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            PermissionRequirements requirement)
        {
            Claim? claim = context.User.Claims
                .SingleOrDefault(c => c.Type == "UserIdentity");


            if (claim == null)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            Guid userId = Guid.Parse(claim!.Value);


            var userPermissions = _context.UsersAndRoles
                .Where(ur => ur.UserId == userId)
                .Include(ur => ur.Role)
                    .ThenInclude(r => r!.Permissions)
                .Select(r => r.Role)
                    .SelectMany(r => r!.Permissions)
                        .Select(p => p.Name)
                .ToList();



            if (userPermissions.Any(p => Equals(p, requirement.Permission.Code)))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            else
            {
                context.Fail();
                HttpContext httpContext = _httpContextAccessor.HttpContext!;



                httpContext.Response.StatusCode = 403;
                httpContext.Response.ContentType = "text/html; charset=utf-8";

                string responseText = "Для совершения данной операции нужно разрешение: " + requirement.Permission.Name;

                string responseHTML = "<!DOCTYPE html>\r\n" +
                    "<html>\r\n" +
                    "<head>\r\n    " +
                        "<meta charset=\"utf-8\" />\r\n    " +
                        "<title>Доступ к содержимому запрещен!</title>\r\n" +
                    "</head>\r\n" +
                    "<body>\r\n    " +
                        "<div>\r\n       " +
                            "<h1 style=\"font-size:200%; color: red; text-align: center;\">ACCESS DENIED</h1>\r\n       " +
                            $"<h1 style=\"font-size:150%; color: red; text-align: center;\">{responseText}</h1>\r\n    " +
                        "</div>\r\n\r\n\r\n    " +
                        "<script>\r\n\r\n        " +
                        "function openPreviousPage() {\r\n            " +
                        "window.location.href = window.history.go(-1);\r\n        }\r\n\r\n        " +
                        "setTimeout(openPreviousPage, 3000);\r\n\r\n\r\n    " +
                        "</script>\r\n" +
                    "</body>\r\n" +
                "</html>\r\n";

                httpContext.Response.WriteAsync(responseHTML);
                //httpContext.Response.WriteAsync("<h1>Для совершения данной операции нужно разрешение: " + requirement.Permission.Name + "</h1>");
                return Task.CompletedTask;
            }
        }
    }
}
