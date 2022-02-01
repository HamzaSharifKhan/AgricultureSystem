using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWeather.PAL
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            WeatherUpdate Weather = new WeatherUpdate();
            this.Hide();
            Weather.Show();
           
        }

        private void btnCrops_Click(object sender, EventArgs e)
        {
            AddFertilizer add = new AddFertilizer();
            this.Hide();
            add.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SearchFertilizer Sea = new SearchFertilizer();
            this.Hide();
            Sea.Show();
        }

        private void btnFertilizer_Click(object sender, EventArgs e)
        {
            Insects ins = new Insects();
            this.Hide();
            ins.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login v = new Login();
            this.Close();
            v.Show();
            
        }
    }
}
