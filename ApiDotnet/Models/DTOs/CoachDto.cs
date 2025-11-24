namespace ApiDotnet.Models.DTOs;

public class CoachDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int? Age { get; set; }
    public BirthDto Birth { get; set; }
    public string Nationality { get; set; }
    public double? Height { get; set; }
    public double? Weight { get; set; }
    public string Photo { get; set; }
    public TeamDto Team { get; set; }
    public List<CareerDto> Career { get; set; }
}

public class BirthDto
{
    public DateTime? Date { get; set; }
    public string Place { get; set; }
    public string Country { get; set; }
}

public class CareerDto
{
    public TeamDto Team { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
}
