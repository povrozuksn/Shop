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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            for (int i = 0; i < MainForm.products.Count; i++)
            {
                DelComboBox.Items.Add(MainForm.products[i].name);
            }

        }

        private void DelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelTextBox.Text = DelComboBox.Text;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить выбранный объект", "Удаление объекта", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string name = "";
                System.IO.File.Delete("../../Pictures/products.txt");
                for (int i = 0; i < MainForm.products.Count; i++)
                {
                    if (DelTextBox.Text == MainForm.products[i].name)
                    {
                        name = MainForm.products[i].name;
                    }
                    else 
                    {
                        System.IO.File.AppendAllText("../../Pictures/products.txt", MainForm.products[i].name + ", " +
                                                                            MainForm.products[i].category + ", " +
                                                                            MainForm.products[i].сalorie + ", " +
                                                                            MainForm.products[i].period + ", " +
                                                                            MainForm.products[i].price + 
                                                                            Environment.NewLine );
                    }
                }

                MessageBox.Show("Объект успешно удален");
                Close();
            }
        }
    }
}
