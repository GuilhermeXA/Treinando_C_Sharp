namespace SistemaINSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //Verificando se os campos estão preenchidos
            if (txtNome.Text == "")
            {
                MessageBox.Show("Atenção! Digite o nome!");
                txtNome.Focus();
            }
            else if (txtSalario.Text == "")
            {
                MessageBox.Show("Atenção! Digite o salário!");
                txtSalario.Focus();
            }
            else
            {
                string nome = txtNome.Text;
                double salario = Convert.ToDouble(txtSalario.Text);

                //Calculando o imposto
                if (salario <= 1320)
                {
                    txtPorcentagem.Text = "7,5%";
                    double valorDesconto = salario * 0.075;
                    txtValDescontar.Text = "R$" + Convert.ToString(valorDesconto.ToString("F2"));
                    double salarioFinal = salario - valorDesconto;
                    txtSalarioFinal.Text = "R$" + Convert.ToString(salarioFinal.ToString("F2"));
                }
                else if (salario <= 2571)
                {
                    txtPorcentagem.Text = "9%";
                    double valorDesconto = salario * 0.09;
                    txtValDescontar.Text = "R$" + Convert.ToString(valorDesconto.ToString("F2"));
                    double salarioFinal = salario - valorDesconto;
                    txtSalarioFinal.Text = "R$" + Convert.ToString(salarioFinal.ToString("F2"));
                }
                else if (salario <= 3856)
                {
                    txtPorcentagem.Text = "12%";
                    double valorDesconto = salario * 0.12;
                    txtValDescontar.Text = "R$" + Convert.ToString(valorDesconto.ToString("F2"));
                    double salarioFinal = salario - valorDesconto;
                    txtSalarioFinal.Text = "R$" + Convert.ToString(salarioFinal.ToString("F2"));
                }
                else if (salario <= 7507)
                {
                    txtPorcentagem.Text = "14%";
                    double valorDesconto = salario * 0.14;
                    txtValDescontar.Text = "R$" + Convert.ToString(valorDesconto.ToString("F2"));
                    double salarioFinal = salario - valorDesconto;
                    txtSalarioFinal.Text = "R$" + Convert.ToString(salarioFinal.ToString("F2"));
                }
                else
                {
                    txtPorcentagem.Text = "Inválido!";
                    double valorDesconto = 0;
                    txtValDescontar.Text = "R$" + Convert.ToString(valorDesconto.ToString("F2"));
                    double salarioFinal = salario - valorDesconto;
                    txtSalarioFinal.Text = "R$" + Convert.ToString(salarioFinal.ToString("F2"));
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSalario.Text = "";
            txtPorcentagem.Text = "";
            txtValDescontar.Text = "";
            txtSalarioFinal.Text = "";
        }
    }
}