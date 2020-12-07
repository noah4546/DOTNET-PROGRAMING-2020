using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11_BallEx
{
    public partial class Form1 : Form
    {
        private List<Ball> ballList = new List<Ball>();
        private int NumberOfBalls { get; set; } = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (StartButton.Enabled)
            {
                GameTimer.Enabled = true;
                StartButton.Enabled = false;
                NumberOfBalls = 0;
                GameTimer_Tick(null, null); // May need to comment this out for now
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Check for end condition
            if (ballList.Count > 0 && NumberOfBalls > 0)
            {
                // TODO – End of Game
                // Turn timer off and re-enable the Start button
                GameTimer.Enabled = false;
                StartButton.Enabled = true;

                MessageBox.Show($"Game Over! You got {NumberOfBalls}");
                // Put up a message that Game is Over and tell them how
                // many rounds they have completed
                return;
            }
            NumberOfBalls++;
            // This will generate a Random set of Balls and put them into a List
            for (int i = 0; i < NumberOfBalls; i++)
            {
                int radius = rnd.Next(20, 50);
                int x = rnd.Next(radius * 2, DrawingPanel.Width - radius * 4);
                int y = rnd.Next(radius * 2, DrawingPanel.Height - radius * 4);
                int red = rnd.Next(100, 255);
                int green = rnd.Next(100, 255);
                int blue = rnd.Next(100, 255);
                ballList.Add(new Ball(x, y, radius, Color.FromArgb(red, green, blue)));
            }
            Graphics g = DrawingPanel.CreateGraphics(); //Create a graphics object

            g.Clear(Color.Black);

            foreach (Ball b in ballList)
                b.Draw(g);

            g.Dispose();
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameTimer.Enabled)
            {
                for (int i = 0; i < NumberOfBalls; i++)
                {
                    if (ballList[i].PointInBall(e.X, e.Y))
                    {
                        ballList.RemoveAt(i);
                        NumberOfBalls--;
                    }
                }

                Graphics g = DrawingPanel.CreateGraphics(); //Create a graphics object

                g.Clear(Color.Black);

                foreach (Ball b in ballList)
                    b.Draw(g);

                g.Dispose();
            }
        }


    }
}
