using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo1_Com2
{
    public partial class Pagar : Form
    {
        double descuento = 0;
        public Pagar()
        {
            InitializeComponent();
            lblConsumo1.Text = Datos.consumoUno; // Usamos la variable global para mostrar en el label el consumo
            lblValor.Text += Datos.valor; // Variable global que muestra el valor total acumulado
            lblUno.Text = $" {Datos.lblUno} \n {Datos.lblDos} \n {Datos.lblTres} \n {Datos.lblCuatro}"; // variable global usada en una interpolacion para mostrar en lista los checkboxs seleccionado el formulario de una habitacion
            lblDos.Text = $" {Datos.lblCinco} \n {Datos.lblSeis} \n {Datos.lblSiete} \n {Datos.lblOcho}";            
            descuento = Datos.valor; // le damos un valor principal de una variable globar, pero dependiendo de las opciones seleccionadas va a ir cambiando mas abajo

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Habitaciones();
            formulario.Show();
           
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Habitacion reservada con exito! Lo abonado fue ${descuento}");
            Datos.isReservado = true; // Usamos la variable globar para determinar si esta ocupada o no una habitacion
            
            Form formulario = new Habitaciones();
            formulario.Show();
            this.Hide();
        }

        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoEfectivo.Checked == true)
            {
                descuento = Datos.valor * 0.9; // aca cambia la variable descuento y realiza un calculo dependiendo del radiobutton seleccionado
                lblValor.Text = $"${descuento.ToString()}";

            }

        }

        private void rdoTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTarjeta.Checked == true)
            {
                descuento = Datos.valor * 1.15;
                lblValor.Text = $"${descuento.ToString()}"; // usamos la variable descuento para convertirlo a string e interpolarlo para mostrarlo en un label usando el metodo string

            }
        }

        private void rdoCrypto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCrypto.Checked == true)
            {
                descuento = Datos.valor * 0.8;
                lblValor.Text = $"${descuento.ToString()}";

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


         

            if (rdoTarjeta.Checked == true)
            {
                descuento = Datos.valor * 1.15;
                lblValor.Text = $"${descuento.ToString()}";

            }
        }

        
    }
}
