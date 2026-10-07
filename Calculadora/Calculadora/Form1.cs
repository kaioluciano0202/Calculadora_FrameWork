using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Soma_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(Txt_Num1.Text); // Double convertendo para númeors com casas decimais 
            double valor2 = Convert.ToDouble(Txt_Num2.Text); // Double convertendo para númeors com casas decimais 

            double resultado = valor1 + valor2; // Convertendo resultado (Número quebrados)
            MessageBox.Show(resultado.ToString(), "RESULTADO DA ADIÇÃO"); // Metodo ToStrubg converte o valor Numeros em letras (Textos)
        }

        private void Btn_Subtracao_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(Txt_Num1.Text); // Int convertendo para números inteiros
            int valor2 = Convert.ToInt32(Txt_Num2.Text); // Int convertendo para números inteiros

            int resultado = valor1 - valor2; // Convertendo o resultado para inteiro
            MessageBox.Show(resultado.ToString(), "RESULTADO DA SUBTRAÇÃO"); // Metodo ToStrubg converte o valor Numeros em letras (Textos)
        }

        private void Btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(Txt_Num1.Text); // Int convertendo para números inteiros 
            int valor2 = Convert.ToInt32(Txt_Num2.Text); // Int convertendo para números inteiros

            int resultado = valor1 * valor2; // Convertendo o resultado para inteiro
            MessageBox.Show(resultado.ToString(), "RESULTADO DA MULTIPLICAÇÃO"); // Metodo ToStrubg converte o valor Numeros em letras (Textos)
        }

        private void Btn_Divisao_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(Txt_Num1.Text); // Int convertendo para números inteiros 
            int valor2 = Convert.ToInt32(Txt_Num2.Text); // Int convertendo para números inteiros

            int resultado = valor1 / valor2; // Convertendo o resultado para inteiro
            MessageBox.Show(resultado.ToString(), "RESULTADO DA DIVISÃO"); // Metodo ToStrubg converte o valor Numeros em letras (Textos)
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Num1.Clear(); // Apaga os valores do numero1
            Txt_Num2.Clear(); // Apaga os valores do numero2
        }
    }
}
