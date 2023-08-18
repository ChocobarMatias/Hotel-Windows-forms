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
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                if (((txtUsuario.Text == "hola") && (txtContraseña.Text == "hola")))
                {
                    Form1 Form1Inicio = new Form1();
                    this.Hide();
                    Form1Inicio.Show();

                }
                else
                {
                    MessageBox.Show("Datos Ingresados incorrectos");
                }
            
         }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

       
        private void btnLogin3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
