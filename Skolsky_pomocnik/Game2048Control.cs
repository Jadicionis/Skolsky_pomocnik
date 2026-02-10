using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Skolsky_pomocnik
{
    public partial class Game2048Control : UserControl
    {
        private int[,] grid = new int[4, 4];
        private Random rnd = new Random();

        private int cellSize;

        private bool hasSelection = false;
        private Point selected;

        public Game2048Control()
        {
            InitializeComponent();

            panel_Grid.Paint += Panel_Grid_Paint;
            panel_Grid.MouseClick += Panel_Grid_MouseClick;
            this.Resize += (s, e) => CenterPanel();

            NewGame();
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel_Grid.Left = (ClientSize.Width - panel_Grid.Width) / 2;
            panel_Grid.Top = (ClientSize.Height - panel_Grid.Height) / 2;
        }

        private void NewGame()
        {
            grid = new int[4, 4];
            hasSelection = false;

            AddRandomTile();
            AddRandomTile();

            panel_Grid.Invalidate();
        }

        private void AddRandomTile()
        {
            var empty = Enumerable.Range(0, 16)
                .Where(i => grid[i / 4, i % 4] == 0)
                .ToList();

            if (empty.Count == 0) return;

            int idx = empty[rnd.Next(empty.Count)];
            grid[idx / 4, idx % 4] = rnd.NextDouble() < 0.9 ? 2 : 4;
        }

        private void Panel_Grid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            cellSize = Math.Min(panel_Grid.Width, panel_Grid.Height) / 4;

            // Získať pozadie podľa témy, trochu svetlejšie pre grid
            Color panelBack = ThemeManager.CurrentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.LightGray;

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Rectangle rect = new Rectangle(c * cellSize, r * cellSize, cellSize, cellSize);
                    g.FillRectangle(new SolidBrush(GetTileColor(grid[r, c])), rect);
                    g.DrawRectangle(Pens.Black, rect);

                    if (grid[r, c] != 0)
                    {
                        string text = grid[r, c].ToString();
                        var size = g.MeasureString(text, this.Font);
                        g.DrawString(text, this.Font, Brushes.Black,
                            rect.X + (cellSize - size.Width) / 2,
                            rect.Y + (cellSize - size.Height) / 2);
                    }
                }
            }
        }
        private Color GetTileColor(int val)
        {
            if (val == 0)
            {
                return ThemeManager.CurrentTheme == Theme.Dark ? Color.FromArgb(80, 80, 80) : Color.White;
            }

            switch (val)
            {
                case 2: return Color.Beige;
                case 4: return Color.Bisque;
                case 8: return Color.Orange;
                case 16: return Color.OrangeRed;
                case 32: return Color.Red;
                case 64: return Color.DarkRed;
                case 128: return Color.Yellow;
                case 256: return Color.Gold;
                case 512: return Color.LightGreen;
                case 1024: return Color.Green;
                case 2048: return Color.Lime;
                default: return Color.Black;
            }
        }
        private void Panel_Grid_MouseClick(object sender, MouseEventArgs e)
        {
            int r = e.Y / cellSize;
            int c = e.X / cellSize;

            if (r < 0 || r > 3 || c < 0 || c > 3)
                return;

            // 1️ výber bloku
            if (!hasSelection)
            {
                if (grid[r, c] == 0)
                    return;

                selected = new Point(r, c);
                hasSelection = true;
                panel_Grid.Invalidate();
                return;
            }

            // 2️ cieľ – MUSÍ byť sused
            int dr = r - selected.X;
            int dc = c - selected.Y;

            if (Math.Abs(dr) + Math.Abs(dc) != 1)
            {
                hasSelection = false;
                panel_Grid.Invalidate();
                return;
            }

            // logika pohybu
            if (grid[r, c] == 0)
            {
                // presun
                grid[r, c] = grid[selected.X, selected.Y];
                grid[selected.X, selected.Y] = 0;
                AddRandomTile();
            }
            else if (grid[r, c] == grid[selected.X, selected.Y])
            {
                // spojenie
                grid[r, c] *= 2;
                grid[selected.X, selected.Y] = 0;
                AddRandomTile();
            }
            // iný blok → zákaz (nič sa nestane)

            hasSelection = false;
            panel_Grid.Invalidate();

            if (CheckWin())
                MessageBox.Show("Gratulujem! Dosiahol si 2048!");
            else if (CheckGameOver())
                MessageBox.Show("Koniec hry!");
        }

        private bool CheckWin()
        {
            return grid.Cast<int>().Any(x => x == 2048);
        }

        private bool CheckGameOver()
        {
            if (grid.Cast<int>().Any(x => x == 0))
                return false;

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 3; c++)
                    if (grid[r, c] == grid[r, c + 1])
                        return false;

            for (int c = 0; c < 4; c++)
                for (int r = 0; r < 3; r++)
                    if (grid[r, c] == grid[r + 1, c])
                        return false;

            return true;
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
