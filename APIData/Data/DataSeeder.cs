using APIData.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIData.Data;

public class DataSeeder
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetService<AucionDbContext>();
        if (context != null)
        {
            SeedData(context);
        }
    }
    public static void SeedData(AucionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }
        var premToInsert = PremisesHelper.GetPremisesStatus2();

        context.Premises.AddRange(premToInsert);
        context.SaveChanges();

        var listPremises = context.Premises.ToList();

        var auctions = new List<Auction>
        {
            new ()
            {
                ReservedPrice = 1000,
                Seller = "John Doe",
                Winner = "Alice Smith",
                RentedAmount = 500.00m,
                CurrentHighBid = 1200.00m,
                CreatedAt = DateTime.UtcNow.AddDays(-10),
                UpdatedAt = DateTime.UtcNow,
                AuctionEnd = DateTime.UtcNow.AddDays(5),
                Status = Status.Live,
                DoorNum = "101",
                Address = "101 Main St, London",
                ImageUrl = "https://cdn.pixabay.com/photo/2016/06/24/10/47/house-1477041_1280.jpg",
                PremiseId = listPremises[0].Id

            },
            new ()
            {
                ReservedPrice = 1500,
                Seller = "Jane Doe",
                Winner = "Bob Brown",
                RentedAmount = 750.00m,
                CurrentHighBid = 1600.00m,
                CreatedAt = DateTime.UtcNow.AddDays(-15),
                UpdatedAt = DateTime.UtcNow,
                AuctionEnd = DateTime.UtcNow.AddDays(3),
                Status = Status.Finished,
                DoorNum = "202",
                Address = "202 Broad St, Manchester",
                ImageUrl = "https://cdn.pixabay.com/photo/2014/07/10/17/18/large-home-389271_1280.jpg",
                 PremiseId = listPremises[1].Id

            },
            new ()
            {
                ReservedPrice = 2000,
                Seller = "Mike Johnson",
                Winner = "Charlie Black",
                RentedAmount = 1000.00m,
                CurrentHighBid = 0.00m,
                CreatedAt = DateTime.UtcNow.AddDays(-20),
                UpdatedAt = DateTime.UtcNow,
                AuctionEnd = DateTime.UtcNow.AddDays(7),
                Status = Status.ReserveNotMet,
                DoorNum = "303",
                Address = "303 High St, Birmingham",
                ImageUrl = "https://cdn.pixabay.com/photo/2016/04/18/08/58/new-england-1336172_1280.jpg",
                 PremiseId = listPremises[2].Id
            }
        };

        // Now you can add these to your database context and save changes
       //context.Premises.AddRange(premToInsert);
       //context.SaveChanges();

      
       
       context.Auctions.AddRange(auctions);
       context.SaveChanges();

    }
}
