using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRMSystem.Domain.Entities;

namespace CRMSystem.Domain
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Requester> Requesters { get; set; }
        public DbSet<RequestInformation> RequestInformation{ get; set; }
        public DbSet<RequestType> RequestTypes{ get; set; }
        public DbSet<Beneficiary> Beneficiaries{ get; set; }
        public DbSet<ExecutiveDepartment> ExecutiveDepartments{ get; set; }
        public DbSet<OrganizationFounder> OrganizationFounders { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                UserId = "a815df5a-a254-4076-aaf3-5c9f7d58f408"
            });
            modelBuilder.Entity<ChatMessage>().HasNoKey();
        }
    }
}
