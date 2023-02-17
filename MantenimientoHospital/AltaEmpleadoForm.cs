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
    public partial class AltaEmpleadoForm : Form
    {
        SqlConnection cone = new SqlConnection(@"Data Source = LAPTOP-4I0IHBID\SQLEXPRESS; Initial Catalog = MantenimientoHospital; Integrated Security = True");
        public AltaEmpleadoForm()
        {
            InitializeComponent();
        }

        private void AltaEmpleadoForm_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            cone.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Empleado(IdE, NombreEmpleado, PuestoEmpleado)VALUES(" + this.idEmpleado_Tbx.Text + ",'" + this.nombreEmpleado_Tbx.Text + "','" + this.puestoEmpleado_Tbx.Text + "')", cone);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Empleado guardado correctamente.");
            cone.Close();
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            SqlCommand buscarEmpleado = new SqlCommand("SELECT * FROM Empleado WHERE IdE = @IDE", cone);
            buscarEmpleado.Parameters.AddWithValue("@IDE", idEmpleado_Tbx.Text);
            cone.Open();
            SqlDataReader registroEmpleado = buscarEmpleado.ExecuteReader();
            if (registroEmpleado.Read())
            {
                nombreEmpleado_Tbx.Text = registroEmpleado["NombreEmpleado"].ToString();
                puestoEmpleado_Tbx.Text = registroEmpleado["PuestoEmpleado"].ToString();
            }
            else
            {
                MessageBox.Show("No existe ningun Empleado con ese ID");
            }
            cone.Close();
        }

        private void borrar_Btn_Click(object sender, EventArgs e)
        {
            
            int flag = 0;
            string cadena = "Delete from Empleado where IdE = '" + idEmpleado_Tbx.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, cone);
            cone.Open();
            flag = comando.ExecuteNonQuery(); //Si es positivo = 1 | si es negativo = 0

            if (flag == 1)
            {
                MessageBox.Show("Empleado borrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar!!!");
            }
            idEmpleado_Tbx.Text = "";
            nombreEmpleado_Tbx.Text = "";
            puestoEmpleado_Tbx.Text = "";
            cone.Close();
        }
    }
}
