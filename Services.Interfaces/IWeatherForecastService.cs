using api.Models;
using System.Collections.Generic;

namespace api.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetAll();
    }
}
