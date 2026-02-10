using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Skolsky_pomocnik
{
    public partial class Form_Main : Form
    {

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        private void ShowApp(UserControl App)
        {
            // Vyčisti starú appku
            panel_Content.Controls.Clear();

            panel_Content.Controls.Add(App);
            App.Dock = DockStyle.Fill;
            App.BringToFront();

            // Aplikovanie temy na UserControl
            ThemeHelper.ApplyTheme(App);
        }


        private void Pomodoro_DisableGameButtons(object sender, EventArgs e)
        {
            button_Minesweeper.Enabled = false;
            button_2048.Enabled = false;
        }
        private void Pomodoro_EnableGameButtons(object sender, EventArgs e)
        {
            button_Minesweeper.Enabled = true;
            button_2048.Enabled = true;
        }


        public Form_Main()
        {
            InitializeComponent();

            ThemeManager.ThemeChanged += () =>
            {
                ThemeHelper.ApplyTheme(this);
                UpdateIcons();
            };
            ApplyTheme();
            UpdateIcons();
        }

        private void SetButtonIcon(Button btn, Image img, int maxSize)
        {
            // limit veľkosti
            int width = Math.Min(img.Width, maxSize);
            int height = Math.Min(img.Height, maxSize);

            Bitmap bmp = new Bitmap(img, width, height);
            btn.Image = bmp;

            // centrovanie
            btn.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void ApplyTheme()
        {
            ThemeHelper.ApplyTheme(this);
        }

        private void UpdateIcons()
        {
            int maxSize = 24;
            if (ThemeManager.CurrentTheme == Theme.Dark)
            {
                SetButtonIcon(button_Close, Properties.Resources.Icon_Close_White, maxSize);
                SetButtonIcon(button_Minimize, Properties.Resources.Icon_Minimize_White, maxSize);
            }
            else
            {
                SetButtonIcon(button_Close, Properties.Resources.Icon_Close, maxSize);
                SetButtonIcon(button_Minimize, Properties.Resources.Icon_Minimize, maxSize);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button_calculator_Click(object sender, EventArgs e)
        {
            ShowApp(new CalculatorControl());
        }

        private void button_Pomodoro_Click(object sender, EventArgs e)
        {
            var pomodoro = new PomodoroTimerControl();

            pomodoro.DisableGameButtons += Pomodoro_DisableGameButtons;
            pomodoro.EnableGameButtons += Pomodoro_EnableGameButtons;

            ShowApp(pomodoro);

        }

        private void button_Calendar_Click(object sender, EventArgs e)
        {
            ShowApp(new CalendarControl());
        }

        private void button_PasswordGenerator_Click(object sender, EventArgs e)
        {
            ShowApp(new PasswordGeneratorControl());
        }

        private void button_Minesweeper_Click(object sender, EventArgs e)
        {
            ShowApp(new MinesweeperControl());
        }

        private void button_2048_Click(object sender, EventArgs e)
        {
            ShowApp(new Game2048Control());
        }

        private void checkBox_Theme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Theme.Checked)
            {
                ThemeManager.SetTheme(Theme.Dark);
            }
            else
            {
                ThemeManager.SetTheme(Theme.Light);
            }
        }
    }
}
