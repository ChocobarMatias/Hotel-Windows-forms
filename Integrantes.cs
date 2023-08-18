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
    public partial class Integrantes : Form
    {
        string img; // string para llamar a la imagen
        int i = 0; // creamos un entero para que se mueva la posicion del vector
        string[] numero = {"1", "2", "3", "4" }; // creamos un vector de 4 posiciones
        public Integrantes()
        {
            InitializeComponent();
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
            // el click cierra el formulario actual y nos envia al seleccionado
        }

        private void Integrantes_load(object sender, EventArgs e)
        {
            img = "wwe" + numero[i] + ".jpg"; 
            picintegrantes.Image = Image.FromFile(@"C:\Users\marco\Desktop\wwe\" + img);  // ruta de la carpeta de las imagenes
        }

        private void btnder_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                i++;
                img = "wwe" + numero[i] + ".jpg" ; // en este if hacemos que el button derecho sume 
                                                   // y a su vez se mueva 
            }

            picintegrantes.Image = Image.FromFile(@"C:\Users\marco\Desktop\wwe\" + img);  // mostramos la imagen 
        }

        private void btnizq_Click(object sender, EventArgs e)
        {

            if (i > 0)
            {
                i--;
                img = "wwe" + numero[i] + ".jpg"; // en este if hacemos que el button izquierdo reste 
            }                                     // y a su vez se mueva 

            picintegrantes.Image = Image.FromFile(@"C:\Users\marco\Desktop\wwe\" + img); // mostramos la imagen 

        }
    }
}
