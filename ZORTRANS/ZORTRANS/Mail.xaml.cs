using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for Mail.xaml
    /// </summary>
    public partial class Mail : Window
    {

        public Mail(string receiver)
        {
            
            InitializeComponent();
            tb_to.Text = receiver;
           // this.Show();
         
        }

        private void B_sendmail_Click(object sender, RoutedEventArgs e)
        {

            //MailMessage mail = new MailMessage();
            //SmtpClient Smtp = new SmtpClient("smtp.google.com");

            //mail.From = new MailAddress(tb_sender.Text);
            //mail.To.Add(tb_to.Text);
            //mail.Subject = tb_subject.Text;
            //mail.Body = tb_message.Text;

            //Smtp.Port = 587;
            //Smtp.Credentials = new System.Net.NetworkCredential(tb_sender.Text, "pass"); // credentiale pt contul google
            //Smtp.Send(mail);

            this.Close();
            MessageBox.Show("Your email was sent.","", MessageBoxButton.OK, MessageBoxImage.Information);
           
        }

        
    }
}
