using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential("abc@gmail.com", "password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential("abc@gmail.com", "password");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage("abc@gmail.com", "xyz@gmail.com");
            message.Subject = "";
        }
    }
}
