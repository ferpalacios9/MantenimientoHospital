using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MantenimientoHospital
{
    public partial class GestionMantenimientoForm : Form
    {
        SqlConnection cone = new SqlConnection(@"Data Source = LAPTOP-4I0IHBID\SQLEXPRESS; Initial Catalog = MantenimientoHospital; Integrated Security = True");
        public GestionMantenimientoForm()
        {
            InitializeComponent();
        }

        private void GestionMantenimientoForm_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT NombreEmpleado from Empleado", cone);
            cone.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                encargado_Cbx.Items.Add(registro["NombreEmpleado"].ToString());

            }
            cone.Close();

        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            cone.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Mantenimiento(NoSerie, NombreEquipo, MarcaEquipo, ProximoMantenimiento, TipoMantenimiento, EncargadoMantenimiento, Detalles)VALUES(" + this.amNumeroSerie_Tbx.Text + ",'" + this.amNombreEquipo_Tbx.Text + "','" + this.amNombreMarca_Tbx.Text + "','" + this.proxMantenimiento_Lbl.Text + "','" + this.tipoMantenimiento_Cbx.SelectedItem.ToString() + "','" + this.encargado_Cbx.Text + "','" + this.detalles_Tbx.Text + "')", cone);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Mantenimiento guardado correctamente.");
            cone.Close();
        }

        private void proximoMantenimiento_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            proxMantenimiento_Lbl.Text = proximoMantenimiento_MonthCalendar.SelectionRange.Start.ToShortDateString();

        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            SqlCommand buscar = new SqlCommand("SELECT * FROM Equipo WHERE IdEM = @ID", cone);
            buscar.Parameters.AddWithValue("@ID", amNumeroSerie_Tbx.Text);
            cone.Open();
            SqlDataReader registro = buscar.ExecuteReader();
            if (registro.Read())
            {
                amNombreMarca_Tbx.Text = registro["MarcaEquipo"].ToString();
                amNombreEquipo_Tbx.Text = registro["NombreEquipo"].ToString();
            }
            else
            {
                MessageBox.Show("No existe ningun Equipo Medico con ese Numero de Serie");
            }
            cone.Close();
        }
    }
}
