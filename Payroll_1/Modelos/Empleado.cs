using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Payroll_1.Modelos
{
    internal class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CuentaCorriente { get; set; }

        public Empleado(int idEmpleado, string dui, string nombre, string apellidos, string telefono, string direccion, string cuentaCorriente)
        {
            IdEmpleado = idEmpleado;
            Dui = dui;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            CuentaCorriente = cuentaCorriente;
        }
        public Empleado() { }

        public Empleado(string dui, string nombre, string apellidos, string telefono, string direccion, string cuentaCorriente)
        {
            Dui = dui;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            CuentaCorriente = cuentaCorriente;
        }


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
                    string query = "INSERT INTO Empleado (dui, nombre, apellidos, direccion, telefono, cuenta_corriente) " +
                                   "VALUES (@dui, @nombre, @apellidos, @telefono, @direccion, @cuenta_corriente)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@dui", SqlDbType.VarChar).Value = Dui;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre;
                        cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = Apellidos;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Telefono;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Direccion;
                        cmd.Parameters.Add("@cuenta_corriente", SqlDbType.VarChar).Value = CuentaCorriente;

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
        public void MostrarEmpleado()
        {
            using (SqlConnection con = conexion.GetConnection())  
            {
                try
                {
                    con.Open();
                    string query = "SELECT nombre, apellidos, direccion, telefono, cuenta_corriente FROM Empleado WHERE id_empleado = 1";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())  
                            {
                                Nombre = reader["nombre"].ToString();
                                Apellidos = reader["apellidos"].ToString();
                                Direccion = reader["direccion"].ToString();
                                Telefono = reader["telefono"].ToString();
                                CuentaCorriente = reader["cuenta_corriente"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        //Cargar la tabla
        public void CargarTabla(DataGridView dgvEmpleados)
        {
            try
            {
                Conexion conexion = new Conexion();
                string query = "SELECT id_empleado, dui, nombre, apellidos, direccion, telefono, cuenta_corriente FROM Empleado";
                using (SqlConnection con = conexion.GetConnection())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);  
                        dgvEmpleados.DataSource = dt;  
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //Editar
        public void EditarEmpleado()
        {
            if (string.IsNullOrEmpty(Dui) || string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellidos) ||
                string.IsNullOrEmpty(Direccion) || string.IsNullOrEmpty(Telefono) || string.IsNullOrEmpty(CuentaCorriente))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Conexion conexion = new Conexion();
                string query = "UPDATE Empleado SET ";
                List<SqlParameter> parametros = new List<SqlParameter>();

                if (Nombre != null)
                {
                    query += "nombre = @nombre, ";
                    parametros.Add(new SqlParameter("@nombre", SqlDbType.VarChar) { Value = Nombre });
                }
                if (Apellidos != null)
                {
                    query += "apellidos = @apellidos, ";
                    parametros.Add(new SqlParameter("@apellidos", SqlDbType.VarChar) { Value = Apellidos });
                }
                if (Direccion != null)
                {
                    query += "direccion = @direccion, ";
                    parametros.Add(new SqlParameter("@direccion", SqlDbType.VarChar) { Value = Direccion });
                }
                if (Telefono != null)
                {
                    query += "telefono = @telefono, ";
                    parametros.Add(new SqlParameter("@telefono", SqlDbType.VarChar) { Value = Telefono });
                }
                if (CuentaCorriente != null)
                {
                    query += "cuenta_corriente = @cuenta_corriente, ";
                    parametros.Add(new SqlParameter("@cuenta_corriente", SqlDbType.VarChar) { Value = CuentaCorriente });
                }

                query = query.TrimEnd(',', ' ') + " WHERE dui = @dui";
                parametros.Add(new SqlParameter("@dui", SqlDbType.VarChar) { Value = Dui });

                using (SqlConnection con = conexion.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
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
                            MessageBox.Show("No se pudo editar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
