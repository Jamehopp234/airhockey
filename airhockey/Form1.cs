using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace airhockey
{
    public partial class AirHockey : Form
    {
        SoundPlayer goalSound = new SoundPlayer(Properties.Resources.goalSound);
        SoundPlayer hitMarker = new SoundPlayer(Properties.Resources.hitMarker);

        Rectangle player1 = new Rectangle(10, 120, 60, 60);
        Rectangle player2 = new Rectangle(580, 120, 60, 60);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle p1Goal = new Rectangle(0,140,10,90);
        Rectangle p2Goal = new Rectangle(675, 140, 10, 90);
        Rectangle center = new Rectangle(325, 0, 10, 400);
        Rectangle blueLine1 = new Rectangle(150, 0, 10, 400);
        Rectangle blueLine2 = new Rectangle(500, 0, 10, 400);
        Pen redPen = new Pen(Color.Red, 10);




        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed = 7;
        int ballXSpeed = -7;
        int ballYSpeed = 7;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;


        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        

        Pen whitePen = new Pen(Color.White, 6);

        
        public AirHockey()
        {
            InitializeComponent();

        }

      

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;

            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;

            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
           
            
            e.Graphics.FillRectangle(redBrush, p1Goal);
            e.Graphics.FillRectangle(redBrush, p2Goal);
            e.Graphics.FillRectangle(redBrush, center);
            e.Graphics.FillRectangle(blueBrush, blueLine1);
            e.Graphics.FillRectangle(blueBrush, blueLine2);
            e.Graphics.FillEllipse(redBrush, player1);
            e.Graphics.FillEllipse(redBrush, player2);
            e.Graphics.FillEllipse(blackBrush, ball);





        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ball.X += ballXSpeed;
            ball.Y += ballYSpeed;


            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed;
            }
            if (dDown == true && player1.X < 325 - player1.Width)
            {
                player1.X += playerSpeed;
            }

            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed;
            }
            if (leftArrowDown == true && player2.X > 325)
            {
                player2.X -= playerSpeed;
            }
            if (rightArrowDown == true && player2.X < 700 - player2.Width)
            {
                player2.X += playerSpeed;
            }


            if (ball.Y < 0 || ball.Y > 350)
            {
                ballYSpeed *= -1;
            }


            if (player1.IntersectsWith(ball))
            {
                hitMarker.Play();
                ballXSpeed *= -1;
                ball.X = player1.X + player1.Width +1;
                ballXSpeed ++;
                
            }
            else if (player2.IntersectsWith(ball))
            {
                hitMarker.Play();
                ballXSpeed *= -1;
               ball.X = player2.X - player2.Width +1;
                ballXSpeed ++;
                
            }


            if (ball.IntersectsWith(p1Goal))
            {
                player2Score++;
                goalSound.Play();
                ball.X = 350;
                ball.Y = 200;

                player1.Y = 200;
                player2.Y = 200;
                player1.X = 0;
                player2.X = 550;
                p2scoreLabel.Text = $"AWAY:{player2Score}";
            }
            if (ball.IntersectsWith(p2Goal))
            {
                player1Score++;
                goalSound.Play();
                ball.X = 350;
                ball.Y = 200;

                player1.Y = 200;
                player2.Y = 200;
                player1.X = 0;
                player2.X = 600;
                p1scoreLabel.Text = $"HOME:{player1Score}";
            }
            if (ball.X > 700)
            {
                ballXSpeed *= -1;
            }
            if(ball.X < 0)
            {
                ballXSpeed *= -1;
            }



            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";

            }

            Refresh();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(redPen, 90, 90, 90, 90);
        }
    }
}

