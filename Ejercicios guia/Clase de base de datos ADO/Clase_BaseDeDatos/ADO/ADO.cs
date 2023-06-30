using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BaseDeDatos
{
    public class ADO
    {
        private static string ruta_conexion;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        static ADO()
        {
            ADO.ruta_conexion = @"Data Source=localhost;Initial Catalog=UTN_db;Integrated Security=true";
        }
        public ADO() 
        {
            this.conexion = new SqlConnection(ADO.ruta_conexion);
        }
        public bool ProbarConexion() 
        {
            bool seConecto = true;
            try 
            {
                this.conexion.Open();
            }
            catch (Exception) 
            {
                seConecto = false;
            }
            finally 
            {
                if (this.conexion.State == ConnectionState.Open)  
                {
                    this.conexion.Close();
                }
            }
            return seConecto;
        }
        public List<Usuario> SelectUsuarios() 
        {

            List<Usuario> lista = new List<Usuario>();
            try 
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Parameters.AddWithValue("@id", -1);
                this.comando.CommandText = "SELECT * from usuarios WHERE id != @id";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();
                while (this.lector.Read()) 
                {
                    Usuario datoObtenido = new Usuario(lector.GetInt32("id"), lector["correo"].ToString(), lector["clave"].ToString(), this.lector["nombre"].ToString(), this.lector.GetInt32("edad"));
                    lista.Add(datoObtenido);
                }
                this.lector.Close();
            }
            catch (Exception) 
            {
                lista = null;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open) 
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
        public bool InsertUsuarios(Usuario unUsuario) 
        {
            bool seInserto = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "INSERT INTO usuarios (correo,clave,nombre,edad) VALUES " +
                    $"'{unUsuario.Correo}', '{unUsuario.Clave}', '{unUsuario.Nombre}', '{unUsuario.Edad.ToString()}'";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 0) 
                {
                    seInserto = false;
                }
            }
            catch (Exception)
            {
                seInserto = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return seInserto;
        }
    }
}
