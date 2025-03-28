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

        public SelectedForm()
        {
            InitializeComponent();
            Text = "Выбранные объекты пользователя: " + AuthForm.username;

            int x = 30;
            int y = 25;
            foreach (KeyValuePair<Product, int> select_product in selectProduct) 
            {
                Product product = select_product.Key;

                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, y);
                pic.Size = new Size(215, 178);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = product.picture.Image;
                Controls.Add(pic);

                Label lbl = new Label();
                lbl.Location = new Point(x+300,y);
                lbl.Size = new Size(200, 20);
                lbl.Text = "Количество: " + select_product.Value.ToString();
                Controls.Add(lbl);

                y += 220;
            }
        }
    }
}
