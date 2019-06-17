namespace FrbaCrucero.AbmPuerto
{
    partial class ABM_Puerto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.puertos = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPuertos = new System.Windows.Forms.ComboBox();
            this.funciones = new System.Windows.Forms.GroupBox();
            this.eliminarPuerto = new System.Windows.Forms.Button();
            this.nuevoPuerto = new System.Windows.Forms.Button();
            this.modificarPuerto = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.nombrePuerto = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.funciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(190, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // puertos
            // 
            this.puertos.AutoSize = true;
            this.puertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puertos.Location = new System.Drawing.Point(13, 13);
            this.puertos.Name = "puertos";
            this.puertos.Size = new System.Drawing.Size(108, 31);
            this.puertos.TabIndex = 1;
            this.puertos.Text = "Puertos";
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(453, 440);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 7;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPuertos);
            this.groupBox2.Location = new System.Drawing.Point(221, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 89);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro de búsqueda";
            // 
            // comboBoxPuertos
            // 
            this.comboBoxPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuertos.FormattingEnabled = true;
            this.comboBoxPuertos.Items.AddRange(new object[] {
            "Todos los puertos",
            "Puertos con recorridos asignados",
            "Puertos con viajes asignados",
            "Puertos con pasajes vendidos",
            "Puertos sin recorridos asignados",
            "Puertos sin viajes asignados",
            "Puertos sin pasajes vendidos"});
            this.comboBoxPuertos.Location = new System.Drawing.Point(6, 37);
            this.comboBoxPuertos.Name = "comboBoxPuertos";
            this.comboBoxPuertos.Size = new System.Drawing.Size(318, 28);
            this.comboBoxPuertos.TabIndex = 6;
            this.comboBoxPuertos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuertos_SelectedIndexChanged);
            // 
            // funciones
            // 
            this.funciones.Controls.Add(this.eliminarPuerto);
            this.funciones.Controls.Add(this.nuevoPuerto);
            this.funciones.Controls.Add(this.modificarPuerto);
            this.funciones.Location = new System.Drawing.Point(221, 145);
            this.funciones.Name = "funciones";
            this.funciones.Size = new System.Drawing.Size(330, 94);
            this.funciones.TabIndex = 18;
            this.funciones.TabStop = false;
            this.funciones.Text = "Funciones";
            // 
            // eliminarPuerto
            // 
            this.eliminarPuerto.Location = new System.Drawing.Point(214, 33);
            this.eliminarPuerto.Name = "eliminarPuerto";
            this.eliminarPuerto.Size = new System.Drawing.Size(110, 39);
            this.eliminarPuerto.TabIndex = 9;
            this.eliminarPuerto.Text = "Eliminar Puerto";
            this.eliminarPuerto.UseVisualStyleBackColor = true;
            this.eliminarPuerto.Click += new System.EventHandler(this.eliminarPuerto_Click);
            // 
            // nuevoPuerto
            // 
            this.nuevoPuerto.Location = new System.Drawing.Point(6, 33);
            this.nuevoPuerto.Name = "nuevoPuerto";
            this.nuevoPuerto.Size = new System.Drawing.Size(98, 39);
            this.nuevoPuerto.TabIndex = 7;
            this.nuevoPuerto.Text = "Nuevo Puerto";
            this.nuevoPuerto.UseVisualStyleBackColor = true;
            this.nuevoPuerto.Click += new System.EventHandler(this.nuevoPuerto_Click);
            // 
            // modificarPuerto
            // 
            this.modificarPuerto.Location = new System.Drawing.Point(110, 33);
            this.modificarPuerto.Name = "modificarPuerto";
            this.modificarPuerto.Size = new System.Drawing.Size(98, 39);
            this.modificarPuerto.TabIndex = 7;
            this.modificarPuerto.Text = "Modificar Puerto";
            this.modificarPuerto.UseVisualStyleBackColor = true;
            this.modificarPuerto.Click += new System.EventHandler(this.modificarPuerto_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(453, 347);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(98, 39);
            this.cancelar.TabIndex = 16;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(331, 347);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(98, 39);
            this.aceptar.TabIndex = 17;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Visible = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // nombrePuerto
            // 
            this.nombrePuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePuerto.Location = new System.Drawing.Point(221, 286);
            this.nombrePuerto.Name = "nombrePuerto";
            this.nombrePuerto.Size = new System.Drawing.Size(330, 26);
            this.nombrePuerto.TabIndex = 20;
            this.nombrePuerto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(221, 267);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(95, 13);
            this.nombre.TabIndex = 21;
            this.nombre.Text = "Nombre del Puerto";
            this.nombre.Visible = false;
            // 
            // ABM_Puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 491);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nombrePuerto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.funciones);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.puertos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ABM_Puerto";
            this.Text = "Puertos";
            this.Load += new System.EventHandler(this.ABM_Puerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.funciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label puertos;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPuertos;
        private System.Windows.Forms.GroupBox funciones;
        private System.Windows.Forms.Button eliminarPuerto;
        private System.Windows.Forms.Button nuevoPuerto;
        private System.Windows.Forms.Button modificarPuerto;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox nombrePuerto;
        private System.Windows.Forms.Label nombre;
    }
}