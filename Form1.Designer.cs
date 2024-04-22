using System;

namespace calculadoramalu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxdisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2_apagar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSoma4 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_subtracao = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_multiplicacao = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_divisao = new System.Windows.Forms.Button();
            this.button_virgula = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button1_Limpar = new System.Windows.Forms.Button();
            this.button_igual = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxdisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxdisplay
            // 
            this.textBoxdisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxdisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxdisplay.Multiline = true;
            this.textBoxdisplay.Name = "textBoxdisplay";
            this.textBoxdisplay.Size = new System.Drawing.Size(375, 156);
            this.textBoxdisplay.TabIndex = 0;
            this.textBoxdisplay.Text = "                                                                                 " +
    "                                          ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button2_apagar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSoma4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_subtracao, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_multiplicacao, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_divisao, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_virgula, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button1_Limpar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_igual, 3, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 165);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 295);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2_apagar
            // 
            this.button2_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2_apagar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_apagar.Location = new System.Drawing.Point(96, 3);
            this.button2_apagar.Name = "button2_apagar";
            this.button2_apagar.Size = new System.Drawing.Size(87, 53);
            this.button2_apagar.TabIndex = 1;
            this.button2_apagar.Text = "apagar";
            this.button2_apagar.UseVisualStyleBackColor = true;
            this.button2_apagar.Click += new System.EventHandler(this.button2_apagar_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(189, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "copiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSoma4
            // 
            this.buttonSoma4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSoma4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma4.Location = new System.Drawing.Point(282, 3);
            this.buttonSoma4.Name = "buttonSoma4";
            this.buttonSoma4.Size = new System.Drawing.Size(90, 53);
            this.buttonSoma4.TabIndex = 3;
            this.buttonSoma4.Text = "+";
            this.buttonSoma4.UseVisualStyleBackColor = true;
            this.buttonSoma4.Click += new System.EventHandler(this.buttonSoma4_Click);
            // 
            // button_7
            // 
            this.button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(3, 62);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(87, 53);
            this.button_7.TabIndex = 4;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_8
            // 
            this.button_8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(96, 62);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(87, 53);
            this.button_8.TabIndex = 5;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_9
            // 
            this.button_9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(189, 62);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(87, 53);
            this.button_9.TabIndex = 6;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_subtracao
            // 
            this.button_subtracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_subtracao.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtracao.Location = new System.Drawing.Point(282, 62);
            this.button_subtracao.Name = "button_subtracao";
            this.button_subtracao.Size = new System.Drawing.Size(90, 53);
            this.button_subtracao.TabIndex = 7;
            this.button_subtracao.Text = "-";
            this.button_subtracao.UseVisualStyleBackColor = true;
            this.button_subtracao.Click += new System.EventHandler(this.button_subtracao_Click);
            // 
            // button_4
            // 
            this.button_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(3, 121);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(87, 53);
            this.button_4.TabIndex = 8;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_5
            // 
            this.button_5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(96, 121);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(87, 53);
            this.button_5.TabIndex = 9;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_6
            // 
            this.button_6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(189, 121);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(87, 53);
            this.button_6.TabIndex = 10;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_multiplicacao
            // 
            this.button_multiplicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_multiplicacao.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiplicacao.Location = new System.Drawing.Point(282, 121);
            this.button_multiplicacao.Name = "button_multiplicacao";
            this.button_multiplicacao.Size = new System.Drawing.Size(90, 53);
            this.button_multiplicacao.TabIndex = 11;
            this.button_multiplicacao.Text = "x";
            this.button_multiplicacao.UseVisualStyleBackColor = true;
            this.button_multiplicacao.Click += new System.EventHandler(this.button_multiplicacao_Click);
            // 
            // button_1
            // 
            this.button_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(3, 180);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(87, 53);
            this.button_1.TabIndex = 12;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_2
            // 
            this.button_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(96, 180);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(87, 53);
            this.button_2.TabIndex = 13;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_3
            // 
            this.button_3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(189, 180);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(87, 53);
            this.button_3.TabIndex = 14;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button_divisao
            // 
            this.button_divisao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_divisao.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divisao.Location = new System.Drawing.Point(282, 180);
            this.button_divisao.Name = "button_divisao";
            this.button_divisao.Size = new System.Drawing.Size(90, 53);
            this.button_divisao.TabIndex = 15;
            this.button_divisao.Text = "/";
            this.button_divisao.UseVisualStyleBackColor = true;
            this.button_divisao.Click += new System.EventHandler(this.button_divisao_Click);
            // 
            // button_virgula
            // 
            this.button_virgula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_virgula.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_virgula.Location = new System.Drawing.Point(189, 239);
            this.button_virgula.Name = "button_virgula";
            this.button_virgula.Size = new System.Drawing.Size(87, 53);
            this.button_virgula.TabIndex = 17;
            this.button_virgula.Text = ",";
            this.button_virgula.UseVisualStyleBackColor = true;
            this.button_virgula.Click += new System.EventHandler(this.button_virgula_Click);
            // 
            // button_0
            // 
            this.button_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_0.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(96, 239);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(87, 53);
            this.button_0.TabIndex = 16;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1_Limpar
            // 
            this.button1_Limpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1_Limpar.Location = new System.Drawing.Point(3, 3);
            this.button1_Limpar.Name = "button1_Limpar";
            this.button1_Limpar.Size = new System.Drawing.Size(87, 53);
            this.button1_Limpar.TabIndex = 19;
            this.button1_Limpar.Text = "limpar";
            this.button1_Limpar.UseVisualStyleBackColor = true;
            // 
            // button_igual
            // 
            this.button_igual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_igual.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_igual.Location = new System.Drawing.Point(282, 239);
            this.button_igual.Name = "button_igual";
            this.button_igual.Size = new System.Drawing.Size(90, 53);
            this.button_igual.TabIndex = 18;
            this.button_igual.Text = "=";
            this.button_igual.UseVisualStyleBackColor = true;
            this.button_igual.Click += new System.EventHandler(this.button_igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxdisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2_apagar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSoma4;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_subtracao;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_multiplicacao;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_divisao;
        private System.Windows.Forms.Button button_igual;
        private System.Windows.Forms.Button button_virgula;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button1_Limpar;
    }
}

