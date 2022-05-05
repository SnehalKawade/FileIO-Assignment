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
    public partial class EmployeeData : Form
    {
        FileStream fs;
        public EmployeeData()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int empid = Convert.ToInt32(txtEmpId.Text);
                string name = txtEmpName.Text;
                string destination = txtDestination.Text;
                int salary = Convert.ToInt32(txtSalary.Text); 
                string depat = txtDepartment.Text;

                fs = new FileStream(@"E:\TestFolder\EmployeeData.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(empid);
                bw.Write(name);
                bw.Write(destination);  
                bw.Write(salary);
                bw.Write(depat); 
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
                fs = new FileStream(@"E:\TestFolder\EmployeeData.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtEmpName.Text = br.ReadString();
                txtDestination.Text = br.ReadString();
                txtSalary.Text = br.ReadInt32().ToString(); 
                txtDepartment.Text = br.ReadString();
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
