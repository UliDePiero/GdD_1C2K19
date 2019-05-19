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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ejecutar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.rolActual = new System.Windows.Forms.Label();
            this.ROL = new System.Windows.Forms.Label();
            this.funcionalidadesDisponibles.SuspendLayout();
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
            this.funcionalidadesDisponibles.Controls.Add(this.comboBox1);
            this.funcionalidadesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionalidadesDisponibles.Location = new System.Drawing.Point(12, 94);
            this.funcionalidadesDisponibles.Name = "funcionalidadesDisponibles";
            this.funcionalidadesDisponibles.Size = new System.Drawing.Size(260, 155);
            this.funcionalidadesDisponibles.TabIndex = 1;
            this.funcionalidadesDisponibles.TabStop = false;
            this.funcionalidadesDisponibles.Text = "Funcionalidades disponibles";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(7, 98);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(110, 35);
            this.ejecutar.TabIndex = 1;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(144, 98);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(110, 35);
            this.salir.TabIndex = 1;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
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
            // ROL
            // 
            this.ROL.AutoSize = true;
            this.ROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROL.Location = new System.Drawing.Point(153, 65);
            this.ROL.Name = "ROL";
            this.ROL.Size = new System.Drawing.Size(40, 17);
            this.ROL.TabIndex = 2;
            this.ROL.Text = "ROL";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ROL);
            this.Controls.Add(this.rolActual);
            this.Controls.Add(this.funcionalidadesDisponibles);
            this.Controls.Add(this.bienvenido);
            this.Name = "Menu";
            this.Text = "Menu";
            this.funcionalidadesDisponibles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenido;
        private System.Windows.Forms.GroupBox funcionalidadesDisponibles;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label rolActual;
        private System.Windows.Forms.Label ROL;
    }
}