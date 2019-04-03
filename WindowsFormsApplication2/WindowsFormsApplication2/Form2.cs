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
    public partial class Form2 : Form
    {
        public void LoadComboBox()
        {

            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Select distinct PassDate from PassRecord";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter data = new SqlDataAdapter(sql, connection);
            connection.Open();
            DataTable dt = new DataTable();
            data.Fill(dt);
            connection.Close();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PassDate";


        }
        public Form2()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string cbtext = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Select * from PassRecord where WorkerID = '" + input + "' or PassDate = '" + cbtext +"'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Select * from PassRecord";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 dlg1 = new Form1();
            dlg1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
