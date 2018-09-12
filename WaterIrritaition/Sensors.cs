using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterIrritaition
{
    class Sensor
    {
        private Soil_moisture_sensor[] SM;
        private Rain_sensor[] R;
        private Temperature_sensor[] T;
    }
    class Soil_moisture_sensor
    {
        private int _id;
        private bool _status;
        private double _humidity;
    }
    class Rain_sensor
    {
        private int _id;
        private bool _status;
        private double Probability_of_precipitation;
    }
    class Temperature_sensor
    {
        private int _id;
        private bool _status;
        private double temperature;
    }
}
