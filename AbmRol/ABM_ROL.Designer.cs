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
            this.components = new System.ComponentModel.Container();
            this.roles = new System.Windows.Forms.Label();
            this.nuevoRol = new System.Windows.Forms.Button();
            this.modificarRol = new System.Windows.Forms.Button();
            this.habilitar_desRol = new System.Windows.Forms.Button();
            this.mostrar_ocuRol = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.funcionalidades = new System.Windows.Forms.Label();
            this.maestraTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.MaestraTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maestraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource1)).BeginInit();
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
            this.nuevoRol.Location = new System.Drawing.Point(15, 19);
            this.nuevoRol.Name = "nuevoRol";
            this.nuevoRol.Size = new System.Drawing.Size(160, 62);
            this.nuevoRol.TabIndex = 2;
            this.nuevoRol.Text = "Nuevo ROL";
            this.nuevoRol.UseVisualStyleBackColor = true;
            this.nuevoRol.Click += new System.EventHandler(this.nuevoRol_Click);
            // 
            // modificarRol
            // 
            this.modificarRol.Location = new System.Drawing.Point(15, 117);
            this.modificarRol.Name = "modificarRol";
            this.modificarRol.Size = new System.Drawing.Size(160, 62);
            this.modificarRol.TabIndex = 3;
            this.modificarRol.Text = "Modificar ROL";
            this.modificarRol.UseVisualStyleBackColor = true;
            this.modificarRol.Click += new System.EventHandler(this.modificarRol_Click);
            // 
            // habilitar_desRol
            // 
            this.habilitar_desRol.Location = new System.Drawing.Point(15, 215);
            this.habilitar_desRol.Name = "habilitar_desRol";
            this.habilitar_desRol.Size = new System.Drawing.Size(160, 62);
            this.habilitar_desRol.TabIndex = 4;
            this.habilitar_desRol.Text = "Habilitar/Deshabilitar ROL";
            this.habilitar_desRol.UseVisualStyleBackColor = true;
            this.habilitar_desRol.Click += new System.EventHandler(this.habilitar_desRol_Click);
            // 
            // mostrar_ocuRol
            // 
            this.mostrar_ocuRol.Location = new System.Drawing.Point(15, 319);
            this.mostrar_ocuRol.Name = "mostrar_ocuRol";
            this.mostrar_ocuRol.Size = new System.Drawing.Size(160, 62);
            this.mostrar_ocuRol.TabIndex = 5;
            this.mostrar_ocuRol.Text = "Mostrar/Ocultar deshabilitados";
            this.mostrar_ocuRol.UseVisualStyleBackColor = true;
            this.mostrar_ocuRol.Click += new System.EventHandler(this.mostrar_ocuRol_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(978, 354);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
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
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(216, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 327);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevoRol);
            this.groupBox1.Controls.Add(this.modificarRol);
            this.groupBox1.Controls.Add(this.habilitar_desRol);
            this.groupBox1.Controls.Add(this.mostrar_ocuRol);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 389);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // maestraBindingSource1
            // 
            this.maestraBindingSource1.DataMember = "Maestra";
            this.maestraBindingSource1.DataSource = this.gD1C2019DataSet;
            // 
            // ABM_ROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 413);
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
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource1)).EndInit();
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
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD1C2019DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource maestraBindingSource1;

    }
}