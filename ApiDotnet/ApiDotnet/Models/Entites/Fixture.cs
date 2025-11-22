namespace ApiDotnet.Models.Entites;

public class Fixture
{
    public int Id { get; set; }
    public string Referee { get; set; }  // poate fi null
    public string Timezone { get; set; }
    public DateTime Date { get; set; }
    public long Timestamp { get; set; }
    public Periods Periods { get; set; }
    public Venue Venue { get; set; }
    public Status Status { get; set; }
}

public class Periods
{
    public long First { get; set; }
    public long Second { get; set; }
}

public class Venue
{
    public int? Id { get; set; }  // poate fi null
    public string Name { get; set; }
    public string City { get; set; }
}

public class Status
{
    public string Long { get; set; }
    public string Short { get; set; }
    public int Elapsed { get; set; }
    public int? Extra { get; set; }  // poate fi null
}
