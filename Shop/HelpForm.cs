using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            if(AuthForm.isAdmin)
            {
                textBox1.Text = File.ReadAllText("../../Pictures/admin_manual.txt");
            }
            else
            {
                textBox1.Text = File.ReadAllText("../../Pictures/user_manual.txt");
            }
        }
    }
}
