﻿namespace FrbaCrucero.AbmPuerto
{
    partial class ABM_Puerto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2019DataSet = new FrbaCrucero.GD1C2019DataSet();
            this.puertos = new System.Windows.Forms.Label();
            this.maestraTableAdapter = new FrbaCrucero.GD1C2019DataSetTableAdapters.MaestraTableAdapter();
            this.atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 429);
            this.dataGridView1.TabIndex = 0;
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
            // puertos
            // 
            this.puertos.AutoSize = true;
            this.puertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puertos.Location = new System.Drawing.Point(13, 13);
            this.puertos.Name = "puertos";
            this.puertos.Size = new System.Drawing.Size(108, 31);
            this.puertos.TabIndex = 1;
            this.puertos.Text = "Puertos";
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(291, 440);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(98, 39);
            this.atras.TabIndex = 7;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // ABM_Puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 491);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.puertos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ABM_Puerto";
            this.Text = "Puertos";
            this.Load += new System.EventHandler(this.ABM_Puerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2019DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label puertos;
        private GD1C2019DataSet gD1C2019DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD1C2019DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.Button atras;
    }
}