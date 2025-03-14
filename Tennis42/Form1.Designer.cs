namespace Tennis42
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
            tableLayoutPanel1 = new TableLayoutPanel();
            _vspong = new Label();
            _vsbreak = new Label();
            _pong42 = new Label();
            _break42 = new Label();
            _pong = new Label();
            _break = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(_vspong, 1, 2);
            tableLayoutPanel1.Controls.Add(_vsbreak, 0, 2);
            tableLayoutPanel1.Controls.Add(_pong42, 1, 1);
            tableLayoutPanel1.Controls.Add(_break42, 0, 1);
            tableLayoutPanel1.Controls.Add(_pong, 1, 0);
            tableLayoutPanel1.Controls.Add(_break, 0, 0);
            tableLayoutPanel1.Location = new Point(261, 239);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(248, 209);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _vspong
            // 
            _vspong.Anchor = AnchorStyles.None;
            _vspong.AutoSize = true;
            _vspong.Location = new Point(162, 166);
            _vspong.Name = "_vspong";
            _vspong.Size = new Size(48, 15);
            _vspong.TabIndex = 5;
            _vspong.Text = "VSPong";
            // 
            // _vsbreak
            // 
            _vsbreak.Anchor = AnchorStyles.None;
            _vsbreak.AutoSize = true;
            _vsbreak.Location = new Point(37, 166);
            _vsbreak.Name = "_vsbreak";
            _vsbreak.Size = new Size(49, 15);
            _vsbreak.TabIndex = 4;
            _vsbreak.Text = "VSBreak";
            // 
            // _pong42
            // 
            _pong42.Anchor = AnchorStyles.None;
            _pong42.AutoSize = true;
            _pong42.Location = new Point(162, 96);
            _pong42.Name = "_pong42";
            _pong42.Size = new Size(47, 15);
            _pong42.TabIndex = 3;
            _pong42.Text = "Pong42";
            // 
            // _break42
            // 
            _break42.Anchor = AnchorStyles.None;
            _break42.AutoSize = true;
            _break42.Location = new Point(38, 96);
            _break42.Name = "_break42";
            _break42.Size = new Size(48, 15);
            _break42.TabIndex = 2;
            _break42.Text = "Break42";
            // 
            // _pong
            // 
            _pong.Anchor = AnchorStyles.None;
            _pong.AutoSize = true;
            _pong.Location = new Point(168, 27);
            _pong.Name = "_pong";
            _pong.Size = new Size(35, 15);
            _pong.TabIndex = 1;
            _pong.Text = "Pong";
            // 
            // _break
            // 
            _break.Anchor = AnchorStyles.None;
            _break.AutoSize = true;
            _break.Location = new Point(44, 27);
            _break.Name = "_break";
            _break.Size = new Size(36, 15);
            _break.TabIndex = 0;
            _break.Text = "Break";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 81);
            label2.Name = "label2";
            label2.Size = new Size(111, 42);
            label2.TabIndex = 2;
            label2.Text = "MENU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label _break;
        private PictureBox pictureBox1;
        private Label _vspong;
        private Label _vsbreak;
        private Label _pong42;
        private Label _break42;
        private Label _pong;
        private Label label2;
    }
}
