using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        const int worldWidth = 400;
        const int worldHeight = 300;
        const int scale = 2;
        const int frames = 24;
        const double randomRate = 0.001;
        const int penRadius = 10;

        byte[,] world;
        Timer timer;
        CellBehavior behavior;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            world = new byte[worldWidth, worldHeight];
            resetWorld();

            pictureBoxCanvas.Left = 0;
            pictureBoxCanvas.Top = 0;
            pictureBoxCanvas.Width = worldWidth * scale;
            pictureBoxCanvas.Height = worldHeight * scale;
            pictureBoxCanvas.SizeMode = PictureBoxSizeMode.Zoom;

            this.Width = pictureBoxCanvas.Width + 15;
            this.Height = pictureBoxCanvas.Height + 38;

            setDefaultBehavior();

            this.Paint += new PaintEventHandler(Form1_Paint);

            // 24 frames a second.
            timer = new Timer();
            timer.Interval = 1000 / frames;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Convert world to bitmap to draw to screen.
            Bitmap bitmap = new Bitmap(worldWidth, worldHeight);
            for (int x = 0; x < worldWidth; ++x)
            {
                for (int y = 0; y < worldHeight; ++y)
                {
                    bitmap.SetPixel(x, y, world[x, y] > 0 ? Color.Black : Color.White);
                }
            }

            pictureBoxCanvas.Image = bitmap;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //addRandom();
            updateWorld();

            this.Invalidate(new Rectangle(0, 0, 800, 600));
        }

        void setDefaultBehavior()
        {
            CellBehavior behavior = new CellBehavior();
            behavior.codes = new List<int>() { 0, 0, 1, 2, 0, 0, 0, 0, 0};
            this.behavior = behavior;
        }

        /// <summary>
        /// Reset and generate a random world
        /// </summary>
        void resetWorld()
        {
            for (int x = 0; x < worldWidth; ++x)
            {
                for (int y = 0; y < worldHeight; ++y)
                {
                    world[x, y] = (byte)random.Next(2);
                }
            }
        }

        void updateWorld()
        {
            byte[,] world2 = new byte[worldWidth, worldHeight];

            // 忽略边上的一圈
            int maxWidth = worldWidth - 1;
            int maxHeight = worldHeight - 1;
            for (int x = 1; x < maxWidth; ++x)
            {
                for (int y = 1; y < maxHeight; ++y)
                {
                    int count =  world[x - 1, y - 1] + world[x, y - 1] + world[x + 1, y - 1] +
                                        world[x - 1, y] + world[x + 1, y] +
                                        world[x - 1, y + 1] + world[x, y + 1] + world[x + 1, y + 1];

                    world2[x, y] = behavior.updateCell(world[x, y], count);
                }
            }

            world = world2;
        }

        void addRandom()
        {
            int count = (int)(worldWidth * worldHeight * randomRate);
            for (int i = 0; i < count; ++i)
            {
                int x = random.Next(worldWidth);
                int y = random.Next(worldHeight);
                world[x, y] = 1;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void buttonRandomBehavior_Click(object sender, EventArgs e)
        {
            this.behavior = new CellBehavior();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                return;
            }

            int centerX = e.X / scale;
            int centerY = e.Y / scale;

            byte cell = (byte)(e.Button == MouseButtons.Left ? 1 : 0);

            for (int x = centerX - penRadius; x <= centerX + penRadius; ++x)
            {
                for (int y = centerY - penRadius; y <= centerY + penRadius; ++y)
                {
                    x = Math.Abs(x);
                    y = Math.Abs(y);
                    world[x % worldWidth, y % worldHeight] = cell;
                }
            }

            this.Invalidate(new Rectangle(0, 0, 800, 600));
        }

        private void buttonDefaultBehavior_Click(object sender, EventArgs e)
        {
            setDefaultBehavior();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            world = new byte[worldWidth, worldHeight];
        }
    }
}
