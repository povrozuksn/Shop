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
    public partial class AuthForm : Form
    {
        public static string username = "";
        public static bool isAdmin = false;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string[] strs = System.IO.File.ReadAllLines("users.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                if(LoginTextBox.Text == parts[2] && PasTextBox.Text == parts[3])
                {
                    username = parts[0] + " " + parts[1];
                    isAdmin = (parts[4]=="1");
                    Close();
                    return;
                }
            }
            MessageBox.Show("Введен неверный логин/пароль");
        }
    }
}
