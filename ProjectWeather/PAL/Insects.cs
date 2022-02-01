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
    public partial class Insects : Form
    {
        public Insects()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insect = txtName.Text;
           DataSet ds= DAL.DataAccessLayer.SearchInsect(insect);
            dataGridView1.DataSource = ds.Tables["tblInsect"];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
