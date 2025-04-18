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
            dataGridView1 = new DataGridView();
            textBoxCriar = new TextBox();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            buttonCompraVendas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 402);
            dataGridView1.TabIndex = 0;
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
            // Feira_Da_Fruta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(buttonCompraVendas);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBoxCriar);
            Controls.Add(dataGridView1);
            Name = "Feira_Da_Fruta";
            Text = "Feira da Fruta";
            Load += Feira_Da_Fruta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxCriar;
        private Button buttonAdicionar;
        private Button buttonRemover;
        private Button buttonCompraVendas;
    }
}
