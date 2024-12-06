using HighLoadDevelopment.Enums;
using HighLoadDevelopment.Models;

namespace HighLoadDevelopment.Extensions
{
    public class PermissionsSeed
    {
        public static readonly Permission get_list_user = new ()
        {
            Id = 1,
            Name = nameof(PermissionsNames.get_list_user),
            Code = nameof(PermissionsNames.get_list_user),
            Created_At = DateTime.UtcNow,
            ////Created_By = 1,

        };

        public static readonly Permission read_user = new ()
        {
            Id = 2,
            Name = nameof(PermissionsNames.read_user),
            Code = nameof(PermissionsNames.read_user),
            Created_At = DateTime.UtcNow,
            ////Created_By = 1,
        };

        public static readonly Permission create_user = new ()
        {
            Id = 3,
            Name = nameof(PermissionsNames.create_user),
            Code = nameof(PermissionsNames.create_user),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission update_user = new ()
        {
            Id = 4,
            Name = nameof(PermissionsNames.update_user),
            Code = nameof(PermissionsNames.update_user),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };

        public static readonly Permission delete_user = new ()
        {
            Id = 5,
            Name = nameof(PermissionsNames.delete_user),
            Code = nameof(PermissionsNames.delete_user),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission restore_user = new ()
        {
            Id = 6,
            Name = nameof(PermissionsNames.restore_user),
            Code = nameof(PermissionsNames.restore_user),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission get_list_role = new ()
        {
            Id = 7,
            Name = nameof(PermissionsNames.get_list_role),
            Code = nameof(PermissionsNames.get_list_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };

        public static readonly Permission read_role = new ()
        {
            Id = 8,
            Name = nameof(PermissionsNames.read_role),
            Code = nameof(PermissionsNames.read_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission create_role = new ()
        {
            Id = 9,
            Name = nameof(PermissionsNames.create_role),
            Code = nameof(PermissionsNames.create_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission update_role = new ()
        {
            Id = 10,
            Name = nameof(PermissionsNames.update_role),
            Code = nameof(PermissionsNames.update_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };

        public static readonly Permission delete_role = new ()
        {
            Id = 11,
            Name = nameof(PermissionsNames.delete_role),
            Code = nameof(PermissionsNames.delete_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission restore_role = new ()
        {
            Id = 12,
            Name = nameof(PermissionsNames.restore_role),
            Code = nameof(PermissionsNames.restore_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission get_list_permission = new ()
        {
            Id = 13,
            Name = nameof(PermissionsNames.get_list_permission),
            Code = nameof(PermissionsNames.get_list_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };

        public static readonly Permission read_permission = new ()
        {
            Id = 14,
            Name = nameof(PermissionsNames.read_permission),
            Code = nameof(PermissionsNames.read_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission create_permission = new ()
        {
            Id = 15,
            Name = nameof(PermissionsNames.create_permission),
            Code = nameof(PermissionsNames.create_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission update_permission = new ()
        {
            Id = 16,
            Name = nameof(PermissionsNames.update_permission),
            Code = nameof(PermissionsNames.update_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };

        public static readonly Permission delete_permission = new ()
        {
            Id = 17,
            Name = nameof(PermissionsNames.delete_permission),
            Code = nameof(PermissionsNames.delete_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission restore_permission = new ()
        {
            Id = 18,
            Name = nameof(PermissionsNames.restore_permission),
            Code = nameof(PermissionsNames.restore_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission get_story_user = new()
        {
            Id = 19,
            Name = nameof(PermissionsNames.get_story_user),
            Code = nameof(PermissionsNames.get_story_user),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission get_story_role = new()
        {
            Id = 20,
            Name = nameof(PermissionsNames.get_story_role),
            Code = nameof(PermissionsNames.get_story_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission get_story_permission = new()
        {
            Id = 21,
            Name = nameof(PermissionsNames.get_story_permission),
            Code = nameof(PermissionsNames.get_story_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,
        };

        public static readonly Permission rollback_permission = new()
        {
            Id = 22,
            Name = nameof(PermissionsNames.rollback_permission),
            Code = nameof(PermissionsNames.rollback_permission),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };

        public static readonly Permission rollback_role = new()
        {
            Id = 23,
            Name = nameof(PermissionsNames.rollback_role),
            Code = nameof(PermissionsNames.rollback_role),
            Created_At = DateTime.UtcNow,
            //Created_By = 1,

        };
        public static Permission[] GetPermissions()
        {
            return [get_list_user, get_list_role, get_list_permission,
                    read_user, read_role, read_permission,
                    create_user, create_role, create_permission,
                    update_user, update_role, update_permission,
                    delete_user, delete_role, delete_permission,
                    restore_user, restore_role, restore_permission,
                    get_story_user, get_story_role, get_story_permission,
                    rollback_role, rollback_permission];
        }
    }
}
