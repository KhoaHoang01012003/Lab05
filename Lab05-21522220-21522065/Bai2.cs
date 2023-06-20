using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Search;
using MimeKit;
using MailKit.Security;

namespace Lab05_21522220_21522065
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBox1.Text;
                string password = textBox2.Text;
                var client = new MailKit.Net.Imap.ImapClient();
                client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
                using (client)
                {
                    client.Connect("localhost", 993, SecureSocketOptions.SslOnConnect);

                    client.Authenticate(email, password);

                    // Lấy tất cả các thư trong thư mục INBOX
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Lấy danh sách các email đã nhận
                    var messages = inbox.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope | MessageSummaryItems.Flags);

                    // Hiển thị danh sách email lên DataGridView
                    foreach (var message in messages)
                    {
                        string from = message.Envelope.From.ToString();
                        string subject = message.Envelope.Subject;
                        DateTimeOffset? date = message.Envelope.Date;
                        DateTimeOffset dateTimeOffset = date ?? default;
                        DateTime dateTime = dateTimeOffset.DateTime;
                        dataGridView1.Rows.Add(subject, from, date);
                    }
                    textBox3.Text = messages.Count.ToString();

                    DateTime now = DateTime.Now;
                    DateTime yesterday = now.AddDays(-1);

                    int recent = messages.Count(m => m.Envelope.Date >= yesterday);

                    textBox4.Text = recent.ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
