using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 8;
        public int speed_top = 8;
        
        public int points = 0;
        public int lvl = 1;
        public int percentValue = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
           
            Cursor.Hide();
            
            this.FormBorderStyle = FormBorderStyle.Sizable;
           
            this.TopMost = true;
          
           
            racket.Top = playground.Bottom - (playground.Bottom / 10);
          
            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);
            gameover_lbl.Top = (playground.Height / 2) - (gameover_lbl.Height / 2);
        
            gameover_lbl.Visible = false;
            achievement.Visible = false;
            achievement_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 1;
                speed_left += 1;

                speed_top = -speed_top;
                points += 1;
                if (percentValue < 100)
                {
                    percentValue += 25;
                }
                points_lbl.Text = points.ToString();
                lvlValue_lbl.Text = lvl.ToString();
                percent_lbl.Text = percentValue.ToString();
                if (points % 10 == 0)
                {
                    achievement.Visible = true;
                    achievement_lbl.Visible = true;
                }
                else
                {
                    achievement.Visible = false;
                    achievement_lbl.Visible = false;
                }
                if (points % 4 == 0)
                {
                    lvl += 1;
                }
                if (percentValue % 100 == 0)
                {
                    percentValue = 0;

                }

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover_lbl.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            bool isRunning = timer1.Enabled;

            if (e.KeyCode == Keys.Space)
            {
                if (isRunning)
                {
                    timer1.Enabled = false;
                }
                else
                {
                    timer1.Enabled = true;
                }

            }
            

            if (e.KeyCode == Keys.Escape) { this.Close(); }
           
            if (e.KeyCode == Keys.Enter)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 8;
                speed_top = 8;
                points = 0;
                points_lbl.Text = "0";
                lvl = 1;
                lvlValue_lbl.Text = "1";
                percentValue = 0;
                percent_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;

               
            }
        }
    }
}
