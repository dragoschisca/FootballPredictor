namespace ApiDotnet.Models.DTOs;

public class SeasonDto
{
    public int Year { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public bool Current { get; set; }
    public CoverageDto Coverage { get; set; }
}

public class CoverageDto
{
    public FixturesCoverageDto Fixtures { get; set; }
    public bool Standings { get; set; }
    public bool Players { get; set; }
    public bool TopScorers { get; set; }
    public bool TopAssists { get; set; }
    public bool TopCards { get; set; }
    public bool Injuries { get; set; }
    public bool Predictions { get; set; }
    public bool Odds { get; set; }
}

public class FixturesCoverageDto
{
    public bool Events { get; set; }
    public bool Lineups { get; set; }
    public bool StatisticsFixtures { get; set; }
    public bool StatisticsPlayers { get; set; }
}
