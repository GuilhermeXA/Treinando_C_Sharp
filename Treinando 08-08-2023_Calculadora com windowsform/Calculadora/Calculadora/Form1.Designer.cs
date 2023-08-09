namespace Calculadora
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
            txtCalculos = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSoma = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtracao = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicacao = new Button();
            btnLimpar = new Button();
            btn0 = new Button();
            btnDivisao = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtCalculos
            // 
            txtCalculos.BorderStyle = BorderStyle.FixedSingle;
            txtCalculos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalculos.Location = new Point(26, 29);
            txtCalculos.Name = "txtCalculos";
            txtCalculos.Size = new Size(354, 43);
            txtCalculos.TabIndex = 17;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(26, 91);
            btn1.Name = "btn1";
            btn1.Size = new Size(84, 84);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumero_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(116, 91);
            btn2.Name = "btn2";
            btn2.Size = new Size(84, 84);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumero_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(206, 91);
            btn3.Name = "btn3";
            btn3.Size = new Size(84, 84);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumero_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoma.Location = new Point(296, 91);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(84, 84);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnOperador_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(26, 181);
            btn4.Name = "btn4";
            btn4.Size = new Size(84, 84);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumero_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(116, 181);
            btn5.Name = "btn5";
            btn5.Size = new Size(84, 84);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumero_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(206, 181);
            btn6.Name = "btn6";
            btn6.Size = new Size(84, 84);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumero_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(296, 181);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(84, 84);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnOperador_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(26, 271);
            btn7.Name = "btn7";
            btn7.Size = new Size(84, 84);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumero_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(116, 271);
            btn8.Name = "btn8";
            btn8.Size = new Size(84, 84);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumero_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(206, 271);
            btn9.Name = "btn9";
            btn9.Size = new Size(84, 84);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumero_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(296, 271);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(84, 84);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnOperador_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(26, 361);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(84, 84);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(116, 361);
            btn0.Name = "btn0";
            btn0.Size = new Size(84, 84);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumero_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivisao.Location = new Point(296, 361);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(84, 84);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnOperador_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIgual.Location = new Point(206, 361);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(84, 84);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 476);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btnLimpar);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtCalculos);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalculos;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSoma;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtracao;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicacao;
        private Button btnLimpar;
        private Button btn0;
        private Button btnDivisao;
        private Button btnIgual;
    }
}