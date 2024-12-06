using HighLoadDevelopment.Configuration;
using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using File = HighLoadDevelopment.Models.File;
    
namespace HighLoadDevelopment.DataBaseContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Meeting> Meetings { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UsersAndRoles> UsersAndRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolesAndPermissions> RolesAndPermissions { get; set; }
        public DbSet<UsersAndTags> UsersAndTags { get; set; }
        public DbSet<MeetingsAndTags> MeetingsAndTags { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Comment> Comments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new VisitConfiguration());
            modelBuilder.ApplyConfiguration(new FileConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new UsersAndRolesConfiguration());
            modelBuilder.ApplyConfiguration(new RolesAndPermissionsConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingsAndTagsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersAndTagsConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
