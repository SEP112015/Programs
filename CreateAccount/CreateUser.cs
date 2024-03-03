using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Windows.Forms;
using Npgsql;
using System.Data;


namespace CreateAccount
{
    internal class CreateUser
    {

        NpgsqlConnection CreateLogin = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = Pp332244,.z; Database = login_sesion;");
        public void Conectar()
        {
            CreateLogin.Open();
            
        }
        public void Desconectar()
        {
            CreateLogin.Close();
     
        }
        public DataTable Consultar()
        {
            string query = "Select * from Personas";
            NpgsqlCommand conector = new NpgsqlCommand(query, CreateLogin);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

        }
     public void Insertar(int id, string nombre, string apellido, string Sexo, string FechaNacimiento, string Usuario, string CorreoElectronico, string contraseña, string Telefono, string Direccion)
        {
            string query = "INSERT INTO CreateAccount VALUES (@id, @nombre, @apellido, @sexo, @fechanacimiento, @usuario, @correoelectronico, @contraseña, @numerotelefono, @direccion)";
            using (NpgsqlCommand ejecutor = new NpgsqlCommand(query, CreateLogin))
            {
                ejecutor.Parameters.AddWithValue("@id", id);
                ejecutor.Parameters.AddWithValue("@nombre", nombre);
                ejecutor.Parameters.AddWithValue("@apellido", apellido);
                ejecutor.Parameters.AddWithValue("@sexo", Sexo);
                ejecutor.Parameters.AddWithValue("@fechanacimiento", DateTime.Parse(FechaNacimiento));
                ejecutor.Parameters.AddWithValue("@usuario", Usuario);
                ejecutor.Parameters.AddWithValue("@correoelectronico", CorreoElectronico);
                ejecutor.Parameters.AddWithValue("@contraseña", contraseña);
                ejecutor.Parameters.AddWithValue("@numerotelefono", Telefono);
                ejecutor.Parameters.AddWithValue("@direccion", Direccion);

                CreateLogin.Open();
                ejecutor.ExecuteNonQuery();
                MessageBox.Show("¡¡Hecho!!");
                
            }
            CreateLogin.Close();

        }


    }
}
