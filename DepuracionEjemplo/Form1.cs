using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepuracionEjemplo
{
    public partial class Form1 : Form
    {
        FuncionesRelleno funcionesRelleno = new FuncionesRelleno();
        FuncionFibonacci funcionFibonacci = new FuncionFibonacci();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            funcionesRelleno.setNumero(int.Parse(txtnumero.Text));
            lbvalores.Items.Clear();
            lvnumeros.Clear();
            foreach (int valores in funcionesRelleno.rellenar())
            {
                lvnumeros.Items.Add(valores.ToString());
                lbvalores.Items.Add(valores.ToString());
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionFibonacci.setNumero(int.Parse(txtnumero.Text));
            lbvalores.Items.Clear();
            lvnumeros.Clear();
            foreach (int valores in funcionFibonacci.llenar())
            {
                lvnumeros.Items.Add(valores.ToString());
                lbvalores.Items.Add(valores.ToString());
            }
        }
    }
}
