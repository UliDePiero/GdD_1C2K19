namespace FrbaCrucero.CompraReservaPasaje
{
    partial class ReservaForm
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
            this.comboBoxPuertoD = new System.Windows.Forms.ComboBox();
            this.comboBoxPuertoO = new System.Windows.Forms.ComboBox();
            this.puertoDestino = new System.Windows.Forms.GroupBox();
            this.puertoOrigen = new System.Windows.Forms.GroupBox();
            this.cerrar = new System.Windows.Forms.Button();
            this.reservarBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.puertoDestino.SuspendLayout();
            this.puertoOrigen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarPasaje
            // 
            this.buscarPasaje.Location = new System.Drawing.Point(349, 91);
            this.buscarPasaje.Name = "buscarPasaje";
            this.buscarPasaje.Size = new System.Drawing.Size(111, 32);
            this.buscarPasaje.TabIndex = 8;
            this.buscarPasaje.Text = "Buscar";
            this.buscarPasaje.UseVisualStyleBackColor = true;
            this.buscarPasaje.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // comboBoxPuertoD
            // 
            this.comboBoxPuertoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuertoD.FormattingEnabled = true;
            this.comboBoxPuertoD.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPuertoD.Name = "comboBoxPuertoD";
            this.comboBoxPuertoD.Size = new System.Drawing.Size(195, 33);
            this.comboBoxPuertoD.TabIndex = 15;
            this.comboBoxPuertoD.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuertoD_SelectedIndexChanged);
            // 
            // comboBoxPuertoO
            // 
            this.comboBoxPuertoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuertoO.FormattingEnabled = true;
            this.comboBoxPuertoO.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPuertoO.Name = "comboBoxPuertoO";
            this.comboBoxPuertoO.Size = new System.Drawing.Size(192, 33);
            this.comboBoxPuertoO.TabIndex = 15;
            this.comboBoxPuertoO.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuertoO_SelectedIndexChanged);
            // 
            // puertoDestino
            // 
            this.puertoDestino.Controls.Add(this.comboBoxPuertoD);
            this.puertoDestino.Location = new System.Drawing.Point(301, 12);
            this.puertoDestino.Name = "puertoDestino";
            this.puertoDestino.Size = new System.Drawing.Size(207, 66);
            this.puertoDestino.TabIndex = 19;
            this.puertoDestino.TabStop = false;
            this.puertoDestino.Text = "Puerto Destino";
            this.puertoDestino.Enter += new System.EventHandler(this.PuertoDestino_Enter);
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.Controls.Add(this.comboBoxPuertoO);
            this.puertoOrigen.Location = new System.Drawing.Point(32, 12);
            this.puertoOrigen.Name = "puertoOrigen";
            this.puertoOrigen.Size = new System.Drawing.Size(204, 66);
            this.puertoOrigen.TabIndex = 20;
            this.puertoOrigen.TabStop = false;
            this.puertoOrigen.Text = "Puerto Origen";
            this.puertoOrigen.Enter += new System.EventHandler(this.PuertoOrigen_Enter);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(432, 420);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(95, 31);
            this.cerrar.TabIndex = 21;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // reservarBtn
            // 
            this.reservarBtn.Location = new System.Drawing.Point(6, 19);
            this.reservarBtn.Name = "reservarBtn";
            this.reservarBtn.Size = new System.Drawing.Size(95, 33);
            this.reservarBtn.TabIndex = 23;
            this.reservarBtn.Text = "Reservar";
            this.reservarBtn.UseVisualStyleBackColor = true;
            this.reservarBtn.Click += new System.EventHandler(this.reservar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(32, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 52);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de salida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(10, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 201);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.reservarBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 121);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(123, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 33);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox);
            this.groupBox3.Location = new System.Drawing.Point(117, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 51);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio del viaje";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(6, 19);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(89, 23);
            this.textBox.TabIndex = 30;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.puertoDestino);
            this.Controls.Add(this.puertoOrigen);
            this.Controls.Add(this.buscarPasaje);
            this.Name = "ReservaForm";
            this.Text = "Buscar pasaje";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.puertoDestino.ResumeLayout(false);
            this.puertoOrigen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarPasaje;
        private System.Windows.Forms.ComboBox comboBoxPuertoD;
        private System.Windows.Forms.ComboBox comboBoxPuertoO;
        private System.Windows.Forms.GroupBox puertoDestino;
        private System.Windows.Forms.GroupBox puertoOrigen;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button reservarBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox;
    }
}