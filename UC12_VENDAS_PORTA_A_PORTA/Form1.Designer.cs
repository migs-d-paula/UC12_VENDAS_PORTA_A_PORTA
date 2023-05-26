namespace UC12_VENDAS_PORTA_A_PORTA
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.labelSENHA = new System.Windows.Forms.Label();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(502, 20);
            this.textBox2.TabIndex = 1;
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.AutoSize = true;
            this.labelUSUARIO.BackColor = System.Drawing.Color.Transparent;
            this.labelUSUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUSUARIO.Location = new System.Drawing.Point(156, 107);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(43, 13);
            this.labelUSUARIO.TabIndex = 2;
            this.labelUSUARIO.Text = "Usuário";
            // 
            // labelSENHA
            // 
            this.labelSENHA.AutoSize = true;
            this.labelSENHA.BackColor = System.Drawing.Color.Transparent;
            this.labelSENHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSENHA.Location = new System.Drawing.Point(156, 201);
            this.labelSENHA.Name = "labelSENHA";
            this.labelSENHA.Size = new System.Drawing.Size(38, 13);
            this.labelSENHA.TabIndex = 3;
            this.labelSENHA.Text = "Senha";
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.AutoSize = true;
            this.buttonENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENTRAR.Location = new System.Drawing.Point(252, 316);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(304, 54);
            this.buttonENTRAR.TabIndex = 4;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_VENDAS_PORTA_A_PORTA.Properties.Resources.v960_ning_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.labelSENHA);
            this.Controls.Add(this.labelUSUARIO);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.Label labelSENHA;
        private System.Windows.Forms.Button buttonENTRAR;
    }
}

