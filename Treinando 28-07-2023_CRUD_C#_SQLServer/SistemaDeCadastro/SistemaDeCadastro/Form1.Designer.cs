namespace SistemaDeCadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            label4 = new Label();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtDataCad = new TextBox();
            dataGridView1 = new DataGridView();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(64, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(71, 31);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 28);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(224, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(570, 31);
            txtNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 73);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(119, 70);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(675, 31);
            txtEndereco.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 118);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 0;
            label4.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Location = new Point(119, 115);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(281, 31);
            txtTelefone.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 118);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 0;
            label5.Text = "Data de Cadastro:";
            // 
            // txtDataCad
            // 
            txtDataCad.BorderStyle = BorderStyle.FixedSingle;
            txtDataCad.Location = new Point(576, 115);
            txtDataCad.Name = "txtDataCad";
            txtDataCad.Size = new Size(218, 31);
            txtDataCad.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(770, 210);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView_SelectionChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(24, 399);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(248, 82);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(285, 399);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(248, 82);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(546, 399);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(248, 82);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(817, 505);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(dataGridView1);
            Controls.Add(txtDataCad);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtEndereco);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sistema de Cadastro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEndereco;
        private Label label4;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtDataCad;
        private DataGridView dataGridView1;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}