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
        List<PrecioAlquiler> precioAlquileres = new List<PrecioAlquiler>();
        


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
                vehiculo.PrecioKm = Convert.ToDecimal(reader.ReadLine());

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

        public void CargarAlquileres()
        {
            string fileName = "Alquileres.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                //leer datos del vehiculo
                Alquiler alquiler = new Alquiler();
                alquiler.Nit = reader.ReadLine();
                alquiler.Placa = reader.ReadLine();
                alquiler.FechaAlquiler = reader.ReadLine();
                alquiler.FechaDevolucion = reader.ReadLine();
                alquiler.KmRecorridos1 = Convert.ToDecimal(reader.ReadLine());

                alquileres.Add(alquiler);
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }

        public void MostrarTodo()
        {
            dataGridViewVehiiculos.Refresh();
            dataGridViewVehiiculos.DataSource = null;
            dataGridViewVehiiculos.DataSource = vehiculos;
            dataGridViewVehiiculos.Refresh();
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();
            dataGridViewAlquileres.DataSource = null;
            dataGridViewAlquileres.DataSource = alquileres;
            dataGridViewAlquileres.Refresh();

        }
        public void Mostrarclientes()
        {
            
            dataGridViewPrecioAlquileres.DataSource = null;
            dataGridViewPrecioAlquileres.DataSource = clientes;
            dataGridViewPrecioAlquileres.Refresh();
            

        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            alquileres.Clear();
            vehiculos.Clear();
            clientes.Clear();
            CargarVehiculos();
            CargarClientes();
            CargarAlquileres();
            MostrarTodo();
            
        }

        private void btnVerAlquiler_Click(object sender, EventArgs e)
        {

            precioAlquileres.Clear();
            foreach (Cliente cliente in clientes)
            {
                string nit = cliente.Nit;

                foreach (Alquiler alquiler in alquileres)
                {
                    string placa = alquiler.Placa;

                    foreach(Vehiculo vehiculo in vehiculos)
                    {
                        if (cliente.Nit == alquiler.Nit && alquiler.Placa == vehiculo.Placa)
                        {
                            PrecioAlquiler precioalquiler = new PrecioAlquiler();

                            precioalquiler.Nombre_Cliente = cliente.Nombre;
                            precioalquiler.Marca = vehiculo.Marca;
                            precioalquiler.Modelo = vehiculo.Modelo;
                            precioalquiler.Color = vehiculo.Color;
                            precioalquiler.Fecha_Devolucion = alquiler.FechaDevolucion;
                            precioalquiler.Total_a_Pagar = vehiculo.PrecioKm * alquiler.KmRecorridos1;

                            precioAlquileres.Add(precioalquiler);

                        }

                    }
                    
                }
            }

            MostrarPrecioAlquileres();
            label5.Visible = true;
            labelVehiculoMasUsado.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

        }

        public void VehiculoMasUsado()
        {


            decimal mayor = precioAlquileres.Max(p => p.Total_a_Pagar);

            Alquiler Mayor = alquileres.OrderByDescending(p => p.KmRecorridos1).First();



            labelVehiculoMasUsado.Text = mayor.ToString();
            label6.Text = Mayor.KmRecorridos1.ToString();

        }

        public void MostrarPrecioAlquileres()
        {
            dataGridViewPrecioAlquileres.DataSource = null;
            dataGridViewPrecioAlquileres.DataSource = precioAlquileres;
            dataGridViewPrecioAlquileres.Refresh();
            VehiculoMasUsado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarDatosVehiculos ingresarDatosVehiculos = new IngresarDatosVehiculos();
            ingresarDatosVehiculos.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
