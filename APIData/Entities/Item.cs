using System.ComponentModel.DataAnnotations.Schema;

namespace APIData.Entities;

[Table("Items")]
public class Item
{
    public int Id { get; set; }
    public required string DoorNum { get; set; }
    public required string Address { get; set; }
    public string? ImageUrl { get; set; }

    // nav properties
    public Auction? Auction { get; set; } 
    public int? AuctionId { get; set; }


    public Premise? Premise { get; set; }
    public int? PremiseId { get; set; }
}
