using AuthenticationApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationApplication.Data;

public class AuthenticationDbContext : IdentityDbContext<User>
{
    public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>(entity =>
        {
            entity.Property(u => u.FirstName).HasMaxLength(100);
            entity.Property(u => u.LastName).HasMaxLength(100);
            entity.Property(u => u.RefreshToken).HasMaxLength(500);
        });
    }
}