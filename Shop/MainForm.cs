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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NameLabel.Visible = false;
            FiltrPanel.Height = HideButton.Height;
            HideButton.Text = "Развернуть";
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ProductForm frm = new ProductForm(pb.Tag.ToString());
            frm.Show();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ProductForm frm = new ProductForm(lbl.Text);
            frm.Show();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height == HideButton.Height)
            {
                FiltrPanel.Height = 120;
                HideButton.Text = "Свернуть";
            }
            else
            {
                FiltrPanel.Height = HideButton.Height;
                HideButton.Text = "Развернуть";
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm frm = new RegForm();
            frm.ShowDialog();
        }
    }
}
