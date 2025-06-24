using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obrazek___branche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki graficzne |*.jpg; *.jpeg; *.png; *.bmp|Wszystkie pliki (*.*)|*.*";
            ofd.Title = "Wybierz plik graficzny do wczytania";
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                Bitmap bitmapa = new Bitmap(ofd.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = bitmapa;
            }
        }

        private void og_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            Bitmap origin = new Bitmap(pictureBox.Image);
            Bitmap zielony = new Bitmap(origin.Width, origin.Height);

            for (int x = 0; x < origin.Width; x++)
            {
                for (int y = 0; y < origin.Height; y++)
                {
                    Color pixel = origin.GetPixel(x, y);

                    if (pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        zielony.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        zielony.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox.Image = zielony;
            origin.Dispose();
        }
    }
}
