using System.Text.Json.Serialization;
using ApiDotnet.Models.DTOs;

namespace ApiDotnet.Models.Entites;

public class Fixture
{
    [JsonPropertyName("fixture")]
    public FixtureInfo FixtureInfo { get; set; }
    
    [JsonPropertyName("league")]
    public League League { get; set; }
    
    [JsonPropertyName("teams")]
    public Teams Teams { get; set; }
    
    [JsonPropertyName("goals")]
    public Goals Goals { get; set; }
    
    [JsonPropertyName("score")]
    public Score Score { get; set; }
    
    [JsonPropertyName("events")]
    public List<object> Events { get; set; }
    
    [JsonPropertyName("lineups")]
    public List<object> Lineups { get; set; }
    
    [JsonPropertyName("statistics")]
    public List<object> Statistics { get; set; }
    
    [JsonPropertyName("players")]
    public List<object> Players { get; set; }
}

public class FixtureInfo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("referee")]
    public string Referee { get; set; }
    
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }
    
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }
    
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
    
    [JsonPropertyName("periods")]
    public Periods Periods { get; set; }
    
    [JsonPropertyName("venue")]
    public Venue Venue { get; set; }
    
    [JsonPropertyName("status")]
    public Status Status { get; set; }
}

public class Periods
{
    [JsonPropertyName("first")]
    public long? First { get; set; }
    
    [JsonPropertyName("second")]
    public long? Second { get; set; }
}

public class Venue
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("city")]
    public string City { get; set; }
}

public class Status
{
    [JsonPropertyName("long")]
    public string Long { get; set; }
    
    [JsonPropertyName("short")]
    public string Short { get; set; }
    
    [JsonPropertyName("elapsed")]
    public int? Elapsed { get; set; }
    
    [JsonPropertyName("extra")]
    public int? Extra { get; set; }
}

public class Teams
{
    [JsonPropertyName("home")]
    public TeamInfo Home { get; set; }
    
    [JsonPropertyName("away")]
    public TeamInfo Away { get; set; }
}

public class TeamInfo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("logo")]
    public string Logo { get; set; }
    
    [JsonPropertyName("winner")]
    public bool? Winner { get; set; }
}

public class Goals
{
    [JsonPropertyName("home")]
    public int? Home { get; set; }
    
    [JsonPropertyName("away")]
    public int? Away { get; set; }
}

public class Score
{
    [JsonPropertyName("halftime")]
    public SubScore Halftime { get; set; }
    
    [JsonPropertyName("fulltime")]
    public SubScore Fulltime { get; set; }
    
    [JsonPropertyName("extratime")]
    public SubScore Extratime { get; set; }
    
    [JsonPropertyName("penalty")]
    public SubScore Penalty { get; set; }
}

public class SubScore
{
    [JsonPropertyName("home")]
    public int? Home { get; set; }
    
    [JsonPropertyName("away")]
    public int? Away { get; set; }
}