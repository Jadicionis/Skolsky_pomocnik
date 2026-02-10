using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Skolsky_pomocnik
{
    public partial class MinesweeperControl : UserControl
    {
        int rows;
        int cols;
        int minesCount;
        Button[,] gridButtons;
        bool[,] mines;
        int[,] numbers;
        bool[,] revealed;
        bool[,] flagged;

        public MinesweeperControl()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            rows = (int)numericUpDown_Rows.Value;
            cols = (int)numericUpDown_Columns.Value;
            minesCount = (int)numericUpDown_Mines.Value;

            GenerateGrid();
        }

        private void GenerateGrid()
        {
            panel_Grid.Controls.Clear();
            gridButtons = new Button[rows, cols];
            mines = new bool[rows, cols];
            numbers = new int[rows, cols];
            revealed = new bool[rows, cols];
            flagged = new bool[rows, cols]; // inicializácia vlajok

            Random rnd = new Random();
            int placed = 0;
            while (placed < minesCount)
            {
                int r = rnd.Next(rows);
                int c = rnd.Next(cols);
                if (!mines[r, c])
                {
                    mines[r, c] = true;
                    placed++;
                }
            }

            // calculate numbers...
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (mines[r, c]) continue;
                    int count = 0;
                    for (int dr = -1; dr <= 1; dr++)
                        for (int dc = -1; dc <= 1; dc++)
                        {
                            int nr = r + dr;
                            int nc = c + dc;
                            if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && mines[nr, nc])
                                count++;
                        }
                    numbers[r, c] = count;
                }
            }

            // create buttons dynamically and set location
            int btnWidth = panel_Grid.Width / cols;
            int btnHeight = panel_Grid.Height / rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Button btn = new Button();
                    btn.Width = btnWidth;
                    btn.Height = btnHeight;
                    btn.Left = c * btnWidth;
                    btn.Top = r * btnHeight;
                    btn.Tag = new Point(r, c);
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.MouseUp += Button_MouseUp; // pridáme MouseUp pre ľavé/pravé kliknutie

                    gridButtons[r, c] = btn;
                    panel_Grid.Controls.Add(btn);
                }
            }
        }


        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            Point p = (Point)btn.Tag;
            int r = p.X;
            int c = p.Y;

            if (e.Button == MouseButtons.Right)
            {
                if (revealed[r, c]) return;

                // toggle vlajky
                flagged[r, c] = !flagged[r, c];
                btn.Text = flagged[r, c] ? "🚩" : "";
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (flagged[r, c] || revealed[r, c]) return;

                RevealCell(r, c);
            }
        }

        private void RevealCell(int r, int c)
        {
            if (revealed[r, c]) return;

            revealed[r, c] = true;
            Button btn = gridButtons[r, c];

            if (mines[r, c])
            {
                btn.BackColor = Color.Red;
                btn.Text = "💣";
                MessageBox.Show("BOOM! Prehral si.");
                RevealAll();

                // zakáž všetky tlačidlá
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        gridButtons[i, j].Enabled = false;

                return;
            }

            btn.BackColor = Color.LightGray;
            int n = numbers[r, c];
            if (n > 0)
            {
                btn.Text = n.ToString();
                btn.ForeColor = GetNumberColor(n);
            }
            else
            {
                btn.Text = "";
                // odhal susedné bunky
                for (int dr = -1; dr <= 1; dr++)
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int nr = r + dr;
                        int nc = c + dc;
                        if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && !revealed[nr, nc])
                            RevealCell(nr, nc);
                    }
            }

            if (CheckWin())
            {
                MessageBox.Show("Gratulujem! Vyhral si.");

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        gridButtons[i, j].Enabled = false;
            }
        }

        private void RevealAdjacent(int r, int c)
        {
            for (int dr = -1; dr <= 1; dr++)
            {
                for (int dc = -1; dc <= 1; dc++)
                {
                    int nr = r + dr;
                    int nc = c + dc;
                    if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && !revealed[nr, nc])
                    {
                        revealed[nr, nc] = true;
                        Button btn = gridButtons[nr, nc];
                        btn.BackColor = Color.LightGray;
                        int n = numbers[nr, nc];
                        if (n > 0)
                        {
                            btn.Text = n.ToString();
                            btn.ForeColor = GetNumberColor(n);
                        }
                        else
                        {
                            btn.Text = "";
                            RevealAdjacent(nr, nc);
                        }
                    }
                }
            }
        }

        private void RevealAll()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (mines[r, c])
                        gridButtons[r, c].Text = "💣";

                    gridButtons[r, c].Enabled = false;
                }
            }
        }

        private bool CheckWin()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (!mines[r, c] && !revealed[r, c])
                        return false;
                }
            }
            return true;
        }

        private Color GetNumberColor(int number)
        {
            switch (number)
            {
                case 1: return Color.Blue;
                case 2: return Color.Green;
                case 3: return Color.Red;
                case 4: return Color.DarkBlue;
                case 5: return Color.DarkRed;
                case 6: return Color.Cyan;
                case 7: return Color.Black;
                case 8: return Color.Gray;
                default: return Color.Black;
            }
        }
    }
}
