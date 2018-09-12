using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum WeatherStatus
{
    RAIN, 
    NICE, 
    WINDY,
    APOCALYPSYS
}

namespace WaterIrritaition
{
    class WeatherApiConnection
    {
        private string _url;
        private int _predictionTemperature;
        private WeatherStatus _predictionWeather;
    }
}
