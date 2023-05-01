using System.Net;
using System.Net.Mail;

namespace Email
{
    public partial class Form1 : Form
    {
        OpenFileDialog f = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //SMTP
            var username = "annabel.jaskolski18@ethereal.email";
            var passeord = "eFYvGeZHfCtaQgMDpR";
            var host = "smtp.ethereal.email";
            var port = 587;


            var message = new MailMessage();
            message.To.Add(textBoxTo.Text);
            message.Subject = textBoxSubject.Text;
            message.Body = textBoxBody.Text;
            message.IsBodyHtml= true;
            message.From = new MailAddress(username);
            message.Attachments.Add(new Attachment(f.FileName));

            var smptClinet = new SmtpClient();
            smptClinet.Host = host;
            smptClinet.Port = port;
            smptClinet.EnableSsl= true;
            smptClinet.Credentials = new NetworkCredential(username, passeord);

            smptClinet.Send(message);
            MessageBox.Show("Done");

        }

        private void button1_Click(object sender, EventArgs e)
        {                        
            f.ShowDialog();
        }
    }
}