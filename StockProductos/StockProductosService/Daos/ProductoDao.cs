using Microsoft.SqlServer.Server;
using StockProductosService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace StockProductosService.Daos
{
    public class ProductoDao
    {
        private IDbConnection PrepararConexion()
        {
            string connectionString = "server=LAPTOP-EI9SSRR5\\SQLEXPRESS;database=CotoStock;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(connectionString);

            conexion.Open();

            return conexion;
        }

        public List<Producto> getAllProductos()
        {
            var listaProductos = new List<Producto>();

            IDbConnection conexion = PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = "SELECT ID, PRODUCTO, STOCK, TIPO from stock";

            IDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Producto producto = new Producto()
                {
                    Id = lector.GetInt32(0),
                    NombreProducto = lector.GetString(1),
                    Stock = lector.GetInt32(2),
                    Tipo = lector.GetString(3)
                };

                listaProductos.Add(producto);

            }

            conexion.Close();

            return listaProductos;
        }

        public void insert(Producto producto)
        {
            string query = $"INSERT INTO stock (PRODUCTO, STOCK, TIPO) values ('{producto.NombreProducto}', {producto.Stock}, '{producto.Tipo}')";
            
            var conexion = this.PrepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = query;
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public List<Producto> buscarPorTipo(String Tipo)
        {
            List<Producto> listaProducto = new List<Producto>();

            IDbConnection conexion = PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();

            if (Tipo == "Bebida")
            {
                comando.CommandText = "SELECT ID, PRODUCTO, STOCK, TIPO FROM stock WHERE TIPO = 'Bebida'";
            }
            else if (Tipo == "Comida")
            {
                comando.CommandText = "SELECT ID, PRODUCTO, STOCK, TIPO FROM stock WHERE TIPO = 'Comida'";
            }
            else
            {
                comando.CommandText = "SELECT ID, PRODUCTO, STOCK, TIPO FROM stock WHERE TIPO = 'Otros'";
            }

            IDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Producto producto = new Producto()
                {
                    Id = lector.GetInt32(0),
                    NombreProducto = lector.GetString(1),
                    Stock = lector.GetInt32(2),
                    Tipo = lector.GetString(3)
                };

                listaProducto.Add(producto);

            }

            conexion.Close();

            return listaProducto;

        }

    }
}
