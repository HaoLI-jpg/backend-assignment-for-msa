using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class OpenLibraryController : ControllerBase
{
    private readonly HttpClient _client;

    /// <summary />
    public OpenLibraryController(IHttpClientFactory clientFactory)
    {
        if (clientFactory is null)
        {
            throw new ArgumentNullException(nameof(clientFactory));
        }
        _client = clientFactory.CreateClient("openlibrary");
    }
    /// <summary>
    /// Gets the raw JSON for the hot feed in reddit
    /// </summary>
    /// <returns>A JSON object representing the hot feed in reddit</returns>
    [HttpGet]
    [Route("raw")]
    [ProducesResponseType(200)]
    public async Task<IActionResult> GetOpenLibraryJson()
    {
        var res = await _client.GetAsync("");
        var content = await res.Content.ReadAsStringAsync();
        return Ok(content);
    }
}