using Breakdance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break
{
    public partial class Form1 : Form
    {

        bool goleft, goright, isgameover, x;

        int score, ballx, bally, playerSpeed;

        Random rnd = new Random();

        private void label1_Click(object sender, EventArgs e)
        {
            // Crie uma nova instância do Form2
            Anuncio form2 = new Anuncio();

            // Mostre o Form2
            form2.Show();
            this.Hide();
        }

        public Form1()
        {
            InitializeComponent();
            setupgame();
        }

        private void setupgame() 
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            Ponto.Text = "Pontos: " + score;

            Tempo.Start();

           
        }


        public void Gameover()
        {
            isgameover = true;
            Tempo.Stop();

            Ponto.Text = "Fim de jogo"; 
        }


        private void tempomestre(object sender, EventArgs e)
        {
            Ponto.Text = "Pontos: " + score;
            if (goleft == true && Player.Left > 0)
            {
                Player.Left -= playerSpeed;
            }
            if (goright == true && Player.Left < 700)
            {
                Player.Left += playerSpeed;
            }

            Bola.Left += ballx;
            Bola.Top += bally;

            if (Bola.Left < 0 || Bola.Left > 784)
            {
                ballx = -ballx;
            }
            if (Bola.Top < 0)
            {
                bally = -bally;
            }


            if (Bola.Bounds.IntersectsWith(Player.Bounds))
            {
                bally = rnd.Next(5, 12) * -1;

                if(ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }
            if (x ==true)
            {
                bally = rnd.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }
            foreach (Control x in this.Controls) 
            {
                if (x is PictureBox && (string)x.Tag == "Tijooj")
                {
                    if (Bola.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        this.Controls.Remove(x);
                    }
                }
            }

            
            
            if (score == 24) 
            {
                Gameover();
            }
            if(Bola.Top > 580)
            {
                Gameover();
            }

        }

        private void Keyisdown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.X)
            {
                x = true;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.X)
            {
                x = false;
            }
        }
    }
}
