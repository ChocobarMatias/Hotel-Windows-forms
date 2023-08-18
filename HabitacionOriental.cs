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
    public partial class HabitacionOriental : Form
    {
        public int Horas() // funcion que retorna un entero
        {
            int preciohora = 0; // aca se crea la variable que actua como almacenador del precio del radio button seleccionado

            if (rdo1.Checked == true) // este if y los demas valida si esta seleccionado la opcion del radiobutton
            {
                preciohora = 2500;

            }
            if (rdo2.Checked == true)
            {
                preciohora = 3000;

            }
            if (rdo3.Checked == true)
            {
                preciohora = 4000;

            }
            if (rdoprueba.Checked == true)
            {
                preciohora = 4000;

            }

            return preciohora; // retorna el valor almacenado dependiendo de que opcion se selecciono
        }

        public int Agregados() // funcion para acumular y retornar el precio de checkbox seleccionados
        {
            int preciocheckBox = 0; // esta variable es el precio que va a tener cada checkbox
            int total = 0; // variable que actua acumulador de precio del checkbox seleccionado

            if (chkPepsi.Checked == true) // este if y los demas validan si esta seleccionada la opcion o no
            {
                preciocheckBox = 400;
                Datos.lblUno = chkPepsi.Text; // llamamos a la variable global para que agarre el texto del checkbox seleccionado y usarlo
                total += preciocheckBox; // acumula el precio del checkbox
            }
            if (chkCoca.Checked == true)
            {
                preciocheckBox = 400;
                Datos.lblDos = chkCoca.Text;

                total += preciocheckBox;
            }
            if (chkQuilmes.Checked == true)
            {
                preciocheckBox = 600;
                Datos.lblTres = chkQuilmes.Text;
                total += preciocheckBox;
            }
            if (chkFernet.Checked == true)
            {
                preciocheckBox = 800;
                Datos.lblCuatro = chkFernet.Text;
                total += preciocheckBox;
            }
            if (chkPreser.Checked == true)
            {
                preciocheckBox = 400;
                Datos.lblCinco = chkPreser.Text;
                total += preciocheckBox;
            }
            if (chkGel.Checked == true)
            {
                preciocheckBox = 2000;
                Datos.lblSeis = chkGel.Text;
                total += preciocheckBox;
            }
            if (chkSham.Checked == true)
            {
                preciocheckBox = 150;
                Datos.lblSiete = chkSham.Text;
                total += preciocheckBox;
            }
            if (chkAzul.Checked == true)
            {
                preciocheckBox = 500;
                Datos.lblOcho = chkAzul.Text;
                total += preciocheckBox;
            }

            return total; // retorna el precio acumulado

        }
        public HabitacionOriental()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)  // evento creado del boton para mostrar otro formulario y ocultar el anterior
        {
            Form formulario = new Habitaciones();
            formulario.Show();
            this.Hide();
        }


        private void CONFIRMAR_Click_1(object sender, EventArgs e) // evento de un boton que muestra el precio total de las opciones seleccionadas
        {
            int preciohora = 0; // precio para 1 hora 
            int preciocheckbox = 0; // acumula los precios de los checkboxs
            int pagar = 0; // variable creada para sumar


            if (rdo1.Checked == true)
            {
                preciohora = Horas(); // llamamos a la funcion que retorna el valor almacenado de un radio button

                preciocheckbox = Agregados(); // llamamos a la funcion que retorna el precio acumulado de los checkboxs

                pagar = preciohora + preciocheckbox; // suma el precio del radio button con los precios de los checkboxs seleccionados
                Datos.consumoUno = rdo1.Text; // Utilizamos a una variable global para mostrar el texto del radio button en otro formulario
            }

            if (rdo2.Checked == true)
            {
                preciohora = Horas();

                preciocheckbox = Agregados();

                pagar = preciohora + preciocheckbox;
                Datos.consumoUno = rdo2.Text;


            }

            if (rdo3.Checked == true)
            {
                preciohora = Horas();

                preciocheckbox = Agregados();

                pagar = preciohora + preciocheckbox;
                Datos.consumoUno = rdo3.Text;


            }

            if (rdoprueba.Checked == true)
            {
                preciohora = Horas();

                preciocheckbox = Agregados();

                pagar = preciohora + preciocheckbox;
                Datos.consumoUno = rdoprueba.Text;


            }

            Pago1.Text = $"$ {pagar.ToString()}"; // Muestra en el label ,utilizando toString, la suma total 
            Datos.valor = pagar; //variable global para almacenar el valor total y llamarla en otros formularios
        }

        private void button1_Click(object sender, EventArgs e) //evento creado para dirigirse al formulario llamado pagar
        {
            int preciohora = 0; // precio para 1 hora 
            int preciocheckbox = 0; // acumula los precios de los checkboxs
            int pagar = 0; // variable creada para sumar

            if (rdo1.Checked == true)
            {
                preciohora = Horas(); // llamamos a la funcion que retorna el valor almacenado de un radio button

                preciocheckbox = Agregados(); // llamamos a la funcion que retorna el precio acumulado de los checkboxs

                pagar = preciohora + preciocheckbox; // suma el precio del radio button con los precios de los checkboxs seleccionados
                Datos.consumoUno = rdo1.Text; // Utilizamos a una variable global para mostrar el texto del radio button en otro formulario
            }

            if (rdo2.Checked == true)
            {
                preciohora = Horas();

                preciocheckbox = Agregados();

                pagar = preciohora + preciocheckbox;
                Datos.consumoUno = rdo2.Text;


            }

            if (rdo3.Checked == true)
            {
                preciohora = Horas();

                preciocheckbox = Agregados();

                pagar = preciohora + preciocheckbox;
                Datos.consumoUno = rdo3.Text;


            }

            if (rdoprueba.Checked == true)
            {
                preciohora = Horas();

                preciocheckbox = Agregados();

                pagar = preciohora + preciocheckbox;
                Datos.consumoUno = rdoprueba.Text;


            }

            Form formulario = new Pagar();
            formulario.Show();
            this.Hide();
        }
    }
}
