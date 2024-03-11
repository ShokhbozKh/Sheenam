//==================================================
//Copyright (c) Coalition of Good-Hearted Enginners
//Free To Use Comfort and Pleace
//==================================================


using System;

namespace Sheenam.Api
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
