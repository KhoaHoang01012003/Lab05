using System.Net.Mail;
using System.Net;

namespace Lab05_21522220_21522065
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin đăng nhập từ Textbox
            string from = textBox1.Text.Trim();
            string password = textBox3.Text.Trim();

            // Lấy thông tin người nhận và nội dung email
            string to = textBox2.Text.Trim();
            string subject = textBox4.Text.Trim();
            string body = richTextBox1.Text;

            // Tạo đối tượng MailMessage để đóng gói email
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            mail.Subject = subject;
            mail.Body = body;

            // Tạo đối tượng SmtpClient để gửi email
            SmtpClient smtpClient = new SmtpClient("127.0.0.1", 25);
            smtpClient.Credentials = new NetworkCredential(from, password);
            smtpClient.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            smtpClient.Send(mail);

            // Hiển thị thông báo gửi email thành công
            MessageBox.Show("Email sent successfully!");
        }
    }
}