using APIData.Data;
using APIData.DTOs;
using APIData.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIData.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionsController(AucionDbContext context, IMapper mapper) : ControllerBase
{


    // GET: api/Auctions
    [HttpGet]
    public async Task<ActionResult<List<AuctionDto>>> GetAuctions( string? date)
    {
        var query = context.Auctions.Include(a => a.Premise).AsQueryable();
        if (date != null)
        {
            query = query.Where(x => x.UpdatedAt.CompareTo(DateTime.Parse(date).ToUniversalTime()) > 0);
        }
        return await query.ProjectTo<AuctionDto>(mapper.ConfigurationProvider).ToListAsync();
    }

    // GET: api/Auctions/5
    [HttpGet("{id}")]
    public async Task<ActionResult<AuctionDto>> GetAuctionById(int id)
    {
        var auction = await context.Auctions.Include(x => x.Premise)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (auction == null)
        {
            return NotFound();
        }

        return mapper.Map<AuctionDto>(auction);
    }

    // PUT: api/Auctions/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAuction(int id, UpdateAuctionDto updateAuctionDto)
    {
        if (id != updateAuctionDto.Id)
        {
            return BadRequest();
        }

        var auction = await context.Auctions
            .Include(x => x.Premise)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (auction == null) return NotFound();

        auction.Status = updateAuctionDto.Status;
        auction.Seller = updateAuctionDto.Seller;
        auction.Winner = updateAuctionDto.Winner;
        auction.RentedAmount = updateAuctionDto.RentedAmount;
        auction.CurrentHighBid = updateAuctionDto.CurrentHighBid;
        auction.AuctionEnd = updateAuctionDto.AuctionEnd;
        auction.DoorNum = updateAuctionDto.DoorNum;
        auction.Address = updateAuctionDto.Address;
        auction.ImageUrl = updateAuctionDto.ImageUrl;
        auction.PremiseId = updateAuctionDto.PremiseId;

        var result = await context.SaveChangesAsync() > 0;
        if (result) return Ok();

        return BadRequest("Failed to update auction");

        
    }

    // POST: api/Auctions
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Auction>> PostAuction(AddAuctionDto addAuctionDto)
    {

        var auction = mapper.Map<Auction>(addAuctionDto);
        auction.Seller = "Unknown user";

        context.Auctions.Add(auction);


       var result = await context.SaveChangesAsync();

        if (result == 0) return BadRequest("Could not save changes to DB");

        return CreatedAtAction(nameof(GetAuctionById),
        new { auction.Id }, mapper.Map<AuctionDto>(auction));
        
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuction(int id)
    {
        var auction = await context.Auctions.FindAsync(id);

        if (auction == null) return NotFound();

        context.Auctions.Remove(auction);


        var result = await context.SaveChangesAsync() > 0;

        if (!result) return BadRequest("Could not update DB");

        return Ok();
    }

}
