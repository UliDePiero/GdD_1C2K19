namespace FrbaCrucero.AbmRol
{
    partial class ABM_ROL
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
            this.roles = new System.Windows.Forms.Label();
            this.nuevoRol = new System.Windows.Forms.Button();
            this.modificarRol = new System.Windows.Forms.Button();
            this.habilitar_desRol = new System.Windows.Forms.Button();
            this.mostrar_ocuRol = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.funcionalidades = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roles
            // 
            this.roles.AutoSize = true;
            this.roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roles.Location = new System.Drawing.Point(272, 9);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(133, 39);
            this.roles.TabIndex = 0;
            this.roles.Text = "ROLES";
            // 
            // nuevoRol
            // 
            this.nuevoRol.Location = new System.Drawing.Point(15, 39);
            this.nuevoRol.Name = "nuevoRol";
            this.nuevoRol.Size = new System.Drawing.Size(160, 62);
            this.nuevoRol.TabIndex = 2;
            this.nuevoRol.Text = "Nuevo ROL";
            this.nuevoRol.UseVisualStyleBackColor = true;
            this.nuevoRol.Click += new System.EventHandler(this.nuevoRol_Click);
            // 
            // modificarRol
            // 
            this.modificarRol.Location = new System.Drawing.Point(15, 136);
            this.modificarRol.Name = "modificarRol";
            this.modificarRol.Size = new System.Drawing.Size(160, 62);
            this.modificarRol.TabIndex = 3;
            this.modificarRol.Text = "Modificar ROL";
            this.modificarRol.UseVisualStyleBackColor = true;
            this.modificarRol.Click += new System.EventHandler(this.modificarRol_Click);
            // 
            // habilitar_desRol
            // 
            this.habilitar_desRol.Location = new System.Drawing.Point(15, 242);
            this.habilitar_desRol.Name = "habilitar_desRol";
            this.habilitar_desRol.Size = new System.Drawing.Size(160, 62);
            this.habilitar_desRol.TabIndex = 4;
            this.habilitar_desRol.Text = "Habilitar/Deshabilitar ROL";
            this.habilitar_desRol.UseVisualStyleBackColor = true;
            this.habilitar_desRol.Click += new System.EventHandler(this.habilitar_desRol_Click);
            // 
            // mostrar_ocuRol
            // 
            this.mostrar_ocuRol.Location = new System.Drawing.Point(313, 38);
            this.mostrar_ocuRol.Name = "mostrar_ocuRol";
            this.mostrar_ocuRol.Size = new System.Drawing.Size(105, 47);
            this.mostrar_ocuRol.TabIndex = 5;
            this.mostrar_ocuRol.Text = "Mostrar/Ocultar deshabilitados";
            this.mostrar_ocuRol.UseVisualStyleBackColor = true;
            this.mostrar_ocuRol.Click += new System.EventHandler(this.mostrar_ocuRol_Click);
            // 
            // atras
            // 
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(959, 433);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(123, 65);
            this.atras.TabIndex = 6;
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
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(216, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 327);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(682, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(290, 327);
            this.dataGridView2.TabIndex = 9;
            // 
            // funcionalidades
            // 
            this.funcionalidades.AutoSize = true;
            this.funcionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionalidades.Location = new System.Drawing.Point(707, 9);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(240, 35);
            this.funcionalidades.TabIndex = 0;
            this.funcionalidades.Text = "Funcionalidades";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoRol);
            this.groupBox1.Controls.Add(this.modificarRol);
            this.groupBox1.Controls.Add(this.habilitar_desRol);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 327);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxFiltro);
            this.groupBox2.Controls.Add(this.mostrar_ocuRol);
            this.groupBox2.Location = new System.Drawing.Point(216, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mostrar solo los que tengan la funcionalidad seleccionada";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todas las funcionalidades"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(6, 57);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(280, 28);
            this.comboBoxFiltro.TabIndex = 6;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ABM_ROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.funcionalidades);
            this.Controls.Add(this.roles);
            this.Name = "ABM_ROL";
            this.Text = "ROL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roles;
        private System.Windows.Forms.Button nuevoRol;
        private System.Windows.Forms.Button modificarRol;
        private System.Windows.Forms.Button habilitar_desRol;
        private System.Windows.Forms.Button mostrar_ocuRol;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label funcionalidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;

    }
}