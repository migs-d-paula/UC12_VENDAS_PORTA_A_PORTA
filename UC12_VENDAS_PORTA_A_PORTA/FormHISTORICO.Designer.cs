namespace UC12_VENDAS_PORTA_A_PORTA
{
    partial class FormHISTORICO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHISTORICO));
            this.dataGridViewPESQUISA = new System.Windows.Forms.DataGridView();
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            this.buttonPESQUISAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPESQUISA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPESQUISA
            // 
            this.dataGridViewPESQUISA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPESQUISA.Location = new System.Drawing.Point(13, 72);
            this.dataGridViewPESQUISA.Name = "dataGridViewPESQUISA";
            this.dataGridViewPESQUISA.Size = new System.Drawing.Size(389, 366);
            this.dataGridViewPESQUISA.TabIndex = 0;
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Location = new System.Drawing.Point(13, 44);
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(308, 20);
            this.textBoxPESQUISA.TabIndex = 2;
            // 
            // buttonPESQUISAR
            // 
            this.buttonPESQUISAR.AutoSize = true;
            this.buttonPESQUISAR.Location = new System.Drawing.Point(327, 42);
            this.buttonPESQUISAR.Name = "buttonPESQUISAR";
            this.buttonPESQUISAR.Size = new System.Drawing.Size(75, 23);
            this.buttonPESQUISAR.TabIndex = 3;
            this.buttonPESQUISAR.Text = "Pesquisar";
            this.buttonPESQUISAR.UseVisualStyleBackColor = true;
            this.buttonPESQUISAR.Click += new System.EventHandler(this.buttonPESQUISAR_Click);
            // 
            // FormHISTORICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_VENDAS_PORTA_A_PORTA.Properties.Resources.sunlight_digital_art_sky_purple_simple_gradient_257116_wallhere_com;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.buttonPESQUISAR);
            this.Controls.Add(this.textBoxPESQUISA);
            this.Controls.Add(this.dataGridViewPESQUISA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHISTORICO";
            this.Text = "FormHISTORICO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPESQUISA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPESQUISA;
        private System.Windows.Forms.TextBox textBoxPESQUISA;
        private System.Windows.Forms.Button buttonPESQUISAR;
    }
}