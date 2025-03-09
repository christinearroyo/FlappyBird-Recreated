namespace Flappy_Bird
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
            FlappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800;
                score++;
                scoreText.Text = "Score: " + score;
            }
            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                FlappyBird.Top < -25
                )
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }
            if (score > 10)
            {
                pipeSpeed = 20;
            }
            if (score > 20)
            {
                pipeSpeed = 25;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
        }
    }
}
