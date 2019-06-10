namespace FrbaCrucero
{
    partial class Menu
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
            this.bienvenido = new System.Windows.Forms.Label();
            this.funcionalidadesDisponibles = new System.Windows.Forms.GroupBox();
            this.salir = new System.Windows.Forms.Button();
            this.ejecutar = new System.Windows.Forms.Button();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.rolActual = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.funcionalidadesDisponibles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bienvenido
            // 
            this.bienvenido.AutoSize = true;
            this.bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenido.Location = new System.Drawing.Point(12, 9);
            this.bienvenido.Name = "bienvenido";
            this.bienvenido.Size = new System.Drawing.Size(148, 31);
            this.bienvenido.TabIndex = 0;
            this.bienvenido.Text = "Bienvenido";
            // 
            // funcionalidadesDisponibles
            // 
            this.funcionalidadesDisponibles.Controls.Add(this.salir);
            this.funcionalidadesDisponibles.Controls.Add(this.ejecutar);
            this.funcionalidadesDisponibles.Controls.Add(this.comboBoxFuncionalidades);
            this.funcionalidadesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionalidadesDisponibles.Location = new System.Drawing.Point(12, 199);
            this.funcionalidadesDisponibles.Name = "funcionalidadesDisponibles";
            this.funcionalidadesDisponibles.Size = new System.Drawing.Size(260, 155);
            this.funcionalidadesDisponibles.TabIndex = 1;
            this.funcionalidadesDisponibles.TabStop = false;
            this.funcionalidadesDisponibles.Text = "Funcionalidades disponibles";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(144, 98);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(110, 35);
            this.salir.TabIndex = 1;
            this.salir.Text = "Cerrar sesión";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(7, 98);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(110, 35);
            this.ejecutar.TabIndex = 1;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            this.ejecutar.Click += new System.EventHandler(this.ejecutar_Click);
            // 
            // comboBoxFuncionalidades
            // 
            this.comboBoxFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFuncionalidades.FormattingEnabled = true;
            this.comboBoxFuncionalidades.Location = new System.Drawing.Point(7, 41);
            this.comboBoxFuncionalidades.Name = "comboBoxFuncionalidades";
            this.comboBoxFuncionalidades.Size = new System.Drawing.Size(248, 24);
            this.comboBoxFuncionalidades.TabIndex = 0;
            // 
            // rolActual
            // 
            this.rolActual.AutoSize = true;
            this.rolActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolActual.Location = new System.Drawing.Point(16, 65);
            this.rolActual.Name = "rolActual";
            this.rolActual.Size = new System.Drawing.Size(91, 17);
            this.rolActual.TabIndex = 2;
            this.rolActual.Text = "Rol actual: ";
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolLabel.Location = new System.Drawing.Point(113, 65);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(14, 17);
            this.RolLabel.TabIndex = 2;
            this.RolLabel.Text = "-";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(166, 22);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(64, 17);
            this.usuarioLabel.TabIndex = 3;
            this.usuarioLabel.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRoles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Rol";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(7, 41);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(248, 24);
            this.comboBoxRoles.TabIndex = 0;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.rolActual);
            this.Controls.Add(this.funcionalidadesDisponibles);
            this.Controls.Add(this.bienvenido);
            this.Name = "Menu";
            this.Text = "Administrador | Menu";
            this.funcionalidadesDisponibles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenido;
        private System.Windows.Forms.GroupBox funcionalidadesDisponibles;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidades;
        private System.Windows.Forms.Label rolActual;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRoles;
    }
}