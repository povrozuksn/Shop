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

            //Адрес: кому
            MailAddress toAdress = new MailAddress("serzh.povorov.95@mail.ru");

            //Тема письма


            //Сообщение
        }
    }
}
