namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playground = new System.Windows.Forms.Panel();
            this.achievement = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lvl_lbl = new System.Windows.Forms.Label();
            this.lvlValue_lbl = new System.Windows.Forms.Label();
            this.achievement_lbl = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playground.BackgroundImage")));
            this.playground.Controls.Add(this.achievement_lbl);
            this.playground.Controls.Add(this.lvlValue_lbl);
            this.playground.Controls.Add(this.lvl_lbl);
            this.playground.Controls.Add(this.achievement);
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.score_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(784, 507);
            this.playground.TabIndex = 0;
            // 
            // achievement
            // 
            this.achievement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.achievement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.achievement.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.achievement.Image = ((System.Drawing.Image)(resources.GetObject("achievement.Image")));
            this.achievement.Location = new System.Drawing.Point(251, 71);
            this.achievement.Name = "achievement";
            this.achievement.Size = new System.Drawing.Size(300, 300);
            this.achievement.TabIndex = 5;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover_lbl.Location = new System.Drawing.Point(375, 249);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(234, 99);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over!\r\nPress Enter to Restart\r\nPress Esc to Exit\r\n";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points_lbl
            // 
            this.points_lbl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points_lbl.Location = new System.Drawing.Point(71, 13);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(34, 26);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_lbl.Location = new System.Drawing.Point(13, 13);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(81, 26);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score: ";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ball.Location = new System.Drawing.Point(94, 71);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 25);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(45, 215);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lvl_lbl
            // 
            this.lvl_lbl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl_lbl.Location = new System.Drawing.Point(670, 13);
            this.lvl_lbl.Name = "lvl_lbl";
            this.lvl_lbl.Size = new System.Drawing.Size(59, 26);
            this.lvl_lbl.TabIndex = 6;
            this.lvl_lbl.Text = "Lvl: ";
            // 
            // lvlValue_lbl
            // 
            this.lvlValue_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlValue_lbl.Location = new System.Drawing.Point(705, 13);
            this.lvlValue_lbl.Name = "lvlValue_lbl";
            this.lvlValue_lbl.Size = new System.Drawing.Size(24, 26);
            this.lvlValue_lbl.TabIndex = 7;
            this.lvlValue_lbl.Text = "1";
            // 
            // achievement_lbl
            // 
            this.achievement_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.achievement_lbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.achievement_lbl.ForeColor = System.Drawing.Color.Black;
            this.achievement_lbl.Location = new System.Drawing.Point(338, 0);
            this.achievement_lbl.Name = "achievement_lbl";
            this.achievement_lbl.Size = new System.Drawing.Size(128, 71);
            this.achievement_lbl.TabIndex = 8;
            this.achievement_lbl.Text = "You Are \r\nAWESOME!\r\n";
            this.achievement_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 507);
            this.Controls.Add(this.playground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rainbow 5 Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label achievement;
        private System.Windows.Forms.Label lvlValue_lbl;
        private System.Windows.Forms.Label lvl_lbl;
        private System.Windows.Forms.Label achievement_lbl;
    }
}

