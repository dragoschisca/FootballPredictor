using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ApiDotnet.Models;
using ApiDotnet.Models.DTOs;

namespace ApiDotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class PredictionsController : ControllerBase
{
    private readonly HttpClient _http;
    private readonly string _apiKey;

    public PredictionsController(HttpClient http)
    {
        _http = http;
        _apiKey = Environment.GetEnvironmentVariable("FOOTBALL_API_KEY") ?? "";
    }
    
    private async Task<JsonDocument?> MakeRequest(string url)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("x-apisports-key", _apiKey);
        var response = await _http.SendAsync(request);
        return response.IsSuccessStatusCode ? JsonDocument.Parse(await response.Content.ReadAsStringAsync()) : null;
    }

    [HttpGet("GetTeamById/{id}")]
    public async Task<IActionResult> GetTeamById(int id)
    {
        var doc = await MakeRequest($"https://v3.football.api-sports.io/teams?id={id}");
        if (doc == null) return StatusCode(500, "API error");

        var teamElement = doc.RootElement
            .GetProperty("response")
            .EnumerateArray()
            .FirstOrDefault()
            .GetProperty("team");

        var teamDto = new TeamDto
        {
            Id = teamElement.GetProperty("id").GetInt32(),
            Name = teamElement.GetProperty("name").GetString() ?? "",
            Code = teamElement.GetProperty("code").GetString() ?? "",
            Country = teamElement.GetProperty("country").GetString() ?? "",
            Founded = teamElement.GetProperty("founded").GetInt32(),
            National = teamElement.GetProperty("national").GetBoolean(),
            Logo = teamElement.GetProperty("logo").GetString() ?? ""
        };

        return Ok(teamDto);
    }

    [HttpGet("GetTodayMatches")]
    public async Task<IActionResult> GetTodayMatches()
    {
        var doc = await MakeRequest($"https://v3.football.api-sports.io/fixtures?date={DateTime.Now:yyyy-MM-dd}");
        if (doc == null) return StatusCode(500, "API error");

        var matches = doc.RootElement
            .GetProperty("response")
            .EnumerateArray()
            .Select(r => new
            {
                FixtureId = r.GetProperty("fixture").GetProperty("id").GetInt32(),
                HomeTeamId = r.GetProperty("teams").GetProperty("home").GetProperty("id").GetInt32(),
                AwayTeamId = r.GetProperty("teams").GetProperty("away").GetProperty("id").GetInt32(),
                LeagueId = r.GetProperty("league").GetProperty("id").GetInt32(),
            })
            .ToList();

        return Ok(matches);
    }
}