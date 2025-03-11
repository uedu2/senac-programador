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
            Numero1 = new TextBox();
            numero2 = new TextBox();
            mais = new Button();
            resultado = new Label();
            menos = new Button();
            dividir = new Button();
            multiplicar = new Button();
            simbolo = new Label();
            wesley = new Button();
            SuspendLayout();
            // 
            // Numero1
            // 
            Numero1.Location = new Point(145, 134);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(100, 23);
            Numero1.TabIndex = 0;
            Numero1.TextChanged += Numero1_TextChanged;
            // 
            // numero2
            // 
            numero2.Location = new Point(332, 134);
            numero2.Name = "numero2";
            numero2.Size = new Size(100, 23);
            numero2.TabIndex = 1;
            numero2.TextChanged += numero2_TextChanged;
            // 
            // mais
            // 
            mais.Location = new Point(250, 188);
            mais.Name = "mais";
            mais.Size = new Size(75, 23);
            mais.TabIndex = 4;
            mais.Text = "+";
            mais.Click += mais_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultado.ForeColor = SystemColors.Control;
            resultado.Location = new Point(458, 136);
            resultado.Name = "resultado";
            resultado.Size = new Size(113, 21);
            resultado.TabIndex = 3;
            resultado.Text = "fsdfsdfsdfsdfdf";
            resultado.Click += resultado_Click;
            // 
            // menos
            // 
            menos.Location = new Point(145, 188);
            menos.Name = "menos";
            menos.Size = new Size(75, 23);
            menos.TabIndex = 5;
            menos.Text = "-";
            menos.Click += menos_Click;
            // 
            // dividir
            // 
            dividir.Location = new Point(357, 188);
            dividir.Name = "dividir";
            dividir.Size = new Size(75, 23);
            dividir.TabIndex = 6;
            dividir.Text = "/";
            dividir.Click += dividir_Click;
            // 
            // multiplicar
            // 
            multiplicar.Location = new Point(145, 261);
            multiplicar.Name = "multiplicar";
            multiplicar.Size = new Size(75, 23);
            multiplicar.TabIndex = 7;
            multiplicar.Text = "*";
            multiplicar.Click += multiplicar_Click;
            // 
            // simbolo
            // 
            simbolo.AutoSize = true;
            simbolo.BackColor = Color.Transparent;
            simbolo.ForeColor = SystemColors.Control;
            simbolo.Location = new Point(265, 141);
            simbolo.Name = "simbolo";
            simbolo.Size = new Size(39, 15);
            simbolo.TabIndex = 10;
            simbolo.Text = "()()()()";
            simbolo.Click += simbolo_Click;
            // 
            // wesley
            // 
            wesley.Location = new Point(357, 261);
            wesley.Name = "wesley";
            wesley.Size = new Size(75, 23);
            wesley.TabIndex = 11;
            wesley.Text = "Wesley";
            wesley.Click += wesley_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wesley);
            Controls.Add(simbolo);
            Controls.Add(multiplicar);
            Controls.Add(dividir);
            Controls.Add(menos);
            Controls.Add(resultado);
            Controls.Add(mais);
            Controls.Add(numero2);
            Controls.Add(Numero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero1;
        private TextBox numero2;
        private Button mais;
        private Label resultado;
        private Button menos;
        private Button dividir;
        private Button multiplicar;
        private Label simbolo;
        private Button wesley;
    }
}
