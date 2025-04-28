using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //Адрес: от кого
            MailAddress fromAdress = new MailAddress("serzh.povorov.95@mail.ru");

            if (TopicComboBox.Text == "")
            {
                MessageBox.Show("Поле <ТЕМА> обязательно для заполнения");
            }
            else
            {
                //Адрес: кому
                MailAddress toAdress = new MailAddress("serzh.povorov.95@mail.ru");
                //Формирование электронного сообщения
                using (MailMessage mailMessage = new MailMessage(fromAdress, toAdress))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    //Тема письма
                    mailMessage.Subject = TopicComboBox.Text;
                    //Текст письма
                    mailMessage.Body = MessageTextBox.Text;
                    mailMessage.IsBodyHtml = true;

                    smtpClient.Host = "smtp.mail.ru";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "erfHctFyUSzczxkna0cw");

                    smtpClient.Send(mailMessage);
                }
                MessageBox.Show("Сообщение отправлено");
                Close();
            }
        }
    }
}
