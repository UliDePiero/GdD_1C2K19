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
            this.components = new System.ComponentModel.Container();
            this.funciones = new System.Windows.Forms.GroupBox();
            this.bajaMomCrucero = new System.Windows.Forms.Button();
            this.altaCrucero = new System.Windows.Forms.Button();
            this.nuevoCrucero = new System.Windows.Forms.Button();
            this.bajaDefCrucero = new System.Windows.Forms.Button();
            this.modificarCrucero = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.crucerosDisponibles = new System.Windows.Forms.Label();
            this.maestraTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.MaestraTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.funciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // funciones
            // 
            this.funciones.Controls.Add(this.bajaMomCrucero);
            this.funciones.Controls.Add(this.altaCrucero);
            this.funciones.Controls.Add(this.nuevoCrucero);
            this.funciones.Controls.Add(this.bajaDefCrucero);
            this.funciones.Controls.Add(this.modificarCrucero);
            this.funciones.Location = new System.Drawing.Point(18, 330);
            this.funciones.Name = "funciones";
            this.funciones.Size = new System.Drawing.Size(342, 138);
            this.funciones.TabIndex = 12;
            this.funciones.TabStop = false;
            this.funciones.Text = "Funciones";
            // 
            // bajaMomCrucero
            // 
            this.bajaMomCrucero.Location = new System.Drawing.Point(161, 85);
            this.bajaMomCrucero.Name = "bajaMomCrucero";
            this.bajaMomCrucero.Size = new System.Drawing.Size(121, 39);
            this.bajaMomCrucero.TabIndex = 7;
            this.bajaMomCrucero.Text = "Dar de baja momentanea Crucero";
            this.bajaMomCrucero.UseVisualStyleBackColor = true;
            this.bajaMomCrucero.Click += new System.EventHandler(this.bajaMomCrucero_Click);
            // 
            // altaCrucero
            // 
            this.altaCrucero.Location = new System.Drawing.Point(34, 85);
            this.altaCrucero.Name = "altaCrucero";
            this.altaCrucero.Size = new System.Drawing.Size(121, 39);
            this.altaCrucero.TabIndex = 8;
            this.altaCrucero.Text = "Dar de alta Crucero";
            this.altaCrucero.UseVisualStyleBackColor = true;
            this.altaCrucero.Click += new System.EventHandler(this.altaCrucero_Click);
            // 
            // nuevoCrucero
            // 
            this.nuevoCrucero.Location = new System.Drawing.Point(6, 33);
            this.nuevoCrucero.Name = "nuevoCrucero";
            this.nuevoCrucero.Size = new System.Drawing.Size(98, 39);
            this.nuevoCrucero.TabIndex = 7;
            this.nuevoCrucero.Text = "Nuevo Crucero";
            this.nuevoCrucero.UseVisualStyleBackColor = true;
            this.nuevoCrucero.Click += new System.EventHandler(this.nuevoCrucero_Click);
            // 
            // bajaDefCrucero
            // 
            this.bajaDefCrucero.Location = new System.Drawing.Point(214, 33);
            this.bajaDefCrucero.Name = "bajaDefCrucero";
            this.bajaDefCrucero.Size = new System.Drawing.Size(121, 39);
            this.bajaDefCrucero.TabIndex = 7;
            this.bajaDefCrucero.Text = "Dar de baja definitiva Crucero";
            this.bajaDefCrucero.UseVisualStyleBackColor = true;
            this.bajaDefCrucero.Click += new System.EventHandler(this.bajaDefCrucero_Click);
            // 
            // modificarCrucero
            // 
            this.modificarCrucero.Location = new System.Drawing.Point(110, 33);
            this.modificarCrucero.Name = "modificarCrucero";
            this.modificarCrucero.Size = new System.Drawing.Size(98, 39);
            this.modificarCrucero.TabIndex = 7;
            this.modificarCrucero.Text = "Modificar Crucero";
            this.modificarCrucero.UseVisualStyleBackColor = true;
            this.modificarCrucero.Click += new System.EventHandler(this.modificarCrucero_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(598, 415);
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
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(21, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 247);
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
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 363);
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
            this.fecha.Location = new System.Drawing.Point(366, 339);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(47, 17);
            this.fecha.TabIndex = 14;
            this.fecha.Text = "Fecha";
            this.fecha.Visible = false;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(369, 415);
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
            this.cancelar.Location = new System.Drawing.Point(473, 415);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(98, 39);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ABM_Crucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 486);
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
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
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
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD1C2019DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.Button bajaMomCrucero;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button altaCrucero;
    }
}