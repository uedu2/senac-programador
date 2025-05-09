namespace InterfaceProjeto
{
    partial class EditarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPedido));
            buttonVoltarMenu = new Button();
            textBoxBuscarPedido = new TextBox();
            dataGridView1 = new DataGridView();
            buttonBuscarPedido = new Button();
            buttonDetalhes = new Button();
            buttonFinalizar = new Button();
            buttonExtender = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Anchor = AnchorStyles.None;
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Location = new Point(1817, 1006);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 23);
            buttonVoltarMenu.TabIndex = 7;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = true;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // textBoxBuscarPedido
            // 
            textBoxBuscarPedido.Anchor = AnchorStyles.Top;
            textBoxBuscarPedido.BackColor = Color.White;
            textBoxBuscarPedido.Location = new Point(672, 322);
            textBoxBuscarPedido.Name = "textBoxBuscarPedido";
            textBoxBuscarPedido.Size = new Size(388, 23);
            textBoxBuscarPedido.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1095, 506);
            dataGridView1.TabIndex = 9;
            // 
            // buttonBuscarPedido
            // 
            buttonBuscarPedido.Anchor = AnchorStyles.Top;
            buttonBuscarPedido.Cursor = Cursors.Hand;
            buttonBuscarPedido.Location = new Point(1077, 322);
            buttonBuscarPedido.Name = "buttonBuscarPedido";
            buttonBuscarPedido.Size = new Size(75, 23);
            buttonBuscarPedido.TabIndex = 10;
            buttonBuscarPedido.Text = "Buscar";
            buttonBuscarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonDetalhes
            // 
            buttonDetalhes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDetalhes.Cursor = Cursors.Hand;
            buttonDetalhes.Location = new Point(1458, 374);
            buttonDetalhes.Name = "buttonDetalhes";
            buttonDetalhes.Size = new Size(75, 23);
            buttonDetalhes.TabIndex = 11;
            buttonDetalhes.Text = "Detalhes";
            buttonDetalhes.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Anchor = AnchorStyles.None;
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.Location = new Point(1539, 857);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 23);
            buttonFinalizar.TabIndex = 12;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // buttonExtender
            // 
            buttonExtender.Anchor = AnchorStyles.None;
            buttonExtender.Cursor = Cursors.Hand;
            buttonExtender.Location = new Point(1458, 857);
            buttonExtender.Name = "buttonExtender";
            buttonExtender.Size = new Size(75, 23);
            buttonExtender.TabIndex = 13;
            buttonExtender.Text = "Extender";
            buttonExtender.UseVisualStyleBackColor = true;
            // 
            // EditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(buttonExtender);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonDetalhes);
            Controls.Add(buttonBuscarPedido);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxBuscarPedido);
            Controls.Add(buttonVoltarMenu);
            Name = "EditarPedido";
            Text = "EditarPedido";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonVoltarMenu;
        private TextBox textBoxBuscarPedido;
        private DataGridView dataGridView1;
        private Button buttonBuscarPedido;
        private Button buttonDetalhes;
        private Button buttonFinalizar;
        private Button buttonExtender;
    }
}