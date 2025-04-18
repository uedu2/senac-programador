namespace FeiraDaFruta
{
    partial class Feira_Da_Fruta
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
            dataGridViewFrutas = new DataGridView();
            textBoxCriar = new TextBox();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            buttonCompraVendas = new Button();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFrutas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFrutas
            // 
            dataGridViewFrutas.AllowUserToAddRows = false;
            dataGridViewFrutas.AllowUserToDeleteRows = false;
            dataGridViewFrutas.AllowUserToResizeColumns = false;
            dataGridViewFrutas.AllowUserToResizeRows = false;
            dataGridViewFrutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFrutas.Location = new Point(12, 36);
            dataGridViewFrutas.MultiSelect = false;
            dataGridViewFrutas.Name = "dataGridViewFrutas";
            dataGridViewFrutas.ReadOnly = true;
            dataGridViewFrutas.Size = new Size(240, 387);
            dataGridViewFrutas.TabIndex = 0;
            // 
            // textBoxCriar
            // 
            textBoxCriar.Location = new Point(298, 36);
            textBoxCriar.Name = "textBoxCriar";
            textBoxCriar.Size = new Size(100, 23);
            textBoxCriar.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(298, 74);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(100, 23);
            buttonAdicionar.TabIndex = 2;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(298, 415);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(100, 23);
            buttonRemover.TabIndex = 3;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonCompraVendas
            // 
            buttonCompraVendas.Location = new Point(436, 415);
            buttonCompraVendas.Name = "buttonCompraVendas";
            buttonCompraVendas.Size = new Size(108, 23);
            buttonCompraVendas.TabIndex = 4;
            buttonCompraVendas.Text = "Compra e Vendas";
            buttonCompraVendas.UseVisualStyleBackColor = true;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 426);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 5;
            labelErro.Text = "label1";
            // 
            // Feira_Da_Fruta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(labelErro);
            Controls.Add(buttonCompraVendas);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBoxCriar);
            Controls.Add(dataGridViewFrutas);
            Name = "Feira_Da_Fruta";
            Text = "Feira da Fruta";
            Load += Feira_Da_Fruta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFrutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFrutas;
        private TextBox textBoxCriar;
        private Button buttonAdicionar;
        private Button buttonRemover;
        private Button buttonCompraVendas;
        private Label labelErro;
    }
}
