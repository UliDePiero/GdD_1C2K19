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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.puertoOrigen = new System.Windows.Forms.Label();
            this.listViewNuevos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puerto_origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puerto_destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewViejos = new System.Windows.Forms.ListView();
            this.id_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puerto_origen2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puerto_destino2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tramosPrevios = new System.Windows.Forms.Label();
            this.tramosActuales = new System.Windows.Forms.Label();
            this.vaciarLista = new System.Windows.Forms.Button();
            this.agregarTramo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.cancelar.Location = new System.Drawing.Point(135, 19);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(109, 45);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(6, 19);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(108, 45);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
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
            this.comboBoxPuerto.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuerto_SelectedIndexChanged);
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
            // listViewNuevos
            // 
            this.listViewNuevos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.puerto_origen,
            this.puerto_destino});
            this.listViewNuevos.Location = new System.Drawing.Point(547, 382);
            this.listViewNuevos.Name = "listViewNuevos";
            this.listViewNuevos.Size = new System.Drawing.Size(513, 214);
            this.listViewNuevos.TabIndex = 18;
            this.listViewNuevos.UseCompatibleStateImageBehavior = false;
            this.listViewNuevos.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 76;
            // 
            // puerto_origen
            // 
            this.puerto_origen.Text = "Puerto origen";
            this.puerto_origen.Width = 197;
            // 
            // puerto_destino
            // 
            this.puerto_destino.Text = "Puerto destino";
            this.puerto_destino.Width = 226;
            // 
            // listViewViejos
            // 
            this.listViewViejos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_2,
            this.puerto_origen2,
            this.puerto_destino2});
            this.listViewViejos.Location = new System.Drawing.Point(547, 139);
            this.listViewViejos.Name = "listViewViejos";
            this.listViewViejos.Size = new System.Drawing.Size(513, 214);
            this.listViewViejos.TabIndex = 19;
            this.listViewViejos.UseCompatibleStateImageBehavior = false;
            this.listViewViejos.View = System.Windows.Forms.View.Details;
            this.listViewViejos.Visible = false;
            // 
            // id_2
            // 
            this.id_2.Text = "ID";
            this.id_2.Width = 79;
            // 
            // puerto_origen2
            // 
            this.puerto_origen2.Text = "Puerto origen";
            this.puerto_origen2.Width = 195;
            // 
            // puerto_destino2
            // 
            this.puerto_destino2.Text = "Puerto destino";
            this.puerto_destino2.Width = 229;
            // 
            // tramosPrevios
            // 
            this.tramosPrevios.AutoSize = true;
            this.tramosPrevios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramosPrevios.Location = new System.Drawing.Point(544, 119);
            this.tramosPrevios.Name = "tramosPrevios";
            this.tramosPrevios.Size = new System.Drawing.Size(106, 17);
            this.tramosPrevios.TabIndex = 20;
            this.tramosPrevios.Text = "Tramos previos";
            this.tramosPrevios.Visible = false;
            // 
            // tramosActuales
            // 
            this.tramosActuales.AutoSize = true;
            this.tramosActuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramosActuales.Location = new System.Drawing.Point(544, 362);
            this.tramosActuales.Name = "tramosActuales";
            this.tramosActuales.Size = new System.Drawing.Size(135, 17);
            this.tramosActuales.TabIndex = 21;
            this.tramosActuales.Text = "Tramos modificados";
            // 
            // vaciarLista
            // 
            this.vaciarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaciarLista.Location = new System.Drawing.Point(435, 228);
            this.vaciarLista.Name = "vaciarLista";
            this.vaciarLista.Size = new System.Drawing.Size(86, 45);
            this.vaciarLista.TabIndex = 22;
            this.vaciarLista.Text = "Vaciar lista de tramos";
            this.vaciarLista.UseVisualStyleBackColor = true;
            this.vaciarLista.Visible = false;
            this.vaciarLista.Click += new System.EventHandler(this.vaciarLista_Click);
            // 
            // agregarTramo
            // 
            this.agregarTramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarTramo.Location = new System.Drawing.Point(435, 308);
            this.agregarTramo.Name = "agregarTramo";
            this.agregarTramo.Size = new System.Drawing.Size(86, 45);
            this.agregarTramo.TabIndex = 23;
            this.agregarTramo.Text = "Agregar tramo";
            this.agregarTramo.UseVisualStyleBackColor = true;
            this.agregarTramo.Visible = false;
            this.agregarTramo.Click += new System.EventHandler(this.agregarTramo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Location = new System.Drawing.Point(816, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 73);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // ModificacionesRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.agregarTramo);
            this.Controls.Add(this.vaciarLista);
            this.Controls.Add(this.tramosActuales);
            this.Controls.Add(this.tramosPrevios);
            this.Controls.Add(this.listViewViejos);
            this.Controls.Add(this.listViewNuevos);
            this.Controls.Add(this.puertoOrigen);
            this.Controls.Add(this.comboBoxPuerto);
            this.Controls.Add(this.dataGridView1);
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
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label puertoOrigen;
        private System.Windows.Forms.ComboBox comboBoxPuerto;
        private System.Windows.Forms.Label tramosActuales;
        private System.Windows.Forms.Label tramosPrevios;
        private System.Windows.Forms.ListView listViewViejos;
        private System.Windows.Forms.ColumnHeader id_2;
        private System.Windows.Forms.ListView listViewNuevos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregarTramo;
        private System.Windows.Forms.Button vaciarLista;
        private System.Windows.Forms.ColumnHeader puerto_origen;
        private System.Windows.Forms.ColumnHeader puerto_destino;
        private System.Windows.Forms.ColumnHeader puerto_origen2;
        private System.Windows.Forms.ColumnHeader puerto_destino2;

    }
}