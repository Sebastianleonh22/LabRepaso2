
namespace LabRepaso2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewVehiiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewPrecioAlquileres = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerAlquiler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVehiculoMasUsado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecioAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehiiculos
            // 
            this.dataGridViewVehiiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiiculos.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewVehiiculos.Name = "dataGridViewVehiiculos";
            this.dataGridViewVehiiculos.Size = new System.Drawing.Size(664, 78);
            this.dataGridViewVehiiculos.TabIndex = 0;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 143);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(664, 78);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // dataGridViewPrecioAlquileres
            // 
            this.dataGridViewPrecioAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrecioAlquileres.Location = new System.Drawing.Point(12, 401);
            this.dataGridViewPrecioAlquileres.Name = "dataGridViewPrecioAlquileres";
            this.dataGridViewPrecioAlquileres.Size = new System.Drawing.Size(664, 78);
            this.dataGridViewPrecioAlquileres.TabIndex = 2;
            this.dataGridViewPrecioAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(574, 341);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(102, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Desplegar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos de vehiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datos de clientes";
            // 
            // btnVerAlquiler
            // 
            this.btnVerAlquiler.Location = new System.Drawing.Point(557, 485);
            this.btnVerAlquiler.Name = "btnVerAlquiler";
            this.btnVerAlquiler.Size = new System.Drawing.Size(119, 23);
            this.btnVerAlquiler.TabIndex = 6;
            this.btnVerAlquiler.Text = "Ver Total a pagar";
            this.btnVerAlquiler.UseVisualStyleBackColor = true;
            this.btnVerAlquiler.Click += new System.EventHandler(this.btnVerAlquiler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos de los alquileres";
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(12, 257);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(664, 78);
            this.dataGridViewAlquileres.TabIndex = 8;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(574, 114);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(102, 23);
            this.btnAgregarVehiculo.TabIndex = 9;
            this.btnAgregarVehiculo.Text = "Agregar vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total a pagar alquiler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehiculo mas recorrido :";
            this.label5.Visible = false;
            // 
            // labelVehiculoMasUsado
            // 
            this.labelVehiculoMasUsado.AutoSize = true;
            this.labelVehiculoMasUsado.Location = new System.Drawing.Point(285, 385);
            this.labelVehiculoMasUsado.Name = "labelVehiculoMasUsado";
            this.labelVehiculoMasUsado.Size = new System.Drawing.Size(35, 13);
            this.labelVehiculoMasUsado.TabIndex = 12;
            this.labelVehiculoMasUsado.Text = "label6";
            this.labelVehiculoMasUsado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 518);
            this.Controls.Add(this.labelVehiculoMasUsado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerAlquiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridViewPrecioAlquileres);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.dataGridViewVehiiculos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecioAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehiiculos;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewPrecioAlquileres;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerAlquiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVehiculoMasUsado;
    }
}

