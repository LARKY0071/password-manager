using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoRun();
            //DevMode();
            //LogsEnable();
        }

        private void LogsEnable()
        {
            string npath = "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents";

            if (checkBox1.Checked)
            {
                Logs(true , npath);
            }
            else
            {
                Logs(false , npath);
            }
        }

        public static bool Logs(bool autorun, string path)
        {
            const string name = "PM-Logs";
            string Path = path;
            RegistryKey reg;

            reg = Registry.CurrentUser.CreateSubKey("Software\\PasswordManager\\");
            try
            {
                if (autorun)
                {
                    reg.SetValue(name, Path);
                }
                else
                {
                    reg.DeleteValue(name);
                }
                reg.Flush();
                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }





        private void AutoRun()
        {
            if (checkBox1.Checked)
            {
                SetAutorunValue(true, Application.ExecutablePath);
            }
            else
            {
                SetAutorunValue(false, Application.ExecutablePath);
            }
        }

        

        public static bool SetAutorunValue(bool autorun, string npath)
        {
            const string name = "PM";
            string ExePath = npath;
            RegistryKey reg;

            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                {
                    reg.SetValue(name, ExePath);
                }
                else
                {
                    reg.DeleteValue(name);
                }
                reg.Flush();
                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
