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
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
            bool auxUno = false;
            auxUno = Datos.isReservado;
            if (auxUno == true)
            {
                btnReservado1.Text = "Ocupado";
                btnReservado1.BackColor = Color.Red;
   
            }
            if (Datos.isReservado == true)
            {
                btnReservado2.Text = "Ocupado";
                btnReservado2.BackColor = Color.Red;

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new HabitacionVIP();
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new HabitacionPremium();
            formulario.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new HabitacionOriental();
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new HabitacionJacuzzy();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Form formulario = new HabitacionTach();
            formulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new HabitacionSimple();
            formulario.Show();
            this.Hide();
        }

      

        private void lblOcupado1_Click(object sender, EventArgs e)
        {
          
        }

       
    }
}
