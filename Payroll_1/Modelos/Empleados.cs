using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Payroll_1.Modelos
{
    internal class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CuentaCorriente { get; set; }
        public string Estado { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        //public Empleado(int idEmpleado, string dui, string nombre, string apellidos, string telefono, string direccion, string cuentaCorriente)
        //{
        //    IdEmpleado = idEmpleado;
        //    Dui = dui;
        //    Nombre = nombre;
        //    Apellidos = apellidos;
        //    Telefono = telefono;
        //    Direccion = direccion;
        //    CuentaCorriente = cuentaCorriente;
        //}
        public Empleados() { }

        //public Empleado(string dui, string nombre, string apellidos, string telefono, string direccion, string cuentaCorriente)
        //{
        //    Dui = dui;
        //    Nombre = nombre;
        //    Apellidos = apellidos;
        //    Telefono = telefono;
        //    Direccion = direccion;
        //    CuentaCorriente = cuentaCorriente;
        //}


        //------------------------ Métodos a usar ----------------------------------------------------------

        Conexion conexion = new Conexion();


        //Agregar
        public void AgregarEmpleado()
        {
            // Hacer validaciones

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "INSERT INTO Empleado (dui, nombre, apellidos, telefono, direccion, cuenta_corriente, estado, correo, contrasena ) " +
                                   "VALUES (@dui, @nombre, @apellidos, @telefono, @direccion, @cuenta_corriente, @estado, @correo, @contrasena)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@dui", SqlDbType.VarChar).Value = Dui;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre;
                        cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = Apellidos;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Telefono;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Direccion;
                        cmd.Parameters.Add("@cuenta_corriente", SqlDbType.VarChar).Value = CuentaCorriente;
                        cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = Estado;
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = Correo;
                        cmd.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = Contrasena;

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Empleado agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Mostrar
        public List<Empleados> MostrarEmpleados()
        {

            List<Empleados> empleados = new List<Empleados>();

            using (SqlConnection con = conexion.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Empleado";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleados empleado = new Empleados
                                {
                                    IdEmpleado = Convert.ToInt32(reader["id_empleado"]),
                                    Dui = reader["dui"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Apellidos = reader["apellidos"].ToString(),
                                    Telefono = reader["telefono"].ToString(),
                                    Direccion = reader["direccion"].ToString(),
                                    CuentaCorriente = reader["cuenta_corriente"].ToString(),
                                    Estado = reader["estado"].ToString(),
                                    Correo = reader["correo"].ToString(),
                                    Contrasena = reader["contrasena"].ToString()
                                };
                                empleados.Add(empleado);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return empleados;
        }


        //Editar
        public void EditarEmpleado(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("ID de empleado inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<SqlParameter> parametros = new List<SqlParameter>();
            StringBuilder query = new StringBuilder("UPDATE Empleado SET ");

            if (!string.IsNullOrEmpty(Nombre))
            {
                query.Append("nombre = @nombre, ");
                parametros.Add(new SqlParameter("@nombre", SqlDbType.VarChar) { Value = Nombre });
            }
            if (!string.IsNullOrEmpty(Apellidos))
            {
                query.Append("apellidos = @apellidos, ");
                parametros.Add(new SqlParameter("@apellidos", SqlDbType.VarChar) { Value = Apellidos });
            }
            if (!string.IsNullOrEmpty(Telefono))
            {
                query.Append("telefono = @telefono, ");
                parametros.Add(new SqlParameter("@telefono", SqlDbType.VarChar) { Value = Telefono });
            }
            if (!string.IsNullOrEmpty(Direccion))
            {
                query.Append("direccion = @direccion, ");
                parametros.Add(new SqlParameter("@direccion", SqlDbType.VarChar) { Value = Direccion });
            }
            if (!string.IsNullOrEmpty(CuentaCorriente))
            {
                query.Append("cuenta_corriente = @cuenta_corriente, ");
                parametros.Add(new SqlParameter("@cuenta_corriente", SqlDbType.VarChar) { Value = CuentaCorriente });
            }
            if (!string.IsNullOrEmpty(Estado))
            {
                query.Append("estado = @estado, ");
                parametros.Add(new SqlParameter("@estado", SqlDbType.VarChar) { Value = Estado });
            }
            if (!string.IsNullOrEmpty(Correo))
            {
                query.Append("correo = @correo, ");
                parametros.Add(new SqlParameter("@correo", SqlDbType.VarChar) { Value = Correo });
            }
            if (!string.IsNullOrEmpty(Contrasena))
            {
                query.Append("contrasena = @contrasena, ");
                parametros.Add(new SqlParameter("@contrasena", SqlDbType.VarChar) { Value = Contrasena });
            }

            if (parametros.Count == 0)
            {
                MessageBox.Show("No hay cambios que guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query.Length -= 2;
            query.Append(" WHERE id_empleado = @idEmpleado");
            parametros.Add(new SqlParameter("@idEmpleado", SqlDbType.Int) { Value = id });

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query.ToString(), con))
                    {
                        cmd.Parameters.AddRange(parametros.ToArray());
                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Empleado editado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el empleado o no hubo cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Login

        public int LoginEmpleado(string correo, string contrasena)
        {
            int idEmpleado = -1; 

            using (SqlConnection con = conexion.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT id_empleado FROM Empleado WHERE correo = @correo AND contrasena = @contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            idEmpleado = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Error al iniciar sesión: Empleado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return idEmpleado; 
        }

    }
}
