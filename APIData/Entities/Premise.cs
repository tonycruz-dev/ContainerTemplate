namespace APIData.Entities;

public class Premise
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

public class PremiseInsert
{
    public required string Name { get; set; }
}
