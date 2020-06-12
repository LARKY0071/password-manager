using System;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PassForm : Form 
    {
        public PassForm()
        {
            InitializeComponent();
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
            LoadPass();
        }

        private void LoadPass()
        {
            textBox1.Text = GetPass.GetPassword("p1");
            textBox2.Text = GetPass.GetPassword("p2");
            textBox3.Text = GetPass.GetPassword("p3");
            textBox4.Text = GetPass.GetPassword("p4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetPass.SetPassword("p1", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetPass.SetPassword("p2", textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetPass.SetPassword("p3", textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetPass.SetPassword("p4", textBox4.Text);
        }

        private void PassForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (textBox1.Text != GetPass.GetPassword("p1") || textBox2.Text != GetPass.GetPassword("p2") || textBox3.Text != GetPass.GetPassword("p3") || textBox4.Text != GetPass.GetPassword("p4"))
            {
                const string message = "У вас есть несохранённые изменения! Сохранить и выйти?";
                const string caption = "Закрытие формы!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveAll();
                    e.Cancel = false;
                }
                if (result == DialogResult.No)
                {
                    e.Cancel = false;
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SaveAll()
        {
            SetPass.SetPassword("p1", textBox1.Text);
            SetPass.SetPassword("p2", textBox2.Text);
            SetPass.SetPassword("p3", textBox3.Text);
            SetPass.SetPassword("p4", textBox4.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            const string message = "Вы хотите очистить все ваши пароли?";
            const string caption = "Очистка паролей!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string str = "Пароль не установлен";
                SetPass.SetPassword("p1", str);
                SetPass.SetPassword("p2", str);
                SetPass.SetPassword("p3", str);
                SetPass.SetPassword("p4", str);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                char ch = '*';
                textBox1.PasswordChar = ch;
                textBox2.PasswordChar = ch;
                textBox3.PasswordChar = ch;
                textBox4.PasswordChar = ch;
            }
            else
            {
                char ch = '\0';
                textBox1.PasswordChar = ch;
                textBox2.PasswordChar = ch;
                textBox3.PasswordChar = ch;
                textBox4.PasswordChar = ch;
            }
        }
    }
}
