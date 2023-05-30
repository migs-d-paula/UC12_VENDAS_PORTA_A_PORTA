namespace UC12_VENDAS_PORTA_A_PORTA
{
    partial class FormLOGIN
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
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.labelSENHA = new System.Windows.Forms.Label();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(59, 112);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(276, 20);
            this.textBoxUSUARIO.TabIndex = 0;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSENHA.Location = new System.Drawing.Point(59, 203);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(276, 20);
            this.textBoxSENHA.TabIndex = 1;
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.AutoSize = true;
            this.labelUSUARIO.BackColor = System.Drawing.Color.Transparent;
            this.labelUSUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUSUARIO.Location = new System.Drawing.Point(176, 93);
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
            this.labelSENHA.Location = new System.Drawing.Point(178, 187);
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
            this.buttonENTRAR.Location = new System.Drawing.Point(38, 309);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(326, 54);
            this.buttonENTRAR.TabIndex = 4;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_VENDAS_PORTA_A_PORTA.Properties.Resources.v960_ning_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.labelSENHA);
            this.Controls.Add(this.labelUSUARIO);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Name = "FormLOGIN";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.Label labelSENHA;
        private System.Windows.Forms.Button buttonENTRAR;
    }
}

