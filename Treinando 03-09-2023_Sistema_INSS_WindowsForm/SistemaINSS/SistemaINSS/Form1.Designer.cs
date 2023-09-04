namespace SistemaINSS
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
            txtNome = new TextBox();
            label2 = new Label();
            txtSalario = new TextBox();
            label3 = new Label();
            txtPorcentagem = new TextBox();
            label4 = new Label();
            txtValDescontar = new TextBox();
            label5 = new Label();
            txtSalarioFinal = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(110, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(656, 34);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 88);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 0;
            label2.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(110, 85);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(150, 34);
            txtSalario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 88);
            label3.Name = "label3";
            label3.Size = new Size(239, 28);
            label3.TabIndex = 0;
            label3.Text = "Porcentagem a Descontar:";
            // 
            // txtPorcentagem
            // 
            txtPorcentagem.Location = new Point(511, 85);
            txtPorcentagem.Name = "txtPorcentagem";
            txtPorcentagem.Size = new Size(255, 34);
            txtPorcentagem.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 141);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 0;
            label4.Text = "Valor a Descontar:";
            // 
            // txtValDescontar
            // 
            txtValDescontar.Location = new Point(214, 138);
            txtValDescontar.Name = "txtValDescontar";
            txtValDescontar.Size = new Size(164, 34);
            txtValDescontar.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 141);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 0;
            label5.Text = "Salário Final:";
            // 
            // txtSalarioFinal
            // 
            txtSalarioFinal.Location = new Point(524, 138);
            txtSalarioFinal.Name = "txtSalarioFinal";
            txtSalarioFinal.Size = new Size(242, 34);
            txtSalarioFinal.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(39, 193);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(356, 55);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(410, 193);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(356, 55);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(801, 273);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalarioFinal);
            Controls.Add(label5);
            Controls.Add(txtValDescontar);
            Controls.Add(label4);
            Controls.Add(txtPorcentagem);
            Controls.Add(label3);
            Controls.Add(txtSalario);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtSalario;
        private Label label3;
        private TextBox txtPorcentagem;
        private Label label4;
        private TextBox txtValDescontar;
        private Label label5;
        private TextBox txtSalarioFinal;
        private Button btnCalcular;
        private Button btnLimpar;
    }
}