namespace calculadora
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
            txtPN = new Label();
            txtSN = new Label();
            label3 = new Label();
            tbPrimerNum = new TextBox();
            tbSegundoNum = new TextBox();
            tbResultado = new TextBox();
            btnSuma = new Button();
            btnMultiplicacion = new Button();
            btnResta = new Button();
            btnDivicion = new Button();
            SuspendLayout();
            // 
            // txtPN
            // 
            txtPN.AutoSize = true;
            txtPN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPN.Location = new Point(12, 42);
            txtPN.Name = "txtPN";
            txtPN.Size = new Size(212, 21);
            txtPN.TabIndex = 0;
            txtPN.Text = "Introduzca el primer numero:";
            txtPN.Click += label1_Click;
            // 
            // txtSN
            // 
            txtSN.AutoSize = true;
            txtSN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSN.Location = new Point(12, 90);
            txtSN.Name = "txtSN";
            txtSN.Size = new Size(225, 21);
            txtSN.TabIndex = 1;
            txtSN.Text = "Introduzca el segundo numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // tbPrimerNum
            // 
            tbPrimerNum.Location = new Point(251, 44);
            tbPrimerNum.Name = "tbPrimerNum";
            tbPrimerNum.Size = new Size(100, 23);
            tbPrimerNum.TabIndex = 3;
            tbPrimerNum.TextAlign = HorizontalAlignment.Right;
            // 
            // tbSegundoNum
            // 
            tbSegundoNum.Location = new Point(251, 92);
            tbSegundoNum.Name = "tbSegundoNum";
            tbSegundoNum.Size = new Size(100, 23);
            tbSegundoNum.TabIndex = 4;
            tbSegundoNum.TextAlign = HorizontalAlignment.Right;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(251, 138);
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(100, 23);
            tbResultado.TabIndex = 5;
            tbResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuma.Location = new Point(394, 55);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(52, 40);
            btnSuma.TabIndex = 6;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacion.Location = new Point(394, 121);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(52, 40);
            btnMultiplicacion.TabIndex = 7;
            btnMultiplicacion.Text = "*";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResta.Location = new Point(477, 55);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(52, 40);
            btnResta.TabIndex = 8;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDivicion
            // 
            btnDivicion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivicion.Location = new Point(477, 121);
            btnDivicion.Name = "btnDivicion";
            btnDivicion.Size = new Size(52, 40);
            btnDivicion.TabIndex = 9;
            btnDivicion.Text = "/";
            btnDivicion.UseMnemonic = false;
            btnDivicion.UseVisualStyleBackColor = true;
            btnDivicion.Click += btnDivicion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 186);
            Controls.Add(btnDivicion);
            Controls.Add(btnResta);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnSuma);
            Controls.Add(tbResultado);
            Controls.Add(tbSegundoNum);
            Controls.Add(tbPrimerNum);
            Controls.Add(label3);
            Controls.Add(txtSN);
            Controls.Add(txtPN);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtPN;
        private Label txtSN;
        private Label label3;
        private TextBox tbPrimerNum;
        private TextBox tbSegundoNum;
        private TextBox tbResultado;
        private Button btnSuma;
        private Button btnMultiplicacion;
        private Button btnResta;
        private Button btnDivicion;
    }
}