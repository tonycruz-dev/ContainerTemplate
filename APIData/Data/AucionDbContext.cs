using APIData.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIData.Data;

public class AucionDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Premise> Premises { get; set; }
}
