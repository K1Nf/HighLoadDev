using HighLoadDevelopment.Extensions;
using HighLoadDevelopment.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace HighLoadDevelopment.Extensions
{
    public static class AuthorizationExtension
    {
        public static IServiceCollection ConfigureAuthorization(this IServiceCollection services)
        {
            return services
                .AddAuthorization(GetOptions());
        }


        public static Action<AuthorizationOptions> GetOptions()
        {
            return new Action<AuthorizationOptions>(o =>
            {
                o.AddPolicy(nameof(PermissionsNames.get_list_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.get_list_user));
                });


                o.AddPolicy(nameof(PermissionsNames.read_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.read_user));
                });


                o.AddPolicy(nameof(PermissionsNames.create_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.create_user));
                });


                o.AddPolicy(nameof(PermissionsNames.update_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.update_user));
                });


                o.AddPolicy(nameof(PermissionsNames.delete_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.delete_user));
                });


                o.AddPolicy(nameof(PermissionsNames.restore_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.restore_user));
                });




                o.AddPolicy(nameof(PermissionsNames.get_list_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.get_list_role));
                });


                o.AddPolicy(nameof(PermissionsNames.read_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.read_role));
                });


                o.AddPolicy(nameof(PermissionsNames.create_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.create_role));
                });


                o.AddPolicy(nameof(PermissionsNames.update_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.update_role));
                });


                o.AddPolicy(nameof(PermissionsNames.delete_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.delete_role));
                });


                o.AddPolicy(nameof(PermissionsNames.restore_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.restore_role));
                });




                o.AddPolicy(nameof(PermissionsNames.get_list_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.get_list_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.read_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.read_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.create_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.create_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.update_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.update_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.delete_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.delete_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.restore_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.restore_permission));
                });




                o.AddPolicy(nameof(PermissionsNames.get_story_user), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.get_story_user));
                });


                o.AddPolicy(nameof(PermissionsNames.get_story_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.get_story_role));
                });


                o.AddPolicy(nameof(PermissionsNames.get_story_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.get_story_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.rollback_permission), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.rollback_permission));
                });


                o.AddPolicy(nameof(PermissionsNames.rollback_role), p =>
                {
                    p.Requirements.Add(new PermissionRequirements(PermissionsSeed.rollback_role));
                });
            });
        }
    }
}
