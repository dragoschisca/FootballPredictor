namespace ApiDotnet.Models.DTOs;

public class LeagueDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; } // League sau Cup
    public string Logo { get; set; }
    public CountryDto Country { get; set; }
    public List<SeasonDto> Seasons { get; set; }
}
