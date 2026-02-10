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
            // Clean the old UserControl from panel
            panel_Content.Controls.Clear();

            App.Dock = DockStyle.Fill;

            // Creating a UserControl Instance
            panel_Content.Controls.Add(App);

            App.BringToFront();
        }


        public Form_Main()
        {
            InitializeComponent();
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
            ShowApp(new PomodoroTimerControl());
        }

        private void button_Calendar_Click(object sender, EventArgs e)
        {
            ShowApp(new CalendarControl());
        }

        private void button_PasswordGenerator_Click(object sender, EventArgs e)
        {
            ShowApp(new PasswordGeneratorControl());
        }
    }
}
