namespace MantenimientoHospital
{
    partial class AltaEquipoForm
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
            this.fecha_Lbl = new System.Windows.Forms.Label();
            this.diaAlta_Lbl = new System.Windows.Forms.Label();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.borrar_Btn = new System.Windows.Forms.Button();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.estadoEquipo_Lbl = new System.Windows.Forms.Label();
            this.estadoEquipo_Cbx = new System.Windows.Forms.ComboBox();
            this.fechaAlta_Lbl = new System.Windows.Forms.Label();
            this.nombreMarca_Lbl = new System.Windows.Forms.Label();
            this.numeroSerie_Lbl = new System.Windows.Forms.Label();
            this.fechaAlta_MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.nombreEquipo_Cbx = new System.Windows.Forms.ComboBox();
            this.nombreEquipo_Lbl = new System.Windows.Forms.Label();
            this.nombreMarca_Tbx = new System.Windows.Forms.TextBox();
            this.numeroSerie_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fecha_Lbl
            // 
            this.fecha_Lbl.AutoSize = true;
            this.fecha_Lbl.Location = new System.Drawing.Point(240, 229);
            this.fecha_Lbl.Name = "fecha_Lbl";
            this.fecha_Lbl.Size = new System.Drawing.Size(108, 13);
            this.fecha_Lbl.TabIndex = 58;
            this.fecha_Lbl.Text = "Fecha Seleccionada:";
            // 
            // diaAlta_Lbl
            // 
            this.diaAlta_Lbl.Location = new System.Drawing.Point(352, 229);
            this.diaAlta_Lbl.Name = "diaAlta_Lbl";
            this.diaAlta_Lbl.Size = new System.Drawing.Size(139, 13);
            this.diaAlta_Lbl.TabIndex = 57;
            this.diaAlta_Lbl.Text = "---";
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(127, 50);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 56;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // borrar_Btn
            // 
            this.borrar_Btn.Location = new System.Drawing.Point(243, 260);
            this.borrar_Btn.Name = "borrar_Btn";
            this.borrar_Btn.Size = new System.Drawing.Size(75, 23);
            this.borrar_Btn.TabIndex = 55;
            this.borrar_Btn.Text = "Borrar";
            this.borrar_Btn.UseVisualStyleBackColor = true;
            this.borrar_Btn.Click += new System.EventHandler(this.borrar_Btn_Click);
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.Location = new System.Drawing.Point(416, 260);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(75, 23);
            this.guardar_Btn.TabIndex = 54;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = true;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // estadoEquipo_Lbl
            // 
            this.estadoEquipo_Lbl.AutoSize = true;
            this.estadoEquipo_Lbl.Location = new System.Drawing.Point(18, 202);
            this.estadoEquipo_Lbl.Name = "estadoEquipo_Lbl";
            this.estadoEquipo_Lbl.Size = new System.Drawing.Size(91, 13);
            this.estadoEquipo_Lbl.TabIndex = 53;
            this.estadoEquipo_Lbl.Text = "Estado de Equipo";
            // 
            // estadoEquipo_Cbx
            // 
            this.estadoEquipo_Cbx.FormattingEnabled = true;
            this.estadoEquipo_Cbx.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.estadoEquipo_Cbx.Location = new System.Drawing.Point(21, 226);
            this.estadoEquipo_Cbx.Name = "estadoEquipo_Cbx";
            this.estadoEquipo_Cbx.Size = new System.Drawing.Size(121, 21);
            this.estadoEquipo_Cbx.TabIndex = 52;
            // 
            // fechaAlta_Lbl
            // 
            this.fechaAlta_Lbl.AutoSize = true;
            this.fechaAlta_Lbl.Location = new System.Drawing.Point(240, 23);
            this.fechaAlta_Lbl.Name = "fechaAlta_Lbl";
            this.fechaAlta_Lbl.Size = new System.Drawing.Size(73, 13);
            this.fechaAlta_Lbl.TabIndex = 51;
            this.fechaAlta_Lbl.Text = "Fecha de Alta";
            // 
            // nombreMarca_Lbl
            // 
            this.nombreMarca_Lbl.AutoSize = true;
            this.nombreMarca_Lbl.Location = new System.Drawing.Point(18, 147);
            this.nombreMarca_Lbl.Name = "nombreMarca_Lbl";
            this.nombreMarca_Lbl.Size = new System.Drawing.Size(92, 13);
            this.nombreMarca_Lbl.TabIndex = 50;
            this.nombreMarca_Lbl.Text = "Nombre de Marca";
            // 
            // numeroSerie_Lbl
            // 
            this.numeroSerie_Lbl.AutoSize = true;
            this.numeroSerie_Lbl.Location = new System.Drawing.Point(18, 28);
            this.numeroSerie_Lbl.Name = "numeroSerie_Lbl";
            this.numeroSerie_Lbl.Size = new System.Drawing.Size(86, 13);
            this.numeroSerie_Lbl.TabIndex = 49;
            this.numeroSerie_Lbl.Text = "Numero de Serie";
            // 
            // fechaAlta_MonthCalendar
            // 
            this.fechaAlta_MonthCalendar.Location = new System.Drawing.Point(243, 52);
            this.fechaAlta_MonthCalendar.MaxSelectionCount = 1;
            this.fechaAlta_MonthCalendar.Name = "fechaAlta_MonthCalendar";
            this.fechaAlta_MonthCalendar.TabIndex = 48;
            this.fechaAlta_MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.fechaAlta_MonthCalendar_DateSelected);
            // 
            // nombreEquipo_Cbx
            // 
            this.nombreEquipo_Cbx.FormattingEnabled = true;
            this.nombreEquipo_Cbx.Items.AddRange(new object[] {
            "Monitor Signos Vitales",
            "Electroencefalografo",
            "Electrocardiografo",
            "Maquina Anestesia",
            "Ultrasonido",
            "Desfibrilador",
            "Esterilizador"});
            this.nombreEquipo_Cbx.Location = new System.Drawing.Point(21, 115);
            this.nombreEquipo_Cbx.Name = "nombreEquipo_Cbx";
            this.nombreEquipo_Cbx.Size = new System.Drawing.Size(129, 21);
            this.nombreEquipo_Cbx.TabIndex = 47;
            // 
            // nombreEquipo_Lbl
            // 
            this.nombreEquipo_Lbl.AutoSize = true;
            this.nombreEquipo_Lbl.Location = new System.Drawing.Point(18, 91);
            this.nombreEquipo_Lbl.Name = "nombreEquipo_Lbl";
            this.nombreEquipo_Lbl.Size = new System.Drawing.Size(94, 13);
            this.nombreEquipo_Lbl.TabIndex = 46;
            this.nombreEquipo_Lbl.Text = "Nombre de equipo";
            // 
            // nombreMarca_Tbx
            // 
            this.nombreMarca_Tbx.Location = new System.Drawing.Point(21, 171);
            this.nombreMarca_Tbx.Name = "nombreMarca_Tbx";
            this.nombreMarca_Tbx.Size = new System.Drawing.Size(100, 20);
            this.nombreMarca_Tbx.TabIndex = 45;
            // 
            // numeroSerie_Tbx
            // 
            this.numeroSerie_Tbx.Location = new System.Drawing.Point(21, 52);
            this.numeroSerie_Tbx.Name = "numeroSerie_Tbx";
            this.numeroSerie_Tbx.Size = new System.Drawing.Size(100, 20);
            this.numeroSerie_Tbx.TabIndex = 44;
            // 
            // AltaEquipoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 296);
            this.Controls.Add(this.fecha_Lbl);
            this.Controls.Add(this.diaAlta_Lbl);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.borrar_Btn);
            this.Controls.Add(this.guardar_Btn);
            this.Controls.Add(this.estadoEquipo_Lbl);
            this.Controls.Add(this.estadoEquipo_Cbx);
            this.Controls.Add(this.fechaAlta_Lbl);
            this.Controls.Add(this.nombreMarca_Lbl);
            this.Controls.Add(this.numeroSerie_Lbl);
            this.Controls.Add(this.fechaAlta_MonthCalendar);
            this.Controls.Add(this.nombreEquipo_Cbx);
            this.Controls.Add(this.nombreEquipo_Lbl);
            this.Controls.Add(this.nombreMarca_Tbx);
            this.Controls.Add(this.numeroSerie_Tbx);
            this.Name = "AltaEquipoForm";
            this.Text = "Registrar Equipo";
            this.Load += new System.EventHandler(this.AltaEquipoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fecha_Lbl;
        private System.Windows.Forms.Label diaAlta_Lbl;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.Button borrar_Btn;
        private System.Windows.Forms.Button guardar_Btn;
        private System.Windows.Forms.Label estadoEquipo_Lbl;
        private System.Windows.Forms.ComboBox estadoEquipo_Cbx;
        private System.Windows.Forms.Label fechaAlta_Lbl;
        private System.Windows.Forms.Label nombreMarca_Lbl;
        private System.Windows.Forms.Label numeroSerie_Lbl;
        private System.Windows.Forms.MonthCalendar fechaAlta_MonthCalendar;
        private System.Windows.Forms.ComboBox nombreEquipo_Cbx;
        private System.Windows.Forms.Label nombreEquipo_Lbl;
        private System.Windows.Forms.TextBox nombreMarca_Tbx;
        private System.Windows.Forms.TextBox numeroSerie_Tbx;
    }
}