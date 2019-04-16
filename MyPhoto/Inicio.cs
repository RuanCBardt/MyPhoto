using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyPhoto
{
    public partial class MyPhoto : Form
    {
        public MyPhoto()
        {
            InitializeComponent();
        }

        private void OpcaoImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog importarfoto = new OpenFileDialog();
            importarfoto.Title = "Selecione sua Imagem";
            importarfoto.Filter = "Tipo de Arquivo (*.jpg; *.jpeg; *.bmp;) | *.jpg; *.jpeg; *.bmp;";

            if (importarfoto.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagem = new Bitmap(importarfoto.FileName);
                imagemOriginal.Image = imagem;
            }
        }

        private void OpcaoLimparOriginal_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                imagemOriginal.CancelAsync();
                imagemOriginal.Image.Dispose();
                imagemOriginal.Image = null;
            }
            
        }

        private void OpcaoLimparEditada_Click(object sender, EventArgs e)
        {
            if (imagemEditada.Image == null)
            {
                MessageBox.Show("Você não tem nenhuma imagem editada.");
            }

            else
            {
                imagemEditada.CancelAsync();
                imagemEditada.Image.Dispose();
                imagemEditada.Image = null;
            }
            
        }

        private void OpcaoPretoBranco_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemPretoBranco = new Bitmap(imagemOriginal.Image);

                int largura = imagemPretoBranco.Width;
                int altura = imagemPretoBranco.Height;

                Color p;

                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        p = imagemPretoBranco.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        int avg = (r + g + b) / 3;

                        imagemPretoBranco.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    }
                }

                imagemEditada.Image = imagemPretoBranco;
            }
        }

        private void OpcaoNegativo_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemNegativo = new Bitmap(imagemOriginal.Image);

                int largura = imagemNegativo.Width;
                int altura = imagemNegativo.Height;

                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        Color p = imagemNegativo.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        imagemNegativo.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                imagemEditada.Image = imagemNegativo;
            }
        }

        /*
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         *  AQUI VAI FICAR A PARTE DO BLUR QUE O AMILTO ESTÁ FINALIZANDO
         */

        private void OpcaoSepia_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemSepia = new Bitmap(imagemOriginal.Image);

                int largura = imagemSepia.Width;
                int altura = imagemSepia.Height;

                Color p;

                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        p = imagemSepia.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                        if (tr > 255)
                        {
                            r = 255;
                        }
                        else
                        {
                            r = tr;
                        }

                        if (tg > 255)
                        {
                            g = 255;
                        }
                        else
                        {
                            g = tg;
                        }

                        if (tb > 255)
                        {
                            b = 255;
                        }
                        else
                        {
                            b = tb;
                        }

                        imagemSepia.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                imagemEditada.Image = imagemSepia;
            }
            
        }

        private void OpcaoEnvelhecido_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemFundo = new Bitmap(imagemOriginal.Image);
                Bitmap efeitoEnvelhecido = new Bitmap("C:\\Users\\rcbardt\\Desktop\\MyPhoto\\MyPhoto\\MyPhoto\\layerEnvelhecido.png");
                Bitmap imagemEnvelhecida = new Bitmap(imagemFundo.Width, imagemFundo.Height);
                Bitmap efeitoEnvelhecidoAjustado = new Bitmap(efeitoEnvelhecido, new Size(imagemFundo.Width, imagemFundo.Height));

                using (Graphics gr = Graphics.FromImage(imagemEnvelhecida))
                {
                    gr.DrawImage(imagemFundo, new Point(0, 0));
                    gr.DrawImage(efeitoEnvelhecidoAjustado, new Point(0, 0));
                }

                imagemEditada.Image = imagemEnvelhecida;
            }
        }

        private void OpcaoEspelhar_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemEspelhar = new Bitmap(imagemOriginal.Image);

                int largura = imagemEspelhar.Width;
                int altura = imagemEspelhar.Height;

                Bitmap imagemInvertida = new Bitmap(largura * 2, altura);

                for (int y = 0; y < altura; y++)
                {
                    for (int lx = 0, rx = largura * 2 - 1; lx < largura; lx++, rx--)
                    {
                        Color p = imagemEspelhar.GetPixel(lx, y);

                        imagemInvertida.SetPixel(lx, y, p);
                        imagemInvertida.SetPixel(rx, y, p);
                    }
                }

                imagemEditada.Image = imagemInvertida;
            }
        }

        private void OpcaoSalvar_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else if (imagemEditada.Image == null)
            {
                MessageBox.Show("Você não editou uma imagem.");
            }

            else
            {
                SaveFileDialog salvarfoto = new SaveFileDialog();
                salvarfoto.Title = "Salvar imagem como";
                salvarfoto.Filter = "Tipo de Arquivo (*.jpg; *.jpeg; *.bmp;) | *.jpg; *.jpeg; *.bmp;";

                if (salvarfoto.ShowDialog() == DialogResult.OK)
                {
                    imagemEditada.Image.Save(salvarfoto.FileName);
                }
            }
        }
    }
}
