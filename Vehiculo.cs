using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso2
{
    class Vehiculo
    {

        string placa;
        string marca;
        string modelo;
        string color;
        decimal precioKm;
        
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public decimal PrecioKm { get => precioKm; set => precioKm = value; }
    }
}
