using APIData.Entities;

namespace APIData.DTOs;

public class AddAuctionDto
{
    public required int ReservedPrice { get; set; }
    public required string Seller { get; set; }
    public string Winner { get; set; } = null!;
    public required decimal RentedAmount { get; set; }
    public decimal CurrentHighBid { get; set; } = 0;
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; } = Status.Pending;

    public required string DoorNum { get; set; }
    public required string Address { get; set; }
    public required string ImageUrl { get; set; }

    public int PremiseId { get; set; }
}
