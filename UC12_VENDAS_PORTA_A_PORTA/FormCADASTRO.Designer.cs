namespace UC12_VENDAS_PORTA_A_PORTA
{
    partial class FormCADASTRO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCADASTRO));
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNOME = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.labelTELEFONE = new System.Windows.Forms.Label();
            this.textBoxTELEFONE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.AutoSize = true;
            this.buttonENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENTRAR.Location = new System.Drawing.Point(43, 319);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(326, 54);
            this.buttonENTRAR.TabIndex = 9;
            this.buttonENTRAR.Text = "Cadastrar";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.BackColor = System.Drawing.Color.Transparent;
            this.labelCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(70, 134);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 8;
            this.labelCPF.Text = "CPF";
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.BackColor = System.Drawing.Color.Transparent;
            this.labelNOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNOME.ForeColor = System.Drawing.Color.White;
            this.labelNOME.Location = new System.Drawing.Point(70, 65);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(35, 13);
            this.labelNOME.TabIndex = 7;
            this.labelNOME.Text = "Nome";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPF.Location = new System.Drawing.Point(70, 150);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(276, 20);
            this.textBoxCPF.TabIndex = 6;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(70, 84);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(276, 20);
            this.textBoxNOME.TabIndex = 5;
            // 
            // labelTELEFONE
            // 
            this.labelTELEFONE.AutoSize = true;
            this.labelTELEFONE.BackColor = System.Drawing.Color.Transparent;
            this.labelTELEFONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTELEFONE.ForeColor = System.Drawing.Color.White;
            this.labelTELEFONE.Location = new System.Drawing.Point(70, 200);
            this.labelTELEFONE.Name = "labelTELEFONE";
            this.labelTELEFONE.Size = new System.Drawing.Size(49, 13);
            this.labelTELEFONE.TabIndex = 13;
            this.labelTELEFONE.Text = "Telefone";
            // 
            // textBoxTELEFONE
            // 
            this.textBoxTELEFONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTELEFONE.Location = new System.Drawing.Point(70, 216);
            this.textBoxTELEFONE.Name = "textBoxTELEFONE";
            this.textBoxTELEFONE.Size = new System.Drawing.Size(276, 20);
            this.textBoxTELEFONE.TabIndex = 11;
            // 
            // FormCADASTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_VENDAS_PORTA_A_PORTA.Properties.Resources.sunlight_sunset_minimalism_reflection_sky_sunrise_627523_wallhere_com;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.labelTELEFONE);
            this.Controls.Add(this.textBoxTELEFONE);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxNOME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCADASTRO";
            this.Text = "FormCADASTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonENTRAR;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Label labelTELEFONE;
        private System.Windows.Forms.TextBox textBoxTELEFONE;
    }
}