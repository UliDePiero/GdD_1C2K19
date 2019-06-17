namespace FrbaCrucero.AbmRecorrido
{
    partial class ABM_Recorrido
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
            this.recorridosDisponibles = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atras = new System.Windows.Forms.Button();
            this.nuevoRecorrido = new System.Windows.Forms.Button();
            this.modificarRecorrido = new System.Windows.Forms.Button();
            this.eliminarRecorridos = new System.Windows.Forms.Button();
            this.funciones = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.editarTramos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.funciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // recorridosDisponibles
            // 
            this.recorridosDisponibles.AutoSize = true;
            this.recorridosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recorridosDisponibles.Location = new System.Drawing.Point(3, 9);
            this.recorridosDisponibles.Name = "recorridosDisponibles";
            this.recorridosDisponibles.Size = new System.Drawing.Size(289, 31);
            this.recorridosDisponibles.TabIndex = 0;
            this.recorridosDisponibles.Text = "Recorridos disponibles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(441, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(349, 647);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 7;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // nuevoRecorrido
            // 
            this.nuevoRecorrido.Location = new System.Drawing.Point(6, 33);
            this.nuevoRecorrido.Name = "nuevoRecorrido";
            this.nuevoRecorrido.Size = new System.Drawing.Size(98, 39);
            this.nuevoRecorrido.TabIndex = 7;
            this.nuevoRecorrido.Text = "Nuevo Recorrido";
            this.nuevoRecorrido.UseVisualStyleBackColor = true;
            this.nuevoRecorrido.Click += new System.EventHandler(this.nuevoRecorrido_Click);
            // 
            // modificarRecorrido
            // 
            this.modificarRecorrido.Location = new System.Drawing.Point(110, 33);
            this.modificarRecorrido.Name = "modificarRecorrido";
            this.modificarRecorrido.Size = new System.Drawing.Size(98, 39);
            this.modificarRecorrido.TabIndex = 7;
            this.modificarRecorrido.Text = "Modificar Recorrido";
            this.modificarRecorrido.UseVisualStyleBackColor = true;
            this.modificarRecorrido.Click += new System.EventHandler(this.modificarRecorrido_Click);
            // 
            // eliminarRecorridos
            // 
            this.eliminarRecorridos.Location = new System.Drawing.Point(214, 33);
            this.eliminarRecorridos.Name = "eliminarRecorridos";
            this.eliminarRecorridos.Size = new System.Drawing.Size(117, 39);
            this.eliminarRecorridos.TabIndex = 7;
            this.eliminarRecorridos.Text = "Habilitar/Deshabilitar Recorrido";
            this.eliminarRecorridos.UseVisualStyleBackColor = true;
            this.eliminarRecorridos.Click += new System.EventHandler(this.eliminarRecorridos_Click);
            // 
            // funciones
            // 
            this.funciones.Controls.Add(this.editarTramos);
            this.funciones.Controls.Add(this.nuevoRecorrido);
            this.funciones.Controls.Add(this.eliminarRecorridos);
            this.funciones.Controls.Add(this.modificarRecorrido);
            this.funciones.Location = new System.Drawing.Point(12, 559);
            this.funciones.Name = "funciones";
            this.funciones.Size = new System.Drawing.Size(444, 82);
            this.funciones.TabIndex = 8;
            this.funciones.TabStop = false;
            this.funciones.Text = "Funciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxDestino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxOrigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 165);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(268, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Mostrar/Ocultar deshabilitados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recorridos con Destino en";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "Cualquier puerto"});
            this.comboBoxDestino.Location = new System.Drawing.Point(6, 123);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(280, 28);
            this.comboBoxDestino.TabIndex = 8;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recorridos con Origen en";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "Cualquier puerto"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(6, 57);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(280, 28);
            this.comboBoxOrigen.TabIndex = 6;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // editarTramos
            // 
            this.editarTramos.Location = new System.Drawing.Point(337, 33);
            this.editarTramos.Name = "editarTramos";
            this.editarTramos.Size = new System.Drawing.Size(98, 39);
            this.editarTramos.TabIndex = 8;
            this.editarTramos.Text = "Editar Tramos";
            this.editarTramos.UseVisualStyleBackColor = true;
            this.editarTramos.Click += new System.EventHandler(this.editarTramos_Click);
            // 
            // ABM_Recorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.funciones);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.recorridosDisponibles);
            this.Name = "ABM_Recorrido";
            this.RightToLeftLayout = true;
            this.Text = "Recorridos";
            this.Load += new System.EventHandler(this.ABM_Recorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.funciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recorridosDisponibles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button nuevoRecorrido;
        private System.Windows.Forms.Button modificarRecorrido;
        private System.Windows.Forms.Button eliminarRecorridos;
        private System.Windows.Forms.GroupBox funciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button editarTramos;
    }
}