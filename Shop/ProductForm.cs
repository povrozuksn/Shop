﻿using System;
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
    public partial class ProductForm : Form
    {
        public ProductForm(Product product)
        {
            InitializeComponent();

            Text = product.name;
            ProductLabel.Text = "Наименование товара: " + product.name;
            ProductPictureBox.Image = product.picture.Image;
            CategoryLabel.Text = "Категория товара: " + product.category;
            CalLabel.Text = "Энергетическая ценность: " + product.сalorie.ToString() + " Ккал";
            PeriodLabel.Text = "Срок хранения: " + product.period.ToString() + " суток";
            PriceLabel.Text = "Цена: " + product.price.ToString() + " руб.";

            try
            {
                OpisTextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + product.name + ".txt");
            }
            catch (Exception) { }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
