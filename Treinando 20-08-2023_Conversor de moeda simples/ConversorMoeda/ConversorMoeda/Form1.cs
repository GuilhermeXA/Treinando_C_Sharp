namespace ConversorMoeda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double valorDolar))
            {
                if (double.TryParse(txtQtd.Text, out double qtdDolar))
                {
                    double conversao = valorDolar * qtdDolar;
                    txtResultado.Text = "R$" + conversao.ToString("N2"); // Exibe a convers�o com 2 casas decimais
                }
                else
                {
                    MessageBox.Show("Digite um valor v�lido para o valor em reais.");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor v�lido para o valor em d�lares.");
            }

            //Escrever vari�veis

        }
    }
}