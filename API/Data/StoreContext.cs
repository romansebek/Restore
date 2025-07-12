using System;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }

    public required DbSet<Basket> Baskets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
        .HasData(
            new IdentityRole { Id = "1c6a14be-db3e-49fa-995d-2e8064c861da", Name = "Member", NormalizedName = "MEMBER" },
            new IdentityRole { Id = "5d2cc979-cecb-41db-ab0a-761c3d525267", Name = "Admin", NormalizedName = "ADMIN" }
        );
    }
}
