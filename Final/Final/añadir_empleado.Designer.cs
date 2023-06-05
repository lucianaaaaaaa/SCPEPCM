namespace Final
{
    partial class añadir_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(añadir_empleado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_completo = new System.Windows.Forms.Label();
            this.lbl_CI = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_fecha_ingreso = new System.Windows.Forms.Label();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_confirmar_contraseña = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.txt_CI = new System.Windows.Forms.TextBox();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_confirmar_contraseña = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_nombre_completo
            // 
            this.lbl_nombre_completo.AutoSize = true;
            this.lbl_nombre_completo.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_completo.Location = new System.Drawing.Point(126, 117);
            this.lbl_nombre_completo.Name = "lbl_nombre_completo";
            this.lbl_nombre_completo.Size = new System.Drawing.Size(189, 24);
            this.lbl_nombre_completo.TabIndex = 1;
            this.lbl_nombre_completo.Text = "Nombre Completo:";
            // 
            // lbl_CI
            // 
            this.lbl_CI.AutoSize = true;
            this.lbl_CI.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CI.Location = new System.Drawing.Point(499, 200);
            this.lbl_CI.Name = "lbl_CI";
            this.lbl_CI.Size = new System.Drawing.Size(38, 24);
            this.lbl_CI.TabIndex = 2;
            this.lbl_CI.Text = "CI:";
            this.lbl_CI.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(104, 160);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(211, 24);
            this.lbl_fecha_nacimiento.TabIndex = 3;
            this.lbl_fecha_nacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lbl_fecha_ingreso
            // 
            this.lbl_fecha_ingreso.AutoSize = true;
            this.lbl_fecha_ingreso.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_ingreso.Location = new System.Drawing.Point(140, 253);
            this.lbl_fecha_ingreso.Name = "lbl_fecha_ingreso";
            this.lbl_fecha_ingreso.Size = new System.Drawing.Size(175, 24);
            this.lbl_fecha_ingreso.TabIndex = 4;
            this.lbl_fecha_ingreso.Text = "Fecha de Ingreso:";
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nacionalidad.Location = new System.Drawing.Point(177, 200);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(138, 24);
            this.lbl_nacionalidad.TabIndex = 5;
            this.lbl_nacionalidad.Text = "Nacionalidad:";
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(116, 336);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(199, 24);
            this.lbl_nombre_usuario.TabIndex = 6;
            this.lbl_nombre_usuario.Text = "Nombre de Usuario:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(195, 379);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(120, 24);
            this.lbl_contraseña.TabIndex = 7;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // lbl_confirmar_contraseña
            // 
            this.lbl_confirmar_contraseña.AutoSize = true;
            this.lbl_confirmar_contraseña.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmar_contraseña.Location = new System.Drawing.Point(92, 427);
            this.lbl_confirmar_contraseña.Name = "lbl_confirmar_contraseña";
            this.lbl_confirmar_contraseña.Size = new System.Drawing.Size(223, 24);
            this.lbl_confirmar_contraseña.TabIndex = 8;
            this.lbl_confirmar_contraseña.Text = "Confirmar Contraseña:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(352, 117);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(136, 22);
            this.txt_nombres.TabIndex = 11;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(545, 117);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(136, 22);
            this.txt_apellidos.TabIndex = 12;
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(352, 163);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(136, 22);
            this.txt_fecha_nacimiento.TabIndex = 13;
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Location = new System.Drawing.Point(352, 203);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(136, 22);
            this.txt_nacionalidad.TabIndex = 14;
            // 
            // txt_CI
            // 
            this.txt_CI.Location = new System.Drawing.Point(545, 203);
            this.txt_CI.Name = "txt_CI";
            this.txt_CI.Size = new System.Drawing.Size(136, 22);
            this.txt_CI.TabIndex = 15;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(352, 253);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(136, 22);
            this.txt_fecha_ingreso.TabIndex = 16;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(352, 336);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(136, 22);
            this.txt_nombre_usuario.TabIndex = 17;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(352, 382);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(136, 22);
            this.txt_contraseña.TabIndex = 18;
            // 
            // txt_confirmar_contraseña
            // 
            this.txt_confirmar_contraseña.Location = new System.Drawing.Point(352, 430);
            this.txt_confirmar_contraseña.Name = "txt_confirmar_contraseña";
            this.txt_confirmar_contraseña.Size = new System.Drawing.Size(136, 22);
            this.txt_confirmar_contraseña.TabIndex = 19;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Thistle;
            this.btn_registrar.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(585, 364);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(160, 55);
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // añadir_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_confirmar_contraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.txt_fecha_ingreso);
            this.Controls.Add(this.txt_CI);
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.txt_fecha_nacimiento);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.lbl_confirmar_contraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.lbl_nacionalidad);
            this.Controls.Add(this.lbl_fecha_ingreso);
            this.Controls.Add(this.lbl_fecha_nacimiento);
            this.Controls.Add(this.lbl_CI);
            this.Controls.Add(this.lbl_nombre_completo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "añadir_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "añadir_empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre_completo;
        private System.Windows.Forms.Label lbl_CI;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_fecha_ingreso;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_confirmar_contraseña;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_fecha_nacimiento;
        private System.Windows.Forms.TextBox txt_nacionalidad;
        private System.Windows.Forms.TextBox txt_CI;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_confirmar_contraseña;
        private System.Windows.Forms.Button btn_registrar;
    }
}