using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaDeCadastro
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=LAPTOP-5M9EP0AR\SQLEXPRESS;Initial Catalog=C_SharpBD;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;
            DateTime dataCadastro = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cadastro (Nome, Endereco, Telefone, DataCadastro) VALUES (@Nome, @Endereco, @Telefone, @DataCadastro)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@DataCadastro", dataCadastro);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            LimparCampos();
            AtualizarDataGridView();
            MessageBox.Show("Cadastro realizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar.");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cadastro SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            LimparCampos();
            AtualizarDataGridView();
            MessageBox.Show("Cadastro editado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Cadastro WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                LimparCampos();
                AtualizarDataGridView();
                MessageBox.Show("Cadastro excluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtId.Text = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                txtNome.Text = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtEndereco.Text = dataGridView1.SelectedRows[0].Cells["Endereco"].Value.ToString();
                txtTelefone.Text = dataGridView1.SelectedRows[0].Cells["Telefone"].Value.ToString();
                txtDataCad.Text = dataGridView1.SelectedRows[0].Cells["DataCadastro"].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtDataCad.Clear();
        }

        private void AtualizarDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cadastro";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}