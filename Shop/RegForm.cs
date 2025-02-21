using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if(PasswordTB.Text == REPasswordTB.Text)
            {
                if (NameTB.Text!="" && SecondnameTB.Text!="" && LoginTB.Text!="" && PasswordTB.Text!="")
                {
                    System.IO.File.AppendAllText("users.txt",
                                              NameTB.Text + ", " +
                                              SecondnameTB.Text + ", " +
                                              LoginTB.Text + ", " +
                                              PasswordTB.Text + ", 0" +
                                              Environment.NewLine);
                    MessageBox.Show("Регистрация прошла успешно");
                    Close();
                }
                else MessageBox.Show("Не заполнены обязательные поля");
            }
            else MessageBox.Show("Пароли не совпадают");
        }
    }
}
