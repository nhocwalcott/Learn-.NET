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
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        protected void Page_Load()
        {
            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Select WorkerID as Mã_NV, WorkerName as Tên_NV, DepID as Tên_BP from CorpWorker";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }
        public void LoadComboBox()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_whbpvn;";
            string sql = "Select name from users";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(sql, connection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    string[] rows = new string[100];
                    int i = 0;
                    while (reader.Read())
                    {   
                        string row = reader.GetString(0) ;
                        rows [i]= row;
                        i++;       
                    }
                    comboBox1.DataSource = rows;
                    comboBox1.DisplayMember = "rows";
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public Form1()
        {
            InitializeComponent();
            Page_Load();
            LoadComboBox();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Select WorkerID as Mã_NV, WorkerName as Tên_NV, DepID as Tên_BP from CorpWorker";
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
            string sql = "Select WorkerID as Mã_NV, WorkerName as Tên_NV, DepID as Tên_BP from CorpWorker";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string cbtext = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string connectionString = @"Data Source = bpvn-hrsrv; Initial Catalog = opensysdb; User ID = sa; Password = BestP@cific";
            string sql = "Select WorkerID as Mã_NV, WorkerName as Tên_NV, DepID as Tên_BP from CorpWorker  where WorkerID = '"+ input + "'"+ " or DepID = '" + cbtext +"'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dlg2 = new Form2();
            dlg2.ShowDialog();
            this.Close();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 dlg2 = new Form4();
            dlg2.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 dlg2 = new Form5();
            dlg2.ShowDialog();
            this.Close();
        }

        private void Form6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 dlg2 = new Form6();
            dlg2.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 dlg2 = new Form7();
            dlg2.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 dlg2 = new Form8();
            dlg2.ShowDialog();
            this.Close();
        }
    }
}
