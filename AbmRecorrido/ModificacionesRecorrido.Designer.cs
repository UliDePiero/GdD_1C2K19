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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLINOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIAPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIDNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIDIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIFECHANACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASAJECODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASAJEPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASAJEFECHACOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHASALIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHALLEGADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHALLEGADAESTIMADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECORRIDOCODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECORRIDOPRECIOBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTODESDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTOHASTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cABINANRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cABINAPISODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRUCEROMODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRUCEROIDENTIFICADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cABINATIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cABINATIPOPORCRECARGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRUFABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVACODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVAFECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tramosDelRecorrido = new System.Windows.Forms.Label();
            this.duracionRecorrido = new System.Windows.Forms.Label();
            this.textBoxDuracionRec = new System.Windows.Forms.TextBox();
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
            this.textBoxCodigoRec.Size = new System.Drawing.Size(382, 23);
            this.textBoxCodigoRec.TabIndex = 3;
            this.textBoxCodigoRec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.cancelar.Location = new System.Drawing.Point(437, 85);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 31);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(437, 31);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(95, 31);
            this.aceptar.TabIndex = 5;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // precioRecorrido
            // 
            this.precioRecorrido.AutoSize = true;
            this.precioRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioRecorrido.Location = new System.Drawing.Point(9, 130);
            this.precioRecorrido.Name = "precioRecorrido";
            this.precioRecorrido.Size = new System.Drawing.Size(137, 17);
            this.precioRecorrido.TabIndex = 2;
            this.precioRecorrido.Text = "Precio del Recorrido";
            // 
            // textBoxPrecioRec
            // 
            this.textBoxPrecioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioRec.Location = new System.Drawing.Point(12, 158);
            this.textBoxPrecioRec.Name = "textBoxPrecioRec";
            this.textBoxPrecioRec.Size = new System.Drawing.Size(382, 23);
            this.textBoxPrecioRec.TabIndex = 3;
            this.textBoxPrecioRec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProviderCodigo
            // 
            this.errorProviderCodigo.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLINOMBREDataGridViewTextBoxColumn,
            this.cLIAPELLIDODataGridViewTextBoxColumn,
            this.cLIDNIDataGridViewTextBoxColumn,
            this.cLIDIRECCIONDataGridViewTextBoxColumn,
            this.cLITELEFONODataGridViewTextBoxColumn,
            this.cLIMAILDataGridViewTextBoxColumn,
            this.cLIFECHANACDataGridViewTextBoxColumn,
            this.pASAJECODIGODataGridViewTextBoxColumn,
            this.pASAJEPRECIODataGridViewTextBoxColumn,
            this.pASAJEFECHACOMPRADataGridViewTextBoxColumn,
            this.fECHASALIDADataGridViewTextBoxColumn,
            this.fECHALLEGADADataGridViewTextBoxColumn,
            this.fECHALLEGADAESTIMADADataGridViewTextBoxColumn,
            this.rECORRIDOCODIGODataGridViewTextBoxColumn,
            this.rECORRIDOPRECIOBASEDataGridViewTextBoxColumn,
            this.pUERTODESDEDataGridViewTextBoxColumn,
            this.pUERTOHASTADataGridViewTextBoxColumn,
            this.cABINANRODataGridViewTextBoxColumn,
            this.cABINAPISODataGridViewTextBoxColumn,
            this.cRUCEROMODELODataGridViewTextBoxColumn,
            this.cRUCEROIDENTIFICADORDataGridViewTextBoxColumn,
            this.cABINATIPODataGridViewTextBoxColumn,
            this.cABINATIPOPORCRECARGODataGridViewTextBoxColumn,
            this.cRUFABRICANTEDataGridViewTextBoxColumn,
            this.rESERVACODIGODataGridViewTextBoxColumn,
            this.rESERVAFECHADataGridViewTextBoxColumn,
            this.Seleccionado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(520, 189);
            this.dataGridView1.TabIndex = 7;
            // 
            // cLINOMBREDataGridViewTextBoxColumn
            // 
            this.cLINOMBREDataGridViewTextBoxColumn.DataPropertyName = "CLI_NOMBRE";
            this.cLINOMBREDataGridViewTextBoxColumn.HeaderText = "CLI_NOMBRE";
            this.cLINOMBREDataGridViewTextBoxColumn.Name = "cLINOMBREDataGridViewTextBoxColumn";
            this.cLINOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIAPELLIDODataGridViewTextBoxColumn
            // 
            this.cLIAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "CLI_APELLIDO";
            this.cLIAPELLIDODataGridViewTextBoxColumn.HeaderText = "CLI_APELLIDO";
            this.cLIAPELLIDODataGridViewTextBoxColumn.Name = "cLIAPELLIDODataGridViewTextBoxColumn";
            this.cLIAPELLIDODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIDNIDataGridViewTextBoxColumn
            // 
            this.cLIDNIDataGridViewTextBoxColumn.DataPropertyName = "CLI_DNI";
            this.cLIDNIDataGridViewTextBoxColumn.HeaderText = "CLI_DNI";
            this.cLIDNIDataGridViewTextBoxColumn.Name = "cLIDNIDataGridViewTextBoxColumn";
            this.cLIDNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIDIRECCIONDataGridViewTextBoxColumn
            // 
            this.cLIDIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "CLI_DIRECCION";
            this.cLIDIRECCIONDataGridViewTextBoxColumn.HeaderText = "CLI_DIRECCION";
            this.cLIDIRECCIONDataGridViewTextBoxColumn.Name = "cLIDIRECCIONDataGridViewTextBoxColumn";
            this.cLIDIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLITELEFONODataGridViewTextBoxColumn
            // 
            this.cLITELEFONODataGridViewTextBoxColumn.DataPropertyName = "CLI_TELEFONO";
            this.cLITELEFONODataGridViewTextBoxColumn.HeaderText = "CLI_TELEFONO";
            this.cLITELEFONODataGridViewTextBoxColumn.Name = "cLITELEFONODataGridViewTextBoxColumn";
            this.cLITELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIMAILDataGridViewTextBoxColumn
            // 
            this.cLIMAILDataGridViewTextBoxColumn.DataPropertyName = "CLI_MAIL";
            this.cLIMAILDataGridViewTextBoxColumn.HeaderText = "CLI_MAIL";
            this.cLIMAILDataGridViewTextBoxColumn.Name = "cLIMAILDataGridViewTextBoxColumn";
            this.cLIMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIFECHANACDataGridViewTextBoxColumn
            // 
            this.cLIFECHANACDataGridViewTextBoxColumn.DataPropertyName = "CLI_FECHA_NAC";
            this.cLIFECHANACDataGridViewTextBoxColumn.HeaderText = "CLI_FECHA_NAC";
            this.cLIFECHANACDataGridViewTextBoxColumn.Name = "cLIFECHANACDataGridViewTextBoxColumn";
            this.cLIFECHANACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASAJECODIGODataGridViewTextBoxColumn
            // 
            this.pASAJECODIGODataGridViewTextBoxColumn.DataPropertyName = "PASAJE_CODIGO";
            this.pASAJECODIGODataGridViewTextBoxColumn.HeaderText = "PASAJE_CODIGO";
            this.pASAJECODIGODataGridViewTextBoxColumn.Name = "pASAJECODIGODataGridViewTextBoxColumn";
            this.pASAJECODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASAJEPRECIODataGridViewTextBoxColumn
            // 
            this.pASAJEPRECIODataGridViewTextBoxColumn.DataPropertyName = "PASAJE_PRECIO";
            this.pASAJEPRECIODataGridViewTextBoxColumn.HeaderText = "PASAJE_PRECIO";
            this.pASAJEPRECIODataGridViewTextBoxColumn.Name = "pASAJEPRECIODataGridViewTextBoxColumn";
            this.pASAJEPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASAJEFECHACOMPRADataGridViewTextBoxColumn
            // 
            this.pASAJEFECHACOMPRADataGridViewTextBoxColumn.DataPropertyName = "PASAJE_FECHA_COMPRA";
            this.pASAJEFECHACOMPRADataGridViewTextBoxColumn.HeaderText = "PASAJE_FECHA_COMPRA";
            this.pASAJEFECHACOMPRADataGridViewTextBoxColumn.Name = "pASAJEFECHACOMPRADataGridViewTextBoxColumn";
            this.pASAJEFECHACOMPRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHASALIDADataGridViewTextBoxColumn
            // 
            this.fECHASALIDADataGridViewTextBoxColumn.DataPropertyName = "FECHA_SALIDA";
            this.fECHASALIDADataGridViewTextBoxColumn.HeaderText = "FECHA_SALIDA";
            this.fECHASALIDADataGridViewTextBoxColumn.Name = "fECHASALIDADataGridViewTextBoxColumn";
            this.fECHASALIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHALLEGADADataGridViewTextBoxColumn
            // 
            this.fECHALLEGADADataGridViewTextBoxColumn.DataPropertyName = "FECHA_LLEGADA";
            this.fECHALLEGADADataGridViewTextBoxColumn.HeaderText = "FECHA_LLEGADA";
            this.fECHALLEGADADataGridViewTextBoxColumn.Name = "fECHALLEGADADataGridViewTextBoxColumn";
            this.fECHALLEGADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHALLEGADAESTIMADADataGridViewTextBoxColumn
            // 
            this.fECHALLEGADAESTIMADADataGridViewTextBoxColumn.DataPropertyName = "FECHA_LLEGADA_ESTIMADA";
            this.fECHALLEGADAESTIMADADataGridViewTextBoxColumn.HeaderText = "FECHA_LLEGADA_ESTIMADA";
            this.fECHALLEGADAESTIMADADataGridViewTextBoxColumn.Name = "fECHALLEGADAESTIMADADataGridViewTextBoxColumn";
            this.fECHALLEGADAESTIMADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECORRIDOCODIGODataGridViewTextBoxColumn
            // 
            this.rECORRIDOCODIGODataGridViewTextBoxColumn.DataPropertyName = "RECORRIDO_CODIGO";
            this.rECORRIDOCODIGODataGridViewTextBoxColumn.HeaderText = "RECORRIDO_CODIGO";
            this.rECORRIDOCODIGODataGridViewTextBoxColumn.Name = "rECORRIDOCODIGODataGridViewTextBoxColumn";
            this.rECORRIDOCODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECORRIDOPRECIOBASEDataGridViewTextBoxColumn
            // 
            this.rECORRIDOPRECIOBASEDataGridViewTextBoxColumn.DataPropertyName = "RECORRIDO_PRECIO_BASE";
            this.rECORRIDOPRECIOBASEDataGridViewTextBoxColumn.HeaderText = "RECORRIDO_PRECIO_BASE";
            this.rECORRIDOPRECIOBASEDataGridViewTextBoxColumn.Name = "rECORRIDOPRECIOBASEDataGridViewTextBoxColumn";
            this.rECORRIDOPRECIOBASEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUERTODESDEDataGridViewTextBoxColumn
            // 
            this.pUERTODESDEDataGridViewTextBoxColumn.DataPropertyName = "PUERTO_DESDE";
            this.pUERTODESDEDataGridViewTextBoxColumn.HeaderText = "PUERTO_DESDE";
            this.pUERTODESDEDataGridViewTextBoxColumn.Name = "pUERTODESDEDataGridViewTextBoxColumn";
            this.pUERTODESDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUERTOHASTADataGridViewTextBoxColumn
            // 
            this.pUERTOHASTADataGridViewTextBoxColumn.DataPropertyName = "PUERTO_HASTA";
            this.pUERTOHASTADataGridViewTextBoxColumn.HeaderText = "PUERTO_HASTA";
            this.pUERTOHASTADataGridViewTextBoxColumn.Name = "pUERTOHASTADataGridViewTextBoxColumn";
            this.pUERTOHASTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cABINANRODataGridViewTextBoxColumn
            // 
            this.cABINANRODataGridViewTextBoxColumn.DataPropertyName = "CABINA_NRO";
            this.cABINANRODataGridViewTextBoxColumn.HeaderText = "CABINA_NRO";
            this.cABINANRODataGridViewTextBoxColumn.Name = "cABINANRODataGridViewTextBoxColumn";
            this.cABINANRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cABINAPISODataGridViewTextBoxColumn
            // 
            this.cABINAPISODataGridViewTextBoxColumn.DataPropertyName = "CABINA_PISO";
            this.cABINAPISODataGridViewTextBoxColumn.HeaderText = "CABINA_PISO";
            this.cABINAPISODataGridViewTextBoxColumn.Name = "cABINAPISODataGridViewTextBoxColumn";
            this.cABINAPISODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRUCEROMODELODataGridViewTextBoxColumn
            // 
            this.cRUCEROMODELODataGridViewTextBoxColumn.DataPropertyName = "CRUCERO_MODELO";
            this.cRUCEROMODELODataGridViewTextBoxColumn.HeaderText = "CRUCERO_MODELO";
            this.cRUCEROMODELODataGridViewTextBoxColumn.Name = "cRUCEROMODELODataGridViewTextBoxColumn";
            this.cRUCEROMODELODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRUCEROIDENTIFICADORDataGridViewTextBoxColumn
            // 
            this.cRUCEROIDENTIFICADORDataGridViewTextBoxColumn.DataPropertyName = "CRUCERO_IDENTIFICADOR";
            this.cRUCEROIDENTIFICADORDataGridViewTextBoxColumn.HeaderText = "CRUCERO_IDENTIFICADOR";
            this.cRUCEROIDENTIFICADORDataGridViewTextBoxColumn.Name = "cRUCEROIDENTIFICADORDataGridViewTextBoxColumn";
            this.cRUCEROIDENTIFICADORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cABINATIPODataGridViewTextBoxColumn
            // 
            this.cABINATIPODataGridViewTextBoxColumn.DataPropertyName = "CABINA_TIPO";
            this.cABINATIPODataGridViewTextBoxColumn.HeaderText = "CABINA_TIPO";
            this.cABINATIPODataGridViewTextBoxColumn.Name = "cABINATIPODataGridViewTextBoxColumn";
            this.cABINATIPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cABINATIPOPORCRECARGODataGridViewTextBoxColumn
            // 
            this.cABINATIPOPORCRECARGODataGridViewTextBoxColumn.DataPropertyName = "CABINA_TIPO_PORC_RECARGO";
            this.cABINATIPOPORCRECARGODataGridViewTextBoxColumn.HeaderText = "CABINA_TIPO_PORC_RECARGO";
            this.cABINATIPOPORCRECARGODataGridViewTextBoxColumn.Name = "cABINATIPOPORCRECARGODataGridViewTextBoxColumn";
            this.cABINATIPOPORCRECARGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRUFABRICANTEDataGridViewTextBoxColumn
            // 
            this.cRUFABRICANTEDataGridViewTextBoxColumn.DataPropertyName = "CRU_FABRICANTE";
            this.cRUFABRICANTEDataGridViewTextBoxColumn.HeaderText = "CRU_FABRICANTE";
            this.cRUFABRICANTEDataGridViewTextBoxColumn.Name = "cRUFABRICANTEDataGridViewTextBoxColumn";
            this.cRUFABRICANTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rESERVACODIGODataGridViewTextBoxColumn
            // 
            this.rESERVACODIGODataGridViewTextBoxColumn.DataPropertyName = "RESERVA_CODIGO";
            this.rESERVACODIGODataGridViewTextBoxColumn.HeaderText = "RESERVA_CODIGO";
            this.rESERVACODIGODataGridViewTextBoxColumn.Name = "rESERVACODIGODataGridViewTextBoxColumn";
            this.rESERVACODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rESERVAFECHADataGridViewTextBoxColumn
            // 
            this.rESERVAFECHADataGridViewTextBoxColumn.DataPropertyName = "RESERVA_FECHA";
            this.rESERVAFECHADataGridViewTextBoxColumn.HeaderText = "RESERVA_FECHA";
            this.rESERVAFECHADataGridViewTextBoxColumn.Name = "rESERVAFECHADataGridViewTextBoxColumn";
            this.rESERVAFECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Seleccionado
            // 
            this.Seleccionado.HeaderText = "";
            this.Seleccionado.Name = "Seleccionado";
            this.Seleccionado.ReadOnly = true;
            // 
            // tramosDelRecorrido
            // 
            this.tramosDelRecorrido.AutoSize = true;
            this.tramosDelRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramosDelRecorrido.Location = new System.Drawing.Point(9, 260);
            this.tramosDelRecorrido.Name = "tramosDelRecorrido";
            this.tramosDelRecorrido.Size = new System.Drawing.Size(145, 17);
            this.tramosDelRecorrido.TabIndex = 2;
            this.tramosDelRecorrido.Text = "Tramos del Recorrido";
            // 
            // duracionRecorrido
            // 
            this.duracionRecorrido.AutoSize = true;
            this.duracionRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionRecorrido.Location = new System.Drawing.Point(9, 196);
            this.duracionRecorrido.Name = "duracionRecorrido";
            this.duracionRecorrido.Size = new System.Drawing.Size(154, 17);
            this.duracionRecorrido.TabIndex = 2;
            this.duracionRecorrido.Text = "Duracion del Recorrido";
            // 
            // textBoxDuracionRec
            // 
            this.textBoxDuracionRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracionRec.Location = new System.Drawing.Point(12, 224);
            this.textBoxDuracionRec.Name = "textBoxDuracionRec";
            this.textBoxDuracionRec.Size = new System.Drawing.Size(382, 23);
            this.textBoxDuracionRec.TabIndex = 3;
            this.textBoxDuracionRec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ModificacionesRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 481);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIFECHANACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASAJECODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASAJEPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASAJEFECHACOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHASALIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHALLEGADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHALLEGADAESTIMADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECORRIDOCODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECORRIDOPRECIOBASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTODESDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTOHASTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cABINANRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cABINAPISODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRUCEROMODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRUCEROIDENTIFICADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cABINATIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cABINATIPOPORCRECARGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRUFABRICANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESERVACODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESERVAFECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label tramosDelRecorrido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionado;
        private System.Windows.Forms.TextBox textBoxDuracionRec;
        private System.Windows.Forms.Label duracionRecorrido;

    }
}