namespace FrbaCrucero.ListadoEstadistico
{
    partial class Listado_Estadistico
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
            this.comboBoxFunciones = new System.Windows.Forms.ComboBox();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.listadoLabel = new System.Windows.Forms.Label();
            this.semestreLabel = new System.Windows.Forms.Label();
            this.anioLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.visualizarListado = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 245);
            this.dataGridView1.TabIndex = 4;
            // 
            // comboBoxFunciones
            // 
            this.comboBoxFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFunciones.FormattingEnabled = true;
            this.comboBoxFunciones.Items.AddRange(new object[] {
            "Recorridos con más pasajes comprados",
            "Clientes con más puntos acumulados a la fecha",
            "Recorridos con más cabinas libres en cada uno de los viajes realizados",
            "Cruceros con mayor cantidad de días fuera de servicio"});
            this.comboBoxFunciones.Location = new System.Drawing.Point(12, 294);
            this.comboBoxFunciones.Name = "comboBoxFunciones";
            this.comboBoxFunciones.Size = new System.Drawing.Size(639, 33);
            this.comboBoxFunciones.TabIndex = 18;
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Items.AddRange(new object[] {
            "Primer semestre (Enero - Junio)",
            "Segundo semestre (Julio - Diciembre)"});
            this.comboBoxSemestre.Location = new System.Drawing.Point(12, 367);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(261, 24);
            this.comboBoxSemestre.TabIndex = 19;
            // 
            // listadoLabel
            // 
            this.listadoLabel.AutoSize = true;
            this.listadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoLabel.Location = new System.Drawing.Point(7, 266);
            this.listadoLabel.Name = "listadoLabel";
            this.listadoLabel.Size = new System.Drawing.Size(81, 25);
            this.listadoLabel.TabIndex = 21;
            this.listadoLabel.Text = "Listado:";
            // 
            // semestreLabel
            // 
            this.semestreLabel.AutoSize = true;
            this.semestreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestreLabel.Location = new System.Drawing.Point(9, 347);
            this.semestreLabel.Name = "semestreLabel";
            this.semestreLabel.Size = new System.Drawing.Size(72, 17);
            this.semestreLabel.TabIndex = 22;
            this.semestreLabel.Text = "Semestre:";
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioLabel.Location = new System.Drawing.Point(285, 350);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(37, 17);
            this.anioLabel.TabIndex = 23;
            this.anioLabel.Text = "Año:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::FrbaCrucero.Properties.Settings.Default, "Inicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(288, 370);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = global::FrbaCrucero.Properties.Settings.Default.Inicio;
            // 
            // visualizarListado
            // 
            this.visualizarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizarListado.Location = new System.Drawing.Point(491, 338);
            this.visualizarListado.Name = "visualizarListado";
            this.visualizarListado.Size = new System.Drawing.Size(160, 53);
            this.visualizarListado.TabIndex = 24;
            this.visualizarListado.Text = "Visualizar Listado";
            this.visualizarListado.UseVisualStyleBackColor = true;
            this.visualizarListado.Click += new System.EventHandler(this.visualizarListado_Click);
            // 
            // atras
            // 
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(668, 349);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(100, 42);
            this.atras.TabIndex = 25;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // Listado_Estadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 409);
            this.Controls.Add(this.visualizarListado);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.anioLabel);
            this.Controls.Add(this.semestreLabel);
            this.Controls.Add(this.listadoLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.comboBoxFunciones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listado_Estadistico";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.Listado_Estadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxFunciones;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label listadoLabel;
        private System.Windows.Forms.Label semestreLabel;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Button visualizarListado;
        private System.Windows.Forms.Button atras;
    }
}