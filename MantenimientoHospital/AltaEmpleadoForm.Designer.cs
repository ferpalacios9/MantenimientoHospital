namespace MantenimientoHospital
{
    partial class AltaEmpleadoForm
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
            this.borrar_Btn = new System.Windows.Forms.Button();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.nombreEmpleado_Tbx = new System.Windows.Forms.TextBox();
            this.puestoEmpleado_Lbl = new System.Windows.Forms.Label();
            this.idEmpleado_Lbl = new System.Windows.Forms.Label();
            this.nombreEmpleado_Lbl = new System.Windows.Forms.Label();
            this.puestoEmpleado_Tbx = new System.Windows.Forms.TextBox();
            this.idEmpleado_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(127, 37);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(75, 23);
            this.buscar_Btn.TabIndex = 48;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // borrar_Btn
            // 
            this.borrar_Btn.Location = new System.Drawing.Point(24, 200);
            this.borrar_Btn.Name = "borrar_Btn";
            this.borrar_Btn.Size = new System.Drawing.Size(75, 23);
            this.borrar_Btn.TabIndex = 47;
            this.borrar_Btn.Text = "Borrar";
            this.borrar_Btn.UseVisualStyleBackColor = true;
            this.borrar_Btn.Click += new System.EventHandler(this.borrar_Btn_Click);
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.Location = new System.Drawing.Point(196, 200);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(75, 23);
            this.guardar_Btn.TabIndex = 46;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = true;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // nombreEmpleado_Tbx
            // 
            this.nombreEmpleado_Tbx.Location = new System.Drawing.Point(21, 100);
            this.nombreEmpleado_Tbx.Name = "nombreEmpleado_Tbx";
            this.nombreEmpleado_Tbx.Size = new System.Drawing.Size(250, 20);
            this.nombreEmpleado_Tbx.TabIndex = 45;
            // 
            // puestoEmpleado_Lbl
            // 
            this.puestoEmpleado_Lbl.AutoSize = true;
            this.puestoEmpleado_Lbl.Location = new System.Drawing.Point(21, 137);
            this.puestoEmpleado_Lbl.Name = "puestoEmpleado_Lbl";
            this.puestoEmpleado_Lbl.Size = new System.Drawing.Size(90, 13);
            this.puestoEmpleado_Lbl.TabIndex = 44;
            this.puestoEmpleado_Lbl.Text = "Puesto Empleado";
            // 
            // idEmpleado_Lbl
            // 
            this.idEmpleado_Lbl.AutoSize = true;
            this.idEmpleado_Lbl.Location = new System.Drawing.Point(21, 24);
            this.idEmpleado_Lbl.Name = "idEmpleado_Lbl";
            this.idEmpleado_Lbl.Size = new System.Drawing.Size(66, 13);
            this.idEmpleado_Lbl.TabIndex = 43;
            this.idEmpleado_Lbl.Text = "Id Empleado";
            // 
            // nombreEmpleado_Lbl
            // 
            this.nombreEmpleado_Lbl.AutoSize = true;
            this.nombreEmpleado_Lbl.Location = new System.Drawing.Point(21, 84);
            this.nombreEmpleado_Lbl.Name = "nombreEmpleado_Lbl";
            this.nombreEmpleado_Lbl.Size = new System.Drawing.Size(94, 13);
            this.nombreEmpleado_Lbl.TabIndex = 42;
            this.nombreEmpleado_Lbl.Text = "Nombre Empleado";
            // 
            // puestoEmpleado_Tbx
            // 
            this.puestoEmpleado_Tbx.Location = new System.Drawing.Point(21, 153);
            this.puestoEmpleado_Tbx.Name = "puestoEmpleado_Tbx";
            this.puestoEmpleado_Tbx.Size = new System.Drawing.Size(250, 20);
            this.puestoEmpleado_Tbx.TabIndex = 41;
            // 
            // idEmpleado_Tbx
            // 
            this.idEmpleado_Tbx.Location = new System.Drawing.Point(21, 40);
            this.idEmpleado_Tbx.Name = "idEmpleado_Tbx";
            this.idEmpleado_Tbx.Size = new System.Drawing.Size(100, 20);
            this.idEmpleado_Tbx.TabIndex = 40;
            // 
            // AltaEmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 241);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.borrar_Btn);
            this.Controls.Add(this.guardar_Btn);
            this.Controls.Add(this.nombreEmpleado_Tbx);
            this.Controls.Add(this.puestoEmpleado_Lbl);
            this.Controls.Add(this.idEmpleado_Lbl);
            this.Controls.Add(this.nombreEmpleado_Lbl);
            this.Controls.Add(this.puestoEmpleado_Tbx);
            this.Controls.Add(this.idEmpleado_Tbx);
            this.Name = "AltaEmpleadoForm";
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.AltaEmpleadoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.Button borrar_Btn;
        private System.Windows.Forms.Button guardar_Btn;
        private System.Windows.Forms.TextBox nombreEmpleado_Tbx;
        private System.Windows.Forms.Label puestoEmpleado_Lbl;
        private System.Windows.Forms.Label idEmpleado_Lbl;
        private System.Windows.Forms.Label nombreEmpleado_Lbl;
        private System.Windows.Forms.TextBox puestoEmpleado_Tbx;
        private System.Windows.Forms.TextBox idEmpleado_Tbx;
    }
}