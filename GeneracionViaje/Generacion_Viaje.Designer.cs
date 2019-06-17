namespace FrbaCrucero.GeneracionViaje
{
    partial class Generacion_Viaje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recorridosDisponibles = new System.Windows.Forms.Label();
            this.crucerosDisponibles = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.generarViaje = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.fechaFinalizacion = new System.Windows.Forms.Label();
            this.textBoxFinalizacion = new System.Windows.Forms.TextBox();
            this.Tiempos = new System.Windows.Forms.DataGridView();
            this.RecorridosInvalidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecorridosInvalidos)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 304);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(16, 432);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(700, 304);
            this.dataGridView2.TabIndex = 11;
            // 
            // recorridosDisponibles
            // 
            this.recorridosDisponibles.AutoSize = true;
            this.recorridosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recorridosDisponibles.Location = new System.Drawing.Point(8, 390);
            this.recorridosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recorridosDisponibles.Name = "recorridosDisponibles";
            this.recorridosDisponibles.Size = new System.Drawing.Size(363, 39);
            this.recorridosDisponibles.TabIndex = 13;
            this.recorridosDisponibles.Text = "Recorridos disponibles";
            // 
            // crucerosDisponibles
            // 
            this.crucerosDisponibles.AutoSize = true;
            this.crucerosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crucerosDisponibles.Location = new System.Drawing.Point(8, 16);
            this.crucerosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crucerosDisponibles.Name = "crucerosDisponibles";
            this.crucerosDisponibles.Size = new System.Drawing.Size(336, 39);
            this.crucerosDisponibles.TabIndex = 14;
            this.crucerosDisponibles.Text = "Cruceros disponibles";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(724, 473);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // generarViaje
            // 
            this.generarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarViaje.Location = new System.Drawing.Point(724, 596);
            this.generarViaje.Margin = new System.Windows.Forms.Padding(4);
            this.generarViaje.Name = "generarViaje";
            this.generarViaje.Size = new System.Drawing.Size(269, 65);
            this.generarViaje.TabIndex = 26;
            this.generarViaje.Text = "Generar Viaje";
            this.generarViaje.UseVisualStyleBackColor = true;
            this.generarViaje.Click += new System.EventHandler(this.generarViaje_Click);
            // 
            // atras
            // 
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(860, 684);
            this.atras.Margin = new System.Windows.Forms.Padding(4);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(133, 52);
            this.atras.TabIndex = 27;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.Location = new System.Drawing.Point(724, 448);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(122, 20);
            this.fechaInicio.TabIndex = 28;
            this.fechaInicio.Text = "Fecha de inicio";
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.AutoSize = true;
            this.fechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinalizacion.Location = new System.Drawing.Point(724, 517);
            this.fechaFinalizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.Size = new System.Drawing.Size(167, 20);
            this.fechaFinalizacion.TabIndex = 29;
            this.fechaFinalizacion.Text = "Fecha de finalizacion";
            // 
            // textBoxFinalizacion
            // 
            this.textBoxFinalizacion.Location = new System.Drawing.Point(724, 553);
            this.textBoxFinalizacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFinalizacion.Name = "textBoxFinalizacion";
            this.textBoxFinalizacion.ReadOnly = true;
            this.textBoxFinalizacion.Size = new System.Drawing.Size(268, 22);
            this.textBoxFinalizacion.TabIndex = 30;
            // 
            // Tiempos
            // 
            this.Tiempos.AllowUserToAddRows = false;
            this.Tiempos.AllowUserToDeleteRows = false;
            this.Tiempos.AllowUserToResizeColumns = false;
            this.Tiempos.AllowUserToResizeRows = false;
            this.Tiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tiempos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tiempos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Tiempos.Enabled = false;
            this.Tiempos.Location = new System.Drawing.Point(723, 713);
            this.Tiempos.Margin = new System.Windows.Forms.Padding(4);
            this.Tiempos.Name = "Tiempos";
            this.Tiempos.ReadOnly = true;
            this.Tiempos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tiempos.Size = new System.Drawing.Size(29, 11);
            this.Tiempos.TabIndex = 32;
            this.Tiempos.Visible = false;
            // 
            // RecorridosInvalidos
            // 
            this.RecorridosInvalidos.AllowUserToAddRows = false;
            this.RecorridosInvalidos.AllowUserToDeleteRows = false;
            this.RecorridosInvalidos.AllowUserToResizeColumns = false;
            this.RecorridosInvalidos.AllowUserToResizeRows = false;
            this.RecorridosInvalidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecorridosInvalidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecorridosInvalidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.RecorridosInvalidos.Enabled = false;
            this.RecorridosInvalidos.Location = new System.Drawing.Point(724, 732);
            this.RecorridosInvalidos.Margin = new System.Windows.Forms.Padding(4);
            this.RecorridosInvalidos.Name = "RecorridosInvalidos";
            this.RecorridosInvalidos.ReadOnly = true;
            this.RecorridosInvalidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecorridosInvalidos.Size = new System.Drawing.Size(28, 12);
            this.RecorridosInvalidos.TabIndex = 33;
            this.RecorridosInvalidos.Visible = false;
            // 
            // Generacion_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 757);
            this.Controls.Add(this.RecorridosInvalidos);
            this.Controls.Add(this.Tiempos);
            this.Controls.Add(this.textBoxFinalizacion);
            this.Controls.Add(this.fechaFinalizacion);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.generarViaje);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.crucerosDisponibles);
            this.Controls.Add(this.recorridosDisponibles);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Generacion_Viaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.Generacion_Viaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecorridosInvalidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label recorridosDisponibles;
        private System.Windows.Forms.Label crucerosDisponibles;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button generarViaje;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label fechaFinalizacion;
        private System.Windows.Forms.TextBox textBoxFinalizacion;
        private System.Windows.Forms.DataGridView Tiempos;
        private System.Windows.Forms.DataGridView RecorridosInvalidos;
    }
}