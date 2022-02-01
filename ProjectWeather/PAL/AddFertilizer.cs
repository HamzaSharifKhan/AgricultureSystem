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
    public partial class AddFertilizer : Form
    {
        public AddFertilizer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFertilizer.Text = "";
            txtName.Text = "";
            cmbStatus.Text = "";
            cmbType.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.CropClass obj = new BAL.CropClass();
            obj.Name = txtName.Text;
            obj.Fertilizers = txtFertilizer.Text;
            obj.Status = cmbStatus.Text;
            obj.Type = cmbType.Text;

            DAL.DataAccessLayer.AddCropRecord(obj);
        }
    }
}
