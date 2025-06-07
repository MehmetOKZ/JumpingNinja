using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBİrd
{
    


    public partial class Form1 : Form
    {
        int templeSpeed = 8; //kulelerin hızı
        int gravity = 5;  // karakter yer çekimi
        int score = 0;  // puanınız

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            jumpingninja.Top += gravity;
            templeBottom.Left -= templeSpeed;
            templeTop.Left -= templeSpeed;
            scoreText.Text = "Score: " + score;

            if(templeBottom.Left < -150)
            {
                templeBottom.Left = 800;
                score++;
            }
            if (templeTop.Left < -180)
            {
                templeTop.Left = 950;
                score++;
            }
            if(jumpingninja.Bounds.IntersectsWith(templeBottom.Bounds) ||
                jumpingninja.Bounds.IntersectsWith(templeTop.Bounds) ||
                jumpingninja.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                endGame();
            }


            if (score > 5) //score 5> ise  oyun hızlanır
            {
                templeSpeed = 15;
            }
             

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = 15; 
            }

        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game Over!!";
        }
    }
}
