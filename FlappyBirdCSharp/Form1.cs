using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBirdCSharp
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 6;
        int gravity = 5;
        int score = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            var randomNum = new Random();
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
          
         

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = randomNum.Next(650, 950);
                score++;
            }

            if (pipeTop.Left < -150)
            {
                pipeTop.Left = randomNum.Next(750, 1050);
                score++;
                count++;
                if (count % 2 == 0)
                {
                    pipeTop.Top = randomNum.Next(-94, -31);
                }
                else if(count % 2 == 1)
                {
                    pipeTop.Top = randomNum.Next(-31, -10);
                }
                
            }

            if (score > 5 && score <= 10)
            {
                pipeSpeed = 8;
            }

            if (score > 10 && score <= 15)
            {
                pipeSpeed = 10;
            }


            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)

            {
                //bird.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                endGame();
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
                
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
                
            }
        }

        private void endGame()
        {
           

            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
            restartButton.Visible = true;
            restartButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scoreText.Parent = ground;
            scoreText.BackColor = Color.Transparent;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            pipeSpeed = 6;
            gravity = 5;
            score = 0;
            scoreText.Text = "Score: " + score;
            count = 0;
            bird.Location = new Point(53, 175);
            pipeTop.Location = new Point(423, -94);
            pipeBottom.Location = new Point(320, 401);
            restartButton.Visible = false;
            restartButton.Enabled = false;
            gameTimer.Start();
        }
    }
}
