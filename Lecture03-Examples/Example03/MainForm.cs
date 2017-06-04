using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationLibrary;

namespace Example03
{
    public partial class WeatherPanel : Form
    {
        private WeatherData data;

        public WeatherPanel()
        {
            InitializeComponent();
            data = new WeatherData()
            {
                Temperature = 30.21,
                Humidity = 90.8921,
                Pressure = 1.10
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            temperatureLabel.Text = "溫度 : " + data.Temperature.ToString("#.##");
            humidityLabel.Text = "濕度 : " + data.Humidity.ToString("#.##");
            pressureLabel.Text = "壓力 : " + data.Pressure.ToString("#.##");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pressurelabel_Click(object sender, EventArgs e)
        {
        }

        private void weatherDataPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}