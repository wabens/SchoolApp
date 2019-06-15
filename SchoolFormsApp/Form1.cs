using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // event handler!
            var testSchool = new School(); // imported with using abve
            testSchool.Name = txtName.Text;
            testSchool.City = txtCity.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.State = txtState.Text;
            testSchool.PhoneNumber = txtPhone.Text;
            testSchool.Zip = txtZip.Text;
            try
            {
                testSchool.TwitterAddress = txtTwitter.Text; // the exposed public version of the private
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());
        }
    }
}
