namespace tentativa_de_RPG2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.NPC = new System.Windows.Forms.PictureBox();
            this.caixaX = new System.Windows.Forms.Label();
            this.Texto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.maingametimer);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Red;
            this.Player.Location = new System.Drawing.Point(198, 255);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(48, 50);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // NPC
            // 
            this.NPC.BackColor = System.Drawing.Color.Lime;
            this.NPC.Location = new System.Drawing.Point(172, 199);
            this.NPC.Name = "NPC";
            this.NPC.Size = new System.Drawing.Size(48, 50);
            this.NPC.TabIndex = 1;
            this.NPC.TabStop = false;
            // 
            // caixaX
            // 
            this.caixaX.AutoSize = true;
            this.caixaX.BackColor = System.Drawing.Color.White;
            this.caixaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaX.ForeColor = System.Drawing.Color.White;
            this.caixaX.Location = new System.Drawing.Point(177, 144);
            this.caixaX.Name = "caixaX";
            this.caixaX.Size = new System.Drawing.Size(38, 37);
            this.caixaX.TabIndex = 2;
            this.caixaX.Text = "X";
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.BackColor = System.Drawing.Color.White;
            this.Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.ForeColor = System.Drawing.Color.White;
            this.Texto.Location = new System.Drawing.Point(234, 104);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(421, 37);
            this.Texto.TabIndex = 3;
            this.Texto.Text = "TEXTO, aperte Z para sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.caixaX);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.NPC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keypress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox NPC;
        private System.Windows.Forms.Label caixaX;
        private System.Windows.Forms.Label Texto;
    }
}

