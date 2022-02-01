using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjectWeather.BAL;
namespace ProjectWeather.DAL
{
    class DataAccessLayer
    {
        public static SqlConnection GetConnection()
        {
            string str = @"Data Source = DESKTOP-TITTVL6; Initial Catalog = CropRepositry; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error in Connection");
            }

            return connection;
        }
        public static void AddCropRecord(CropClass std)
        {
            string qry = "INSERT INTO tblCrop VALUES(@Name, @Type, @Status,@Fertilizers)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);

            command.Parameters.AddWithValue("@Name", std.Name);
            command.Parameters.AddWithValue("@Type", std.Type);
            command.Parameters.AddWithValue("@Status", std.Status);
            command.Parameters.AddWithValue("@Fertilizers", std.Fertilizers);
           

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully...");
            }
            catch (Exception)
            {

                MessageBox.Show("Record could not added!!!");
            }

        }
        public static DataSet AdapterBus()
        {
            string qry = "Select* From tblCrop;";
            SqlConnection connection = DataAccessLayer.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, connection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "tblCrop");
            return ds;
        }
        public static DataSet SearchFertilizer(string Name)
        {
            string qry = "SELECT * FROM tblCrop where Fertilizers = @Fertilizers";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@Fertilizers", Name);
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "tblCrop");
            return ds;
        }
        public static DataSet SearchInsect(string Name)
        {
            string qry = "SELECT * FROM tblInsect where Insect = @Insect";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@Insect", Name);
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "tblInsect");
            return ds;
        }


    }
}
