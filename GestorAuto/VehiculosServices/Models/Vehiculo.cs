using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosServices.Models
{
    public class Vehiculo
    {
        public long Id { get; set; }
        public string Patente { get; set; }
        public long Tipo_id { get; set; }
        public decimal Velocidad { get; set; }

        public Vehiculo(string patente, long tipo_id, decimal velocidad)
        {
            this.Patente = patente;
            this.Tipo_id = tipo_id;
            this.Velocidad = velocidad;
        }


        // se puede tener 2 constructores un vacio y otro que sirve por si le quiero dar los valores cuando lo creo
        public Vehiculo() {}



    }


}
