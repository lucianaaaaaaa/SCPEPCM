namespace Final
{
    partial class pantalla_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_empleado));
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.txt_nit_cliente = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar_canasta = new System.Windows.Forms.Button();
            this.btn_generar_comprobante = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(183, 134);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(92, 24);
            this.lbl_nombre_producto.TabIndex = 3;
            this.lbl_nombre_producto.Text = "Nombre:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIT:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datos Cliente";
            // 
            // cmb_productos
            // 
            this.cmb_productos.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(12, 356);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(376, 32);
            this.cmb_productos.TabIndex = 9;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_nombre_cliente.Location = new System.Drawing.Point(312, 131);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(452, 34);
            this.txt_nombre_cliente.TabIndex = 10;
            // 
            // txt_nit_cliente
            // 
            this.txt_nit_cliente.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_nit_cliente.Location = new System.Drawing.Point(312, 180);
            this.txt_nit_cliente.Name = "txt_nit_cliente";
            this.txt_nit_cliente.Size = new System.Drawing.Size(452, 34);
            this.txt_nit_cliente.TabIndex = 11;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_cantidad.Location = new System.Drawing.Point(429, 354);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(152, 34);
            this.txt_cantidad.TabIndex = 12;
            // 
            // btn_agregar_canasta
            // 
            this.btn_agregar_canasta.BackColor = System.Drawing.Color.Thistle;
            this.btn_agregar_canasta.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_canasta.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_canasta.Location = new System.Drawing.Point(603, 318);
            this.btn_agregar_canasta.Name = "btn_agregar_canasta";
            this.btn_agregar_canasta.Size = new System.Drawing.Size(217, 70);
            this.btn_agregar_canasta.TabIndex = 22;
            this.btn_agregar_canasta.Text = "Agregar a Canasta";
            this.btn_agregar_canasta.UseVisualStyleBackColor = false;
            this.btn_agregar_canasta.Click += new System.EventHandler(this.btn_agregar_canasta_Click);
            // 
            // btn_generar_comprobante
            // 
            this.btn_generar_comprobante.BackColor = System.Drawing.Color.Thistle;
            this.btn_generar_comprobante.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_comprobante.ForeColor = System.Drawing.Color.White;
            this.btn_generar_comprobante.Location = new System.Drawing.Point(342, 423);
            this.btn_generar_comprobante.Name = "btn_generar_comprobante";
            this.btn_generar_comprobante.Size = new System.Drawing.Size(194, 97);
            this.btn_generar_comprobante.TabIndex = 23;
            this.btn_generar_comprobante.Text = "Generar Comprobante";
            this.btn_generar_comprobante.UseVisualStyleBackColor = false;
            this.btn_generar_comprobante.Click += new System.EventHandler(this.btn_generar_comprobante_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad:";
            // 
            // pantalla_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_generar_comprobante);
            this.Controls.Add(this.btn_agregar_canasta);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_nit_cliente);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.cmb_productos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Name = "pantalla_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pantalla_empleado";
            this.Load += new System.EventHandler(this.pantalla_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_productos;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.TextBox txt_nit_cliente;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar_canasta;
        private System.Windows.Forms.Button btn_generar_comprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}