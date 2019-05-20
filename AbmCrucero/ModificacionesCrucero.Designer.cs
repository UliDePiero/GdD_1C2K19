namespace FrbaCrucero.AbmCrucero
{
    partial class ModificacionesCrucero
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
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.textBoxCrucero = new System.Windows.Forms.TextBox();
            this.nombreCrucero = new System.Windows.Forms.Label();
            this.nuevoCrucero = new System.Windows.Forms.Label();
            this.modificarCrucero = new System.Windows.Forms.Label();
            this.fechaAltaCrucero = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.marca = new System.Windows.Forms.Label();
            this.comboBoxModelos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tipoDeServicio = new System.Windows.Forms.Label();
            this.comboBoxTipoServ = new System.Windows.Forms.ComboBox();
            this.cantidadDeCabinas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tipoDeCabinas = new System.Windows.Forms.Label();
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
            this.seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.maestraTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.MaestraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(652, 462);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 31);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(522, 462);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(95, 31);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // textBoxCrucero
            // 
            this.textBoxCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCrucero.Location = new System.Drawing.Point(15, 93);
            this.textBoxCrucero.Name = "textBoxCrucero";
            this.textBoxCrucero.Size = new System.Drawing.Size(382, 23);
            this.textBoxCrucero.TabIndex = 9;
            // 
            // nombreCrucero
            // 
            this.nombreCrucero.AutoSize = true;
            this.nombreCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCrucero.Location = new System.Drawing.Point(12, 65);
            this.nombreCrucero.Name = "nombreCrucero";
            this.nombreCrucero.Size = new System.Drawing.Size(135, 17);
            this.nombreCrucero.TabIndex = 8;
            this.nombreCrucero.Text = "Nombre del Crucero";
            // 
            // nuevoCrucero
            // 
            this.nuevoCrucero.AutoSize = true;
            this.nuevoCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCrucero.Location = new System.Drawing.Point(12, 9);
            this.nuevoCrucero.Name = "nuevoCrucero";
            this.nuevoCrucero.Size = new System.Drawing.Size(197, 31);
            this.nuevoCrucero.TabIndex = 7;
            this.nuevoCrucero.Text = "Nuevo Crucero";
            // 
            // modificarCrucero
            // 
            this.modificarCrucero.AutoSize = true;
            this.modificarCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarCrucero.Location = new System.Drawing.Point(9, 9);
            this.modificarCrucero.Name = "modificarCrucero";
            this.modificarCrucero.Size = new System.Drawing.Size(228, 31);
            this.modificarCrucero.TabIndex = 12;
            this.modificarCrucero.Text = "Modificar Crucero";
            // 
            // fechaAltaCrucero
            // 
            this.fechaAltaCrucero.AutoSize = true;
            this.fechaAltaCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaAltaCrucero.Location = new System.Drawing.Point(412, 65);
            this.fechaAltaCrucero.Name = "fechaAltaCrucero";
            this.fechaAltaCrucero.Size = new System.Drawing.Size(94, 17);
            this.fechaAltaCrucero.TabIndex = 16;
            this.fechaAltaCrucero.Text = "Fecha de alta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(12, 135);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(47, 17);
            this.marca.TabIndex = 16;
            this.marca.Text = "Marca";
            // 
            // comboBoxModelos
            // 
            this.comboBoxModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModelos.FormattingEnabled = true;
            this.comboBoxModelos.Location = new System.Drawing.Point(15, 165);
            this.comboBoxModelos.Name = "comboBoxModelos";
            this.comboBoxModelos.Size = new System.Drawing.Size(382, 33);
            this.comboBoxModelos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(415, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 23);
            this.textBox1.TabIndex = 9;
            // 
            // tipoDeServicio
            // 
            this.tipoDeServicio.AutoSize = true;
            this.tipoDeServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeServicio.Location = new System.Drawing.Point(412, 223);
            this.tipoDeServicio.Name = "tipoDeServicio";
            this.tipoDeServicio.Size = new System.Drawing.Size(108, 17);
            this.tipoDeServicio.TabIndex = 16;
            this.tipoDeServicio.Text = "Tipo de servicio";
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(415, 255);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(332, 33);
            this.comboBoxTipoServ.TabIndex = 17;
            // 
            // cantidadDeCabinas
            // 
            this.cantidadDeCabinas.AutoSize = true;
            this.cantidadDeCabinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadDeCabinas.Location = new System.Drawing.Point(12, 223);
            this.cantidadDeCabinas.Name = "cantidadDeCabinas";
            this.cantidadDeCabinas.Size = new System.Drawing.Size(137, 17);
            this.cantidadDeCabinas.TabIndex = 8;
            this.cantidadDeCabinas.Text = "Cantidad de cabinas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 268);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // tipoDeCabinas
            // 
            this.tipoDeCabinas.AutoSize = true;
            this.tipoDeCabinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeCabinas.Location = new System.Drawing.Point(12, 310);
            this.tipoDeCabinas.Name = "tipoDeCabinas";
            this.tipoDeCabinas.Size = new System.Drawing.Size(109, 17);
            this.tipoDeCabinas.TabIndex = 8;
            this.tipoDeCabinas.Text = "Tipo de cabinas";
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
            this.seleccionado});
            this.dataGridView1.DataSource = this.maestraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(382, 150);
            this.dataGridView1.TabIndex = 19;
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
            // seleccionado
            // 
            this.seleccionado.HeaderText = "";
            this.seleccionado.Name = "seleccionado";
            this.seleccionado.ReadOnly = true;
            // 
            // maestraBindingSource
            // 
            this.maestraBindingSource.DataMember = "Maestra";
            this.maestraBindingSource.DataSource = this.gD1C2019DataSet;
            // 
            // gD1C2019DataSet
            // 
            this.gD1C2019DataSet.DataSetName = "GD1C2019DataSet";
            this.gD1C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // ModificacionesCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxTipoServ);
            this.Controls.Add(this.comboBoxModelos);
            this.Controls.Add(this.tipoDeServicio);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.fechaAltaCrucero);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.modificarCrucero);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tipoDeCabinas);
            this.Controls.Add(this.cantidadDeCabinas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCrucero);
            this.Controls.Add(this.nombreCrucero);
            this.Controls.Add(this.nuevoCrucero);
            this.Name = "ModificacionesCrucero";
            this.Text = "Cruceros | Modificaciones";
            this.Load += new System.EventHandler(this.ModificacionesCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox textBoxCrucero;
        private System.Windows.Forms.Label nombreCrucero;
        private System.Windows.Forms.Label nuevoCrucero;
        private System.Windows.Forms.Label modificarCrucero;
        private System.Windows.Forms.Label fechaAltaCrucero;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.ComboBox comboBoxModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tipoDeServicio;
        private System.Windows.Forms.ComboBox comboBoxTipoServ;
        private System.Windows.Forms.Label cantidadDeCabinas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label tipoDeCabinas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD1C2019DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionado;
    }
}