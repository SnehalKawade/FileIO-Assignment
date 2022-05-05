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

namespace WindowsFormsApp
{
    public partial class StudentData : Form
    {
        FileStream fs;
        public StudentData()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = Convert.ToInt32(txtRollNo.Text);
                string name = txtName.Text;
                int percentage = Convert.ToInt32(txtPercentage.Text);
                string stream=txtStream.Text;
                string city = txtCity.Text;

                fs = new FileStream(@"E:\TestFolder\StudentData.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(rollno);
                bw.Write(name);
                bw.Write(percentage);
                bw.Write(stream);
                bw.Write(city);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\TestFolder\StudentData.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRollNo.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPercentage.Text=br.ReadInt32().ToString();
                txtStream.Text = br.ReadString();
                txtCity.Text = br.ReadString();
                br.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
