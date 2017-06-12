using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationLibrary
{
    public class WeatherData
    {
        private double temperature;
        private double humidity;
        private double pressure;

        public double Temperature
        {
            set
            {
                if (value > 40)
                {
                    this.temperature = 40;
                }
                else if (value < -10)
                {
                    this.temperature = -10;
                }
                else
                {
                    this.temperature = value;
                }
            }

            get
            {
                return this.temperature;
            }
        }

        public double Humidity
        {
            get => Humidity;
            set
            {
                if (value > 100)
                {
                    this.humidity = 100;
                }
                else if (value < 0)
                {
                    this.humidity = 0;
                }
                else
                {
                    this.humidity = value;
                }
            }
        }

        public double Pressure
        {
            get => pressure;
            set
            {
                if (value > 1)
                {
                    this.pressure = 1;
                }
                else if (value < 0)
                {
                    this.pressure = 0;
                }
                else
                {
                    this.pressure = value;
                }
            }
        }

        /*
        public void SetTemperature(double value)
        {
            if (value > 40)
            {
                this.temperature = 40;
            }
            else if (value < -10)
            {
                this.temperature = -10;
            }
            else
            {
                this.temperature = value;
            }
        }

        public double GetTemperature()
        {
            return this.temperature;
        }
        */

        /*
    public void SetHumidity(double value)
    {
        if (value > 100)
        {
            this.Humidity = 100;
        }
        else if (value < 0)
        {
            this.Humidity = 0;
        }
        else
        {
            this.Humidity = value;
        }
    }

    public double GetHumidity()
    {
        return this.Humidity;
    }
    */

        public bool Equals(WeatherData other)
        {
            return this.temperature == other.temperature
                   && this.humidity == other.humidity
                   && this.pressure == other.pressure;
        }
    }
}