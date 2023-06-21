using LifeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife    
{
    public partial class Form1 : Form
    {
        Board board;
        public int NumberOfGeneration = 0;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private void pictureBox1_SizeChanged(object sender, EventArgs e) { Reset(); }

        private void Reset(bool randomize = true)
        {
            board = new Board(pictureBox1.Width, pictureBox1.Height, 20);
            if (randomize)
            {
                board.Randomize((double)6 / 100);
            }
            NumberOfGeneration = 0;
            Render();
        }

        private void Reset(string startingPattern)
        {
            string[] lines = startingPattern.Split('\n');
            int yOffset = (board.Rows - lines.Length) / 2;
            int xOffset = (board.Columns - lines[0].Length) / 2;

            Reset(randomize: false);
            for (int y = 0; y < lines.Length; y++)
            {
                for (int x = 0; x < lines[y].Length; x++)
                {
                    board.Cells[x + xOffset, y + yOffset].IsAlive = lines[y].Substring(x, 1) == "X";
                }
            }
            NumberOfGeneration = 0;
            Render();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            NumberOfGeneration++;
            toolStripStatusLabel2.Text = NumberOfGeneration.ToString();  
            Invalidate();
            board.Advance();
            Render();
            CheckGeneration();
            if (CheckGeneration())
            {
                NumberOfGeneration = 0;
                timer1.Enabled = false;
            }
        }
        private void Render()
        {
            using (var bmp = new Bitmap(board.Width, board.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var brush = new SolidBrush(Color.HotPink))
            {
                gfx.Clear(Color.DarkGray);

                Size cellSize;
                if (board.CellSize > 1)
                {
                    cellSize = new Size(board.CellSize - 1, board.CellSize - 1);
                }
                else
                {
                    cellSize = new Size(board.CellSize, board.CellSize);
                }

                for (int col = 0; col < board.Columns; col++)
                {
                    for (int row = 0; row < board.Rows; row++)
                    {
                        var cell = board.Cells[col, row];
                        if (cell.IsAlive)
                        {
                            var cellLocation = new Point(col * board.CellSize, row * board.CellSize);
                            var cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(brush, cellRect);
                        }
                        
                    }
                }

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }
        bool CheckGeneration()
        {
            bool Checked = true;
            for (int col = 0; col < board.Columns; col++)
            {
                for (int row = 0; row < board.Rows; row++)
                {
                    var cell = board.Cells[col, row];
                    if (cell.IsAlive) 
                    {
                        Checked = false;
                    }
                }
            }
            return Checked;
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
