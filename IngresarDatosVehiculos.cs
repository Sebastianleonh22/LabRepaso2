using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepaso2
{
    public partial class IngresarDatosVehiculos : Form
    {
        public IngresarDatosVehiculos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        Form1 form1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPlaca.Text) ||
                string.IsNullOrWhiteSpace(textBoxMarca.Text) ||
                string.IsNullOrWhiteSpace(textBoxModelo.Text) ||
                string.IsNullOrWhiteSpace(textBoxColor.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecioKm.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del método si algún campo está vacío
            }

            
            Vehiculo vehiculo1 = vehiculos.Find(c => c.Placa == textBoxPlaca.Text);
            if(vehiculo1 == null)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = textBoxPlaca.Text;
                vehiculo.Marca = textBoxMarca.Text;
                vehiculo.Modelo = textBoxModelo.Text;
                vehiculo.Color = textBoxColor.Text;
                vehiculo.PrecioKm = Convert.ToInt32(textBoxPrecioKm.Text);

                vehiculos.Add(vehiculo);

                using (FileStream stream = new FileStream("Vehiculos.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        for (int i = 0; i < vehiculos.Count; i++)
                        {
                            writer.WriteLine(vehiculos[i].Placa);
                            writer.WriteLine(vehiculos[i].Marca);
                            writer.WriteLine(vehiculos[i].Modelo);
                            writer.WriteLine(vehiculos[i].Color);
                            writer.WriteLine(vehiculos[i].PrecioKm);
                        }
                    }
                }

                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("ya wxiste esta placa");
            }
            



            form1.Show();
            this.Hide();

            
        }


        private void IngresarDatosVehiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            

            this.Hide();
            form1.Show();
        }
    }
}
