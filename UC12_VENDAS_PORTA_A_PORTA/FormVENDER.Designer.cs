namespace UC12_VENDAS_PORTA_A_PORTA
{
    partial class FormVENDER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVENDER));
            this.dataGridViewUSUARIOS = new System.Windows.Forms.DataGridView();
            this.buttonCOMPRAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNUMERO = new System.Windows.Forms.Label();
            this.dataGridViewPRODUTOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUSUARIOS
            // 
            this.dataGridViewUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUSUARIOS.Location = new System.Drawing.Point(13, 53);
            this.dataGridViewUSUARIOS.Name = "dataGridViewUSUARIOS";
            this.dataGridViewUSUARIOS.Size = new System.Drawing.Size(143, 315);
            this.dataGridViewUSUARIOS.TabIndex = 0;
            // 
            // buttonCOMPRAR
            // 
            this.buttonCOMPRAR.AutoSize = true;
            this.buttonCOMPRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCOMPRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCOMPRAR.Location = new System.Drawing.Point(45, 395);
            this.buttonCOMPRAR.Name = "buttonCOMPRAR";
            this.buttonCOMPRAR.Size = new System.Drawing.Size(326, 54);
            this.buttonCOMPRAR.TabIndex = 19;
            this.buttonCOMPRAR.Text = "Comprar";
            this.buttonCOMPRAR.UseVisualStyleBackColor = true;
            this.buttonCOMPRAR.Click += new System.EventHandler(this.buttonCOMPRAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNUMERO
            // 
            this.labelNUMERO.AutoSize = true;
            this.labelNUMERO.BackColor = System.Drawing.Color.Transparent;
            this.labelNUMERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNUMERO.ForeColor = System.Drawing.Color.Transparent;
            this.labelNUMERO.Location = new System.Drawing.Point(248, 322);
            this.labelNUMERO.Name = "labelNUMERO";
            this.labelNUMERO.Size = new System.Drawing.Size(66, 46);
            this.labelNUMERO.TabIndex = 22;
            this.labelNUMERO.Text = "13";
            this.labelNUMERO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPRODUTOS
            // 
            this.dataGridViewPRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUTOS.Location = new System.Drawing.Point(199, 53);
            this.dataGridViewPRODUTOS.Name = "dataGridViewPRODUTOS";
            this.dataGridViewPRODUTOS.Size = new System.Drawing.Size(172, 256);
            this.dataGridViewPRODUTOS.TabIndex = 23;
            // 
            // FormVENDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_VENDAS_PORTA_A_PORTA.Properties.Resources.sunlight_digital_art_abstract_sky_blue_texture_77772_wallhere_com;
            this.ClientSize = new System.Drawing.Size(414, 461);
            this.Controls.Add(this.dataGridViewPRODUTOS);
            this.Controls.Add(this.labelNUMERO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCOMPRAR);
            this.Controls.Add(this.dataGridViewUSUARIOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVENDER";
            this.Text = "FormVENDER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUSUARIOS;
        private System.Windows.Forms.Button buttonCOMPRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNUMERO;
        private System.Windows.Forms.DataGridView dataGridViewPRODUTOS;
    }
}