namespace FrbaCrucero
{
    partial class INICIO
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
            this.seleccionROL = new System.Windows.Forms.GroupBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compraReserva = new System.Windows.Forms.Button();
            this.pagoReserva = new System.Windows.Forms.Button();
            this.seleccionROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seleccionROL
            // 
            this.seleccionROL.Controls.Add(this.ingresar);
            this.seleccionROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionROL.Location = new System.Drawing.Point(407, 382);
            this.seleccionROL.Name = "seleccionROL";
            this.seleccionROL.Size = new System.Drawing.Size(189, 93);
            this.seleccionROL.TabIndex = 0;
            this.seleccionROL.TabStop = false;
            this.seleccionROL.Text = "Administrador";
            // 
            // ingresar
            // 
            this.ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.Location = new System.Drawing.Point(6, 32);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(177, 55);
            this.ingresar.TabIndex = 1;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "FRBA - CRUCERO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::FrbaCrucero.Properties.Resources.INICIO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 313);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pagoReserva);
            this.groupBox1.Controls.Add(this.compraReserva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // compraReserva
            // 
            this.compraReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraReserva.Location = new System.Drawing.Point(6, 32);
            this.compraReserva.Name = "compraReserva";
            this.compraReserva.Size = new System.Drawing.Size(198, 55);
            this.compraReserva.TabIndex = 1;
            this.compraReserva.Text = "Comprar o Reservar pasaje";
            this.compraReserva.UseVisualStyleBackColor = true;
            this.compraReserva.Click += new System.EventHandler(this.compraReserva_Click);
            // 
            // pagoReserva
            // 
            this.pagoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoReserva.Location = new System.Drawing.Point(210, 32);
            this.pagoReserva.Name = "pagoReserva";
            this.pagoReserva.Size = new System.Drawing.Size(173, 55);
            this.pagoReserva.TabIndex = 2;
            this.pagoReserva.Text = "Pagar reserva de pasaje";
            this.pagoReserva.UseVisualStyleBackColor = true;
            this.pagoReserva.Click += new System.EventHandler(this.pagoReserva_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionROL);
            this.Name = "INICIO";
            this.Text = "FRBA - CRUCERO";
            this.seleccionROL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox seleccionROL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pagoReserva;
        private System.Windows.Forms.Button compraReserva;
    }
}