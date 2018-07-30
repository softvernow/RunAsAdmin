using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAsAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public Boolean Is_Administrator()
        {
            Boolean result = false;

            try
            {
                result = (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                throw;
            }
                   
            return result;
        }

        private void btnRunAsAdmin_Click(object sender, EventArgs e)
        {

            if (Is_Administrator())
                MessageBox.Show("Application is Running as Administrator");
            else
                MessageBox.Show("Application is NOT Running as Administrator");

        }
    }
}






