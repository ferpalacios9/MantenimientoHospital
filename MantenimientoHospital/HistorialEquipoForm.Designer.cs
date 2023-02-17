namespace MantenimientoHospital
{
    partial class HistorialEquipoForm
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
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.hmNombreEquipo_Tbx = new System.Windows.Forms.TextBox();
            this.nombreMarca_Lbl = new System.Windows.Forms.Label();
            this.numeroSerie_Lbl = new System.Windows.Forms.Label();
            this.nombreEquipo_Lbl = new System.Windows.Forms.Label();
            this.hmNombreMarca_Tbx = new System.Windows.Forms.TextBox();
            this.hmNumeroSerie_Tbx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(144, 38);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 43;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // hmNombreEquipo_Tbx
            // 
            this.hmNombreEquipo_Tbx.Location = new System.Drawing.Point(369, 38);
            this.hmNombreEquipo_Tbx.Name = "hmNombreEquipo_Tbx";
            this.hmNombreEquipo_Tbx.ReadOnly = true;
            this.hmNombreEquipo_Tbx.Size = new System.Drawing.Size(124, 20);
            this.hmNombreEquipo_Tbx.TabIndex = 42;
            // 
            // nombreMarca_Lbl
            // 
            this.nombreMarca_Lbl.AutoSize = true;
            this.nombreMarca_Lbl.Location = new System.Drawing.Point(496, 22);
            this.nombreMarca_Lbl.Name = "nombreMarca_Lbl";
            this.nombreMarca_Lbl.Size = new System.Drawing.Size(92, 13);
            this.nombreMarca_Lbl.TabIndex = 41;
            this.nombreMarca_Lbl.Text = "Nombre de Marca";
            // 
            // numeroSerie_Lbl
            // 
            this.numeroSerie_Lbl.AutoSize = true;
            this.numeroSerie_Lbl.Location = new System.Drawing.Point(20, 24);
            this.numeroSerie_Lbl.Name = "numeroSerie_Lbl";
            this.numeroSerie_Lbl.Size = new System.Drawing.Size(86, 13);
            this.numeroSerie_Lbl.TabIndex = 40;
            this.numeroSerie_Lbl.Text = "Numero de Serie";
            // 
            // nombreEquipo_Lbl
            // 
            this.nombreEquipo_Lbl.AutoSize = true;
            this.nombreEquipo_Lbl.Location = new System.Drawing.Point(366, 22);
            this.nombreEquipo_Lbl.Name = "nombreEquipo_Lbl";
            this.nombreEquipo_Lbl.Size = new System.Drawing.Size(94, 13);
            this.nombreEquipo_Lbl.TabIndex = 39;
            this.nombreEquipo_Lbl.Text = "Nombre de equipo";
            // 
            // hmNombreMarca_Tbx
            // 
            this.hmNombreMarca_Tbx.Location = new System.Drawing.Point(499, 38);
            this.hmNombreMarca_Tbx.Name = "hmNombreMarca_Tbx";
            this.hmNombreMarca_Tbx.ReadOnly = true;
            this.hmNombreMarca_Tbx.Size = new System.Drawing.Size(119, 20);
            this.hmNombreMarca_Tbx.TabIndex = 38;
            // 
            // hmNumeroSerie_Tbx
            // 
            this.hmNumeroSerie_Tbx.Location = new System.Drawing.Point(23, 40);
            this.hmNumeroSerie_Tbx.Name = "hmNumeroSerie_Tbx";
            this.hmNumeroSerie_Tbx.Size = new System.Drawing.Size(100, 20);
            this.hmNumeroSerie_Tbx.TabIndex = 37;
            this.hmNumeroSerie_Tbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hmNumeroSerie_Tbx_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 216);
            this.dataGridView1.TabIndex = 47;
            // 
            // HistorialEquipoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.hmNombreEquipo_Tbx);
            this.Controls.Add(this.nombreMarca_Lbl);
            this.Controls.Add(this.numeroSerie_Lbl);
            this.Controls.Add(this.nombreEquipo_Lbl);
            this.Controls.Add(this.hmNombreMarca_Tbx);
            this.Controls.Add(this.hmNumeroSerie_Tbx);
            this.Name = "HistorialEquipoForm";
            this.Text = "Historial Mantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.TextBox hmNombreEquipo_Tbx;
        private System.Windows.Forms.Label nombreMarca_Lbl;
        private System.Windows.Forms.Label numeroSerie_Lbl;
        private System.Windows.Forms.Label nombreEquipo_Lbl;
        private System.Windows.Forms.TextBox hmNombreMarca_Tbx;
        private System.Windows.Forms.TextBox hmNumeroSerie_Tbx;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}