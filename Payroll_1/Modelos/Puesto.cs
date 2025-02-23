using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Puesto
    {
        Conexion conexion = new Conexion();
        public int IdPuesto { get; set; }
        public string NombrePuesto { get; set; }
        public int IdCategoria { get; set; }

        // MÉTODO PARA OBTENER TODOS LOS PUESTOS
        public List<Puesto> MostrarPuestos()
        {
            List<Puesto> listaPuestos = new List<Puesto>();

            try
            {
                using (SqlConnection con = conexion.GetConnection())
                {
                    string query = "SELECT * FROM Puesto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Puesto puesto = new Puesto
                                {
                                    IdPuesto = Convert.ToInt32(reader["id_puesto"]),
                                    NombrePuesto = reader["nombre_puesto"].ToString(),
                                    IdCategoria = Convert.ToInt32(reader["id_categoria"])
                                };
                                listaPuestos.Add(puesto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaPuestos;
        }   
    }
}

