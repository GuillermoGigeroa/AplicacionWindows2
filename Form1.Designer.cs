namespace AplicacionWindows2
{
    partial class VentanaAplicacion1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.Etiqueta3 = new System.Windows.Forms.Label();
            this.Etiqueta4 = new System.Windows.Forms.Label();
            this.Etiqueta5 = new System.Windows.Forms.Label();
            this.CajaApellido = new System.Windows.Forms.TextBox();
            this.CajaNombre = new System.Windows.Forms.TextBox();
            this.CajaEdad = new System.Windows.Forms.TextBox();
            this.CajaDireccion = new System.Windows.Forms.TextBox();
            this.CajaResultado = new System.Windows.Forms.TextBox();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(12, 18);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(71, 16);
            this.Etiqueta1.TabIndex = 0;
            this.Etiqueta1.Text = "APELLIDO";
            this.Etiqueta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Etiqueta2
            // 
            this.Etiqueta2.AutoSize = true;
            this.Etiqueta2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta2.Location = new System.Drawing.Point(12, 49);
            this.Etiqueta2.Name = "Etiqueta2";
            this.Etiqueta2.Size = new System.Drawing.Size(65, 16);
            this.Etiqueta2.TabIndex = 1;
            this.Etiqueta2.Text = "NOMBRE";
            this.Etiqueta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Etiqueta3
            // 
            this.Etiqueta3.AutoSize = true;
            this.Etiqueta3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta3.Location = new System.Drawing.Point(12, 83);
            this.Etiqueta3.Name = "Etiqueta3";
            this.Etiqueta3.Size = new System.Drawing.Size(44, 16);
            this.Etiqueta3.TabIndex = 2;
            this.Etiqueta3.Text = "EDAD";
            this.Etiqueta3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Etiqueta4
            // 
            this.Etiqueta4.AutoSize = true;
            this.Etiqueta4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta4.Location = new System.Drawing.Point(12, 118);
            this.Etiqueta4.Name = "Etiqueta4";
            this.Etiqueta4.Size = new System.Drawing.Size(78, 16);
            this.Etiqueta4.TabIndex = 3;
            this.Etiqueta4.Text = "DIRECCIÓN";
            this.Etiqueta4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Etiqueta5
            // 
            this.Etiqueta5.AutoSize = true;
            this.Etiqueta5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta5.Location = new System.Drawing.Point(12, 153);
            this.Etiqueta5.Name = "Etiqueta5";
            this.Etiqueta5.Size = new System.Drawing.Size(84, 16);
            this.Etiqueta5.TabIndex = 4;
            this.Etiqueta5.Text = "RESULTADO";
            this.Etiqueta5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CajaApellido
            // 
            this.CajaApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaApellido.Location = new System.Drawing.Point(89, 15);
            this.CajaApellido.MaxLength = 30;
            this.CajaApellido.Name = "CajaApellido";
            this.CajaApellido.Size = new System.Drawing.Size(288, 20);
            this.CajaApellido.TabIndex = 5;
            this.CajaApellido.TextChanged += new System.EventHandler(this.CajaApellido_TextChanged);
            // 
            // CajaNombre
            // 
            this.CajaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaNombre.Location = new System.Drawing.Point(89, 49);
            this.CajaNombre.MaxLength = 30;
            this.CajaNombre.Name = "CajaNombre";
            this.CajaNombre.Size = new System.Drawing.Size(288, 20);
            this.CajaNombre.TabIndex = 6;
            this.CajaNombre.TextChanged += new System.EventHandler(this.CajaNombre_TextChanged);
            // 
            // CajaEdad
            // 
            this.CajaEdad.Location = new System.Drawing.Point(89, 83);
            this.CajaEdad.MaxLength = 3;
            this.CajaEdad.Name = "CajaEdad";
            this.CajaEdad.Size = new System.Drawing.Size(50, 20);
            this.CajaEdad.TabIndex = 7;
            this.CajaEdad.TextChanged += new System.EventHandler(this.CajaEdad_TextChanged);
            this.CajaEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaEdad_KeyPress);
            // 
            // CajaDireccion
            // 
            this.CajaDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaDireccion.Location = new System.Drawing.Point(89, 117);
            this.CajaDireccion.MaxLength = 30;
            this.CajaDireccion.Name = "CajaDireccion";
            this.CajaDireccion.Size = new System.Drawing.Size(288, 20);
            this.CajaDireccion.TabIndex = 8;
            this.CajaDireccion.TextChanged += new System.EventHandler(this.CajaDireccion_TextChanged);
            // 
            // CajaResultado
            // 
            this.CajaResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaResultado.Location = new System.Drawing.Point(12, 173);
            this.CajaResultado.MaxLength = 1000;
            this.CajaResultado.Multiline = true;
            this.CajaResultado.Name = "CajaResultado";
            this.CajaResultado.ReadOnly = true;
            this.CajaResultado.Size = new System.Drawing.Size(365, 108);
            this.CajaResultado.TabIndex = 9;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(71, 292);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(98, 24);
            this.BotonAceptar.TabIndex = 10;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(231, 292);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(98, 24);
            this.BotonCancelar.TabIndex = 11;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // VentanaAplicacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(393, 328);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.CajaResultado);
            this.Controls.Add(this.CajaDireccion);
            this.Controls.Add(this.CajaEdad);
            this.Controls.Add(this.CajaNombre);
            this.Controls.Add(this.CajaApellido);
            this.Controls.Add(this.Etiqueta5);
            this.Controls.Add(this.Etiqueta4);
            this.Controls.Add(this.Etiqueta3);
            this.Controls.Add(this.Etiqueta2);
            this.Controls.Add(this.Etiqueta1);
            this.Name = "VentanaAplicacion1";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Label Etiqueta2;
        private System.Windows.Forms.Label Etiqueta3;
        private System.Windows.Forms.Label Etiqueta4;
        private System.Windows.Forms.Label Etiqueta5;
        private System.Windows.Forms.TextBox CajaApellido;
        private System.Windows.Forms.TextBox CajaNombre;
        private System.Windows.Forms.TextBox CajaEdad;
        private System.Windows.Forms.TextBox CajaDireccion;
        private System.Windows.Forms.TextBox CajaResultado;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
    }
}

