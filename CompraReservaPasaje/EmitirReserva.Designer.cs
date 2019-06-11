namespace FrbaCrucero.CompraReservaPasaje
{
    partial class EmitirReserva
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
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(89, 164);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(95, 31);
            this.cerrar.TabIndex = 22;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // PagarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cerrar);
            this.Name = "PagarReserva";
            this.Text = "PagarReserva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cerrar;

    }
}