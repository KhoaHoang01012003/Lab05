using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_21522220_21522065
{
    public partial class Bai3_Login : Form
    {
        public Bai3_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993, true);
            try
            {
                client.Authenticate(textBox1.Text, textBox2.Text);
                Properties.Settings.Default.Email = textBox1.Text;
                Properties.Settings.Default.Password = textBox2.Text;
                Properties.Settings.Default.Save();

                // Mở form chính
                var mainForm = new Bai3_Inbox(this);
                mainForm.Show();
                this.Hide();
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }

        }
    }
}
