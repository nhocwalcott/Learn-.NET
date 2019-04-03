using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtNVID.Text;
            string name = txtNVName.Text;
            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Insert into NV(WorkerID, WorkerName) values('" + id + "','" + name + "')";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand myCommand = new SqlCommand(sql, connection);
            myCommand.ExecuteNonQuery();
            connection.Close();                        
        }
    }
}
