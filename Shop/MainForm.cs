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

            label = new Label();
            label.Text = name;
        }
    }

    
    public partial class MainForm : Form
    {
        Product[] products = new Product[5];

        public MainForm()
        {
            InitializeComponent();

            NameLabel.Visible = false;
            FiltrPanel.Height = HideButton.Height;
            HideButton.Text = "Развернуть";

            products[0] = new Product("Хлеб ржаной", "Хлебобулочные изделия", 259, 36, 30);
            products[1] = new Product("Хлеб белый", "Хлебобулочные изделия", 265, 24, 40);
            products[2] = new Product("Молоко 32%", "Кисломолочные продукты", 64, 7, 90);
            products[3] = new Product("Кефир", "Кисломолочные продукты", 53, 14, 70);
            products[4] = new Product("Колбаса", "Мясные продукты", 257, 7, 170);

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = 30;
            for(int i=0; i<5; i++)
            {
                products[i].picture.Location = new Point(x, 25);
                products[i].picture.Size = new Size(215, 178);
                products[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                products[i].picture.Click += new EventHandler(picProduct_Click);
                MainPanel.Controls.Add(products[i].picture);

                products[i].label.Location = new Point(x, 220);
                products[i].label.Size = new Size(136, 25);
                MainPanel.Controls.Add(products[i].label);

                x += 250;
            }
        }
    }
}
