namespace esferas_do_dragao
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
            tableLayoutPanel1 = new TableLayoutPanel();
            volume = new Label();
            diametro = new Label();
            raio = new Label();
            circunferencia = new Label();
            area = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            Resul = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(volume, 1, 1);
            tableLayoutPanel1.Controls.Add(diametro, 0, 1);
            tableLayoutPanel1.Controls.Add(raio, 1, 0);
            tableLayoutPanel1.Controls.Add(circunferencia, 0, 0);
            tableLayoutPanel1.Controls.Add(area, 0, 2);
            tableLayoutPanel1.Location = new Point(215, 376);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Size = new Size(357, 228);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // volume
            // 
            volume.Anchor = AnchorStyles.None;
            volume.AutoSize = true;
            volume.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volume.Location = new Point(229, 106);
            volume.Name = "volume";
            volume.Size = new Size(76, 25);
            volume.TabIndex = 4;
            volume.Text = "Volume";
            volume.Click += volume_Click_1;
            // 
            // diametro
            // 
            diametro.Anchor = AnchorStyles.None;
            diametro.AutoSize = true;
            diametro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diametro.Location = new Point(44, 106);
            diametro.Name = "diametro";
            diametro.Size = new Size(90, 25);
            diametro.TabIndex = 3;
            diametro.Text = "Diametro";
            diametro.Click += diametro_Click;
            // 
            // raio
            // 
            raio.Anchor = AnchorStyles.None;
            raio.AutoSize = true;
            raio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            raio.Location = new Point(243, 27);
            raio.Name = "raio";
            raio.Size = new Size(49, 25);
            raio.TabIndex = 2;
            raio.Text = "Raio";
            raio.Click += raio_Click;
            // 
            // circunferencia
            // 
            circunferencia.Anchor = AnchorStyles.None;
            circunferencia.AutoSize = true;
            circunferencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            circunferencia.Location = new Point(23, 27);
            circunferencia.Name = "circunferencia";
            circunferencia.Size = new Size(132, 25);
            circunferencia.TabIndex = 1;
            circunferencia.Text = "circunferencia";
            circunferencia.Click += circunferencia_Click;
            // 
            // area
            // 
            area.Anchor = AnchorStyles.None;
            area.AutoSize = true;
            area.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            area.Location = new Point(63, 180);
            area.Name = "area";
            area.Size = new Size(51, 25);
            area.TabIndex = 5;
            area.Text = "Area";
            area.Click += area_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.SeaShell;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Resul, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel2.Location = new Point(215, 185);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2432442F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.0540543F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2432442F));
            tableLayoutPanel2.Size = new Size(357, 185);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Resul
            // 
            Resul.Anchor = AnchorStyles.None;
            Resul.AutoSize = true;
            Resul.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resul.Location = new Point(222, 79);
            Resul.Name = "Resul";
            Resul.Size = new Size(90, 25);
            Resul.TabIndex = 5;
            Resul.Text = "la bamba";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(3, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label volume;
        private Label diametro;
        private Label raio;
        private Label circunferencia;
        private Label area;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Resul;
        private TextBox textBox2;
    }
}
