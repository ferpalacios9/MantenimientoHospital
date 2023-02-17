namespace MantenimientoHospital
{
    partial class InicioForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.historialEquipo_Btn = new System.Windows.Forms.Button();
            this.registrarMantenimiento_Btn = new System.Windows.Forms.Button();
            this.registrarEquipo_Btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarOBorrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarFabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historialEquipo_Btn
            // 
            this.historialEquipo_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historialEquipo_Btn.BackgroundImage")));
            this.historialEquipo_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historialEquipo_Btn.FlatAppearance.BorderSize = 0;
            this.historialEquipo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historialEquipo_Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialEquipo_Btn.ForeColor = System.Drawing.Color.White;
            this.historialEquipo_Btn.Location = new System.Drawing.Point(541, 51);
            this.historialEquipo_Btn.Name = "historialEquipo_Btn";
            this.historialEquipo_Btn.Size = new System.Drawing.Size(232, 200);
            this.historialEquipo_Btn.TabIndex = 8;
            this.historialEquipo_Btn.Text = "Historial Equipo";
            this.historialEquipo_Btn.UseVisualStyleBackColor = true;
            this.historialEquipo_Btn.Click += new System.EventHandler(this.historialEquipo_Btn_Click);
            // 
            // registrarMantenimiento_Btn
            // 
            this.registrarMantenimiento_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registrarMantenimiento_Btn.BackgroundImage")));
            this.registrarMantenimiento_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrarMantenimiento_Btn.FlatAppearance.BorderSize = 0;
            this.registrarMantenimiento_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarMantenimiento_Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarMantenimiento_Btn.ForeColor = System.Drawing.Color.White;
            this.registrarMantenimiento_Btn.Location = new System.Drawing.Point(281, 51);
            this.registrarMantenimiento_Btn.Name = "registrarMantenimiento_Btn";
            this.registrarMantenimiento_Btn.Size = new System.Drawing.Size(232, 200);
            this.registrarMantenimiento_Btn.TabIndex = 7;
            this.registrarMantenimiento_Btn.Text = "Registrar Mantenimiento";
            this.registrarMantenimiento_Btn.UseVisualStyleBackColor = true;
            this.registrarMantenimiento_Btn.Click += new System.EventHandler(this.registrarMantenimiento_Btn_Click);
            // 
            // registrarEquipo_Btn
            // 
            this.registrarEquipo_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registrarEquipo_Btn.BackgroundImage")));
            this.registrarEquipo_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrarEquipo_Btn.FlatAppearance.BorderSize = 0;
            this.registrarEquipo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarEquipo_Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarEquipo_Btn.ForeColor = System.Drawing.Color.White;
            this.registrarEquipo_Btn.Location = new System.Drawing.Point(24, 51);
            this.registrarEquipo_Btn.Name = "registrarEquipo_Btn";
            this.registrarEquipo_Btn.Size = new System.Drawing.Size(232, 200);
            this.registrarEquipo_Btn.TabIndex = 6;
            this.registrarEquipo_Btn.Text = "Registrar equipo";
            this.registrarEquipo_Btn.UseVisualStyleBackColor = true;
            this.registrarEquipo_Btn.Click += new System.EventHandler(this.registrarEquipo_Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarOBorrarToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // registrarOBorrarToolStripMenuItem
            // 
            this.registrarOBorrarToolStripMenuItem.Name = "registrarOBorrarToolStripMenuItem";
            this.registrarOBorrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarOBorrarToolStripMenuItem.Text = "Registrar o Borrar ";
            this.registrarOBorrarToolStripMenuItem.Click += new System.EventHandler(this.registrarOBorrarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactarFabricanteToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // contactarFabricanteToolStripMenuItem
            // 
            this.contactarFabricanteToolStripMenuItem.Name = "contactarFabricanteToolStripMenuItem";
            this.contactarFabricanteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contactarFabricanteToolStripMenuItem.Text = "Contactar fabricante";
            this.contactarFabricanteToolStripMenuItem.Click += new System.EventHandler(this.contactarFabricanteToolStripMenuItem_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.historialEquipo_Btn);
            this.Controls.Add(this.registrarMantenimiento_Btn);
            this.Controls.Add(this.registrarEquipo_Btn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "InicioForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button historialEquipo_Btn;
        private System.Windows.Forms.Button registrarMantenimiento_Btn;
        private System.Windows.Forms.Button registrarEquipo_Btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarOBorrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactarFabricanteToolStripMenuItem;
    }
}

