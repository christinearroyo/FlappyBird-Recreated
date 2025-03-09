namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeTop = new PictureBox();
            FlappyBird = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Anchor = AnchorStyles.None;
            pipeTop.BackColor = Color.Transparent;
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(467, -4);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(96, 159);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // FlappyBird
            // 
            FlappyBird.Anchor = AnchorStyles.None;
            FlappyBird.BackColor = Color.Transparent;
            FlappyBird.Image = (Image)resources.GetObject("FlappyBird.Image");
            FlappyBird.Location = new Point(88, 250);
            FlappyBird.Name = "FlappyBird";
            FlappyBird.Size = new Size(78, 67);
            FlappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            FlappyBird.TabIndex = 1;
            FlappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Anchor = AnchorStyles.None;
            pipeBottom.BackColor = Color.Transparent;
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(310, 409);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(96, 178);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Anchor = AnchorStyles.None;
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-8, 584);
            ground.Name = "ground";
            ground.Size = new Size(618, 62);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.Anchor = AnchorStyles.None;
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(22, 26);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(144, 34);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(604, 647);
            Controls.Add(scoreText);
            Controls.Add(FlappyBird);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "FlappyBirdNiArroyo";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox FlappyBird;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
