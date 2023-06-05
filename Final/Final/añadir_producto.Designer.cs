namespace Final
{
    partial class añadir_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(añadir_producto));
            this.lbl_lista_productos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.linklbl_agregar_producto = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lista_productos
            // 
            this.lbl_lista_productos.AutoSize = true;
            this.lbl_lista_productos.BackColor = System.Drawing.Color.Thistle;
            this.lbl_lista_productos.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista_productos.Location = new System.Drawing.Point(43, 35);
            this.lbl_lista_productos.Name = "lbl_lista_productos";
            this.lbl_lista_productos.Size = new System.Drawing.Size(189, 24);
            this.lbl_lista_productos.TabIndex = 2;
            this.lbl_lista_productos.Text = "Lista de Productos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Thistle;
            this.btn_actualizar.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(364, 421);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(160, 55);
            this.btn_actualizar.TabIndex = 21;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // linklbl_agregar_producto
            // 
            this.linklbl_agregar_producto.AutoSize = true;
            this.linklbl_agregar_producto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_agregar_producto.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklbl_agregar_producto.Location = new System.Drawing.Point(74, 344);
            this.linklbl_agregar_producto.Name = "linklbl_agregar_producto";
            this.linklbl_agregar_producto.Size = new System.Drawing.Size(168, 21);
            this.linklbl_agregar_producto.TabIndex = 22;
            this.linklbl_agregar_producto.TabStop = true;
            this.linklbl_agregar_producto.Text = "Agregar producto...";
            // 
            // añadir_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.linklbl_agregar_producto);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.lbl_lista_productos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "añadir_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "añadir_producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lista_productos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.LinkLabel linklbl_agregar_producto;
    }
}