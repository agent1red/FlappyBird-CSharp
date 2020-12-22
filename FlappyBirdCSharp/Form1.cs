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
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

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
            scoreText.BackColor = Color.Transparent;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = randomNum.Next(450, 750);
                score++;
            }

            if (pipeTop.Left < -150)
            {
                pipeTop.Left = randomNum.Next(750, 1050);
                score++;
            }

            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
                bird.Bounds.IntersectsWith(pipeTop.Bounds) || 
                bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
