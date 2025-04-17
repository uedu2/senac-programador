namespace ListaAtividades
{
    partial class Criar_Atividade
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
            textBoxTitulo = new TextBox();
            labelerro = new Label();
            Criar = new Button();
            Descartar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(204, 172);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(165, 23);
            textBoxTitulo.TabIndex = 0;
            // 
            // labelerro
            // 
            labelerro.AutoSize = true;
            labelerro.Location = new Point(204, 239);
            labelerro.Name = "labelerro";
            labelerro.Size = new Size(38, 15);
            labelerro.TabIndex = 1;
            labelerro.Text = "label1";
            // 
            // Criar
            // 
            Criar.Location = new Point(294, 201);
            Criar.Name = "Criar";
            Criar.Size = new Size(75, 23);
            Criar.TabIndex = 2;
            Criar.Text = "button1";
            Criar.UseVisualStyleBackColor = true;
            Criar.Click += Criar_Click;
            // 
            // Descartar
            // 
            Descartar.Location = new Point(204, 201);
            Descartar.Name = "Descartar";
            Descartar.Size = new Size(75, 23);
            Descartar.TabIndex = 3;
            Descartar.Text = "button2";
            Descartar.UseVisualStyleBackColor = true;
            Descartar.Click += Descartar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 125);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // Criar_Atividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Descartar);
            Controls.Add(Criar);
            Controls.Add(labelerro);
            Controls.Add(textBoxTitulo);
            Name = "Criar_Atividade";
            Text = "Criar Atividade";
            Load += Criar_Atividade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitulo;
        private Label labelerro;
        private Button Criar;
        private Button Descartar;
        private Label label2;
    }
}