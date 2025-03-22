using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool soma = false;
        private bool subtracao = false;
        private bool dividir = false;
        private bool multiplicar = false;
        private bool operacaoRealizada = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
            operacaoRealizada = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
            operacaoRealizada = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
            operacaoRealizada = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
            operacaoRealizada = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
            operacaoRealizada = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
            operacaoRealizada = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
            operacaoRealizada = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
            operacaoRealizada = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
            operacaoRealizada = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
            operacaoRealizada = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            subtracao = false;
            dividir = false;
            multiplicar = false;
            soma = true;

            if (txtresultado.Text.Contains("+")
                || txtresultado.Text.Contains("-")
                || txtresultado.Text.Contains("*")
                || txtresultado.Text.Contains("/"))
                return;

            if (txtresultado.Text[txtresultado.Text.Length - 1] == '-'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '*'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '/')
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1);
            }
            if (txtresultado.Text[txtresultado.Text.Length - 1] == '+')
                return;
            txtresultado.Text += "+";
            operacaoRealizada = false;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            subtracao = true;
            dividir = false;
            multiplicar = false;
            soma = false;

            if (txtresultado.Text.Contains("+")
                || txtresultado.Text.Contains("-")
                || txtresultado.Text.Contains("*")
                || txtresultado.Text.Contains("/"))
                return ;

                if (txtresultado.Text[txtresultado.Text.Length - 1] == '+'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '*'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '/')
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1);
            }
            if (txtresultado.Text[txtresultado.Text.Length - 1] == '-')
                return;
            txtresultado.Text += "-";
            operacaoRealizada = false;

        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            subtracao = false;
            dividir = false;
            multiplicar = true;
            soma = false;

            if (txtresultado.Text.Contains("+")
                || txtresultado.Text.Contains("-")
                || txtresultado.Text.Contains("*")
                || txtresultado.Text.Contains("/"))
                return;

            if (txtresultado.Text[txtresultado.Text.Length - 1] == '+'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '-'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '/')
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1);
            }
            if (txtresultado.Text[txtresultado.Text.Length - 1] == '*')
                return;
            txtresultado.Text += "*";
            operacaoRealizada = false;

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            subtracao = false;
            dividir = true;
            multiplicar = false;
            soma = false;

            if (txtresultado.Text.Contains("+")
                || txtresultado.Text.Contains("-")
                || txtresultado.Text.Contains("*")
                || txtresultado.Text.Contains("/"))
                return;

            if (txtresultado.Text[txtresultado.Text.Length - 1] == '+'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '-'
                || txtresultado.Text[txtresultado.Text.Length - 1] == '*')
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1);
            }
            if (txtresultado.Text[txtresultado.Text.Length - 1] == '/')
                return;
            txtresultado.Text += "/";
            operacaoRealizada = false;

        }


        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (operacaoRealizada)
            {
                return;
            }

            if (soma)
            {
                List<string> aSoma = txtresultado.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSoma[0]);
                double segundoNumero = Convert.ToDouble(aSoma[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtresultado.Text = resultado.ToString();
            }
            else if (subtracao)
            {
                List<string> aSubtracao = txtresultado.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtracao[0]);
                double segundoNumero = Convert.ToDouble(aSubtracao[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtresultado.Text = resultado.ToString();
            }
            else if (multiplicar)
            {
                List<string> aMultiplicar = txtresultado.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtresultado.Text = resultado.ToString();
            }
            else if (dividir)
            {
                List<string> aDividir = txtresultado.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                double resultado = primeiroNumero / segundoNumero;
                txtresultado.Text = resultado.ToString();
            }

            operacaoRealizada = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            soma = false;
            subtracao = false;
            dividir = false;
            multiplicar = false;
            operacaoRealizada = false;

        }
    }
}
