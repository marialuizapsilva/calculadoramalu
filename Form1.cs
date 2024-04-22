using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoramalu

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxdisplay.Clear();
        }

        private void button2_apagar_Click(object sender, EventArgs e)
        {
            if (textBoxdisplay.Text.Length > 0)
                textBoxdisplay.Text =
                     textBoxdisplay.Text.Remove(textBoxdisplay.Text.Length - 1, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxdisplay.Text);
        }


        private void buttonNum_Click(object sender, EventArgs e)
        {

            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += ",";
        }


        //enum é uma lista de opções
        enum Operacao
        {
            soma,
            subtrai,
            divide,
            multiplica,
            nenhuma
        }
        //declaração da variavél "ultimaOperacao".
        private void FazerCalculo(Operacao ultimaOperacao)
        {
           //uma lista de números do tipo double (real)
           //uma lista é um vetor MELHORADO

           List<double> ListaDeNumeros = new List<double>();

           switch (ultimaOperacao)
            {
            case Operacao.soma:
                    ListaDeNumeros = textBoxdisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxdisplay.Text = (ListaDeNumeros[0] + ListaDeNumeros[1].ToString());
                    break;
            case Operacao.subtrai:
                ListaDeNumeros = textBoxdisplay.Text.Split('-').Select(double.Parse).ToList();
                textBoxdisplay.Text = (ListaDeNumeros[0] - ListaDeNumeros[1].ToString());
                break; 
            case Operacao.divide:
                ListaDeNumeros = textBoxdisplay.Text.Split('/').Select(double.Parse).ToList();
                break;
            case Operacao.multiplica:
                break;
            case Operacao.nenhuma:
                break;
            default:
                break;
            }
            //exibe os números no display
        }
          
        

        static Operacao ultimaOperacao = Operacao.nenhuma;

        private void buttonSoma4_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.soma;
            }
            else FazerCalculo(ultimaOperacao);

            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void button_subtracao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.subtrai;
            }
            else FazerCalculo(ultimaOperacao);

            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void button_multiplicacao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.multiplica;
            }
            else FazerCalculo(ultimaOperacao);

            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void button_divisao_Click(object sender, EventArgs e)
        {

            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.divide;
            }
            else FazerCalculo(ultimaOperacao);

            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacao.nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacao.nenhuma;
        }
    }
    }

   
    
   