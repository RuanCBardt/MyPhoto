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
            importarfoto.Filter = "Tipo de Arquivo (*.jpg; *.jpeg; *.bmp; *.png; *.gif;) | *.jpg; *.jpeg; *.bmp; *.png; *.gif;";

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

                Color pixel;

                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        pixel = imagemPretoBranco.GetPixel(x, y);

                        int a = pixel.A;
                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;

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
                        Color pixel = imagemNegativo.GetPixel(x, y);

                        int a = pixel.A;
                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;

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
         * ESTÁ DANDO ERRO NO BLUR
         * ESTÁ DANDO ERRO NO BLUR
         * ESTÁ DANDO ERRO NO BLUR
         * ESTÁ DANDO ERRO NO BLUR
         */

        private void OpcaoBlur_Click(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemBlur = new Bitmap(imagemOriginal.Image);

                int largura = imagemBlur.Width;
                int altura = imagemBlur.Height;
                int quantBlur = 10;

                for (int y = quantBlur; y < largura- quantBlur; y++)
                {
                    for (int x = quantBlur; x < altura- quantBlur; x++)
                    {
                        Color c = imagemBlur.GetPixel(y, x);
                        Color n =  imagemBlur.GetPixel(y - quantBlur, x);
                        Color s =  imagemBlur.GetPixel(y + quantBlur, x);
                        Color o =  imagemBlur.GetPixel(y, x - quantBlur);
                        Color l =  imagemBlur.GetPixel(y, x + quantBlur);
                        Color no = imagemBlur.GetPixel(y - quantBlur, x - quantBlur);
                        Color so = imagemBlur.GetPixel(y + quantBlur, x - quantBlur);
                        Color ne = imagemBlur.GetPixel(y - quantBlur, x + quantBlur);
                        Color se = imagemBlur.GetPixel(y + quantBlur, x + quantBlur);
                        
                        int avgR = (int)((n.R + s.R + o.R + l.R + no.R + so.R + ne.R + se.R + c.R) / 9);
                        int avgG = (int)((n.G + s.G + o.G + l.G + no.G + so.G + ne.G + se.G + c.R) / 9);
                        int avgB = (int)((n.B + s.B + o.B + l.B + no.B + so.B + ne.B + se.B + c.R) / 9);

                        imagemBlur.SetPixel(y, x, Color.FromArgb(avgR, avgG, avgB));
                    }
                }

                imagemEditada.Image = imagemBlur;
            }
        }

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

                Color pixel;

                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        pixel = imagemSepia.GetPixel(x, y);

                        int a = pixel.A;
                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;

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
                Bitmap efeitoEnvelhecido = new Bitmap(@"../../Imagens/layerEnvelhecido.png");
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

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            if (imagemOriginal.Image == null)
            {
                MessageBox.Show("Você não importou uma imagem.");
            }

            else
            {
                Bitmap imagemFundo = new Bitmap(imagemOriginal.Image);
                Bitmap efeitoPascoa = new Bitmap(@"../../Imagens/molduraPascoa.png");
                Bitmap imagemPascoa = new Bitmap(imagemFundo.Width, imagemFundo.Height);
                Bitmap efeitoPascoaAjustado = new Bitmap(efeitoPascoa, new Size(imagemFundo.Width, imagemFundo.Height));

                using (Graphics gr = Graphics.FromImage(imagemPascoa))
                {
                    gr.DrawImage(imagemFundo, new Point(0, 0));
                    gr.DrawImage(efeitoPascoaAjustado, new Point(0, 0));
                }

                imagemEditada.Image = imagemPascoa;
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
