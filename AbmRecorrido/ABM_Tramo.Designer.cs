namespace FrbaCrucero.AbmRecorrido
{
    partial class ABM_Tramo
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
            this.funciones = new System.Windows.Forms.GroupBox();
            this.nuevoTramo = new System.Windows.Forms.Button();
            this.eliminarTramo = new System.Windows.Forms.Button();
            this.modificarTramo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.tramosDisponibles = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.maestraTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.MaestraTableAdapter();
            this.seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.funciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // funciones
            // 
            this.funciones.Controls.Add(this.nuevoTramo);
            this.funciones.Controls.Add(this.eliminarTramo);
            this.funciones.Controls.Add(this.modificarTramo);
            this.funciones.Location = new System.Drawing.Point(18, 330);
            this.funciones.Name = "funciones";
            this.funciones.Size = new System.Drawing.Size(321, 82);
            this.funciones.TabIndex = 12;
            this.funciones.TabStop = false;
            this.funciones.Text = "Funciones";
            // 
            // nuevoTramo
            // 
            this.nuevoTramo.Location = new System.Drawing.Point(6, 33);
            this.nuevoTramo.Name = "nuevoTramo";
            this.nuevoTramo.Size = new System.Drawing.Size(98, 39);
            this.nuevoTramo.TabIndex = 7;
            this.nuevoTramo.Text = "Nuevo Tramo";
            this.nuevoTramo.UseVisualStyleBackColor = true;
            this.nuevoTramo.Click += new System.EventHandler(this.nuevoTramo_Click);
            // 
            // eliminarTramo
            // 
            this.eliminarTramo.Location = new System.Drawing.Point(214, 33);
            this.eliminarTramo.Name = "eliminarTramo";
            this.eliminarTramo.Size = new System.Drawing.Size(98, 39);
            this.eliminarTramo.TabIndex = 7;
            this.eliminarTramo.Text = "Eliminar Tramos";
            this.eliminarTramo.UseVisualStyleBackColor = true;
            // 
            // modificarTramo
            // 
            this.modificarTramo.Location = new System.Drawing.Point(110, 33);
            this.modificarTramo.Name = "modificarTramo";
            this.modificarTramo.Size = new System.Drawing.Size(98, 39);
            this.modificarTramo.TabIndex = 7;
            this.modificarTramo.Text = "Modificar Tramo";
            this.modificarTramo.UseVisualStyleBackColor = true;
            this.modificarTramo.Click += new System.EventHandler(this.modificarTramo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionado});
            this.dataGridView1.Location = new System.Drawing.Point(21, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 247);
            this.dataGridView1.TabIndex = 10;
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
            // tramosDisponibles
            // 
            this.tramosDisponibles.AutoSize = true;
            this.tramosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramosDisponibles.Location = new System.Drawing.Point(12, 9);
            this.tramosDisponibles.Name = "tramosDisponibles";
            this.tramosDisponibles.Size = new System.Drawing.Size(249, 31);
            this.tramosDisponibles.TabIndex = 9;
            this.tramosDisponibles.Text = "Tramos disponibles";
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(448, 363);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 11;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // seleccionado
            // 
            this.seleccionado.HeaderText = "";
            this.seleccionado.Name = "seleccionado";
            this.seleccionado.ReadOnly = true;
            // 
            // ABM_Tramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 427);
            this.Controls.Add(this.funciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tramosDisponibles);
            this.Controls.Add(this.atras);
            this.Name = "ABM_Tramo";
            this.Text = "Recorridos | Tramos";
            this.Load += new System.EventHandler(this.ABM_Tramo_Load);
            this.funciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox funciones;
        private System.Windows.Forms.Button nuevoTramo;
        private System.Windows.Forms.Button eliminarTramo;
        private System.Windows.Forms.Button modificarTramo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tramosDisponibles;
        private System.Windows.Forms.Button atras;
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD1C2019DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionado;
    }
}