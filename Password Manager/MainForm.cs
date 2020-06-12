using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Password_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstStart();
        }

        private void FirstStart()
        {
            RegistryKey curr = Registry.CurrentUser;
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey FS = curr.OpenSubKey("Software\\PasswordManager", true);
            RegistryKey StartKey = currentUserKey.CreateSubKey("Software\\PasswordManager");

            if (null == FS.GetValue("PM-create"))
            {
                DateTime StartDate = DateTime.Today;
                StartKey.SetValue("PM", "Larky " + StartDate.ToString("d"));
                StartKey.SetValue("PM-create", "yes hi world");
            }
            else
            {
                //MessageBox.Show("NE FIRST RAZ!");
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*Form form = Application.OpenForms[0];
            form.Show();*/
        }

        private void изменитьПаролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassForm form = new PassForm();
            form.Show();
        }

        private void пароль1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)GetPass.GetPassword("p1"));
        }

        private void пароль2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)GetPass.GetPassword("p2"));
        }

        private void пароль3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)GetPass.GetPassword("p3"));
        }

        private void пароль4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)GetPass.GetPassword("p4"));
        }
    }
}
