﻿using Shop.Properties;
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
    public struct Product
    {
        public string name;
        public string category;
        public int сalorie;
        public int period;
        public int price;
        public PictureBox picture;
        public Label label;

        public Product(string _name, string _category, int _сalorie, int _period, int _price)
        {
            name = _name;
            category = _category;
            сalorie = _сalorie;
            period = _period;
            price = _price;
            picture = new PictureBox();
            try
            {
                picture.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }
            picture.Tag = name;

            label = new Label();
            label.Text = name;
        }
    }

    
    public partial class MainForm : Form
    {
        public static List<Product> products = new List<Product>();

        public MainForm()
        {
            InitializeComponent();

            NameLabel.Visible = false;
            FiltrPanel.Height = HideButton.Height;
            HideButton.Text = "Развернуть";
            
            products.Clear();
            string[] strs = System.IO.File.ReadAllLines("../../Pictures/products.txt");

            foreach (string str in strs) 
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                Product product = new Product(  parts[0], 
                                                parts[1], 
                                                Convert.ToInt32(parts[2]),
                                                Convert.ToInt32(parts[3]),
                                                Convert.ToInt32(parts[4])   );
                products.Add(product);
            }
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            for(int i=0; i<products.Count; i++)
            {
                if(pb.Tag.ToString() == products[i].name)
                {
                    ProductForm frm = new ProductForm(products[i]);
                    frm.Show();
                }
            }
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            for (int i=0; i< products.Count; i++)
            {
                if (lbl.Text == products[i].name)
                {
                    ProductForm frm = new ProductForm(products[i]);
                    frm.Show();
                }
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 25;
            for(int i=0; i<products.Count; i++)
            {
                products[i].picture.Location = new Point(x, y);
                products[i].picture.Size = new Size(215, 178);
                products[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                products[i].picture.Click += new EventHandler(picProduct_Click);
                MainPanel.Controls.Add(products[i].picture);

                products[i].label.Location = new Point(x, y+200);
                products[i].label.Size = new Size(136, 25);
                products[i].label.Click += new EventHandler(lblProduct_Click);
                MainPanel.Controls.Add(products[i].label);

                x += 250;
                if(x+215 > MainPanel.Width)
                {
                    x = 30;
                    y += 250;
                }
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 25;
            for (int i = 0; i < products.Count; i++)
            {
                products[i].picture.Visible = true;
                products[i].label.Visible = true;

                if (NameTextBox.Text != "" && !products[i].name.Contains(NameTextBox.Text))
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                if (CategoryComboBox.Text != "" && CategoryComboBox.Text != products[i].category)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                if (KallTextBox.Text != "" && Convert.ToInt32(KallTextBox.Text) < products[i].сalorie)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                if (PriceToComboBox.Text != "" && Convert.ToInt32(PriceToComboBox.Text) >= products[i].price)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                if (PriceFromComboBox.Text != "" && Convert.ToInt32(PriceFromComboBox.Text) <= products[i].price)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }


                if (products[i].picture.Visible)
                {
                    products[i].picture.Location = new Point(x, y);
                    products[i].label.Location = new Point(x, y + 200);

                    x += 250;
                    if (x + 215 > MainPanel.Width)
                    {
                        x = 30;
                        y += 250;
                    }
                }
            }
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
           FindButton_Click(null, null);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
        }
    }
}
