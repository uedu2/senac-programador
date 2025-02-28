using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tentativa_de_RPG2
{
    public partial class Form1 : Form
    {
        bool goleft, goright, goup, godown, x;
        int playerSpeed, y;


        public Form1()
        {
            InitializeComponent();
            setupgame();
        }
        private void setupgame()
        {
            playerSpeed = 10;

            gametimer.Start();
        }

        private void maingametimer(object sender, EventArgs e)
        {
            if (goleft == true && Player.Left > 0)
            {
                Player.Left -= playerSpeed;
            }
            if (goright == true && Player.Left < 750)
            {
                Player.Left += playerSpeed;
            }
            if (goup == true && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }
            if (godown == true && Player.Top < 400)
            {
                Player.Top += playerSpeed;
            }
            if (Player.Bounds.IntersectsWith(NPC.Bounds)) 
            {
                caixaX.BackColor = Color.Black;
                if (x == true && Player.Bounds.IntersectsWith(NPC.Bounds))
                {
                    Texto.BackColor = Color.Black;
                }
                else
                {
                    Texto.BackColor = Color.White;
                }
            }
            else
            {
                caixaX.BackColor = Color.White;
            }
        }

        private void keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.X)
            {
                x = true;
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.X)
            {
                godown = false;
            }
        }
    }
}
