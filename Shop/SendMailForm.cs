using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //Адрес: от кого
            MailAddress fromAdress = new MailAddress("serzh.povorov.95@mail.ru");

            if (AdressTextBox.Text == "")
            {
                MessageBox.Show("Укажите адрес электронной почты");
            }
            else
            {
                //Адрес: кому
                MailAddress toAdress = new MailAddress(AdressTextBox.Text);
                //Формирование электронного сообщения
                using (MailMessage mailMessage = new MailMessage(fromAdress, toAdress))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    //Тема письма
                    mailMessage.Subject = "Ваш список";
                    //Текст письма
                    mailMessage.Body = "Здравствуйте, " + AuthForm.username + Environment.NewLine + ". Мы прислали Вам список избранного, общей стоимостью " + SelectedForm.TotalPrice;
                    mailMessage.IsBodyHtml = true;

                    System.IO.File.AppendAllText("Избранное_" + AuthForm.username + ".csv", "Название,Количество,Цена");
                    foreach(KeyValuePair<Product, int> select_product in SelectedForm.selectProduct)
                    {
                        Product product = select_product.Key;
                        System.IO.File.AppendAllText("Избранное_" + AuthForm.username + ".csv", Environment.NewLine + product.name + "," + select_product.Value + "," + product.price);
                    }

                    System.IO.File.AppendAllText("Избранное_" + AuthForm.username + ".csv", Environment.NewLine + ",Общая стоимость," + SelectedForm.TotalPrice);

                    mailMessage.Attachments.Add(new Attachment("Избранное_" + AuthForm.username + ".csv"));

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
