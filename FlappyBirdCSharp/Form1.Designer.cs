namespace FlappyBirdCSharp
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.restartButton = new System.Windows.Forms.Button();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.scoreBackground = new System.Windows.Forms.PictureBox();
            this.clouds1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(43, 43);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(211, 55);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.UseWaitCursor = true;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Gold;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(284, 237);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(214, 63);
            this.restartButton.TabIndex = 6;
            this.restartButton.Text = "Play Again";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdCSharp.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(423, -94);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 246);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBirdCSharp.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(53, 175);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(86, 72);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdCSharp.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-24, 524);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(924, 179);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBirdCSharp.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(320, 401);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(113, 224);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // scoreBackground
            // 
            this.scoreBackground.BackColor = System.Drawing.Color.Transparent;
            this.scoreBackground.Location = new System.Drawing.Point(12, 589);
            this.scoreBackground.Name = "scoreBackground";
            this.scoreBackground.Size = new System.Drawing.Size(561, 180);
            this.scoreBackground.TabIndex = 5;
            this.scoreBackground.TabStop = false;
            this.scoreBackground.Click += new System.EventHandler(this.scoreBackground_Click);
            // 
            // clouds1
            // 
            this.clouds1.Image = global::FlappyBirdCSharp.Properties.Resources.clouds;
            this.clouds1.Location = new System.Drawing.Point(559, 237);
            this.clouds1.Name = "clouds1";
            this.clouds1.Size = new System.Drawing.Size(198, 115);
            this.clouds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds1.TabIndex = 7;
            this.clouds1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(769, 691);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.scoreBackground);
            this.Controls.Add(this.clouds1);
            this.MaximumSize = new System.Drawing.Size(785, 730);
            this.MinimumSize = new System.Drawing.Size(785, 730);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox scoreBackground;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox clouds1;
    }
}

