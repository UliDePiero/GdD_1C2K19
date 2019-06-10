namespace FrbaCrucero.CompraReservaPasaje
{
    partial class Reservar
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
            this.buscarPasaje = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPuertoD = new System.Windows.Forms.ComboBox();
            this.comboBoxPuertoO = new System.Windows.Forms.ComboBox();
            this.puertoDestino = new System.Windows.Forms.GroupBox();
            this.puertoOrigen = new System.Windows.Forms.GroupBox();
            this.cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservarBtn = new System.Windows.Forms.Button();
            this.puertoDestino.SuspendLayout();
            this.puertoOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarPasaje
            // 
            this.buscarPasaje.Location = new System.Drawing.Point(265, 94);
            this.buscarPasaje.Name = "buscarPasaje";
            this.buscarPasaje.Size = new System.Drawing.Size(98, 27);
            this.buscarPasaje.TabIndex = 8;
            this.buscarPasaje.Text = "Buscar pasaje";
            this.buscarPasaje.UseVisualStyleBackColor = true;
            this.buscarPasaje.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(15, 81);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(108, 17);
            this.fecha.TabIndex = 16;
            this.fecha.Text = "Fecha de salida";
            this.fecha.Visible = false;
            this.fecha.Click += new System.EventHandler(this.FechaSalida_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxPuertoD
            // 
            this.comboBoxPuertoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuertoD.FormattingEnabled = true;
            this.comboBoxPuertoD.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPuertoD.Name = "comboBoxPuertoD";
            this.comboBoxPuertoD.Size = new System.Drawing.Size(186, 33);
            this.comboBoxPuertoD.TabIndex = 15;
            this.comboBoxPuertoD.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuertoD_SelectedIndexChanged);
            // 
            // comboBoxPuertoO
            // 
            this.comboBoxPuertoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuertoO.FormattingEnabled = true;
            this.comboBoxPuertoO.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPuertoO.Name = "comboBoxPuertoO";
            this.comboBoxPuertoO.Size = new System.Drawing.Size(186, 33);
            this.comboBoxPuertoO.TabIndex = 15;
            this.comboBoxPuertoO.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuertoO_SelectedIndexChanged);
            // 
            // puertoDestino
            // 
            this.puertoDestino.Controls.Add(this.comboBoxPuertoD);
            this.puertoDestino.Location = new System.Drawing.Point(216, 12);
            this.puertoDestino.Name = "puertoDestino";
            this.puertoDestino.Size = new System.Drawing.Size(198, 66);
            this.puertoDestino.TabIndex = 19;
            this.puertoDestino.TabStop = false;
            this.puertoDestino.Text = "Puerto Destino";
            this.puertoDestino.Enter += new System.EventHandler(this.PuertoDestino_Enter);
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.Controls.Add(this.comboBoxPuertoO);
            this.puertoOrigen.Location = new System.Drawing.Point(12, 12);
            this.puertoOrigen.Name = "puertoOrigen";
            this.puertoOrigen.Size = new System.Drawing.Size(198, 66);
            this.puertoOrigen.TabIndex = 20;
            this.puertoOrigen.TabStop = false;
            this.puertoOrigen.Text = "Puerto Origen";
            this.puertoOrigen.Enter += new System.EventHandler(this.PuertoOrigen_Enter);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(222, 430);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(95, 31);
            this.cerrar.TabIndex = 21;
            this.cerrar.Text = "Atras";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(408, 288);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reservarBtn
            // 
            this.reservarBtn.Location = new System.Drawing.Point(109, 430);
            this.reservarBtn.Name = "reservarBtn";
            this.reservarBtn.Size = new System.Drawing.Size(95, 31);
            this.reservarBtn.TabIndex = 23;
            this.reservarBtn.Text = "Reservar";
            this.reservarBtn.UseVisualStyleBackColor = true;
            this.reservarBtn.Click += new System.EventHandler(this.reservar_Click);
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 473);
            this.Controls.Add(this.reservarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.puertoDestino);
            this.Controls.Add(this.puertoOrigen);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buscarPasaje);
            this.Name = "Reserva";
            this.Text = "Reserva de pasaje";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.puertoDestino.ResumeLayout(false);
            this.puertoOrigen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarPasaje;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxPuertoD;
        private System.Windows.Forms.ComboBox comboBoxPuertoO;
        private System.Windows.Forms.GroupBox puertoDestino;
        private System.Windows.Forms.GroupBox puertoOrigen;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reservarBtn;
    }
}