namespace Final
{
    partial class Datos_modificar_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_modificar_producto));
            this.bttn_atrás = new System.Windows.Forms.Button();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.txt_cantidad_producto = new System.Windows.Forms.TextBox();
            this.txt_costo_producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_atrás
            // 
            this.bttn_atrás.Location = new System.Drawing.Point(17, 33);
            this.bttn_atrás.Name = "bttn_atrás";
            this.bttn_atrás.Size = new System.Drawing.Size(109, 32);
            this.bttn_atrás.TabIndex = 31;
            this.bttn_atrás.Text = "Atrás";
            this.bttn_atrás.UseVisualStyleBackColor = true;
            this.bttn_atrás.Click += new System.EventHandler(this.bttn_atrás_Click);
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.Thistle;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_producto.Location = new System.Drawing.Point(358, 440);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(160, 55);
            this.btn_agregar_producto.TabIndex = 30;
            this.btn_agregar_producto.Text = "Actualizar";
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // txt_cantidad_producto
            // 
            this.txt_cantidad_producto.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_cantidad_producto.Location = new System.Drawing.Point(383, 284);
            this.txt_cantidad_producto.Name = "txt_cantidad_producto";
            this.txt_cantidad_producto.Size = new System.Drawing.Size(190, 34);
            this.txt_cantidad_producto.TabIndex = 29;
            // 
            // txt_costo_producto
            // 
            this.txt_costo_producto.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_costo_producto.Location = new System.Drawing.Point(383, 212);
            this.txt_costo_producto.Name = "txt_costo_producto";
            this.txt_costo_producto.Size = new System.Drawing.Size(190, 34);
            this.txt_costo_producto.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Costo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-36, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(253, 149);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(92, 24);
            this.lbl_nombre_producto.TabIndex = 23;
            this.lbl_nombre_producto.Text = "Nombre:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(383, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 32);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.CuandoSeleccione);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descuento:";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_descuento.Location = new System.Drawing.Point(383, 354);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(190, 34);
            this.txt_descuento.TabIndex = 34;
            this.txt_descuento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(604, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "%";
            // 
            // Datos_modificar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttn_atrás);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.txt_cantidad_producto);
            this.Controls.Add(this.txt_costo_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Name = "Datos_modificar_producto";
            this.Text = "Datos_modificar_producto";
            this.Load += new System.EventHandler(this.Datos_modificar_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_atrás;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.TextBox txt_cantidad_producto;
        private System.Windows.Forms.TextBox txt_costo_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label4;
    }
}