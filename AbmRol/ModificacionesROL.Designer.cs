namespace FrbaCrucero.AbmRol
{
    partial class ModificacionesROL
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
            this.components = new System.ComponentModel.Container();
            this.nuevoROL = new System.Windows.Forms.Label();
            this.nombreNuevoROL = new System.Windows.Forms.Label();
            this.FuncionalidadesNuevoROL = new System.Windows.Forms.Label();
            this.textBoxNombreROL = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.modificarROL = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoROL
            // 
            this.nuevoROL.AutoSize = true;
            this.nuevoROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoROL.Location = new System.Drawing.Point(12, 9);
            this.nuevoROL.Name = "nuevoROL";
            this.nuevoROL.Size = new System.Drawing.Size(156, 31);
            this.nuevoROL.TabIndex = 0;
            this.nuevoROL.Text = "Nuevo ROL";
            // 
            // nombreNuevoROL
            // 
            this.nombreNuevoROL.AutoSize = true;
            this.nombreNuevoROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreNuevoROL.Location = new System.Drawing.Point(15, 75);
            this.nombreNuevoROL.Name = "nombreNuevoROL";
            this.nombreNuevoROL.Size = new System.Drawing.Size(58, 17);
            this.nombreNuevoROL.TabIndex = 0;
            this.nombreNuevoROL.Text = "Nombre";
            // 
            // FuncionalidadesNuevoROL
            // 
            this.FuncionalidadesNuevoROL.AutoSize = true;
            this.FuncionalidadesNuevoROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncionalidadesNuevoROL.Location = new System.Drawing.Point(15, 133);
            this.FuncionalidadesNuevoROL.Name = "FuncionalidadesNuevoROL";
            this.FuncionalidadesNuevoROL.Size = new System.Drawing.Size(111, 17);
            this.FuncionalidadesNuevoROL.TabIndex = 0;
            this.FuncionalidadesNuevoROL.Text = "Funcionalidades";
            // 
            // textBoxNombreROL
            // 
            this.textBoxNombreROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreROL.Location = new System.Drawing.Point(18, 103);
            this.textBoxNombreROL.Name = "textBoxNombreROL";
            this.textBoxNombreROL.Size = new System.Drawing.Size(382, 23);
            this.textBoxNombreROL.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "ABM de Rol",
            "ABM de Puerto",
            "ABM de Recorrido",
            "ABM de Crucero",
            "Login y seguridad",
            "Registro de Usuario",
            "Generar Viaje",
            "Compra y/o reserva de viaje",
            "Pago Reserva",
            "Listado Estadístico"});
            this.checkedListBox1.Location = new System.Drawing.Point(18, 159);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(382, 154);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(305, 9);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(95, 31);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(305, 49);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 31);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // modificarROL
            // 
            this.modificarROL.AutoSize = true;
            this.modificarROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarROL.Location = new System.Drawing.Point(12, 9);
            this.modificarROL.Name = "modificarROL";
            this.modificarROL.Size = new System.Drawing.Size(187, 31);
            this.modificarROL.TabIndex = 0;
            this.modificarROL.Text = "Modificar ROL";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificacionesROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 335);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBoxNombreROL);
            this.Controls.Add(this.FuncionalidadesNuevoROL);
            this.Controls.Add(this.nombreNuevoROL);
            this.Controls.Add(this.modificarROL);
            this.Controls.Add(this.nuevoROL);
            this.Name = "ModificacionesROL";
            this.Text = "ROL | Modificaciones";
            this.Load += new System.EventHandler(this.ModificacionesROL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nuevoROL;
        private System.Windows.Forms.Label nombreNuevoROL;
        private System.Windows.Forms.Label FuncionalidadesNuevoROL;
        private System.Windows.Forms.TextBox textBoxNombreROL;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label modificarROL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}