using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoHospital
{
    public partial class InicioForm : Form
    {
        AltaEmpleadoForm altaEmpleado_Form = new AltaEmpleadoForm();
        AltaEquipoForm altaEquipo_Form = new AltaEquipoForm();
        GestionMantenimientoForm gestionMantenimiento_Form = new GestionMantenimientoForm();
        HistorialEquipoForm historialEquipo_Form = new HistorialEquipoForm();
        AyudaForm ayuda_Form = new AyudaForm();

        public InicioForm()
        {
            InitializeComponent();
        }

        private void registrarEquipo_Btn_Click(object sender, EventArgs e)
        {
            altaEquipo_Form.Show();
        }

        private void registrarMantenimiento_Btn_Click(object sender, EventArgs e)
        {
            gestionMantenimiento_Form.Show();
        }

        private void historialEquipo_Btn_Click(object sender, EventArgs e)
        {
            historialEquipo_Form.Show();
        }

        private void contactarFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda_Form.Show();
        }

        private void registrarOBorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaEmpleado_Form.Show();
        }
    }
}
