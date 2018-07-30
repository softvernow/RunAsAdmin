using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAsAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {


            if (args.Length == 0)
            {

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                System.Security.SecureString ssPwd = new System.Security.SecureString();
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.FileName = "RunAsAdmin.exe";
                proc.StartInfo.Arguments = "run";
                //proc.StartInfo.Verb = "runas";
                //proc.StartInfo.Domain = "hca.corpad.net";
                proc.StartInfo.Domain = "yourDOMAIN";
                proc.StartInfo.UserName = "YOURLOGIN";
                string password = "YOURPASSWORD";
                for (int x = 0; x < password.Length; x++)
                {
                    ssPwd.AppendChar(password[x]);
                }
                password = "";
                proc.StartInfo.Password = ssPwd;
                proc.Start();

            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
         


        }
    }
}
