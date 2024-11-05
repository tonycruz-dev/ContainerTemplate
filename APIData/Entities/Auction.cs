using System.ComponentModel.DataAnnotations.Schema;

namespace APIData.Entities;

public class Auction
{
    public int Id { get; set; }
    public int ReservedPrice { get; set; }
    public string Seller { get; set; } = null!;
    public string Winner { get; set; } = null!;
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RentedAmount { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; }

    public required string DoorNum { get; set; }
    public required string Address { get; set; }
    public string? ImageUrl { get; set; }

    public Premise? Premise { get; set; }
    public int? PremiseId { get; set; }
}
