namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificacionesTramo
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
            this.nuevoTramo = new System.Windows.Forms.Label();
            this.modificarTramo = new System.Windows.Forms.Label();
            this.textBoxDuracionRec = new System.Windows.Forms.TextBox();
            this.textBoxPrecioRec = new System.Windows.Forms.TextBox();
            this.duracionRecorrido = new System.Windows.Forms.Label();
            this.precioRecorrido = new System.Windows.Forms.Label();
            this.comboBoxTramoO = new System.Windows.Forms.ComboBox();
            this.tramoOrigen = new System.Windows.Forms.GroupBox();
            this.tramoDestino = new System.Windows.Forms.GroupBox();
            this.comboBoxTramoD = new System.Windows.Forms.ComboBox();
            this.tramoOrigen.SuspendLayout();
            this.tramoDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(437, 85);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 31);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(437, 31);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(95, 31);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // nuevoTramo
            // 
            this.nuevoTramo.AutoSize = true;
            this.nuevoTramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoTramo.Location = new System.Drawing.Point(12, 9);
            this.nuevoTramo.Name = "nuevoTramo";
            this.nuevoTramo.Size = new System.Drawing.Size(178, 31);
            this.nuevoTramo.TabIndex = 7;
            this.nuevoTramo.Text = "Nuevo Tramo";
            // 
            // modificarTramo
            // 
            this.modificarTramo.AutoSize = true;
            this.modificarTramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarTramo.Location = new System.Drawing.Point(12, 9);
            this.modificarTramo.Name = "modificarTramo";
            this.modificarTramo.Size = new System.Drawing.Size(209, 31);
            this.modificarTramo.TabIndex = 10;
            this.modificarTramo.Text = "Modificar Tramo";
            // 
            // textBoxDuracionRec
            // 
            this.textBoxDuracionRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracionRec.Location = new System.Drawing.Point(15, 315);
            this.textBoxDuracionRec.Name = "textBoxDuracionRec";
            this.textBoxDuracionRec.Size = new System.Drawing.Size(389, 23);
            this.textBoxDuracionRec.TabIndex = 13;
            // 
            // textBoxPrecioRec
            // 
            this.textBoxPrecioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioRec.Location = new System.Drawing.Point(15, 249);
            this.textBoxPrecioRec.Name = "textBoxPrecioRec";
            this.textBoxPrecioRec.Size = new System.Drawing.Size(389, 23);
            this.textBoxPrecioRec.TabIndex = 14;
            // 
            // duracionRecorrido
            // 
            this.duracionRecorrido.AutoSize = true;
            this.duracionRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionRecorrido.Location = new System.Drawing.Point(12, 287);
            this.duracionRecorrido.Name = "duracionRecorrido";
            this.duracionRecorrido.Size = new System.Drawing.Size(154, 17);
            this.duracionRecorrido.TabIndex = 11;
            this.duracionRecorrido.Text = "Duracion del Recorrido";
            // 
            // precioRecorrido
            // 
            this.precioRecorrido.AutoSize = true;
            this.precioRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioRecorrido.Location = new System.Drawing.Point(12, 221);
            this.precioRecorrido.Name = "precioRecorrido";
            this.precioRecorrido.Size = new System.Drawing.Size(137, 17);
            this.precioRecorrido.TabIndex = 12;
            this.precioRecorrido.Text = "Precio del Recorrido";
            // 
            // comboBoxTramoO
            // 
            this.comboBoxTramoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTramoO.FormattingEnabled = true;
            this.comboBoxTramoO.Location = new System.Drawing.Point(6, 22);
            this.comboBoxTramoO.Name = "comboBoxTramoO";
            this.comboBoxTramoO.Size = new System.Drawing.Size(386, 33);
            this.comboBoxTramoO.TabIndex = 15;
            // 
            // tramoOrigen
            // 
            this.tramoOrigen.Controls.Add(this.comboBoxTramoO);
            this.tramoOrigen.Location = new System.Drawing.Point(12, 60);
            this.tramoOrigen.Name = "tramoOrigen";
            this.tramoOrigen.Size = new System.Drawing.Size(398, 66);
            this.tramoOrigen.TabIndex = 17;
            this.tramoOrigen.TabStop = false;
            this.tramoOrigen.Text = "Tramo Origen";
            // 
            // tramoDestino
            // 
            this.tramoDestino.Controls.Add(this.comboBoxTramoD);
            this.tramoDestino.Location = new System.Drawing.Point(12, 142);
            this.tramoDestino.Name = "tramoDestino";
            this.tramoDestino.Size = new System.Drawing.Size(398, 66);
            this.tramoDestino.TabIndex = 17;
            this.tramoDestino.TabStop = false;
            this.tramoDestino.Text = "Tramo Destino";
            // 
            // comboBoxTramoD
            // 
            this.comboBoxTramoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTramoD.FormattingEnabled = true;
            this.comboBoxTramoD.Location = new System.Drawing.Point(6, 22);
            this.comboBoxTramoD.Name = "comboBoxTramoD";
            this.comboBoxTramoD.Size = new System.Drawing.Size(386, 33);
            this.comboBoxTramoD.TabIndex = 15;
            // 
            // ModificacionesTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 357);
            this.Controls.Add(this.tramoDestino);
            this.Controls.Add(this.tramoOrigen);
            this.Controls.Add(this.textBoxDuracionRec);
            this.Controls.Add(this.textBoxPrecioRec);
            this.Controls.Add(this.duracionRecorrido);
            this.Controls.Add(this.precioRecorrido);
            this.Controls.Add(this.modificarTramo);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.nuevoTramo);
            this.Name = "ModificacionesTramo";
            this.Text = "Recorridos | Tramos | Modificaciones";
            this.tramoOrigen.ResumeLayout(false);
            this.tramoDestino.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label nuevoTramo;
        private System.Windows.Forms.Label modificarTramo;
        private System.Windows.Forms.TextBox textBoxDuracionRec;
        private System.Windows.Forms.TextBox textBoxPrecioRec;
        private System.Windows.Forms.Label duracionRecorrido;
        private System.Windows.Forms.Label precioRecorrido;
        private System.Windows.Forms.ComboBox comboBoxTramoO;
        private System.Windows.Forms.GroupBox tramoOrigen;
        private System.Windows.Forms.GroupBox tramoDestino;
        private System.Windows.Forms.ComboBox comboBoxTramoD;
    }
}