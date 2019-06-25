namespace FrbaCrucero.GeneracionViaje
{
    partial class Generacion_Viaje
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recorridosDisponibles = new System.Windows.Forms.Label();
            this.crucerosDisponibles = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.generarViaje = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.fechaFinalizacion = new System.Windows.Forms.Label();
            this.textBoxFinalizacion = new System.Windows.Forms.TextBox();
            this.horaInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarCruceros = new System.Windows.Forms.Button();
            this.numericUpDownMinutos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoras = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoras)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(495, 300);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(18, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(495, 274);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // recorridosDisponibles
            // 
            this.recorridosDisponibles.AutoSize = true;
            this.recorridosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recorridosDisponibles.Location = new System.Drawing.Point(12, 9);
            this.recorridosDisponibles.Name = "recorridosDisponibles";
            this.recorridosDisponibles.Size = new System.Drawing.Size(289, 31);
            this.recorridosDisponibles.TabIndex = 13;
            this.recorridosDisponibles.Text = "Recorridos disponibles";
            // 
            // crucerosDisponibles
            // 
            this.crucerosDisponibles.AutoSize = true;
            this.crucerosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crucerosDisponibles.Location = new System.Drawing.Point(12, 330);
            this.crucerosDisponibles.Name = "crucerosDisponibles";
            this.crucerosDisponibles.Size = new System.Drawing.Size(268, 31);
            this.crucerosDisponibles.TabIndex = 14;
            this.crucerosDisponibles.Text = "Cruceros disponibles";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // generarViaje
            // 
            this.generarViaje.Enabled = false;
            this.generarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarViaje.Location = new System.Drawing.Point(519, 620);
            this.generarViaje.Name = "generarViaje";
            this.generarViaje.Size = new System.Drawing.Size(202, 53);
            this.generarViaje.TabIndex = 26;
            this.generarViaje.Text = "Generar Viaje";
            this.generarViaje.UseVisualStyleBackColor = true;
            this.generarViaje.Click += new System.EventHandler(this.generarViaje_Click);
            // 
            // atras
            // 
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(781, 631);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(100, 42);
            this.atras.TabIndex = 27;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.Location = new System.Drawing.Point(7, 80);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(111, 17);
            this.fechaInicio.TabIndex = 28;
            this.fechaInicio.Text = "Fecha de inicio :";
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.AutoSize = true;
            this.fechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinalizacion.Location = new System.Drawing.Point(7, 131);
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.Size = new System.Drawing.Size(149, 17);
            this.fechaFinalizacion.TabIndex = 29;
            this.fechaFinalizacion.Text = "Fecha de finalizacion :";
            // 
            // textBoxFinalizacion
            // 
            this.textBoxFinalizacion.Location = new System.Drawing.Point(154, 131);
            this.textBoxFinalizacion.Name = "textBoxFinalizacion";
            this.textBoxFinalizacion.ReadOnly = true;
            this.textBoxFinalizacion.Size = new System.Drawing.Size(202, 20);
            this.textBoxFinalizacion.TabIndex = 30;
            // 
            // horaInicio
            // 
            this.horaInicio.AutoSize = true;
            this.horaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaInicio.Location = new System.Drawing.Point(7, 35);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Size = new System.Drawing.Size(148, 17);
            this.horaInicio.TabIndex = 32;
            this.horaInicio.Text = "Hora de inicio (24hs) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = " :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownHoras);
            this.groupBox1.Controls.Add(this.numericUpDownMinutos);
            this.groupBox1.Controls.Add(this.fechaInicio);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxFinalizacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechaFinalizacion);
            this.groupBox1.Controls.Add(this.horaInicio);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(519, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 167);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha del viaje";
            // 
            // buscarCruceros
            // 
            this.buscarCruceros.Enabled = false;
            this.buscarCruceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCruceros.Location = new System.Drawing.Point(519, 546);
            this.buscarCruceros.Name = "buscarCruceros";
            this.buscarCruceros.Size = new System.Drawing.Size(202, 53);
            this.buscarCruceros.TabIndex = 37;
            this.buscarCruceros.Text = "Buscar Cruceros disponibles";
            this.buscarCruceros.UseVisualStyleBackColor = true;
            this.buscarCruceros.Click += new System.EventHandler(this.buscarCruceros_Click);
            // 
            // numericUpDownMinutos
            // 
            this.numericUpDownMinutos.Location = new System.Drawing.Point(307, 35);
            this.numericUpDownMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutos.Name = "numericUpDownMinutos";
            this.numericUpDownMinutos.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownMinutos.TabIndex = 35;
            this.numericUpDownMinutos.ValueChanged += new System.EventHandler(this.numericUpDownMinutos_ValueChanged);
            // 
            // numericUpDownHoras
            // 
            this.numericUpDownHoras.Location = new System.Drawing.Point(231, 35);
            this.numericUpDownHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHoras.Name = "numericUpDownHoras";
            this.numericUpDownHoras.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownHoras.TabIndex = 36;
            this.numericUpDownHoras.ValueChanged += new System.EventHandler(this.numericUpDownHoras_ValueChanged);
            // 
            // Generacion_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 689);
            this.Controls.Add(this.buscarCruceros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generarViaje);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.crucerosDisponibles);
            this.Controls.Add(this.recorridosDisponibles);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Generacion_Viaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.Generacion_Viaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label recorridosDisponibles;
        private System.Windows.Forms.Label crucerosDisponibles;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button generarViaje;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label fechaFinalizacion;
        private System.Windows.Forms.TextBox textBoxFinalizacion;
        private System.Windows.Forms.Label horaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buscarCruceros;
        private System.Windows.Forms.NumericUpDown numericUpDownHoras;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutos;
    }
}