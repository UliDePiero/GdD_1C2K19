﻿namespace FrbaCrucero
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inicioDeSesion = new System.Windows.Forms.GroupBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.inicioDeSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // inicioDeSesion
            // 
            this.inicioDeSesion.Controls.Add(this.iniciar);
            this.inicioDeSesion.Controls.Add(this.textBoxUsuario);
            this.inicioDeSesion.Controls.Add(this.textBoxContraseña);
            this.inicioDeSesion.Controls.Add(this.contraseña);
            this.inicioDeSesion.Controls.Add(this.usuario);
            this.inicioDeSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioDeSesion.Location = new System.Drawing.Point(16, 15);
            this.inicioDeSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioDeSesion.Name = "inicioDeSesion";
            this.inicioDeSesion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioDeSesion.Size = new System.Drawing.Size(347, 369);
            this.inicioDeSesion.TabIndex = 0;
            this.inicioDeSesion.TabStop = false;
            this.inicioDeSesion.Text = "Inicio de sesión";
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(65, 281);
            this.iniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(196, 57);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(8, 112);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(329, 36);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(8, 208);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(329, 36);
            this.textBoxContraseña.TabIndex = 1;
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(85, 174);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(143, 29);
            this.contraseña.TabIndex = 0;
            this.contraseña.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(112, 78);
            this.usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 29);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 402);
            this.Controls.Add(this.inicioDeSesion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Administrador | Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.inicioDeSesion.ResumeLayout(false);
            this.inicioDeSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inicioDeSesion;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.ErrorProvider errorProvider1;




    }
}

