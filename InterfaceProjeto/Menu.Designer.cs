namespace InterfaceProjeto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonCriarPedido = new Button();
            label1 = new Label();
            buttonCriarCliente = new Button();
            buttonEditarPedido = new Button();
            buttonRelatorio = new Button();
            SuspendLayout();
            // 
            // buttonCriarPedido
            // 
            buttonCriarPedido.Anchor = AnchorStyles.None;
            buttonCriarPedido.BackColor = Color.Transparent;
            buttonCriarPedido.Cursor = Cursors.Hand;
            buttonCriarPedido.FlatStyle = FlatStyle.Flat;
            buttonCriarPedido.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonCriarPedido.ForeColor = Color.AliceBlue;
            buttonCriarPedido.Location = new Point(561, 377);
            buttonCriarPedido.Name = "buttonCriarPedido";
            buttonCriarPedido.Size = new Size(381, 150);
            buttonCriarPedido.TabIndex = 0;
            buttonCriarPedido.Text = "Criar pedido";
            buttonCriarPedido.UseVisualStyleBackColor = false;
            buttonCriarPedido.Click += buttonCriarPedido_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(915, 1013);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // buttonCriarCliente
            // 
            buttonCriarCliente.Anchor = AnchorStyles.None;
            buttonCriarCliente.BackColor = Color.Transparent;
            buttonCriarCliente.Cursor = Cursors.Hand;
            buttonCriarCliente.FlatStyle = FlatStyle.Flat;
            buttonCriarCliente.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCriarCliente.ForeColor = Color.White;
            buttonCriarCliente.Location = new Point(561, 545);
            buttonCriarCliente.Name = "buttonCriarCliente";
            buttonCriarCliente.Size = new Size(381, 150);
            buttonCriarCliente.TabIndex = 2;
            buttonCriarCliente.Text = "Criar Cliente\r\n";
            buttonCriarCliente.UseVisualStyleBackColor = false;
            buttonCriarCliente.Click += buttonCriarCliente_Click;
            buttonCriarCliente.MouseEnter += buttonCriarCliente_MouseEnter;
            buttonCriarCliente.MouseLeave += buttonCriarCliente_MouseLeave;
            // 
            // buttonEditarPedido
            // 
            buttonEditarPedido.Anchor = AnchorStyles.None;
            buttonEditarPedido.BackColor = Color.Transparent;
            buttonEditarPedido.Cursor = Cursors.Hand;
            buttonEditarPedido.FlatStyle = FlatStyle.Flat;
            buttonEditarPedido.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonEditarPedido.ForeColor = Color.White;
            buttonEditarPedido.Location = new Point(1006, 377);
            buttonEditarPedido.Name = "buttonEditarPedido";
            buttonEditarPedido.Size = new Size(407, 150);
            buttonEditarPedido.TabIndex = 3;
            buttonEditarPedido.Text = "Editar pedido ";
            buttonEditarPedido.UseVisualStyleBackColor = false;
            buttonEditarPedido.Click += buttonEditarPedido_Click;
            // 
            // buttonRelatorio
            // 
            buttonRelatorio.Anchor = AnchorStyles.None;
            buttonRelatorio.BackColor = Color.Transparent;
            buttonRelatorio.Cursor = Cursors.Hand;
            buttonRelatorio.FlatStyle = FlatStyle.Flat;
            buttonRelatorio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRelatorio.ForeColor = Color.White;
            buttonRelatorio.Location = new Point(1006, 545);
            buttonRelatorio.Name = "buttonRelatorio";
            buttonRelatorio.Size = new Size(407, 150);
            buttonRelatorio.TabIndex = 4;
            buttonRelatorio.Text = "Relatórios";
            buttonRelatorio.UseVisualStyleBackColor = false;
            buttonRelatorio.Click += buttonRelatorio_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1900, 1037);
            Controls.Add(buttonCriarPedido);
            Controls.Add(buttonRelatorio);
            Controls.Add(buttonEditarPedido);
            Controls.Add(buttonCriarCliente);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarPedido;
        private Label label1;
        private Button buttonCriarCliente;
        private Button buttonEditarPedido;
        private Button buttonRelatorio;
    }
}
