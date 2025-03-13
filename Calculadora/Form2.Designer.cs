namespace Calculadora
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            result_label = new Label();
            volume = new Label();
            area = new Label();
            perimetro = new Label();
            base_ = new TextBox();
            altura = new TextBox();
            largura = new TextBox();
            resultado = new Label();
            quadrado = new RadioButton();
            retangulo = new RadioButton();
            cubo = new RadioButton();
            paralelepipedo = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(result_label, 1, 1);
            tableLayoutPanel1.Controls.Add(volume, 0, 1);
            tableLayoutPanel1.Controls.Add(area, 1, 0);
            tableLayoutPanel1.Controls.Add(perimetro, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 358);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(855, 218);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // result_label
            // 
            result_label.Anchor = AnchorStyles.None;
            result_label.AutoSize = true;
            result_label.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result_label.Location = new Point(617, 138);
            result_label.Name = "result_label";
            result_label.Size = new Size(47, 50);
            result_label.TabIndex = 4;
            result_label.Text = "=";
            result_label.Click += result_label_Click;
            // 
            // volume
            // 
            volume.Anchor = AnchorStyles.None;
            volume.AutoSize = true;
            volume.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volume.Location = new Point(140, 138);
            volume.Name = "volume";
            volume.Size = new Size(146, 50);
            volume.TabIndex = 3;
            volume.Text = "Volume";
            volume.Click += volume_Click;
            // 
            // area
            // 
            area.Anchor = AnchorStyles.None;
            area.AutoSize = true;
            area.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            area.Location = new Point(592, 29);
            area.Name = "area";
            area.Size = new Size(97, 50);
            area.TabIndex = 2;
            area.Text = "Area";
            area.Click += area_Click;
            // 
            // perimetro
            // 
            perimetro.Anchor = AnchorStyles.None;
            perimetro.AutoSize = true;
            perimetro.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perimetro.Location = new Point(122, 29);
            perimetro.Name = "perimetro";
            perimetro.Size = new Size(182, 50);
            perimetro.TabIndex = 1;
            perimetro.Text = "Perimetro";
            perimetro.Click += perimetro_Click;
            // 
            // base_
            // 
            base_.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            base_.Location = new Point(31, 275);
            base_.Name = "base_";
            base_.Size = new Size(100, 50);
            base_.TabIndex = 1;
            base_.Text = "A";
            base_.TextChanged += base__TextChanged;
            // 
            // altura
            // 
            altura.Enabled = false;
            altura.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            altura.Location = new Point(322, 275);
            altura.Name = "altura";
            altura.Size = new Size(100, 50);
            altura.TabIndex = 2;
            altura.Text = "C";
            altura.TextChanged += altura_TextChanged;
            // 
            // largura
            // 
            largura.Enabled = false;
            largura.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            largura.Location = new Point(173, 275);
            largura.Name = "largura";
            largura.Size = new Size(100, 50);
            largura.TabIndex = 3;
            largura.Text = "B";
            largura.TextChanged += largura_TextChanged;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultado.Location = new Point(651, 278);
            resultado.Name = "resultado";
            resultado.Size = new Size(189, 45);
            resultado.TabIndex = 4;
            resultado.Text = "RESULTADO";
            resultado.Click += resultado_Click;
            // 
            // quadrado
            // 
            quadrado.AutoSize = true;
            quadrado.Location = new Point(31, 65);
            quadrado.Name = "quadrado";
            quadrado.Size = new Size(76, 19);
            quadrado.TabIndex = 5;
            quadrado.TabStop = true;
            quadrado.Text = "quadrado";
            quadrado.UseVisualStyleBackColor = true;
            quadrado.CheckedChanged += quadrado_CheckedChanged;
            // 
            // retangulo
            // 
            retangulo.AutoSize = true;
            retangulo.Location = new Point(31, 90);
            retangulo.Name = "retangulo";
            retangulo.Size = new Size(76, 19);
            retangulo.TabIndex = 6;
            retangulo.TabStop = true;
            retangulo.Text = "retangulo";
            retangulo.UseVisualStyleBackColor = true;
            retangulo.CheckedChanged += retangulo_CheckedChanged;
            // 
            // cubo
            // 
            cubo.AutoSize = true;
            cubo.Location = new Point(31, 115);
            cubo.Name = "cubo";
            cubo.Size = new Size(52, 19);
            cubo.TabIndex = 7;
            cubo.TabStop = true;
            cubo.Text = "cubo";
            cubo.UseVisualStyleBackColor = true;
            cubo.CheckedChanged += cubo_CheckedChanged;
            // 
            // paralelepipedo
            // 
            paralelepipedo.AutoSize = true;
            paralelepipedo.Location = new Point(31, 140);
            paralelepipedo.Name = "paralelepipedo";
            paralelepipedo.Size = new Size(103, 19);
            paralelepipedo.TabIndex = 8;
            paralelepipedo.TabStop = true;
            paralelepipedo.Text = "paralelepipedo";
            paralelepipedo.UseVisualStyleBackColor = true;
            paralelepipedo.CheckedChanged += paralelepipedo_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(852, 572);
            Controls.Add(paralelepipedo);
            Controls.Add(cubo);
            Controls.Add(retangulo);
            Controls.Add(quadrado);
            Controls.Add(resultado);
            Controls.Add(largura);
            Controls.Add(altura);
            Controls.Add(base_);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label perimetro;
        private Label result_label;
        private Label volume;
        private Label area;
        private TextBox base_;
        private TextBox altura;
        private TextBox largura;
        private Label resultado;
        private RadioButton quadrado;
        private RadioButton retangulo;
        private RadioButton cubo;
        private RadioButton paralelepipedo;
    }
}