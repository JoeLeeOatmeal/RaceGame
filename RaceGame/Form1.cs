using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RaceGame
{
    public partial class Form1 : Form
    {
        int score = 0;                          // score == 0 when game start
        int gameSpeed = 1;                      // 遊戲速度
        int carXSpeed = 8;                     // car 橫移的速度
        bool canGetScore = true;                // 只有當 canGetScore 為 true 時，car 接觸到 star 才會加分，如果沒有使用這個bool 控制的話，持續接觸的過程會一直加分
        Random rd;                              // 產生亂數產生器 rd;

        public Form1()
        {
            InitializeComponent();
            rd = new Random();                  // 建立亂數產生器 instance


        }
        /// <summary>
        /// timer1_Tick 
        /// interval == 10 ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {   
            CheckIfGameOver();                          // 確認是否 game over
            CheckGetScore();                            // 確認是否得分
            GroundLineMove();                           // 地面標線移動
            EnemyMove();                                // 敵人(其他車輛, 障礙物) 移動
            TreeMove();                                 // 路樹移動
            StarMove();                                 // 得分星星移動
            label1.Text = "Score :" + score.ToString();
        }
        /// <summary>
        /// keydown situation in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (gameSpeed < 5)
                    {
                        gameSpeed++;
                    }
                    else
                    {
                        gameSpeed = 5; 
                    }
                    break;

                case Keys.Left:
                    if (car.Left > Tree1.Width && gameSpeed != 0)
                    {
                       car.Left += -carXSpeed;
                    }
                    break;

                case Keys.Right:
                    if (car.Left + car.Width < ClientSize.Width && gameSpeed != 0)
                    {
                        car.Left += carXSpeed;
                    }
                    break;

                case Keys.Down:
                    if(gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                    break;
            }
        }

        /// <summary>
        ///  check if game over
        /// </summary>
        private void CheckIfGameOver()
        {
            /// Game Over Situation ///
            if (car.Bounds.IntersectsWith(enemy1.Bounds) ||
                car.Bounds.IntersectsWith(enemy2.Bounds) ||
                car.Bounds.IntersectsWith(enemy3.Bounds) || 
                car.Bounds.IntersectsWith(enemy4.Bounds))

                GameOver();
        }

        /// <summary>
        /// check if the player get the score => other words, the car intersects with the star;
        /// </summary>
        private void CheckGetScore()
        {
            if (car.Bounds.IntersectsWith(star.Bounds) && canGetScore == true)             // 如果 car 跟 star 接觸的話 => 得分
            {
                score++;                                                                  // 分數加一分
                star.Visible = false;                                                     // car intersects with star would disappear
                canGetScore = false;                                                      // set canGetScore to false when the car continuously intersects with the star
            }
            else if (!car.Bounds.IntersectsWith(star.Bounds))
            {
                canGetScore = true;                                                       // set canGetScore to true when the car stop intersects with the star
            }
        }


        /// <summary>
        /// things to do after it is game over
        /// </summary>
        private void GameOver()
        {
            timer1.Enabled = false;
            carXSpeed = 0;
            MessageBox.Show("Game Over");
        }
        /// <summary>
        /// ground line move
        /// </summary>
        private void GroundLineMove()
        {
            
            if (pictureBox1.Top > ClientSize.Height)
            {
                pictureBox1.Top = -pictureBox1.Height;
            }
            pictureBox1.Top += gameSpeed;

            if (pictureBox2.Top > ClientSize.Height)
            {
                pictureBox2.Top = -pictureBox2.Height;
            }
            pictureBox2.Top += gameSpeed;

            if (pictureBox3.Top > ClientSize.Height)
            {
                pictureBox3.Top = -pictureBox3.Height;
            }
            pictureBox3.Top += gameSpeed;

            if (pictureBox4.Top > ClientSize.Height)
            {
                pictureBox4.Top = -pictureBox4.Height;
            }
            pictureBox4.Top += gameSpeed;

            if (pictureBox5.Top > ClientSize.Height)
            {
                pictureBox5.Top = -pictureBox5.Height;
            }
            pictureBox5.Top += gameSpeed;

            if (pictureBox6.Top > ClientSize.Height)
            {
                pictureBox6.Top = -pictureBox6.Height;
            }
            pictureBox6.Top += gameSpeed;
        }
        /// <summary>
        /// enemy move
        /// </summary>
        private void EnemyMove()
        {
            if (enemy1.Top > ClientSize.Height)
            {
                do
                {
                    enemy1.Left = rd.Next(Tree1.Width, ClientSize.Width - enemy1.Width);
                    enemy1.Top = 0;
                } while (enemy1.Bounds.IntersectsWith(enemy2.Bounds) || enemy1.Bounds.IntersectsWith(enemy3.Bounds) || enemy1.Bounds.IntersectsWith(enemy4.Bounds));
            }
            enemy1.Top += gameSpeed;

            if (enemy2.Top > ClientSize.Height)
            {
                do
                {
                    enemy2.Left = rd.Next(Tree1.Width, ClientSize.Width - enemy2.Width);
                    enemy2.Top = 0;
                } while (enemy2.Bounds.IntersectsWith(enemy1.Bounds) || enemy2.Bounds.IntersectsWith(enemy3.Bounds) || enemy2.Bounds.IntersectsWith(enemy4.Bounds));
               
            }
            enemy2.Top += gameSpeed;

            if (enemy3.Top > ClientSize.Height)
            {
                do
                {
                    enemy3.Left = rd.Next(Tree1.Width, ClientSize.Width - enemy3.Width);
                    enemy3.Top = 0;
                } while (enemy3.Bounds.IntersectsWith(enemy1.Bounds) || enemy3.Bounds.IntersectsWith(enemy2.Bounds) || enemy3.Bounds.IntersectsWith(enemy4.Bounds));
                
            }
            enemy3.Top += gameSpeed;

            if (enemy4.Top > ClientSize.Height)
            {
                do
                {
                    enemy4.Left = rd.Next(Tree1.Width, ClientSize.Width - enemy4.Width);
                    enemy4.Top = 0;
                } while (enemy4.Bounds.IntersectsWith(enemy1.Bounds) || enemy4.Bounds.IntersectsWith(enemy2.Bounds) || enemy4.Bounds.IntersectsWith(enemy3.Bounds));
                
            }
            enemy4.Top += gameSpeed;
        }
        /// <summary>
        /// tree moves while timer1_Tick works
        /// </summary>
        private void TreeMove()
        {
            if (Tree1.Top > ClientSize.Height)
            {
                Tree1.Top = -Tree1.Height;
            }
            Tree1.Top += gameSpeed;

            if (Tree2.Top > ClientSize.Height)
            {
                Tree2.Top = -Tree2.Height;
            }
            Tree2.Top += gameSpeed;

            if (Tree3.Top > ClientSize.Height)
            {
                Tree3.Top = -Tree3.Height;
            }
            Tree3.Top += gameSpeed;

            if (Tree4.Top > ClientSize.Height)
            {
                Tree4.Top = -Tree4.Height;
            }
            Tree4.Top += gameSpeed;

            if (Tree5.Top > ClientSize.Height)
            {
                Tree5.Top = -Tree5.Height;
            }
            Tree5.Top += gameSpeed;
        }      

        /// <summary>
        /// define star's movement;
        /// </summary>
        private void StarMove()
        {
            if (star.Top > ClientSize.Height)
            {
                do
                {
                    star.Left = rd.Next(Tree1.Width, ClientSize.Width - star.Width);
                    star.Top = 0;
                } while (star.Bounds.IntersectsWith(enemy1.Bounds) || star.Bounds.IntersectsWith(enemy2.Bounds) || star.Bounds.IntersectsWith(enemy3.Bounds) || star.Bounds.IntersectsWith(enemy4.Bounds));
                star.Visible = true;
            }
            star.Top += gameSpeed;
        }
    }
}
