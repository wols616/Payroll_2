using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Contrato
    {
        Conexion conexion = new Conexion();

        

        public int IdContrato { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; } // Nullable para contratos indefinidos
        public int IdPuesto { get; set; }
        public string TipoContrato { get; set; }
        public string Vigente { get; set; }

        public Contrato(int idEmpleado, DateTime fechaAlta, DateTime? fechaBaja, int idPuesto, string tipoContrato, string vigente)
        {
            IdEmpleado = idEmpleado;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            IdPuesto = idPuesto;
            TipoContrato = tipoContrato;
            Vigente = vigente;
        }
        public Contrato() { }

        public Contrato(int idContrato, int idEmpleado, DateTime fechaAlta, DateTime? fechaBaja, int idPuesto, string tipoContrato, string vigente)
        {
            IdContrato = idContrato;
            IdEmpleado = idEmpleado;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            IdPuesto = idPuesto;
            TipoContrato = tipoContrato;
            Vigente = vigente;
        }

        // MÉTODO PARA AGREGAR CONTRATO
        public void AgregarContrato()
        {
            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "INSERT INTO Contrato (id_empleado, fecha_alta, fecha_baja, id_puesto, tipo_contrato, vigente) " +
                                   "VALUES (@id_empleado, @fecha_alta, @fecha_baja, @id_puesto, @tipo_contrato, @vigente)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = IdEmpleado;
                        cmd.Parameters.Add("@fecha_alta", SqlDbType.DateTime).Value = FechaAlta;
                        cmd.Parameters.Add("@fecha_baja", SqlDbType.DateTime).Value = (object)FechaBaja ?? DBNull.Value; // Manejar nulos
                        cmd.Parameters.Add("@id_puesto", SqlDbType.Int).Value = IdPuesto;
                        cmd.Parameters.Add("@tipo_contrato", SqlDbType.VarChar).Value = TipoContrato;
                        cmd.Parameters.Add("@vigente", SqlDbType.VarChar).Value = Vigente;

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contrato agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el contrato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MÉTODO PARA OBTENER TODOS LOS CONTRATOS
        public List<Contrato> ObtenerContratos()
        {
            List<Contrato> listaContratos = new List<Contrato>();

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "SELECT * FROM Contrato";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Contrato contrato = new Contrato
                                {
                                    IdContrato = Convert.ToInt32(reader["id_contrato"]),
                                    IdEmpleado = Convert.ToInt32(reader["id_empleado"]),
                                    FechaAlta = Convert.ToDateTime(reader["fecha_alta"]),
                                    FechaBaja = reader["fecha_baja"] as DateTime?,
                                    IdPuesto = Convert.ToInt32(reader["id_puesto"]),
                                    TipoContrato = reader["tipo_contrato"].ToString(),
                                    Vigente = reader["vigente"].ToString()
                                };
                                listaContratos.Add(contrato);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los contratos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaContratos;
        }

        public List<Contrato> ObtenerContratos(int idEmpleado)
        {
            List<Contrato> listaContratos = new List<Contrato>();

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "SELECT * FROM Contrato WHERE id_empleado = @id_empleado";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = idEmpleado;

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Contrato contrato = new Contrato
                                {
                                    IdContrato = Convert.ToInt32(reader["id_contrato"]),
                                    IdEmpleado = Convert.ToInt32(reader["id_empleado"]),
                                    FechaAlta = Convert.ToDateTime(reader["fecha_alta"]),
                                    FechaBaja = reader["fecha_baja"] as DateTime?,
                                    IdPuesto = Convert.ToInt32(reader["id_puesto"]),
                                    TipoContrato = reader["tipo_contrato"].ToString(),
                                    Vigente = reader["vigente"].ToString()
                                };
                                listaContratos.Add(contrato);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los contratos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaContratos;
        }

        // MÉTODO PARA ACTUALIZAR CONTRATO
        public void ActualizarContrato()
        {
            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "UPDATE Contrato SET id_empleado = @id_empleado, fecha_alta = @fecha_alta, fecha_baja = @fecha_baja, " +
                                   "id_puesto = @id_puesto, tipo_contrato = @tipo_contrato, vigente = @vigente WHERE id_contrato = @id_contrato";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@id_contrato", SqlDbType.Int).Value = IdContrato;
                        cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = IdEmpleado;
                        cmd.Parameters.Add("@fecha_alta", SqlDbType.DateTime).Value = FechaAlta;
                        cmd.Parameters.Add("@fecha_baja", SqlDbType.DateTime).Value = (object)FechaBaja ?? DBNull.Value; // Manejar nulos
                        cmd.Parameters.Add("@id_puesto", SqlDbType.Int).Value = IdPuesto;
                        cmd.Parameters.Add("@tipo_contrato", SqlDbType.VarChar).Value = TipoContrato;
                        cmd.Parameters.Add("@vigente", SqlDbType.VarChar).Value = Vigente;

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contrato actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el contrato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el contrato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

