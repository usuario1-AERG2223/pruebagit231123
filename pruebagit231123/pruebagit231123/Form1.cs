using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebagit231123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0;//! usuario1 damos valor inicial 0
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked) //! usuario1 cambia radioboton
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (rbOrdinario.Checked) //! usuario1 cambia radioboton
                if (tipoTelegrama == 'o')
                {
                    if (numPalabras <= 10)
                        coste = 2.5;//! cambio precio
                    else
                        coste = 2.5 + 0.5 * (numPalabras - 10);//! usuario1 cambia formula
                }
                else
                //Si el telegrama es urgente
                if (tipoTelegrama == 'u')
                {

                    if (numPalabras <= 10)
                        coste = 5;
                    else
                        coste = 5 + 0.75 * (numPalabras - 10);
                }

                else
                    coste = 0;
                
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
