using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabRepaso2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Cliente> clientes = new List<Cliente>();
        List<Alquiler> alquileres = new List<Alquiler>();
        


        public void CargarVehiculos()
        {
            string fileName = "Vehiculos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                //leer datos del vehiculo
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = reader.ReadLine();
                vehiculo.Marca = reader.ReadLine();
                vehiculo.Modelo = reader.ReadLine();
                vehiculo.Color = reader.ReadLine();
                vehiculo.PrecioKm = Convert.ToInt32(reader.ReadLine());

                vehiculos.Add(vehiculo);
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }

        public void CargarClientes()
        {
            string fileName = "Clientes.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                //leer datos del cliente
                Cliente cliente = new Cliente();
                cliente.Nit = reader.ReadLine();
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();

                clientes.Add(cliente);
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }


        public void MostrarTodo()
        {
            dataGridViewVehiiculos.DataSource = null;
            dataGridViewVehiiculos.DataSource = vehiculos;
            dataGridViewVehiiculos.Refresh();
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarVehiculos();
            CargarClientes();
            MostrarTodo();
        }

        private void btnVerAlquiler_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in clientes)
            {
                string nit = cliente.Nit;

                foreach (Alquiler alquiler in alquileres)
                {
                    if (cliente.Nit == alquiler.Nit)
                    {
                        Vehiculo vehiculo = new Vehiculo();


                        alquiler.Nit = cliente.Nit;
                        alquiler.KmRecorridos1 = vehiculo.PrecioKm * alquiler.KmRecorridos1;
                       
                    }
                }
            }
        }
    }
}
