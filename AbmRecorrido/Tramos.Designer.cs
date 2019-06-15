namespace FrbaCrucero.AbmRecorrido
{
    partial class Tramos
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
            this.atras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nuevoTramo = new System.Windows.Forms.Button();
            this.modificarTramo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.puertoDestino = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.puertoOrigen = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.duracionLB = new System.Windows.Forms.Label();
            this.precioLB = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(444, 502);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 8;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(529, 343);
            this.dataGridView1.TabIndex = 9;
            // 
            // nuevoTramo
            // 
            this.nuevoTramo.Location = new System.Drawing.Point(6, 40);
            this.nuevoTramo.Name = "nuevoTramo";
            this.nuevoTramo.Size = new System.Drawing.Size(98, 39);
            this.nuevoTramo.TabIndex = 10;
            this.nuevoTramo.Text = "Nuevo Tramo";
            this.nuevoTramo.UseVisualStyleBackColor = true;
            this.nuevoTramo.Click += new System.EventHandler(this.nuevoTramo_Click);
            // 
            // modificarTramo
            // 
            this.modificarTramo.Location = new System.Drawing.Point(110, 40);
            this.modificarTramo.Name = "modificarTramo";
            this.modificarTramo.Size = new System.Drawing.Size(98, 39);
            this.modificarTramo.TabIndex = 11;
            this.modificarTramo.Text = "Modificar Tramo";
            this.modificarTramo.UseVisualStyleBackColor = true;
            this.modificarTramo.Click += new System.EventHandler(this.modificarTramo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoTramo);
            this.groupBox1.Controls.Add(this.modificarTramo);
            this.groupBox1.Location = new System.Drawing.Point(13, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // puertoDestino
            // 
            this.puertoDestino.AutoSize = true;
            this.puertoDestino.Location = new System.Drawing.Point(12, 405);
            this.puertoDestino.Name = "puertoDestino";
            this.puertoDestino.Size = new System.Drawing.Size(77, 13);
            this.puertoDestino.TabIndex = 9;
            this.puertoDestino.Text = "Puerto Destino";
            this.puertoDestino.Visible = false;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "Cualquier puerto"});
            this.comboBoxDestino.Location = new System.Drawing.Point(12, 421);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(280, 28);
            this.comboBoxDestino.TabIndex = 8;
            this.comboBoxDestino.Visible = false;
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.AutoSize = true;
            this.puertoOrigen.Location = new System.Drawing.Point(12, 358);
            this.puertoOrigen.Name = "puertoOrigen";
            this.puertoOrigen.Size = new System.Drawing.Size(72, 13);
            this.puertoOrigen.TabIndex = 7;
            this.puertoOrigen.Text = "Puerto Origen";
            this.puertoOrigen.Visible = false;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "Cualquier puerto"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(12, 374);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(280, 28);
            this.comboBoxOrigen.TabIndex = 6;
            this.comboBoxOrigen.Visible = false;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(310, 376);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(232, 26);
            this.textBoxPrecio.TabIndex = 13;
            this.textBoxPrecio.Visible = false;
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracion.Location = new System.Drawing.Point(310, 423);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(232, 26);
            this.textBoxDuracion.TabIndex = 14;
            this.textBoxDuracion.WordWrap = false;
            // 
            // duracionLB
            // 
            this.duracionLB.AutoSize = true;
            this.duracionLB.Location = new System.Drawing.Point(307, 407);
            this.duracionLB.Name = "duracionLB";
            this.duracionLB.Size = new System.Drawing.Size(87, 13);
            this.duracionLB.TabIndex = 16;
            this.duracionLB.Text = "Duracion (Horas)";
            this.duracionLB.Visible = false;
            // 
            // precioLB
            // 
            this.precioLB.AutoSize = true;
            this.precioLB.Location = new System.Drawing.Point(307, 360);
            this.precioLB.Name = "precioLB";
            this.precioLB.Size = new System.Drawing.Size(37, 13);
            this.precioLB.TabIndex = 15;
            this.precioLB.Text = "Precio";
            this.precioLB.Visible = false;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(340, 502);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(98, 39);
            this.cancelar.TabIndex = 17;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(236, 502);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(98, 39);
            this.aceptar.TabIndex = 18;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Visible = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // Tramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 564);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.duracionLB);
            this.Controls.Add(this.precioLB);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.puertoDestino);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.puertoOrigen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.atras);
            this.Name = "Tramos";
            this.Text = "Tramos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nuevoTramo;
        private System.Windows.Forms.Button modificarTramo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label puertoDestino;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Label puertoOrigen;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.Label duracionLB;
        private System.Windows.Forms.Label precioLB;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
    }
}