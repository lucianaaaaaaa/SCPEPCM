namespace Final
{
    partial class ver_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver_inventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.bttn_atrás = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventario.Location = new System.Drawing.Point(23, 104);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.RowHeadersWidth = 51;
            this.dgv_inventario.RowTemplate.Height = 24;
            this.dgv_inventario.Size = new System.Drawing.Size(823, 400);
            this.dgv_inventario.TabIndex = 5;
            // 
            // bttn_atrás
            // 
            this.bttn_atrás.Location = new System.Drawing.Point(23, 12);
            this.bttn_atrás.Name = "bttn_atrás";
            this.bttn_atrás.Size = new System.Drawing.Size(109, 32);
            this.bttn_atrás.TabIndex = 22;
            this.bttn_atrás.Text = "Atrás";
            this.bttn_atrás.UseVisualStyleBackColor = true;
            this.bttn_atrás.Click += new System.EventHandler(this.bttn_atrás_Click);
            // 
            // ver_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.bttn_atrás);
            this.Controls.Add(this.dgv_inventario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ver_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ver_inventario";
            this.Load += new System.EventHandler(this.ver_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.Button bttn_atrás;
    }
}