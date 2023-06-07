namespace Final
{
    partial class despedir_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(despedir_empleado));
            this.picb_volver = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.txt_nombre_aplicacion = new System.Windows.Forms.TextBox();
            this.btn_eliminar_empleado = new System.Windows.Forms.Button();
            this.bttn_atrás = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_volver
            // 
            this.picb_volver.Image = ((System.Drawing.Image)(resources.GetObject("picb_volver.Image")));
            this.picb_volver.Location = new System.Drawing.Point(-31, -22);
            this.picb_volver.Name = "picb_volver";
            this.picb_volver.Size = new System.Drawing.Size(951, 105);
            this.picb_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_volver.TabIndex = 4;
            this.picb_volver.TabStop = false;
            this.picb_volver.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(100, 187);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(199, 24);
            this.lbl_nombre_usuario.TabIndex = 5;
            this.lbl_nombre_usuario.Text = "Nombre de Usuario:";
            // 
            // lbl_confirmar
            // 
            this.lbl_confirmar.AutoSize = true;
            this.lbl_confirmar.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmar.Location = new System.Drawing.Point(162, 293);
            this.lbl_confirmar.Name = "lbl_confirmar";
            this.lbl_confirmar.Size = new System.Drawing.Size(503, 24);
            this.lbl_confirmar.TabIndex = 6;
            this.lbl_confirmar.Text = "Ingrese el nombre de esta plataforma para confirmar:";
            // 
            // txt_nombre_aplicacion
            // 
            this.txt_nombre_aplicacion.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.txt_nombre_aplicacion.Location = new System.Drawing.Point(314, 371);
            this.txt_nombre_aplicacion.Name = "txt_nombre_aplicacion";
            this.txt_nombre_aplicacion.Size = new System.Drawing.Size(222, 34);
            this.txt_nombre_aplicacion.TabIndex = 8;
            this.txt_nombre_aplicacion.MouseLeave += new System.EventHandler(this.ocultarContra);
            this.txt_nombre_aplicacion.MouseHover += new System.EventHandler(this.mostrarContra);
            // 
            // btn_eliminar_empleado
            // 
            this.btn_eliminar_empleado.BackColor = System.Drawing.Color.Thistle;
            this.btn_eliminar_empleado.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_empleado.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_empleado.Location = new System.Drawing.Point(345, 427);
            this.btn_eliminar_empleado.Name = "btn_eliminar_empleado";
            this.btn_eliminar_empleado.Size = new System.Drawing.Size(160, 55);
            this.btn_eliminar_empleado.TabIndex = 22;
            this.btn_eliminar_empleado.Text = "Eliminar";
            this.btn_eliminar_empleado.UseVisualStyleBackColor = false;
            this.btn_eliminar_empleado.Click += new System.EventHandler(this.btn_eliminar_empleado_Click);
            // 
            // bttn_atrás
            // 
            this.bttn_atrás.Location = new System.Drawing.Point(12, 12);
            this.bttn_atrás.Name = "bttn_atrás";
            this.bttn_atrás.Size = new System.Drawing.Size(109, 32);
            this.bttn_atrás.TabIndex = 23;
            this.bttn_atrás.Text = "Atrás";
            this.bttn_atrás.UseVisualStyleBackColor = true;
            this.bttn_atrás.Click += new System.EventHandler(this.bttn_atrás_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(441, 32);
            this.comboBox1.TabIndex = 24;
            // 
            // despedir_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttn_atrás);
            this.Controls.Add(this.btn_eliminar_empleado);
            this.Controls.Add(this.txt_nombre_aplicacion);
            this.Controls.Add(this.lbl_confirmar);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.picb_volver);
            this.Name = "despedir_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "despedir_empleado";
            this.Load += new System.EventHandler(this.despedir_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_volver;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Label lbl_confirmar;
        private System.Windows.Forms.TextBox txt_nombre_aplicacion;
        private System.Windows.Forms.Button btn_eliminar_empleado;
        private System.Windows.Forms.Button bttn_atrás;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}