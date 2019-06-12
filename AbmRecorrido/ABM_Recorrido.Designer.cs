namespace FrbaCrucero.AbmRecorrido
{
    partial class ABM_Recorrido
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
            this.recorridosDisponibles = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atras = new System.Windows.Forms.Button();
            this.nuevoRecorrido = new System.Windows.Forms.Button();
            this.modificarRecorrido = new System.Windows.Forms.Button();
            this.eliminarRecorridos = new System.Windows.Forms.Button();
            this.funciones = new System.Windows.Forms.GroupBox();
            this.editarTramos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.funciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // recorridosDisponibles
            // 
            this.recorridosDisponibles.AutoSize = true;
            this.recorridosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recorridosDisponibles.Location = new System.Drawing.Point(3, 9);
            this.recorridosDisponibles.Name = "recorridosDisponibles";
            this.recorridosDisponibles.Size = new System.Drawing.Size(289, 31);
            this.recorridosDisponibles.TabIndex = 0;
            this.recorridosDisponibles.Text = "Recorridos disponibles";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(439, 363);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 7;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // nuevoRecorrido
            // 
            this.nuevoRecorrido.Location = new System.Drawing.Point(6, 33);
            this.nuevoRecorrido.Name = "nuevoRecorrido";
            this.nuevoRecorrido.Size = new System.Drawing.Size(98, 39);
            this.nuevoRecorrido.TabIndex = 7;
            this.nuevoRecorrido.Text = "Nuevo Recorrido";
            this.nuevoRecorrido.UseVisualStyleBackColor = true;
            this.nuevoRecorrido.Click += new System.EventHandler(this.nuevoRecorrido_Click);
            // 
            // modificarRecorrido
            // 
            this.modificarRecorrido.Location = new System.Drawing.Point(110, 33);
            this.modificarRecorrido.Name = "modificarRecorrido";
            this.modificarRecorrido.Size = new System.Drawing.Size(98, 39);
            this.modificarRecorrido.TabIndex = 7;
            this.modificarRecorrido.Text = "Modificar Recorrido";
            this.modificarRecorrido.UseVisualStyleBackColor = true;
            this.modificarRecorrido.Click += new System.EventHandler(this.modificarRecorrido_Click);
            // 
            // eliminarRecorridos
            // 
            this.eliminarRecorridos.Location = new System.Drawing.Point(214, 33);
            this.eliminarRecorridos.Name = "eliminarRecorridos";
            this.eliminarRecorridos.Size = new System.Drawing.Size(98, 39);
            this.eliminarRecorridos.TabIndex = 7;
            this.eliminarRecorridos.Text = "Eliminar Recorridos";
            this.eliminarRecorridos.UseVisualStyleBackColor = true;
            // 
            // funciones
            // 
            this.funciones.Controls.Add(this.nuevoRecorrido);
            this.funciones.Controls.Add(this.editarTramos);
            this.funciones.Controls.Add(this.eliminarRecorridos);
            this.funciones.Controls.Add(this.modificarRecorrido);
            this.funciones.Location = new System.Drawing.Point(9, 330);
            this.funciones.Name = "funciones";
            this.funciones.Size = new System.Drawing.Size(424, 82);
            this.funciones.TabIndex = 8;
            this.funciones.TabStop = false;
            this.funciones.Text = "Funciones";
            // 
            // editarTramos
            // 
            this.editarTramos.Location = new System.Drawing.Point(318, 33);
            this.editarTramos.Name = "editarTramos";
            this.editarTramos.Size = new System.Drawing.Size(98, 39);
            this.editarTramos.TabIndex = 7;
            this.editarTramos.Text = "Editar Tramos";
            this.editarTramos.UseVisualStyleBackColor = true;
            this.editarTramos.Click += new System.EventHandler(this.editarTramos_Click);
            // 
            // ABM_Recorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 424);
            this.Controls.Add(this.funciones);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.recorridosDisponibles);
            this.Name = "ABM_Recorrido";
            this.RightToLeftLayout = true;
            this.Text = "Recorridos";
            this.Load += new System.EventHandler(this.ABM_Recorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.funciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recorridosDisponibles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button nuevoRecorrido;
        private System.Windows.Forms.Button modificarRecorrido;
        private System.Windows.Forms.Button eliminarRecorridos;
        private System.Windows.Forms.GroupBox funciones;
        private System.Windows.Forms.Button editarTramos;
    }
}