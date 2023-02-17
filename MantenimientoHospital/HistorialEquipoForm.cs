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
    public partial class HistorialEquipoForm : Form
    {
        SqlConnection cone = new SqlConnection(@"Data Source = LAPTOP-4I0IHBID\SQLEXPRESS; Initial Catalog = MantenimientoHospital; Integrated Security = True");
        public HistorialEquipoForm()
        {
            InitializeComponent();
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            SqlCommand buscar = new SqlCommand("SELECT * FROM Mantenimiento WHERE NoSerie = @NS", cone);
            buscar.Parameters.AddWithValue("@NS", hmNumeroSerie_Tbx.Text);
            cone.Open();
            SqlDataReader registro = buscar.ExecuteReader();
            if (registro.Read())
            {
                hmNombreMarca_Tbx.Text = registro["MarcaEquipo"].ToString();
                hmNombreEquipo_Tbx.Text = registro["NombreEquipo"].ToString();
            }
            else
            {
                MessageBox.Show("No existe ningun Registro con ese Numero de Serie");
            }
            cone.Close();
        }

        private void hmNumeroSerie_Tbx_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT IdMantenimiento, ProximoMantenimiento, TipoMantenimiento, EncargadoMantenimiento, Detalles FROM Mantenimiento where NoSerie like ('" + hmNumeroSerie_Tbx.Text + "')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();
        }
    }
}
