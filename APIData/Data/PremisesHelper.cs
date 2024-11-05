using APIData.Entities;

namespace APIData.Data;

public class PremisesHelper
{
    public static List<Premise> GetPremisesStatus()
    {
        return
            [
             new Premise {Id = 1, Name = "Studio Flat"},
             new Premise {Id = 2, Name = "One-Bedroom Flat"},
             new Premise {Id = 3, Name = "Two-Bedroom Flat"},
             new Premise {Id = 4, Name = "Three-Bedroom Flat"},
             new Premise {Id = 5, Name = "Two-Bedroom House"},
             new Premise {Id = 6, Name = "Three-Bedroom House"},
             new Premise {Id = 7, Name = "Four-Bedroom House"},
             new Premise {Id = 8, Name = "Five-Bedroom House"},
             new Premise {Id = 9, Name = "Bungalow"},
             new Premise {Id = 10, Name = "Maisonette"},
             new Premise {Id = 11, Name = "Penthouse"},
             new Premise {Id = 12, Name = "Duplex Apartment"},
             new Premise {Id = 13, Name = "Semi-Detached House"},
             new Premise {Id = 14, Name = "Detached House"},
             new Premise {Id = 15, Name = "Terraced House"},
             new Premise {Id = 16, Name = "End-of-Terrace House"},
             new Premise {Id = 17, Name = "Cottage"},
             new Premise {Id = 18, Name = "Townhouse"},
             new Premise {Id = 19, Name = "Loft Apartment"},
             new Premise {Id = 20, Name = "Serviced Apartment"},
             new Premise {Id = 21, Name = "Condominium"},
             new Premise {Id = 22, Name = "Caravan"},
             new Premise {Id = 23, Name = "Mobile Home"},
             new Premise {Id = 24, Name = "Farmhouse"},
             new Premise {Id = 25, Name = "Villa"},
             new Premise {Id = 26, Name = "Mansion"},
            ];
    }

    public static List<Premise> GetPremisesStatus2()
    {
        return
            [
             new Premise {Id = 0, Name = "Studio Flat"},
             new Premise {Id = 0, Name = "One-Bedroom Flat"},
             new Premise {Id = 0, Name = "Two-Bedroom Flat"},
             new Premise {Id = 0, Name = "Three-Bedroom Flat"},
             new Premise {Id = 0, Name = "Two-Bedroom House"},
             new Premise {Id = 0, Name = "Three-Bedroom House"},
             new Premise {Id = 0, Name = "Four-Bedroom House"},
             new Premise {Id = 0, Name = "Five-Bedroom House"},
             new Premise {Id = 0, Name = "Bungalow"},
             new Premise {Id = 0, Name = "Maisonette"},
             new Premise {Id = 0, Name = "Penthouse"},
             new Premise {Id = 0, Name = "Duplex Apartment"},
             new Premise {Id = 0, Name = "Semi-Detached House"},
             new Premise {Id = 0, Name = "Detached House"},
             new Premise {Id = 0, Name = "Terraced House"},
             new Premise {Id = 0, Name = "End-of-Terrace House"},
             new Premise {Id = 0, Name = "Cottage"},
             new Premise {Id = 0, Name = "Townhouse"},
             new Premise {Id = 0, Name = "Loft Apartment"},
             new Premise {Id = 0, Name = "Serviced Apartment"},
             new Premise {Id = 0, Name = "Condominium"},
             new Premise {Id = 0, Name = "Caravan"},
             new Premise {Id = 0, Name = "Mobile Home"},
             new Premise {Id = 0, Name = "Farmhouse"},
             new Premise {Id = 0, Name = "Villa"},
             new Premise {Id = 0, Name = "Mansion"},
            ];
    }
    public static List<PremiseInsert> GetPremiseInsert() => [
             new PremiseInsert { Name = "Studio Flat"},
             new PremiseInsert { Name = "One-Bedroom Flat"},
             new PremiseInsert { Name = "Two-Bedroom Flat"},
             new PremiseInsert { Name = "Three-Bedroom Flat"},
             new PremiseInsert { Name = "Two-Bedroom House"},
             new PremiseInsert { Name = "Three-Bedroom House"},
             new PremiseInsert { Name = "Four-Bedroom House"},
             new PremiseInsert { Name = "Five-Bedroom House"},
             new PremiseInsert { Name = "Bungalow"},
             new PremiseInsert { Name = "Maisonette"},
             new PremiseInsert { Name = "Penthouse"},
             new PremiseInsert { Name = "Duplex Apartment"},
             new PremiseInsert { Name = "Semi-Detached House"},
             new PremiseInsert { Name = "Detached House"},
             new PremiseInsert { Name = "Terraced House"},
             new PremiseInsert { Name = "End-of-Terrace House"},
             new PremiseInsert { Name = "Cottage"},
             new PremiseInsert { Name = "Townhouse"},
             new PremiseInsert { Name = "Loft Apartment"},
             new PremiseInsert { Name = "Serviced Apartment"},
             new PremiseInsert { Name = "Condominium"},
             new PremiseInsert { Name = "Caravan"},
             new PremiseInsert { Name = "Mobile Home"},
             new PremiseInsert { Name = "Farmhouse"},
             new PremiseInsert { Name = "Villa"},
             new PremiseInsert { Name = "Mansion"},
            ];
}
