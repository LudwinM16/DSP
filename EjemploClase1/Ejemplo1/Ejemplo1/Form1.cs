using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private string mensa;
        private static int conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento se ejecuta al iniciar ejecución de Forms1
            mensa = "Aún no se ha presionado el botón contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //int conta = 0;
            //Acumulador, total de veces que se presiona el botón
            conta = conta + 1;
            //conta+=1; //en forma de operador abreviado

            mensa = " Presionó el botón Contar un total de " + Convert.ToString(conta) + " veces"; //convert me pasa mi variable conta de int a string
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //restaura conteo clic realizado a button1
            conta = 0;
            mensa = "Presionó el botón contar un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
