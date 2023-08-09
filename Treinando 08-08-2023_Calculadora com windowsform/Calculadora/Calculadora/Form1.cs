using System.Data;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double currentValue = 0;
        private string currentOperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtCalculos.Text += button.Text;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtCalculos.Text += " " + button.Text + " ";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expressao = txtCalculos.Text;
                DataTable table = new DataTable();
                var resultado = table.Compute(expressao, "");
                txtCalculos.Text = resultado.ToString();
            }
            catch (Exception)
            {
                txtCalculos.Text = "Erro";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            currentInput = "";
            currentValue = 0;
            currentOperator = "";
            txtCalculos.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}