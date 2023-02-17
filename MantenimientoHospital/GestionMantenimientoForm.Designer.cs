namespace MantenimientoHospital
{
    partial class GestionMantenimientoForm
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
            this.encargado_Cbx = new System.Windows.Forms.ComboBox();
            this.fecha_Lbl = new System.Windows.Forms.Label();
            this.proxMantenimiento_Lbl = new System.Windows.Forms.Label();
            this.encargado_Lbl = new System.Windows.Forms.Label();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.detalles_Lbl = new System.Windows.Forms.Label();
            this.detalles_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoMantenimiento_Cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proximoMantenimiento_MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.amNombreEquipo_Tbx = new System.Windows.Forms.TextBox();
            this.nombreMarca_Lbl = new System.Windows.Forms.Label();
            this.numeroSerie_Lbl = new System.Windows.Forms.Label();
            this.nombreEquipo_Lbl = new System.Windows.Forms.Label();
            this.amNombreMarca_Tbx = new System.Windows.Forms.TextBox();
            this.amNumeroSerie_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encargado_Cbx
            // 
            this.encargado_Cbx.FormattingEnabled = true;
            this.encargado_Cbx.Location = new System.Drawing.Point(21, 273);
            this.encargado_Cbx.Name = "encargado_Cbx";
            this.encargado_Cbx.Size = new System.Drawing.Size(167, 21);
            this.encargado_Cbx.TabIndex = 65;
            // 
            // fecha_Lbl
            // 
            this.fecha_Lbl.AutoSize = true;
            this.fecha_Lbl.Location = new System.Drawing.Point(367, 217);
            this.fecha_Lbl.Name = "fecha_Lbl";
            this.fecha_Lbl.Size = new System.Drawing.Size(108, 13);
            this.fecha_Lbl.TabIndex = 64;
            this.fecha_Lbl.Text = "Fecha Seleccionada:";
            // 
            // proxMantenimiento_Lbl
            // 
            this.proxMantenimiento_Lbl.Location = new System.Drawing.Point(479, 217);
            this.proxMantenimiento_Lbl.Name = "proxMantenimiento_Lbl";
            this.proxMantenimiento_Lbl.Size = new System.Drawing.Size(139, 13);
            this.proxMantenimiento_Lbl.TabIndex = 63;
            this.proxMantenimiento_Lbl.Text = "---";
            // 
            // encargado_Lbl
            // 
            this.encargado_Lbl.AutoSize = true;
            this.encargado_Lbl.Location = new System.Drawing.Point(21, 246);
            this.encargado_Lbl.Name = "encargado_Lbl";
            this.encargado_Lbl.Size = new System.Drawing.Size(131, 13);
            this.encargado_Lbl.TabIndex = 62;
            this.encargado_Lbl.Text = "Encargado Mantenimiento";
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.Location = new System.Drawing.Point(537, 467);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(75, 23);
            this.guardar_Btn.TabIndex = 61;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = true;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // detalles_Lbl
            // 
            this.detalles_Lbl.AutoSize = true;
            this.detalles_Lbl.Location = new System.Drawing.Point(21, 320);
            this.detalles_Lbl.Name = "detalles_Lbl";
            this.detalles_Lbl.Size = new System.Drawing.Size(48, 13);
            this.detalles_Lbl.TabIndex = 59;
            this.detalles_Lbl.Text = "Detalles:";
            // 
            // detalles_Tbx
            // 
            this.detalles_Tbx.Location = new System.Drawing.Point(20, 352);
            this.detalles_Tbx.Multiline = true;
            this.detalles_Tbx.Name = "detalles_Tbx";
            this.detalles_Tbx.Size = new System.Drawing.Size(592, 98);
            this.detalles_Tbx.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tipo de Mantenimiento";
            // 
            // tipoMantenimiento_Cbx
            // 
            this.tipoMantenimiento_Cbx.FormattingEnabled = true;
            this.tipoMantenimiento_Cbx.Items.AddRange(new object[] {
            "PREVENTIVO",
            "CORRECTIVO"});
            this.tipoMantenimiento_Cbx.Location = new System.Drawing.Point(21, 204);
            this.tipoMantenimiento_Cbx.Name = "tipoMantenimiento_Cbx";
            this.tipoMantenimiento_Cbx.Size = new System.Drawing.Size(115, 21);
            this.tipoMantenimiento_Cbx.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Próximo Mantenimiento";
            // 
            // proximoMantenimiento_MonthCalendar
            // 
            this.proximoMantenimiento_MonthCalendar.Location = new System.Drawing.Point(370, 46);
            this.proximoMantenimiento_MonthCalendar.Name = "proximoMantenimiento_MonthCalendar";
            this.proximoMantenimiento_MonthCalendar.TabIndex = 54;
            this.proximoMantenimiento_MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.proximoMantenimiento_MonthCalendar_DateSelected);
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(135, 44);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 53;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // amNombreEquipo_Tbx
            // 
            this.amNombreEquipo_Tbx.Location = new System.Drawing.Point(21, 94);
            this.amNombreEquipo_Tbx.Name = "amNombreEquipo_Tbx";
            this.amNombreEquipo_Tbx.ReadOnly = true;
            this.amNombreEquipo_Tbx.Size = new System.Drawing.Size(115, 20);
            this.amNombreEquipo_Tbx.TabIndex = 52;
            // 
            // nombreMarca_Lbl
            // 
            this.nombreMarca_Lbl.AutoSize = true;
            this.nombreMarca_Lbl.Location = new System.Drawing.Point(21, 131);
            this.nombreMarca_Lbl.Name = "nombreMarca_Lbl";
            this.nombreMarca_Lbl.Size = new System.Drawing.Size(92, 13);
            this.nombreMarca_Lbl.TabIndex = 51;
            this.nombreMarca_Lbl.Text = "Nombre de Marca";
            // 
            // numeroSerie_Lbl
            // 
            this.numeroSerie_Lbl.AutoSize = true;
            this.numeroSerie_Lbl.Location = new System.Drawing.Point(21, 30);
            this.numeroSerie_Lbl.Name = "numeroSerie_Lbl";
            this.numeroSerie_Lbl.Size = new System.Drawing.Size(86, 13);
            this.numeroSerie_Lbl.TabIndex = 50;
            this.numeroSerie_Lbl.Text = "Numero de Serie";
            // 
            // nombreEquipo_Lbl
            // 
            this.nombreEquipo_Lbl.AutoSize = true;
            this.nombreEquipo_Lbl.Location = new System.Drawing.Point(21, 78);
            this.nombreEquipo_Lbl.Name = "nombreEquipo_Lbl";
            this.nombreEquipo_Lbl.Size = new System.Drawing.Size(94, 13);
            this.nombreEquipo_Lbl.TabIndex = 49;
            this.nombreEquipo_Lbl.Text = "Nombre de equipo";
            // 
            // amNombreMarca_Tbx
            // 
            this.amNombreMarca_Tbx.Location = new System.Drawing.Point(24, 147);
            this.amNombreMarca_Tbx.Name = "amNombreMarca_Tbx";
            this.amNombreMarca_Tbx.ReadOnly = true;
            this.amNombreMarca_Tbx.Size = new System.Drawing.Size(112, 20);
            this.amNombreMarca_Tbx.TabIndex = 48;
            // 
            // amNumeroSerie_Tbx
            // 
            this.amNumeroSerie_Tbx.Location = new System.Drawing.Point(21, 46);
            this.amNumeroSerie_Tbx.Name = "amNumeroSerie_Tbx";
            this.amNumeroSerie_Tbx.Size = new System.Drawing.Size(100, 20);
            this.amNumeroSerie_Tbx.TabIndex = 47;
            // 
            // GestionMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 501);
            this.Controls.Add(this.encargado_Cbx);
            this.Controls.Add(this.fecha_Lbl);
            this.Controls.Add(this.proxMantenimiento_Lbl);
            this.Controls.Add(this.encargado_Lbl);
            this.Controls.Add(this.guardar_Btn);
            this.Controls.Add(this.detalles_Lbl);
            this.Controls.Add(this.detalles_Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoMantenimiento_Cbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proximoMantenimiento_MonthCalendar);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.amNombreEquipo_Tbx);
            this.Controls.Add(this.nombreMarca_Lbl);
            this.Controls.Add(this.numeroSerie_Lbl);
            this.Controls.Add(this.nombreEquipo_Lbl);
            this.Controls.Add(this.amNombreMarca_Tbx);
            this.Controls.Add(this.amNumeroSerie_Tbx);
            this.Name = "GestionMantenimientoForm";
            this.Text = "Registrar Mantenimiento";
            this.Load += new System.EventHandler(this.GestionMantenimientoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox encargado_Cbx;
        private System.Windows.Forms.Label fecha_Lbl;
        private System.Windows.Forms.Label proxMantenimiento_Lbl;
        private System.Windows.Forms.Label encargado_Lbl;
        private System.Windows.Forms.Button guardar_Btn;
        private System.Windows.Forms.Label detalles_Lbl;
        private System.Windows.Forms.TextBox detalles_Tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipoMantenimiento_Cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar proximoMantenimiento_MonthCalendar;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.TextBox amNombreEquipo_Tbx;
        private System.Windows.Forms.Label nombreMarca_Lbl;
        private System.Windows.Forms.Label numeroSerie_Lbl;
        private System.Windows.Forms.Label nombreEquipo_Lbl;
        private System.Windows.Forms.TextBox amNombreMarca_Tbx;
        private System.Windows.Forms.TextBox amNumeroSerie_Tbx;
    }
}