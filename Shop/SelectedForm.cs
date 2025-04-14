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
    public partial class SelectedForm : Form
    {
        public static Dictionary<Product, int> selectProduct = new Dictionary<Product, int>();
        int TotalPrice = 0;

        public SelectedForm()
        {
            InitializeComponent();
            Text = "Выбранные объекты пользователя: " + AuthForm.username;
            ReDraw();
        }

        void ReDraw()
        {
            Controls.Clear();
            Controls.Add(TotalPriceLabel);

            int x = 30;
            int y = 150;
            foreach (KeyValuePair<Product, int> select_product in selectProduct)
            {
                Product product = select_product.Key;

                #region 1 столбец - Картинка
                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, y);
                pic.Size = new Size(215, 178);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = product.picture.Image;
                Controls.Add(pic);
                #endregion

                #region 2 столбец - Характеристики
                Label lbl_name = new Label();
                lbl_name.Location = new Point(x + 250, y);
                lbl_name.Size = new Size(300, 20);
                lbl_name.Text = "Товар: " + select_product.Key.name.ToString();
                Controls.Add(lbl_name);

                Label lbl_cat = new Label();
                lbl_cat.Location = new Point(x + 250, y + 20);
                lbl_cat.Size = new Size(300, 20);
                lbl_cat.Text = "Категория: " + select_product.Key.category.ToString();
                Controls.Add(lbl_cat);

                Label lbl_kall = new Label();
                lbl_kall.Location = new Point(x + 250, y + 40);
                lbl_kall.Size = new Size(300, 20);
                lbl_kall.Text = "Энерг. ценность: " + select_product.Key.сalorie.ToString();
                Controls.Add(lbl_kall);

                Label lbl_per = new Label();
                lbl_per.Location = new Point(x + 250, y + 60);
                lbl_per.Size = new Size(300, 20);
                lbl_per.Text = "Срок хранения: " + select_product.Key.period.ToString();
                Controls.Add(lbl_per);

                Button btn_opis = new Button();
                btn_opis.Location = new Point(x + 250, y + 90);
                btn_opis.Size = new Size(200, 40);
                btn_opis.Text = "К описанию";
                btn_opis.Tag = select_product.Key.name;
                btn_opis.Click += new EventHandler(open_product);
                Controls.Add(btn_opis);
                #endregion

                #region 3 столбец - Количество+Цена
                Label lbl_kol = new Label();
                lbl_kol.Location = new Point(x + 600, y);
                lbl_kol.Size = new Size(100, 20);
                lbl_kol.Text = "Количество:";
                Controls.Add(lbl_kol);

                NumericUpDown kol = new NumericUpDown();
                kol.Location = new Point(x + 600, y + 20);
                kol.Size = new Size(120, 20);
                kol.Value = select_product.Value;
                kol.ValueChanged += new EventHandler(count_changed);
                Controls.Add(kol);

                Label lbl_price = new Label();
                lbl_price.Location = new Point(x + 600, y + 60);
                lbl_price.Size = new Size(100, 20);
                lbl_price.Text = "Цена: " + select_product.Key.price.ToString();
                Controls.Add(lbl_price);

                Label lbl_stoim = new Label();
                lbl_stoim.Location = new Point(x + 600, y + 80);
                lbl_stoim.Size = new Size(200, 20);
                lbl_stoim.Text = "Стоимость: " + (select_product.Key.price * select_product.Value).ToString();
                Controls.Add(lbl_stoim);
                #endregion

                #region 4 столбец - Кнопка удаления
                Button btn_del = new Button();
                btn_del.Location = new Point(x + 900, y);
                btn_del.Size = new Size(200, 30);
                btn_del.Text = "Удалить";
                btn_del.Click += new EventHandler(DelClick);
                Controls.Add(btn_del);
                #endregion


                y += 220;
            }
            Calculate();
            TotalPriceLabel.Text = "Общая стоимость: " + TotalPrice.ToString();
        }

        void DelClick(object sender, EventArgs e)
        {
            int i = 0;
            Dictionary<Product, int> selectProduct1 = new Dictionary<Product, int>();
            Button btn = (Button)sender;
            foreach (KeyValuePair<Product, int> select_product in selectProduct)
            {
                Product product = select_product.Key;
                if(btn.Location == new Point(30 + 900, 220 * i + 150 + AutoScrollPosition.Y))
                {

                }
                else
                {
                    selectProduct1[select_product.Key] = select_product.Value;
                }
                i++;
            }
            selectProduct = selectProduct1;
            ReDraw();
        }

        private void open_product(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (KeyValuePair<Product, int> select_product in selectProduct)
            {
                if (btn.Tag.ToString() == select_product.Key.name)
                {
                    ProductForm frm = new ProductForm(select_product.Key);
                    frm.Show();
                }
            }
        }

        private void count_changed(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            for (int i = 0; i < selectProduct.Count; i++)
            {
                if (num.Location == new Point(630, 220 * i + 170 + AutoScrollPosition.Y))
                {
                    int price = 0;
                    string name = "";

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(630, 220 * i + 210 + AutoScrollPosition.Y))
                        {
                            price = Convert.ToInt32(ctrl.Text.Replace("Цена: ", ""));
                        }
                    }
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(630, 220 * i + 230 + AutoScrollPosition.Y))
                        {
                            ctrl.Text = "Стоимость: " + (price * num.Value).ToString();
                        }
                    }
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(280, 220 * i + 150 + AutoScrollPosition.Y))
                        {
                            name = ctrl.Text.Replace("Товар: ", "");       
                        }
                    }
                    foreach (Product product in MainForm.products)
                    {
                        if(product.name ==  name)
                        {
                            selectProduct[product] = Convert.ToInt32(num.Value);
                        }
                    }
                }
            }
            Calculate();
            TotalPriceLabel.Text = "Общая стоимость: " + TotalPrice.ToString();
        }

        void Calculate()
        {
            TotalPrice = 0;
            foreach (KeyValuePair<Product, int> select_product in selectProduct)
            {
                TotalPrice += select_product.Value * select_product.Key.price;
            }
        }
    }
}
