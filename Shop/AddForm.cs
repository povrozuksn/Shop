using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(KallTextBox.Text, out a) || !Int32.TryParse(PeriodTextBox.Text, out a) || !Int32.TryParse(PriceTextBox.Text, out a))
            {
                MessageBox.Show("Не число");
                return;
            }

            if(NameTextBox.Text=="" || CategoryComboBox.Text=="" || KallTextBox.Text=="" || PeriodTextBox.Text=="" || PriceTextBox.Text=="")
            {
                MessageBox.Show("Все поля обязательны к заполнению");
                return;
            }

            System.IO.File.AppendAllText("../../Pictures/products.txt", Environment.NewLine +
                                                                        NameTextBox.Text + ", " +
                                                                        CategoryComboBox.Text + ", " +
                                                                        KallTextBox.Text + ", " +
                                                                        PeriodTextBox.Text + ", " + 
                                                                        PriceTextBox.Text);


            if(FileName != "")
            {
                System.IO.File.Copy(FileName, "../../Pictures/" + NameTextBox.Text + ".jpg");
            }

            System.IO.File.AppendAllText("../../Pictures/" + NameTextBox.Text + ".txt", OpisTextBox.Text);

            MessageBox.Show("Сорханено");
            Close();
        }

        string FileName = "";
        private void LoadPicButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }
    }
}
