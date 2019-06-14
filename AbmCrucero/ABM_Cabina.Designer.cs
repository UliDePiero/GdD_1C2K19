namespace FrbaCrucero.AbmCrucero
{
    partial class ABM_Cabina
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
            this.piso = new System.Windows.Forms.Label();
            this.numericUpDownPiso = new System.Windows.Forms.NumericUpDown();
            this.sacarCabina = new System.Windows.Forms.Button();
            this.agregarCabina = new System.Windows.Forms.Button();
            this.comboBoxCabinas = new System.Windows.Forms.ComboBox();
            this.tipoDeCabina = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.Label();
            this.numericUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cabinas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // piso
            // 
            this.piso.AutoSize = true;
            this.piso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piso.Location = new System.Drawing.Point(169, 403);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(35, 17);
            this.piso.TabIndex = 36;
            this.piso.Text = "Piso";
            // 
            // numericUpDownPiso
            // 
            this.numericUpDownPiso.Location = new System.Drawing.Point(172, 423);
            this.numericUpDownPiso.Name = "numericUpDownPiso";
            this.numericUpDownPiso.Size = new System.Drawing.Size(128, 20);
            this.numericUpDownPiso.TabIndex = 35;
            // 
            // sacarCabina
            // 
            this.sacarCabina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sacarCabina.Location = new System.Drawing.Point(172, 457);
            this.sacarCabina.Name = "sacarCabina";
            this.sacarCabina.Size = new System.Drawing.Size(128, 36);
            this.sacarCabina.TabIndex = 34;
            this.sacarCabina.Text = "Sacar cabina";
            this.sacarCabina.UseVisualStyleBackColor = true;
            this.sacarCabina.Click += new System.EventHandler(this.sacarCabina_Click);
            // 
            // agregarCabina
            // 
            this.agregarCabina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCabina.Location = new System.Drawing.Point(12, 457);
            this.agregarCabina.Name = "agregarCabina";
            this.agregarCabina.Size = new System.Drawing.Size(128, 36);
            this.agregarCabina.TabIndex = 33;
            this.agregarCabina.Text = "Agregar cabina";
            this.agregarCabina.UseVisualStyleBackColor = true;
            this.agregarCabina.Click += new System.EventHandler(this.agregarCabina_Click);
            // 
            // comboBoxCabinas
            // 
            this.comboBoxCabinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCabinas.FormattingEnabled = true;
            this.comboBoxCabinas.Location = new System.Drawing.Point(12, 351);
            this.comboBoxCabinas.Name = "comboBoxCabinas";
            this.comboBoxCabinas.Size = new System.Drawing.Size(382, 33);
            this.comboBoxCabinas.TabIndex = 32;
            // 
            // tipoDeCabina
            // 
            this.tipoDeCabina.AutoSize = true;
            this.tipoDeCabina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeCabina.Location = new System.Drawing.Point(12, 331);
            this.tipoDeCabina.Name = "tipoDeCabina";
            this.tipoDeCabina.Size = new System.Drawing.Size(102, 17);
            this.tipoDeCabina.TabIndex = 31;
            this.tipoDeCabina.Text = "Tipo de cabina";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(403, 440);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(128, 53);
            this.cancelar.TabIndex = 38;
            this.cancelar.Text = "Atrás";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(9, 403);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(58, 17);
            this.numero.TabIndex = 40;
            this.numero.Text = "Numero";
            // 
            // numericUpDownNumero
            // 
            this.numericUpDownNumero.Location = new System.Drawing.Point(12, 423);
            this.numericUpDownNumero.Name = "numericUpDownNumero";
            this.numericUpDownNumero.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumero.TabIndex = 39;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(519, 285);
            this.dataGridView1.TabIndex = 41;
            // 
            // cabinas
            // 
            this.cabinas.AutoSize = true;
            this.cabinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinas.Location = new System.Drawing.Point(12, 9);
            this.cabinas.Name = "cabinas";
            this.cabinas.Size = new System.Drawing.Size(114, 31);
            this.cabinas.TabIndex = 42;
            this.cabinas.Text = "Cabinas";
            // 
            // ABM_Cabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 505);
            this.Controls.Add(this.cabinas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.numericUpDownNumero);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.numericUpDownPiso);
            this.Controls.Add(this.sacarCabina);
            this.Controls.Add(this.agregarCabina);
            this.Controls.Add(this.comboBoxCabinas);
            this.Controls.Add(this.tipoDeCabina);
            this.Name = "ABM_Cabina";
            this.Text = "ABM_Cabina";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label piso;
        private System.Windows.Forms.NumericUpDown numericUpDownPiso;
        private System.Windows.Forms.Button sacarCabina;
        private System.Windows.Forms.Button agregarCabina;
        private System.Windows.Forms.ComboBox comboBoxCabinas;
        private System.Windows.Forms.Label tipoDeCabina;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.NumericUpDown numericUpDownNumero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cabinas;
    }
}