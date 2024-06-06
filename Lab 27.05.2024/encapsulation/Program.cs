using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RandomPersonGenerator.Controllers
{
    [Route("api/[controller]")]
    public class GeneratorController : Controller
    {
        [HttpGet("[action]")]
        public async Task<IActionResult> Generate()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.randomuser.me");
                    var response = await client.GetAsync("https://api.randomuser.me");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawData = JsonConvert.DeserializeObject<PersonAPIResponse>(stringResult);
                    return Ok(new
                    {
                        Gender = rawData.Results.Select(x => x.Gender)
                    });
                }

                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error generating person: {httpRequestException.Message}");
                }
            }
        }
    }

    public class PersonAPIResponse
    {
        public IEnumerable<PersonDescription> Results { get; set; }
    }

    public class PersonDescription
    {
        public string Gender { get; set; }
    }
}