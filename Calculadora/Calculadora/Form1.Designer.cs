
namespace Calculadora
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Num1 = new System.Windows.Forms.Label();
            this.Lbl_Num2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Soma = new System.Windows.Forms.Button();
            this.Btn_Subtracao = new System.Windows.Forms.Button();
            this.Btn_Multiplicacao = new System.Windows.Forms.Button();
            this.Btn_Divisao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Titulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(-10, 15);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(1346, 68);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "CALCULADORA";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources._65964693_uma_desenho_animado_calculadora_personagem_acenando_e_sorridente_vetor;
            this.pictureBox1.Location = new System.Drawing.Point(20, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Num1
            // 
            this.Lbl_Num1.AutoSize = true;
            this.Lbl_Num1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Num1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Num1.Location = new System.Drawing.Point(624, 160);
            this.Lbl_Num1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Num1.Name = "Lbl_Num1";
            this.Lbl_Num1.Size = new System.Drawing.Size(124, 26);
            this.Lbl_Num1.TabIndex = 3;
            this.Lbl_Num1.Text = "Primeiro N°:";
            // 
            // Lbl_Num2
            // 
            this.Lbl_Num2.AutoSize = true;
            this.Lbl_Num2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Num2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Num2.Location = new System.Drawing.Point(624, 279);
            this.Lbl_Num2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Num2.Name = "Lbl_Num2";
            this.Lbl_Num2.Size = new System.Drawing.Size(129, 26);
            this.Lbl_Num2.TabIndex = 4;
            this.Lbl_Num2.Text = "Segundo N°:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(842, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 33);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(842, 288);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 33);
            this.textBox2.TabIndex = 6;
            // 
            // Btn_Soma
            // 
            this.Btn_Soma.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Soma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Soma.Location = new System.Drawing.Point(811, 418);
            this.Btn_Soma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Soma.Name = "Btn_Soma";
            this.Btn_Soma.Size = new System.Drawing.Size(184, 79);
            this.Btn_Soma.TabIndex = 7;
            this.Btn_Soma.Text = "SOMA";
            this.Btn_Soma.UseVisualStyleBackColor = true;
            // 
            // Btn_Subtracao
            // 
            this.Btn_Subtracao.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subtracao.Location = new System.Drawing.Point(1007, 418);
            this.Btn_Subtracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Subtracao.Name = "Btn_Subtracao";
            this.Btn_Subtracao.Size = new System.Drawing.Size(204, 79);
            this.Btn_Subtracao.TabIndex = 8;
            this.Btn_Subtracao.Text = "SUBTRAÇÃO";
            this.Btn_Subtracao.UseVisualStyleBackColor = true;
            // 
            // Btn_Multiplicacao
            // 
            this.Btn_Multiplicacao.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplicacao.Location = new System.Drawing.Point(817, 507);
            this.Btn_Multiplicacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Multiplicacao.Name = "Btn_Multiplicacao";
            this.Btn_Multiplicacao.Size = new System.Drawing.Size(180, 71);
            this.Btn_Multiplicacao.TabIndex = 9;
            this.Btn_Multiplicacao.Text = "MULTIPLICAÇÃO";
            this.Btn_Multiplicacao.UseVisualStyleBackColor = true;
            // 
            // Btn_Divisao
            // 
            this.Btn_Divisao.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divisao.Location = new System.Drawing.Point(1007, 507);
            this.Btn_Divisao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Divisao.Name = "Btn_Divisao";
            this.Btn_Divisao.Size = new System.Drawing.Size(204, 71);
            this.Btn_Divisao.TabIndex = 10;
            this.Btn_Divisao.Text = "DIVISÃO";
            this.Btn_Divisao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.Btn_Divisao);
            this.Controls.Add(this.Btn_Multiplicacao);
            this.Controls.Add(this.Btn_Subtracao);
            this.Controls.Add(this.Btn_Soma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_Num2);
            this.Controls.Add(this.Lbl_Num1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Num1;
        private System.Windows.Forms.Label Lbl_Num2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_Soma;
        private System.Windows.Forms.Button Btn_Subtracao;
        private System.Windows.Forms.Button Btn_Multiplicacao;
        private System.Windows.Forms.Button Btn_Divisao;
    }
}

