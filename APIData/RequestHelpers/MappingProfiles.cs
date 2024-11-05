using APIData.DTOs;
using APIData.Entities;
using AutoMapper;

namespace APIData.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Premise);
        CreateMap<Premise, AuctionDto>();
        CreateMap<AddAuctionDto, Auction>();
        CreateMap<UpdateAuctionDto, Auction>();
        //CreateMap<CreateAuctionDto, Auction>()
        //    .ForMember(d => d.Item, o => o.MapFrom(s => s));
        //CreateMap<CreateAuctionDto, Item>();
        //CreateMap<AuctionDto, AuctionCreated>();
        //CreateMap<Auction, AuctionUpdated>().IncludeMembers(a => a.Item);
        //CreateMap<Item, AuctionUpdated>();
    }
}