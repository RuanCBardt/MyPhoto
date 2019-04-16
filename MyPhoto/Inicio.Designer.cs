namespace MyPhoto
{
    partial class MyPhoto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagemOriginal = new System.Windows.Forms.PictureBox();
            this.imagemEditada = new System.Windows.Forms.PictureBox();
            this.opcaoPretoBranco = new System.Windows.Forms.Button();
            this.opcaoSepia = new System.Windows.Forms.Button();
            this.opcaoPixelizado = new System.Windows.Forms.Button();
            this.opcaoNegativo = new System.Windows.Forms.Button();
            this.opcao4Cores = new System.Windows.Forms.Button();
            this.opcaoImportar = new System.Windows.Forms.Button();
            this.opcaoSalvar = new System.Windows.Forms.Button();
            this.lbOriginal = new System.Windows.Forms.Label();
            this.lbEditada = new System.Windows.Forms.Label();
            this.opcaoLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemEditada)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemOriginal
            // 
            this.imagemOriginal.Location = new System.Drawing.Point(12, 12);
            this.imagemOriginal.Name = "imagemOriginal";
            this.imagemOriginal.Size = new System.Drawing.Size(349, 407);
            this.imagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemOriginal.TabIndex = 0;
            this.imagemOriginal.TabStop = false;
            // 
            // imagemEditada
            // 
            this.imagemEditada.Location = new System.Drawing.Point(555, 12);
            this.imagemEditada.Name = "imagemEditada";
            this.imagemEditada.Size = new System.Drawing.Size(349, 407);
            this.imagemEditada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemEditada.TabIndex = 1;
            this.imagemEditada.TabStop = false;
            // 
            // opcaoPretoBranco
            // 
            this.opcaoPretoBranco.Location = new System.Drawing.Point(414, 12);
            this.opcaoPretoBranco.Name = "opcaoPretoBranco";
            this.opcaoPretoBranco.Size = new System.Drawing.Size(90, 29);
            this.opcaoPretoBranco.TabIndex = 2;
            this.opcaoPretoBranco.Text = "Preto e Branco";
            this.opcaoPretoBranco.UseVisualStyleBackColor = true;
            this.opcaoPretoBranco.Click += new System.EventHandler(this.OpcaoPretoBranco_Click);
            // 
            // opcaoSepia
            // 
            this.opcaoSepia.Location = new System.Drawing.Point(414, 47);
            this.opcaoSepia.Name = "opcaoSepia";
            this.opcaoSepia.Size = new System.Drawing.Size(90, 29);
            this.opcaoSepia.TabIndex = 3;
            this.opcaoSepia.Text = "Sépia";
            this.opcaoSepia.UseVisualStyleBackColor = true;
            this.opcaoSepia.Click += new System.EventHandler(this.OpcaoSepia_Click);
            // 
            // opcaoPixelizado
            // 
            this.opcaoPixelizado.Location = new System.Drawing.Point(414, 117);
            this.opcaoPixelizado.Name = "opcaoPixelizado";
            this.opcaoPixelizado.Size = new System.Drawing.Size(90, 29);
            this.opcaoPixelizado.TabIndex = 5;
            this.opcaoPixelizado.Text = "Pixelizado";
            this.opcaoPixelizado.UseVisualStyleBackColor = true;
            // 
            // opcaoNegativo
            // 
            this.opcaoNegativo.Location = new System.Drawing.Point(414, 82);
            this.opcaoNegativo.Name = "opcaoNegativo";
            this.opcaoNegativo.Size = new System.Drawing.Size(90, 29);
            this.opcaoNegativo.TabIndex = 4;
            this.opcaoNegativo.Text = "Negativo";
            this.opcaoNegativo.UseVisualStyleBackColor = true;
            // 
            // opcao4Cores
            // 
            this.opcao4Cores.Location = new System.Drawing.Point(414, 152);
            this.opcao4Cores.Name = "opcao4Cores";
            this.opcao4Cores.Size = new System.Drawing.Size(90, 29);
            this.opcao4Cores.TabIndex = 6;
            this.opcao4Cores.Text = "4 Cores";
            this.opcao4Cores.UseVisualStyleBackColor = true;
            // 
            // opcaoImportar
            // 
            this.opcaoImportar.Location = new System.Drawing.Point(414, 355);
            this.opcaoImportar.Name = "opcaoImportar";
            this.opcaoImportar.Size = new System.Drawing.Size(90, 29);
            this.opcaoImportar.TabIndex = 8;
            this.opcaoImportar.Text = "Importar";
            this.opcaoImportar.UseVisualStyleBackColor = true;
            this.opcaoImportar.Click += new System.EventHandler(this.OpcaoImportar_Click);
            // 
            // opcaoSalvar
            // 
            this.opcaoSalvar.Location = new System.Drawing.Point(814, 432);
            this.opcaoSalvar.Name = "opcaoSalvar";
            this.opcaoSalvar.Size = new System.Drawing.Size(90, 29);
            this.opcaoSalvar.TabIndex = 7;
            this.opcaoSalvar.Text = "Salvar";
            this.opcaoSalvar.UseVisualStyleBackColor = true;
            this.opcaoSalvar.Click += new System.EventHandler(this.OpcaoSalvar_Click);
            // 
            // lbOriginal
            // 
            this.lbOriginal.AutoSize = true;
            this.lbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginal.Location = new System.Drawing.Point(123, 433);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(107, 31);
            this.lbOriginal.TabIndex = 9;
            this.lbOriginal.Text = "Original";
            // 
            // lbEditada
            // 
            this.lbEditada.AutoSize = true;
            this.lbEditada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditada.Location = new System.Drawing.Point(684, 433);
            this.lbEditada.Name = "lbEditada";
            this.lbEditada.Size = new System.Drawing.Size(106, 31);
            this.lbEditada.TabIndex = 10;
            this.lbEditada.Text = "Editada";
            // 
            // opcaoLimpar
            // 
            this.opcaoLimpar.Location = new System.Drawing.Point(414, 390);
            this.opcaoLimpar.Name = "opcaoLimpar";
            this.opcaoLimpar.Size = new System.Drawing.Size(90, 29);
            this.opcaoLimpar.TabIndex = 11;
            this.opcaoLimpar.Text = "Limpar";
            this.opcaoLimpar.UseVisualStyleBackColor = true;
            this.opcaoLimpar.Click += new System.EventHandler(this.OpcaoLimpar_Click);
            // 
            // MyPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 473);
            this.Controls.Add(this.opcaoLimpar);
            this.Controls.Add(this.lbEditada);
            this.Controls.Add(this.lbOriginal);
            this.Controls.Add(this.opcaoImportar);
            this.Controls.Add(this.opcaoSalvar);
            this.Controls.Add(this.opcao4Cores);
            this.Controls.Add(this.opcaoPixelizado);
            this.Controls.Add(this.opcaoNegativo);
            this.Controls.Add(this.opcaoSepia);
            this.Controls.Add(this.opcaoPretoBranco);
            this.Controls.Add(this.imagemEditada);
            this.Controls.Add(this.imagemOriginal);
            this.Name = "MyPhoto";
            this.Text = "MyPhoto";
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemEditada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemOriginal;
        private System.Windows.Forms.PictureBox imagemEditada;
        private System.Windows.Forms.Button opcaoPretoBranco;
        private System.Windows.Forms.Button opcaoSepia;
        private System.Windows.Forms.Button opcaoPixelizado;
        private System.Windows.Forms.Button opcaoNegativo;
        private System.Windows.Forms.Button opcao4Cores;
        private System.Windows.Forms.Button opcaoImportar;
        private System.Windows.Forms.Button opcaoSalvar;
        private System.Windows.Forms.Label lbOriginal;
        private System.Windows.Forms.Label lbEditada;
        private System.Windows.Forms.Button opcaoLimpar;
    }
}

