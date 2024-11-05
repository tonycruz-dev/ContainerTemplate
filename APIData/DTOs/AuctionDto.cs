using APIData.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIData.DTOs;

public class AuctionDto
{
    public int Id { get; set; }
    public int ReservedPrice { get; set; }
    public string Seller { get; set; } = null!;
    public string Winner { get; set; } = null!;
    public decimal? RentedAmount { get; set; }
    public decimal? CurrentHighBid { get; set; }
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; }

    public required string DoorNum { get; set; }
    public required string Address { get; set; }
    public string? ImageUrl { get; set; }

    public string? Name { get; set; }
}
