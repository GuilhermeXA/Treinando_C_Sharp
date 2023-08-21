namespace ConversorMoeda
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
            txtDolar = new TextBox();
            txtQtd = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            btnConverter = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtDolar
            // 
            txtDolar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDolar.Location = new Point(211, 34);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(125, 34);
            txtDolar.TabIndex = 1;
            // 
            // txtQtd
            // 
            txtQtd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtd.Location = new Point(211, 80);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(125, 34);
            txtQtd.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(211, 123);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 34);
            txtResultado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 1;
            label1.Text = "Dolar";
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConverter.Location = new Point(34, 189);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(302, 53);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 83);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 1;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 126);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 1;
            label3.Text = "Resultado em Real";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 277);
            Controls.Add(btnConverter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtQtd);
            Controls.Add(txtDolar);
            Name = "Form1";
            Text = "Conversor de dólar para real";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDolar;
        private TextBox txtQtd;
        private TextBox txtResultado;
        private Label label1;
        private Button btnConverter;
        private Label label2;
        private Label label3;
    }
}