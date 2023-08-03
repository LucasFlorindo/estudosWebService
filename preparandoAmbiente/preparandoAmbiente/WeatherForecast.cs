using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace preparandoAmbiente
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }



        [HttpGet("HotReloadTest")]
        public IEnumerable<string> GetTesteHotReload()
        {
            return new string[] { "Hot Reload 2", "Visual Studio 2019", ".NET 5" };
        }
    }
}
