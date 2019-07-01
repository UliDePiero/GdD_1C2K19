namespace FrbaCrucero.AbmCrucero
{
    partial class ABM_Crucero
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
            this.funciones = new System.Windows.Forms.GroupBox();
            this.bajaMomCrucero = new System.Windows.Forms.Button();
            this.nuevoCrucero = new System.Windows.Forms.Button();
            this.bajaDefCrucero = new System.Windows.Forms.Button();
            this.modificarCrucero = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crucerosDisponibles = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIdentificador = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAlta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBajaM = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBajaD = new System.Windows.Forms.DateTimePicker();
            this.limpiar = new System.Windows.Forms.Button();
            this.mostrarBajaDef = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.funciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // funciones
            // 
            this.funciones.Controls.Add(this.bajaMomCrucero);
            this.funciones.Controls.Add(this.nuevoCrucero);
            this.funciones.Controls.Add(this.bajaDefCrucero);
            this.funciones.Controls.Add(this.modificarCrucero);
            this.funciones.Location = new System.Drawing.Point(18, 509);
            this.funciones.Name = "funciones";
            this.funciones.Size = new System.Drawing.Size(296, 151);
            this.funciones.TabIndex = 12;
            this.funciones.TabStop = false;
            this.funciones.Text = "Funciones";
            // 
            // bajaMomCrucero
            // 
            this.bajaMomCrucero.Location = new System.Drawing.Point(12, 85);
            this.bajaMomCrucero.Name = "bajaMomCrucero";
            this.bajaMomCrucero.Size = new System.Drawing.Size(98, 53);
            this.bajaMomCrucero.TabIndex = 7;
            this.bajaMomCrucero.Text = "Dar de baja momentanea Crucero";
            this.bajaMomCrucero.UseVisualStyleBackColor = true;
            this.bajaMomCrucero.Click += new System.EventHandler(this.bajaMomCrucero_Click);
            // 
            // nuevoCrucero
            // 
            this.nuevoCrucero.Location = new System.Drawing.Point(12, 33);
            this.nuevoCrucero.Name = "nuevoCrucero";
            this.nuevoCrucero.Size = new System.Drawing.Size(98, 39);
            this.nuevoCrucero.TabIndex = 7;
            this.nuevoCrucero.Text = "Nuevo Crucero";
            this.nuevoCrucero.UseVisualStyleBackColor = true;
            this.nuevoCrucero.Click += new System.EventHandler(this.nuevoCrucero_Click);
            // 
            // bajaDefCrucero
            // 
            this.bajaDefCrucero.Location = new System.Drawing.Point(131, 85);
            this.bajaDefCrucero.Name = "bajaDefCrucero";
            this.bajaDefCrucero.Size = new System.Drawing.Size(98, 53);
            this.bajaDefCrucero.TabIndex = 7;
            this.bajaDefCrucero.Text = "Dar de baja definitiva Crucero";
            this.bajaDefCrucero.UseVisualStyleBackColor = true;
            this.bajaDefCrucero.Click += new System.EventHandler(this.bajaDefCrucero_Click);
            // 
            // modificarCrucero
            // 
            this.modificarCrucero.Location = new System.Drawing.Point(131, 33);
            this.modificarCrucero.Name = "modificarCrucero";
            this.modificarCrucero.Size = new System.Drawing.Size(98, 39);
            this.modificarCrucero.TabIndex = 7;
            this.modificarCrucero.Text = "Modificar Crucero";
            this.modificarCrucero.UseVisualStyleBackColor = true;
            this.modificarCrucero.Click += new System.EventHandler(this.modificarCrucero_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(592, 598);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 11;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 247);
            this.dataGridView1.TabIndex = 10;
            // 
            // crucerosDisponibles
            // 
            this.crucerosDisponibles.AutoSize = true;
            this.crucerosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crucerosDisponibles.Location = new System.Drawing.Point(12, 9);
            this.crucerosDisponibles.Name = "crucerosDisponibles";
            this.crucerosDisponibles.Size = new System.Drawing.Size(268, 31);
            this.crucerosDisponibles.TabIndex = 9;
            this.crucerosDisponibles.Text = "Cruceros disponibles";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 542);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(366, 518);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(47, 17);
            this.fecha.TabIndex = 14;
            this.fecha.Text = "Fecha";
            this.fecha.Visible = false;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(369, 598);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(98, 39);
            this.aceptar.TabIndex = 11;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Visible = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(473, 598);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(98, 39);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxMarca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxIdentificador);
            this.groupBox2.Location = new System.Drawing.Point(18, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 165);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cruceros marca";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Cualquier marca"});
            this.comboBoxMarca.Location = new System.Drawing.Point(6, 123);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(280, 28);
            this.comboBoxMarca.TabIndex = 8;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crucero identificador";
            // 
            // comboBoxIdentificador
            // 
            this.comboBoxIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdentificador.FormattingEnabled = true;
            this.comboBoxIdentificador.Items.AddRange(new object[] {
            "Todos los identificadores"});
            this.comboBoxIdentificador.Location = new System.Drawing.Point(6, 57);
            this.comboBoxIdentificador.Name = "comboBoxIdentificador";
            this.comboBoxIdentificador.Size = new System.Drawing.Size(280, 28);
            this.comboBoxIdentificador.TabIndex = 6;
            this.comboBoxIdentificador.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdentificador_SelectedIndexChanged);
            // 
            // dateTimePickerAlta
            // 
            this.dateTimePickerAlta.Location = new System.Drawing.Point(9, 35);
            this.dateTimePickerAlta.Name = "dateTimePickerAlta";
            this.dateTimePickerAlta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAlta.TabIndex = 10;
            this.dateTimePickerAlta.ValueChanged += new System.EventHandler(this.dateTimePickerAlta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Crucero con fecha de alta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Crucero con fecha de baja momentanea";
            // 
            // dateTimePickerBajaM
            // 
            this.dateTimePickerBajaM.Location = new System.Drawing.Point(9, 84);
            this.dateTimePickerBajaM.Name = "dateTimePickerBajaM";
            this.dateTimePickerBajaM.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBajaM.TabIndex = 12;
            this.dateTimePickerBajaM.ValueChanged += new System.EventHandler(this.dateTimePickerBajaM_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Crucero con fecha de baja definitiva";
            // 
            // dateTimePickerBajaD
            // 
            this.dateTimePickerBajaD.Location = new System.Drawing.Point(9, 133);
            this.dateTimePickerBajaD.Name = "dateTimePickerBajaD";
            this.dateTimePickerBajaD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBajaD.TabIndex = 14;
            this.dateTimePickerBajaD.ValueChanged += new System.EventHandler(this.dateTimePickerBajaD_ValueChanged);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(226, 114);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(98, 39);
            this.limpiar.TabIndex = 16;
            this.limpiar.Text = "Limpiar filtros";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // mostrarBajaDef
            // 
            this.mostrarBajaDef.Location = new System.Drawing.Point(226, 19);
            this.mostrarBajaDef.Name = "mostrarBajaDef";
            this.mostrarBajaDef.Size = new System.Drawing.Size(98, 70);
            this.mostrarBajaDef.TabIndex = 17;
            this.mostrarBajaDef.Text = "Mostrar solo cruceros dados de baja definitivamente";
            this.mostrarBajaDef.UseVisualStyleBackColor = true;
            this.mostrarBajaDef.Click += new System.EventHandler(this.mostrarBajaDef_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mostrarBajaDef);
            this.groupBox1.Controls.Add(this.dateTimePickerAlta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.dateTimePickerBajaM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePickerBajaD);
            this.groupBox1.Location = new System.Drawing.Point(366, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda 2";
            // 
            // ABM_Crucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.funciones);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crucerosDisponibles);
            this.Name = "ABM_Crucero";
            this.Text = "Cruceros";
            this.Load += new System.EventHandler(this.ABM_Crucero_Load);
            this.funciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox funciones;
        private System.Windows.Forms.Button nuevoCrucero;
        private System.Windows.Forms.Button bajaDefCrucero;
        private System.Windows.Forms.Button modificarCrucero;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label crucerosDisponibles;
        private System.Windows.Forms.Button bajaMomCrucero;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIdentificador;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBajaM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBajaD;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button mostrarBajaDef;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}