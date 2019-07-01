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
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.textBoxCrucero = new System.Windows.Forms.TextBox();
            this.identificadorCrucero = new System.Windows.Forms.Label();
            this.nuevoCrucero = new System.Windows.Forms.Label();
            this.modificarCrucero = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.Label();
            this.comboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.tipoDeServicio = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(266, 299);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(128, 53);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Atrás";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(12, 299);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(128, 53);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // textBoxCrucero
            // 
            this.textBoxCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCrucero.Location = new System.Drawing.Point(12, 93);
            this.textBoxCrucero.Name = "textBoxCrucero";
            this.textBoxCrucero.Size = new System.Drawing.Size(382, 23);
            this.textBoxCrucero.TabIndex = 9;
            // 
            // identificadorCrucero
            // 
            this.identificadorCrucero.AutoSize = true;
            this.identificadorCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificadorCrucero.Location = new System.Drawing.Point(9, 64);
            this.identificadorCrucero.Name = "identificadorCrucero";
            this.identificadorCrucero.Size = new System.Drawing.Size(162, 17);
            this.identificadorCrucero.TabIndex = 8;
            this.identificadorCrucero.Text = "Identificador del Crucero";
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
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(9, 128);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(47, 17);
            this.marca.TabIndex = 16;
            this.marca.Text = "Marca";
            // 
            // comboBoxMarcas
            // 
            this.comboBoxMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarcas.FormattingEnabled = true;
            this.comboBoxMarcas.Location = new System.Drawing.Point(12, 148);
            this.comboBoxMarcas.Name = "comboBoxMarcas";
            this.comboBoxMarcas.Size = new System.Drawing.Size(382, 33);
            this.comboBoxMarcas.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(12, 227);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(382, 23);
            this.textBoxModelo.TabIndex = 9;
            // 
            // tipoDeServicio
            // 
            this.tipoDeServicio.AutoSize = true;
            this.tipoDeServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDeServicio.Location = new System.Drawing.Point(407, 64);
            this.tipoDeServicio.Name = "tipoDeServicio";
            this.tipoDeServicio.Size = new System.Drawing.Size(115, 17);
            this.tipoDeServicio.TabIndex = 16;
            this.tipoDeServicio.Text = "Tipo de servicios";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(410, 93);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(353, 259);
            this.checkedListBox1.TabIndex = 20;
            // 
            // ModificacionesCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 370);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBoxMarcas);
            this.Controls.Add(this.tipoDeServicio);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.modificarCrucero);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCrucero);
            this.Controls.Add(this.identificadorCrucero);
            this.Controls.Add(this.nuevoCrucero);
            this.Name = "ModificacionesCrucero";
            this.Text = "Cruceros | Modificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox textBoxCrucero;
        private System.Windows.Forms.Label identificadorCrucero;
        private System.Windows.Forms.Label nuevoCrucero;
        private System.Windows.Forms.Label modificarCrucero;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.ComboBox comboBoxMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label tipoDeServicio;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}