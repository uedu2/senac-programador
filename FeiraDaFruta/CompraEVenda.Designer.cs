namespace FeiraDaFruta
{
    partial class CompraEVenda
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
            dataGridView1 = new DataGridView();
            textBoxQuantidade = new TextBox();
            label1 = new Label();
            checkCompra = new CheckBox();
            checkVenda = new CheckBox();
            buttonFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(531, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 395);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(397, 34);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(100, 23);
            textBoxQuantidade.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Quantidade";
            // 
            // checkCompra
            // 
            checkCompra.AutoSize = true;
            checkCompra.Location = new Point(380, 80);
            checkCompra.Name = "checkCompra";
            checkCompra.Size = new Size(69, 19);
            checkCompra.TabIndex = 5;
            checkCompra.Text = "Compra";
            checkCompra.UseVisualStyleBackColor = true;
            // 
            // checkVenda
            // 
            checkVenda.AutoSize = true;
            checkVenda.Location = new Point(455, 80);
            checkVenda.Name = "checkVenda";
            checkVenda.Size = new Size(58, 19);
            checkVenda.TabIndex = 6;
            checkVenda.Text = "Venda";
            checkVenda.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(409, 122);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 23);
            buttonFinalizar.TabIndex = 7;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // CompraEVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFinalizar);
            Controls.Add(checkVenda);
            Controls.Add(checkCompra);
            Controls.Add(label1);
            Controls.Add(textBoxQuantidade);
            Controls.Add(dataGridView1);
            Name = "CompraEVenda";
            Text = "CompraEVenda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxQuantidade;
        private Label label1;
        private CheckBox checkCompra;
        private CheckBox checkVenda;
        private Button buttonFinalizar;
    }
}