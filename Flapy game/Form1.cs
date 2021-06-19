using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flapy_game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        int[] defaultBirdLocation = new int[2]{105,348};
        int[] defaultTopPipeLocation = new int[2] { 600, 0 };
        int[] defaultBottumPipeLocation = new int[2] { 600, 543 };



        public Form1()
        {
            InitializeComponent();

        }

        void RandomPipes()
        {
            TopPipe.Top = random.Next(-450, -200);
            BottumPipe.Top = random.Next(450, 550);
        }
        private void Game_Timer_Event(object sender, EventArgs e)
        {
            
            ObjectPlayer.Top += gravity;
            TopPipe.Left -= pipeSpeed;
            BottumPipe.Left -= pipeSpeed;
            if (TopPipe.Left < -100)
            {
                TopPipe.Left = random.Next(1410, 1600);
                score++;
            }
            else if (BottumPipe.Left < -100)
            {
                BottumPipe.Left = random.Next(1410, 1600);
                RandomPipes();
                score++;
            }
            ScoreLabel.Text = "Score: " + score.ToString();
            switch (score)
            {
                case 7:
                pipeSpeed = 10;
                    break;
                case 10:
                pipeSpeed = 15;
                    break;
                case 17:
                pipeSpeed = 20;
                    break;
                case 20:
                pipeSpeed = 25;
                    break;
                case 30:
                pipeSpeed = 35;
                    break;
            }

            if (ObjectPlayer.Bounds.IntersectsWith(TopPipe.Bounds)|| ObjectPlayer.Bounds.IntersectsWith(BottumPipe.Bounds)
                || ObjectPlayer.Bounds.IntersectsWith(Ground.Bounds)||ObjectPlayer.Top<-10)
            {
                GameTimer.Stop();
                DialogResult dialog= MessageBox.Show("Try Again?", "Game Over", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ObjectPlayer.Left = defaultBirdLocation[0];
                    ObjectPlayer.Top = defaultBirdLocation[1];
                    TopPipe.Left = defaultTopPipeLocation[0];
                    BottumPipe.Left = defaultBottumPipeLocation[0];
                    score = 0;
                    GameTimer.Start();
                }
                else
                    Application.Exit();
            }
        }

        private void Game_Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.M)
            {
                gravity = -12;
            }
        }

        private void Game_Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                gravity = 12;
            }
        }
    }
}
