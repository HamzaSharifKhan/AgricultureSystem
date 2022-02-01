using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace ProjectWeather.PAL
{
    public partial class WeatherUpdate : Form
    {
        public WeatherUpdate()
        {
            InitializeComponent();
        }

        internal void open()
        {
            throw new NotImplementedException();
        }
        string city;
        private void button1_Click(object sender, EventArgs e)
        {

            //city
            city = txtcity.Text;
            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=51d63331cf0d4adf8f3150430210911&q={0}&days=1&aqi=no&alerts=no", city);

            //Load URL



            try
            {
                XDocument.Load(uri);
            }


            catch (WebException)
            {

                MessageBox.Show("Sorry Spelling is incorrect!!!");
                System.Windows.Forms.Application.Exit();
            }

            XDocument doc = XDocument.Load(uri);

            //Convert XML data to objects

            string maxtemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            string mintemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();


            string maxwindm = (string)doc.Descendants("wind_mph").FirstOrDefault();
            string maxwindk = (string)doc.Descendants("wind_kph").FirstOrDefault();

            string humidity = (string)doc.Descendants("humidity").FirstOrDefault();
            string cloud = (string)doc.Descendants("text").FirstOrDefault();
            string country = (string)doc.Descendants("country").FirstOrDefault();
            string prec = (string)doc.Descendants("precip_mm").FirstOrDefault();
            int precipitation = int.Parse(prec);

        

            txtcountry.Text = country;
            txthumidity.Text = humidity;
            txtmaxtemp.Text = maxtemp;
            txtmintemp.Text = mintemp;
            txtcloud.Text = cloud;
            txtwindk.Text = maxwindk;
            txtwindm.Text = maxwindm;
            txtpre.Text = prec;
            if (precipitation >75 && cloud=="Overcast" )
            {
                MessageBox.Show("Today is overcast day So no need of Tubewell!", cloud);
            }
            else
            {
                MessageBox.Show("There is need of TubeWell!",cloud);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcity.Text = "";
            txtcountry.Text = "";
            txthumidity.Text = "";
            txtmaxtemp.Text = "";
            txtmintemp.Text = "";
            txtcloud.Text = "";
            txtwindk.Text = "";
            txtwindm.Text = "";
            txtpre.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Max Temp", typeof(string));
            dt.Columns.Add("Min Temp", typeof(string));
            dt.Columns.Add("Wind speed kph", typeof(string));
            dt.Columns.Add("wind speed mph", typeof(string));
            dt.Columns.Add("Humidity", typeof(string));
            dt.Columns.Add("Cloud", typeof(string));

            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=51d63331cf0d4adf8f3150430210911&q={0}&days=7&aqi=no&alerts=no", city);
            XDocument doc = XDocument.Load(uri);

            foreach (var npc in doc.Descendants("forecastday"))
            {
                dt.Rows.Add(new object[]{
                    (string)doc.Descendants("country").FirstOrDefault(), 
                    (string)npc.Descendants("time").FirstOrDefault(),
                    (string)npc.Descendants("maxtemp_c").FirstOrDefault(),
                    (string)npc.Descendants("mintemp_c").FirstOrDefault(),                    
                    (string)npc.Descendants("wind_mph").FirstOrDefault(),
                    (string)npc.Descendants("wind_kph").FirstOrDefault(),
                    (string)npc.Descendants("humidity").FirstOrDefault(),
                    (string)npc.Descendants("text").FirstOrDefault(),
                
                 
                 
                });
            }
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
