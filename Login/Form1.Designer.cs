namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            pictureBox1 = new PictureBox();
            labelUsuario = new Label();
            textBoxNovoUsuario = new TextBox();
            textBoxNovaSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(366, 335);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 249);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 286);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(353, 246);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(353, 283);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(100, 23);
            textBoxSenha.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(353, 313);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(0, 15);
            labelUsuario.TabIndex = 6;
            // 
            // textBoxNovoUsuario
            // 
            textBoxNovoUsuario.Location = new Point(900, 139);
            textBoxNovoUsuario.Name = "textBoxNovoUsuario";
            textBoxNovoUsuario.Size = new Size(198, 23);
            textBoxNovoUsuario.TabIndex = 7;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Location = new Point(900, 180);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.Size = new Size(198, 23);
            textBoxNovaSenha.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(955, 96);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "Novo Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(856, 142);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(856, 183);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Senha";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(868, 257);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(849, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1125, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(258, 310);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(951, 343);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 15;
            labelResultado.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1384, 450);
            Controls.Add(labelResultado);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNovaSenha);
            Controls.Add(textBoxNovoUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private PictureBox pictureBox1;
        private Label labelUsuario;
        private TextBox textBoxNovoUsuario;
        private TextBox textBoxNovaSenha;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelResultado;
    }
}
