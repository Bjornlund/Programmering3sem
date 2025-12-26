using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace REST_TEST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private const string dataDirectory = "tmp";
        private static readonly string filePath = dataDirectory + "/tmpData.json";
        private static readonly object fileLock = new object();
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        static WeatherForecastController()
        {

        //laver directory, opretter ny fil og overskriver, hvis de ikke eksisterer
           lock(fileLock)
            {
                if(!Directory.Exists(dataDirectory))
                    Directory.CreateDirectory(dataDirectory);

                if (!System.IO.File.Exists(filePath))
                    System.IO.File.WriteAllText("[]", filePath); //blank json fil
            }
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpHead("Heartbeat")] //endpoint + type endpoint navn i swagger og client
        public ActionResult Ping()
        {
            return Ok();
        }

    }
}
