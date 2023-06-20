using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05_21522220_21522065
{
    public partial class Bai3_sendmail : Form
    {
        public Bai3_sendmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new MailKit.Net.Smtp.SmtpClient();
                client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
                client.Connect("127.0.0.1", 465, true);
                client.Authenticate(Properties.Settings.Default.Email, Properties.Settings.Default.Password);

                var message = new MimeKit.MimeMessage();
                message.From.Add(new MimeKit.MailboxAddress(Properties.Settings.Default.Email, Properties.Settings.Default.Email));
                message.To.Add(new MimeKit.MailboxAddress(textBox1.Text, textBox1.Text));
                message.Subject = textBox2.Text;
                message.Body = new MimeKit.TextPart("plain") { Text = richTextBox1.Text };

                client.Send(message);
                MessageBox.Show("Gửi mail thành công đến " + textBox1.Text);
                client.Disconnect(true);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }
    }
}
