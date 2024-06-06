using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using VehiculosServices.Models;

namespace VehiculosServices.Daos
{
    public class VehiculoDao
    {
        private IDbConnection prepararConecion()
        {
            string connectionString = "server=LAPTOP-EI9SSRR5\\SQLEXPRESS;database=concesionario;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(connectionString);

            conexion.Open();

            return conexion;
        }

        public List<Vehiculo> getAll() {
            
            IDbConnection conexion  = this.prepararConecion();
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = "select ID,PATENTE,TIPO_ID,VELOCIDAD from VEHICULOS";

            IDataReader lector = comando.ExecuteReader();

            var listaVehiculos = new List<Vehiculo>(); 

            while (lector.Read())
            {
                Vehiculo nuevoVehiculo = new Vehiculo()
                {
                    Id = lector.GetInt32(0),
                    Patente = lector.GetString(1),
                    Tipo_id = lector.GetInt32(2),
                    Velocidad = lector.GetDecimal(3)
                };

                listaVehiculos.Add(nuevoVehiculo);

            }

            conexion.Close();

            return listaVehiculos;

        }

        public void insert(Vehiculo vehiculo)
        {
            string query = $"insert into VEHICULOS (PATENTE, TIPO_ID, VELOCIDAD) values ('{vehiculo.Patente}', {vehiculo.Tipo_id}, {vehiculo.Velocidad}) ";

            var conexion = this.prepararConecion();
            var comando = conexion.CreateCommand();
            comando.CommandText = query;
            comando.ExecuteNonQuery();

            conexion.Close();
        }

    }
}
