using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApplication2
{
    public partial class Form7 : Form
    {
        protected void loadComBobox()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_whbpvn;";
            string sql = "Select distinct ct_ma from congtrinh order by ct_ma asc";
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
                    string[] rows = new string[10000];
                    int i = 0;
                    while (reader.Read())
                    {
                        string row = reader.GetString(0);
                        rows[i] = row;
                        i++;
                    }
                    comboBox1.DataSource = rows;
                    comboBox1.DisplayMember = "rows";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadDataView()
        {
            string c = comboBox1.Text;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_whbpvn;";
            string sql = "Select * from serial where vt_id = '" + c + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(sql, connection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            DataSet ds = new DataSet();
            connection.Open();
            reader = commandDatabase.ExecuteReader();
            string[] rows = new string[10000];
            int i = 0;
            while (reader.Read())
            {
                string row = reader.GetString(0);
                rows[i] = row;
                i++;
            }
            connection.Close();
            dataGridView1.DataSource = rows;
            dataGridView1.DataMember = "Authors_table";
        }
        public Form7()
        {
            InitializeComponent();
            loadComBobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = comboBox1.Text;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_whbpvn;";
            string sql;
            if (c == "")
            {
                sql = "SELECT vt_ten,`congtrinh`.`ct_ten`,`congtrinh`.`ct_ma`,`vattu`.`vt_gia` ,`nhasanxuat`.`nsx_ten`,`donvitinh`.`dvt_ten`,`nhaphanphoi`.`npp_ten`,COUNT(serial) as SLton  FROM `serial`,`chitietxuatkho`,`xuatkho`,`vattu`,`congtrinh` ,`nhaphanphoi`,`nhasanxuat`,`donvitinh` WHERE `serial`.`ctxk_id`=`chitietxuatkho`.`id` and `chitietxuatkho`.`xk_id` = `xuatkho`.`id` AND `serial`.`vt_id`=`vattu`.id and `congtrinh`.`id` = `xuatkho`.`ct_id` and `vattu`.`npp_id`=`nhaphanphoi`.`id`and `vattu`.`nsx_id`=`nhasanxuat`.`id` and `donvitinh`.`id`= `vattu`.`dvt_id` GROUP by `xuatkho`.`id` ORDER BY ct_ten";
            }
            else
            {

                sql = "SELECT vt_ten,`congtrinh`.`ct_ten`,`congtrinh`.`ct_ma`,`vattu`.`vt_gia` ,`nhasanxuat`.`nsx_ten`,`donvitinh`.`dvt_ten`,`nhaphanphoi`.`npp_ten`,COUNT(serial) as SLton  FROM `serial`,`chitietxuatkho`,`xuatkho`,`vattu`,`congtrinh` ,`nhaphanphoi`,`nhasanxuat`,`donvitinh` WHERE `serial`.`ctxk_id`=`chitietxuatkho`.`id` and `chitietxuatkho`.`xk_id` = `xuatkho`.`id` AND `serial`.`vt_id`=`vattu`.id and `congtrinh`.`id` = `xuatkho`.`ct_id` and `vattu`.`npp_id`=`nhaphanphoi`.`id`and `vattu`.`nsx_id`=`nhasanxuat`.`id` and `donvitinh`.`id`= `vattu`.`dvt_id` and ct_ma = '" + c + "' GROUP by `xuatkho`.`id` ORDER BY ct_ten";           
            }
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlDataAdapter mysql = new MySqlDataAdapter(sql,connection);
            DataSet DS = new DataSet();
            mysql.Fill(DS);            
            dataGridView1.DataSource = DS.Tables[0];
            DataTable dt = (DataTable)dataGridView1.DataSource;
            connection.Close();                                  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            string ten = textBox1.Text;
            xlWorkBook.SaveAs("G:\\meo_meo\\" + ten + ".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Excel file created , you can find the file G:\\meo_meo\\test.xlsx");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            string ten = textBox1.Text;
            xlWorkBook.SaveAs("G:\\meo_meo\\"+ten+".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Excel file created , you can find the file G:\\meo_meo\\test.xlsx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Tạo phần đầu nếu muốn

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            Microsoft.Office.Interop.Excel.Range head = xlWorkSheet.get_Range("A1", "H1");

            head.MergeCells = true;

            head.Value2 = "BẢNG KIỂM KÊ TÀI SẢN CỐ ĐỊNH";

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = xlWorkSheet.get_Range("A3", "A3");

            cl1.Value2 = "Tên vật tư";

            cl1.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl2 = xlWorkSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Bộ phận";

            cl2.ColumnWidth = 25.5;

            Microsoft.Office.Interop.Excel.Range cl3 = xlWorkSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mã bộ phận";

            cl3.ColumnWidth = 10.5;
            Microsoft.Office.Interop.Excel.Range cl4 = xlWorkSheet.get_Range("D3", "D3");

            cl4.Value2 = "Model";

            cl4.ColumnWidth = 15.5;
            Microsoft.Office.Interop.Excel.Range cl5 = xlWorkSheet.get_Range("E3", "E3");

            cl5.Value2 = "Nhà sản xuất";

            cl5.ColumnWidth = 25.5;
            Microsoft.Office.Interop.Excel.Range cl6 = xlWorkSheet.get_Range("F3", "F3");

            cl6.Value2 = "Đơn vị tính";

            cl6.ColumnWidth = 5.5;
            Microsoft.Office.Interop.Excel.Range cl7 = xlWorkSheet.get_Range("G3", "G3");

            cl7.Value2 = "Nhà cung ứng";
            cl7.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl8 = xlWorkSheet.get_Range("H3", "H3");

            cl8.Value2 = "SL kiểm kê";
            cl8.ColumnWidth = 12.5;
            
            Microsoft.Office.Interop.Excel.Range rowHead = xlWorkSheet.get_Range("A3", "H3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Lấy dữ liệu ra
            DataTable dt = (DataTable)dataGridView1.DataSource;
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            
            for (int r = 0; r < dt.Rows.Count; r++)

            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = xlWorkSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            string ten = textBox1.Text;
            xlWorkBook.SaveAs("G:\\meo_meo\\" + ten + ".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Excel file created , you can find the file G:\\meo_meo\\test.xlsx");
        }
    }
}
