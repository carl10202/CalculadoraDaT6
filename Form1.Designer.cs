namespace CalculadoraCarlos1
{
    partial class Form1
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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMais = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonBarra = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSeis = new System.Windows.Forms.Button();
            this.buttonCinco = new System.Windows.Forms.Button();
            this.buttonSete = new System.Windows.Forms.Button();
            this.buttonOito = new System.Windows.Forms.Button();
            this.buttonNove = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonDois = new System.Windows.Forms.Button();
            this.buttonUm = new System.Windows.Forms.Button();
            this.buttonQuatro = new System.Windows.Forms.Button();
            this.buttonTres = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(28, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(253, 85);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "CalculadoraCarlos";
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonMais, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonVirgula, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonMenos, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBarra, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCopiar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonApagar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLimpar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSeis, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCinco, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSete, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOito, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNove, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDividir, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonIgual, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDois, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonUm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonQuatro, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonTres, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 252);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonMais
            // 
            this.buttonMais.Location = new System.Drawing.Point(195, 103);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(60, 35);
            this.buttonMais.TabIndex = 17;
            this.buttonMais.Text = "+";
            this.buttonMais.UseVisualStyleBackColor = true;
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.Location = new System.Drawing.Point(131, 203);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(58, 40);
            this.buttonVirgula.TabIndex = 23;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = true;
            // 
            // buttonMenos
            // 
            this.buttonMenos.Location = new System.Drawing.Point(195, 53);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(60, 35);
            this.buttonMenos.TabIndex = 13;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            // 
            // buttonBarra
            // 
            this.buttonBarra.Location = new System.Drawing.Point(195, 3);
            this.buttonBarra.Name = "buttonBarra";
            this.buttonBarra.Size = new System.Drawing.Size(60, 35);
            this.buttonBarra.TabIndex = 5;
            this.buttonBarra.Text = "/";
            this.buttonBarra.UseVisualStyleBackColor = true;
            this.buttonBarra.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Location = new System.Drawing.Point(131, 3);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(58, 35);
            this.buttonCopiar.TabIndex = 4;
            this.buttonCopiar.Text = "copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(67, 3);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(58, 35);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(3, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(58, 35);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSeis
            // 
            this.buttonSeis.Location = new System.Drawing.Point(131, 103);
            this.buttonSeis.Name = "buttonSeis";
            this.buttonSeis.Size = new System.Drawing.Size(58, 35);
            this.buttonSeis.TabIndex = 12;
            this.buttonSeis.Text = "6";
            this.buttonSeis.UseVisualStyleBackColor = true;
            // 
            // buttonCinco
            // 
            this.buttonCinco.Location = new System.Drawing.Point(67, 103);
            this.buttonCinco.Name = "buttonCinco";
            this.buttonCinco.Size = new System.Drawing.Size(58, 35);
            this.buttonCinco.TabIndex = 11;
            this.buttonCinco.Text = "5";
            this.buttonCinco.UseVisualStyleBackColor = true;
            // 
            // buttonSete
            // 
            this.buttonSete.Location = new System.Drawing.Point(3, 53);
            this.buttonSete.Name = "buttonSete";
            this.buttonSete.Size = new System.Drawing.Size(58, 35);
            this.buttonSete.TabIndex = 6;
            this.buttonSete.Text = "7";
            this.buttonSete.UseVisualStyleBackColor = true;
            this.buttonSete.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonOito
            // 
            this.buttonOito.Location = new System.Drawing.Point(67, 53);
            this.buttonOito.Name = "buttonOito";
            this.buttonOito.Size = new System.Drawing.Size(58, 35);
            this.buttonOito.TabIndex = 7;
            this.buttonOito.Text = "8";
            this.buttonOito.UseVisualStyleBackColor = true;
            // 
            // buttonNove
            // 
            this.buttonNove.Location = new System.Drawing.Point(131, 53);
            this.buttonNove.Name = "buttonNove";
            this.buttonNove.Size = new System.Drawing.Size(58, 35);
            this.buttonNove.TabIndex = 8;
            this.buttonNove.Text = "9";
            this.buttonNove.UseVisualStyleBackColor = true;
            // 
            // buttonDividir
            // 
            this.buttonDividir.Location = new System.Drawing.Point(195, 153);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(60, 35);
            this.buttonDividir.TabIndex = 20;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.button20_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(67, 203);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(58, 35);
            this.buttonZero.TabIndex = 10;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Location = new System.Drawing.Point(195, 203);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(58, 40);
            this.buttonIgual.TabIndex = 25;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            // 
            // buttonDois
            // 
            this.buttonDois.Location = new System.Drawing.Point(67, 153);
            this.buttonDois.Name = "buttonDois";
            this.buttonDois.Size = new System.Drawing.Size(58, 35);
            this.buttonDois.TabIndex = 14;
            this.buttonDois.Text = "2";
            this.buttonDois.UseVisualStyleBackColor = true;
            // 
            // buttonUm
            // 
            this.buttonUm.Location = new System.Drawing.Point(3, 153);
            this.buttonUm.Name = "buttonUm";
            this.buttonUm.Size = new System.Drawing.Size(58, 40);
            this.buttonUm.TabIndex = 26;
            this.buttonUm.Text = "1";
            this.buttonUm.UseVisualStyleBackColor = true;
            // 
            // buttonQuatro
            // 
            this.buttonQuatro.Location = new System.Drawing.Point(3, 103);
            this.buttonQuatro.Name = "buttonQuatro";
            this.buttonQuatro.Size = new System.Drawing.Size(58, 35);
            this.buttonQuatro.TabIndex = 16;
            this.buttonQuatro.Text = "4";
            this.buttonQuatro.UseVisualStyleBackColor = true;
            // 
            // buttonTres
            // 
            this.buttonTres.Location = new System.Drawing.Point(131, 153);
            this.buttonTres.Name = "buttonTres";
            this.buttonTres.Size = new System.Drawing.Size(58, 35);
            this.buttonTres.TabIndex = 15;
            this.buttonTres.Text = "3";
            this.buttonTres.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(309, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonCinco;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonOito;
        private System.Windows.Forms.Button buttonSete;
        private System.Windows.Forms.Button buttonBarra;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonDois;
        private System.Windows.Forms.Button buttonTres;
        private System.Windows.Forms.Button buttonUm;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonSeis;
        private System.Windows.Forms.Button buttonNove;
        private System.Windows.Forms.Button buttonQuatro;
    }
}

