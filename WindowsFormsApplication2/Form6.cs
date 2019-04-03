using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if(open.ShowDialog()== DialogResult.OK)
            {
                tb1.Text = open.FileName;
                pb1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(tb1.Text,Path.Combine(@"G:\meo_meo", Path.GetFileName(tb1.Text)),true);
            MessageBox.Show("Đã lưu!");
            this.Hide();
            Form1 dlg2 = new Form1();
            dlg2.ShowDialog();
            this.Close();
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
