using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Authorization;

namespace HighLoadDevelopment.Extensions
{
    public class PermissionRequirements(Permission permission) : IAuthorizationRequirement
    {
        public Permission Permission => permission;
    }
}
