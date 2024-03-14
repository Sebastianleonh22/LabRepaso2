using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso2
{
    class PrecioAlquiler
    {
        string nombreCliente;

        string marca;
        string modelo;
        string color;
        string fecha_Devolucion;
        decimal totalaPagar;

        public string Nombre_Cliente { get => nombreCliente; set => nombreCliente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public string Fecha_Devolucion { get => fecha_Devolucion; set => fecha_Devolucion = value; }
        public decimal Total_a_Pagar { get => totalaPagar; set => totalaPagar = value; }
        
    }
}
