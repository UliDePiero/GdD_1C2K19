﻿namespace FrbaCrucero.AbmPuerto
{
    partial class ABM_Puerto
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
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.puertos = new System.Windows.Forms.Label();
            this.maestraTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.MaestraTableAdapter();
            this.atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.rESERVAFECHADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maestraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 199);
            this.dataGridView1.TabIndex = 0;
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
            // puertos
            // 
            this.puertos.AutoSize = true;
            this.puertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puertos.Location = new System.Drawing.Point(13, 13);
            this.puertos.Name = "puertos";
            this.puertos.Size = new System.Drawing.Size(108, 31);
            this.puertos.TabIndex = 1;
            this.puertos.Text = "Puertos";
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(291, 210);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 7;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // ABM_Puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.puertos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ABM_Puerto";
            this.Text = "Puertos";
            this.Load += new System.EventHandler(this.ABM_Puerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label puertos;
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
        private System.Windows.Forms.Button atras;
    }
}