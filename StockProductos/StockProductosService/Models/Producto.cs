using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProductosService.Models
{
    public class Producto
    {
        public long Id { get; set; }
        public string NombreProducto { get; set; }
        public long Stock { get; set; }
        public string Tipo { get; set; }

        public Producto(string nombreProducto, long stock, string tipo)
        {
            NombreProducto = nombreProducto;
            Stock = stock;
            Tipo = tipo;
        }

        public Producto() { } 
    }
}
