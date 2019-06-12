namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificacionesRecorrido
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
            this.components = new System.ComponentModel.Container();
            this.nuevoRecorrido = new System.Windows.Forms.Label();
            this.modificarRecorrido = new System.Windows.Forms.Label();
            this.textBoxCodigoRec = new System.Windows.Forms.TextBox();
            this.codigoRecorrido = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.precioRecorrido = new System.Windows.Forms.Label();
            this.textBoxPrecioRec = new System.Windows.Forms.TextBox();
            this.errorProviderCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.tramosDelRecorrido = new System.Windows.Forms.Label();
            this.duracionRecorrido = new System.Windows.Forms.Label();
            this.textBoxDuracionRec = new System.Windows.Forms.TextBox();
            this.checkedListBoxTramos = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.puertoOrigen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoRecorrido
            // 
            this.nuevoRecorrido.AutoSize = true;
            this.nuevoRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoRecorrido.Location = new System.Drawing.Point(12, 9);
            this.nuevoRecorrido.Name = "nuevoRecorrido";
            this.nuevoRecorrido.Size = new System.Drawing.Size(218, 31);
            this.nuevoRecorrido.TabIndex = 1;
            this.nuevoRecorrido.Text = "Nuevo Recorrido";
            // 
            // modificarRecorrido
            // 
            this.modificarRecorrido.AutoSize = true;
            this.modificarRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarRecorrido.Location = new System.Drawing.Point(12, 9);
            this.modificarRecorrido.Name = "modificarRecorrido";
            this.modificarRecorrido.Size = new System.Drawing.Size(249, 31);
            this.modificarRecorrido.TabIndex = 1;
            this.modificarRecorrido.Text = "Modificar Recorrido";
            // 
            // textBoxCodigoRec
            // 
            this.textBoxCodigoRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoRec.Location = new System.Drawing.Point(15, 93);
            this.textBoxCodigoRec.Name = "textBoxCodigoRec";
            this.textBoxCodigoRec.Size = new System.Drawing.Size(386, 23);
            this.textBoxCodigoRec.TabIndex = 3;
            // 
            // codigoRecorrido
            // 
            this.codigoRecorrido.AutoSize = true;
            this.codigoRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoRecorrido.Location = new System.Drawing.Point(12, 65);
            this.codigoRecorrido.Name = "codigoRecorrido";
            this.codigoRecorrido.Size = new System.Drawing.Size(141, 17);
            this.codigoRecorrido.TabIndex = 2;
            this.codigoRecorrido.Text = "Codigo del Recorrido";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(451, 108);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(161, 45);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(451, 37);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(161, 45);
            this.aceptar.TabIndex = 5;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // precioRecorrido
            // 
            this.precioRecorrido.AutoSize = true;
            this.precioRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioRecorrido.Location = new System.Drawing.Point(12, 222);
            this.precioRecorrido.Name = "precioRecorrido";
            this.precioRecorrido.Size = new System.Drawing.Size(137, 17);
            this.precioRecorrido.TabIndex = 2;
            this.precioRecorrido.Text = "Precio del Recorrido";
            // 
            // textBoxPrecioRec
            // 
            this.textBoxPrecioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioRec.Location = new System.Drawing.Point(15, 250);
            this.textBoxPrecioRec.Name = "textBoxPrecioRec";
            this.textBoxPrecioRec.ReadOnly = true;
            this.textBoxPrecioRec.Size = new System.Drawing.Size(386, 23);
            this.textBoxPrecioRec.TabIndex = 3;
            // 
            // errorProviderCodigo
            // 
            this.errorProviderCodigo.ContainerControl = this;
            // 
            // tramosDelRecorrido
            // 
            this.tramosDelRecorrido.AutoSize = true;
            this.tramosDelRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramosDelRecorrido.Location = new System.Drawing.Point(9, 356);
            this.tramosDelRecorrido.Name = "tramosDelRecorrido";
            this.tramosDelRecorrido.Size = new System.Drawing.Size(145, 17);
            this.tramosDelRecorrido.TabIndex = 2;
            this.tramosDelRecorrido.Text = "Tramos del Recorrido";
            // 
            // duracionRecorrido
            // 
            this.duracionRecorrido.AutoSize = true;
            this.duracionRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionRecorrido.Location = new System.Drawing.Point(12, 288);
            this.duracionRecorrido.Name = "duracionRecorrido";
            this.duracionRecorrido.Size = new System.Drawing.Size(154, 17);
            this.duracionRecorrido.TabIndex = 2;
            this.duracionRecorrido.Text = "Duracion del Recorrido";
            // 
            // textBoxDuracionRec
            // 
            this.textBoxDuracionRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracionRec.Location = new System.Drawing.Point(15, 316);
            this.textBoxDuracionRec.Name = "textBoxDuracionRec";
            this.textBoxDuracionRec.ReadOnly = true;
            this.textBoxDuracionRec.Size = new System.Drawing.Size(386, 23);
            this.textBoxDuracionRec.TabIndex = 3;
            // 
            // checkedListBoxTramos
            // 
            this.checkedListBoxTramos.FormattingEnabled = true;
            this.checkedListBoxTramos.Location = new System.Drawing.Point(12, 382);
            this.checkedListBoxTramos.Name = "checkedListBoxTramos";
            this.checkedListBoxTramos.Size = new System.Drawing.Size(98, 214);
            this.checkedListBoxTramos.TabIndex = 7;
            this.checkedListBoxTramos.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTramos_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(509, 214);
            this.dataGridView1.TabIndex = 10;
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(15, 166);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(386, 33);
            this.comboBoxPuerto.TabIndex = 16;
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.AutoSize = true;
            this.puertoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puertoOrigen.Location = new System.Drawing.Point(16, 136);
            this.puertoOrigen.Name = "puertoOrigen";
            this.puertoOrigen.Size = new System.Drawing.Size(94, 17);
            this.puertoOrigen.TabIndex = 17;
            this.puertoOrigen.Text = "Puerto origen";
            // 
            // ModificacionesRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 608);
            this.Controls.Add(this.puertoOrigen);
            this.Controls.Add(this.comboBoxPuerto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBoxTramos);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.textBoxDuracionRec);
            this.Controls.Add(this.textBoxPrecioRec);
            this.Controls.Add(this.duracionRecorrido);
            this.Controls.Add(this.tramosDelRecorrido);
            this.Controls.Add(this.precioRecorrido);
            this.Controls.Add(this.textBoxCodigoRec);
            this.Controls.Add(this.codigoRecorrido);
            this.Controls.Add(this.modificarRecorrido);
            this.Controls.Add(this.nuevoRecorrido);
            this.Name = "ModificacionesRecorrido";
            this.Text = "Recorridos | Modificaciones";
            this.Load += new System.EventHandler(this.ModificacionesRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nuevoRecorrido;
        private System.Windows.Forms.Label modificarRecorrido;
        private System.Windows.Forms.TextBox textBoxCodigoRec;
        private System.Windows.Forms.Label codigoRecorrido;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox textBoxPrecioRec;
        private System.Windows.Forms.Label precioRecorrido;
        private System.Windows.Forms.ErrorProvider errorProviderCodigo;
        private System.Windows.Forms.Label tramosDelRecorrido;
        private System.Windows.Forms.TextBox textBoxDuracionRec;
        private System.Windows.Forms.Label duracionRecorrido;
        private System.Windows.Forms.CheckedListBox checkedListBoxTramos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label puertoOrigen;
        private System.Windows.Forms.ComboBox comboBoxPuerto;

    }
}