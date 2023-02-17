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
    public partial class AltaEquipoForm : Form
    {
        SqlConnection cone = new SqlConnection(@"Data Source = LAPTOP-4I0IHBID\SQLEXPRESS; Initial Catalog = MantenimientoHospital; Integrated Security = True");
        public AltaEquipoForm()
        {
            InitializeComponent();
        }

        private void AltaEquipoForm_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            cone.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Equipo(IdEM, MarcaEquipo, NombreEquipo, EstadoEquipo, FechaAlta)VALUES(" + this.numeroSerie_Tbx.Text + ",'" + this.nombreMarca_Tbx.Text + "','" + this.nombreEquipo_Cbx.SelectedItem.ToString() + "','" + this.estadoEquipo_Cbx.Text + "','" + this.diaAlta_Lbl.Text + "')", cone);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Equipo guardado correctamente.");
            cone.Close();
        }

        private void fechaAlta_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            diaAlta_Lbl.Text = fechaAlta_MonthCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void borrar_Btn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string cadena = "Delete from Equipo where IdEM = '" + numeroSerie_Tbx.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, cone);
            cone.Open();
            flag = comando.ExecuteNonQuery(); //Si es positivo = 1 | si es negativo = 0

            if (flag == 1)
            {
                MessageBox.Show("Equipo borrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar!!!");
            }
            numeroSerie_Tbx.Text = "";
            nombreEquipo_Cbx.Text = "";
            nombreMarca_Tbx.Text = "";
            estadoEquipo_Cbx.Text = "";
            cone.Close();
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            SqlCommand buscarEquipo = new SqlCommand("SELECT * FROM Equipo WHERE IdEM = @IDE", cone);
            buscarEquipo.Parameters.AddWithValue("@IDE", numeroSerie_Tbx.Text);
            cone.Open();
            SqlDataReader registroEquipo = buscarEquipo.ExecuteReader();
            if (registroEquipo.Read())
            {
                nombreEquipo_Cbx.Text = registroEquipo["NombreEquipo"].ToString();
                nombreMarca_Tbx.Text = registroEquipo["MarcaEquipo"].ToString();
                estadoEquipo_Cbx.Text = registroEquipo["EstadoEquipo"].ToString();
            }
            else
            {
                MessageBox.Show("No existe ningun Equipo con ese No Serie");
            }
            cone.Close();
        }
    }
}
