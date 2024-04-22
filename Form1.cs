using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCarlos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (texBoxDisplay.Text.Lengh > 0)
            {
                TextBoxDisplay.Text =
                    textBoxDisplay.Text.Remove();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (ultimaOperacao) 
            {
                case Operacao.Soma:
                    ListaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    break;
                case Operacao.Subtrai:
                    ListaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (Listadenumeros[0] - Listadenumeros[1]).ToString();
                    break;
                case Operacao.Divide:
                    listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros)

                    case Operacao.Multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros)
            }
        }
            
    }
}

        private void buttonZero_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }
private void object sender, EventArgs e)
{

}