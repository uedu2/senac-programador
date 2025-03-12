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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Numero1
            // 
            Numero1.Location = new Point(54, 133);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(100, 23);
            Numero1.TabIndex = 0;
            Numero1.TextChanged += Numero1_TextChanged;
            // 
            // numero2
            // 
            numero2.Location = new Point(350, 133);
            numero2.Name = "numero2";
            numero2.Size = new Size(100, 23);
            numero2.TabIndex = 1;
            numero2.TextChanged += numero2_TextChanged;
            // 
            // mais
            // 
            mais.Anchor = AnchorStyles.None;
            mais.Cursor = Cursors.Hand;
            mais.Location = new Point(202, 51);
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
            resultado.ForeColor = SystemColors.ActiveCaptionText;
            resultado.Location = new Point(458, 136);
            resultado.Name = "resultado";
            resultado.Size = new Size(113, 21);
            resultado.TabIndex = 3;
            resultado.Text = "fsdfsdfsdfsdfdf";
            resultado.Click += resultado_Click;
            // 
            // menos
            // 
            menos.Anchor = AnchorStyles.None;
            menos.Cursor = Cursors.Hand;
            menos.Location = new Point(42, 51);
            menos.Name = "menos";
            menos.Size = new Size(75, 23);
            menos.TabIndex = 5;
            menos.Text = "-";
            menos.Click += menos_Click;
            // 
            // dividir
            // 
            dividir.Anchor = AnchorStyles.None;
            dividir.Cursor = Cursors.Hand;
            dividir.Location = new Point(363, 51);
            dividir.Name = "dividir";
            dividir.Size = new Size(75, 23);
            dividir.TabIndex = 6;
            dividir.Text = "/";
            dividir.Click += dividir_Click;
            // 
            // multiplicar
            // 
            multiplicar.Anchor = AnchorStyles.None;
            multiplicar.Cursor = Cursors.Hand;
            multiplicar.Location = new Point(42, 176);
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
            simbolo.ForeColor = SystemColors.ActiveCaptionText;
            simbolo.Location = new Point(227, 136);
            simbolo.Name = "simbolo";
            simbolo.Size = new Size(39, 15);
            simbolo.TabIndex = 10;
            simbolo.Text = "()()()()";
            simbolo.Click += simbolo_Click;
            // 
            // wesley
            // 
            wesley.Anchor = AnchorStyles.None;
            wesley.Cursor = Cursors.Hand;
            wesley.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wesley.Location = new Point(363, 176);
            wesley.Name = "wesley";
            wesley.Size = new Size(75, 23);
            wesley.TabIndex = 11;
            wesley.Text = "Wesley";
            wesley.Click += wesley_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(wesley, 2, 1);
            tableLayoutPanel1.Controls.Add(multiplicar, 0, 1);
            tableLayoutPanel1.Controls.Add(dividir, 2, 0);
            tableLayoutPanel1.Controls.Add(menos, 0, 0);
            tableLayoutPanel1.Controls.Add(mais, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 188);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(482, 250);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(checkedListBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Location = new Point(500, 188);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(200, 250);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.ImeMode = ImeMode.NoControl;
            checkedListBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(94, 72);
            checkedListBox1.TabIndex = 15;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(112, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(simbolo);
            Controls.Add(resultado);
            Controls.Add(numero2);
            Controls.Add(Numero1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox checkedListBox1;
        private Button button1;
    }
}
