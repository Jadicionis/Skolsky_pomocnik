using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skolsky_pomocnik
{
    public partial class PomodoroTimerControl : UserControl
    {
        Timer timer = new Timer();
        int remainingSeconds = 0;
        bool isWorkInterval = true;
        int initialSeconds = 0; // Track the starting time

        public event EventHandler DisableGameButtons;
        public event EventHandler EnableGameButtons;

        public PomodoroTimerControl()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            numericUpDown_Work_Time.Value = 25;
            numericUpDown_Break_Time.Value = 5;
            label_Timer.Text = "25:00";
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                if (remainingSeconds == 0)
                {
                    remainingSeconds = (int)numericUpDown_Work_Time.Value * 60;
                    initialSeconds = remainingSeconds;
                    isWorkInterval = true;
                }
                timer.Start();
                button_Start_Stop.Text = "Zastaviť";
                DisableGameButtons.Invoke(this, EventArgs.Empty);
            }
            else
            {
                timer.Stop();
                button_Start_Stop.Text = "Spustiť";
                EnableGameButtons.Invoke(this, EventArgs.Empty);

                // Log pause to history
                int elapsedSeconds = initialSeconds - remainingSeconds;
                int elapsedMinutes = elapsedSeconds / 60;
                string type = isWorkInterval ? "Práca" : "Pauza";
                listBox_History.Items.Add($"{DateTime.Now:HH:mm} - {type} pozastavené ({elapsedMinutes} min)");
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            remainingSeconds = 0;
            initialSeconds = 0;
            isWorkInterval = true;
            label_Timer.Text = $"{numericUpDown_Work_Time.Value:00}:00";
            button_Start_Stop.Text = "Spustiť";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                label_Timer.Text = TimeSpan.FromSeconds(remainingSeconds).ToString(@"mm\:ss");
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();

                // Adding to History - completed interval
                string type = isWorkInterval ? "Práca" : "Pauza";
                int completedMinutes = initialSeconds / 60;
                listBox_History.Items.Add($"{DateTime.Now:HH:mm} - {type} dokončené ({completedMinutes} min)");

                // Update stats before changing interval
                UpdateStats();

                // Change Interval
                if (isWorkInterval)
                {
                    remainingSeconds = (int)numericUpDown_Break_Time.Value * 60;
                    initialSeconds = remainingSeconds;
                    isWorkInterval = false;
                }
                else
                {
                    remainingSeconds = (int)numericUpDown_Work_Time.Value * 60;
                    initialSeconds = remainingSeconds;
                    isWorkInterval = true;
                }
            }
        }

        private void UpdateStats()
        {
            int workCount = listBox_History.Items.Cast<string>().Count(x => x.Contains("Práca dokončené"));
            int breakCount = listBox_History.Items.Cast<string>().Count(x => x.Contains("Pauza dokončené"));
            int totalMinutes = workCount * (int)numericUpDown_Work_Time.Value;

            label_Cycles.Text = $"Cykly: {workCount}";
            label_Pauses.Text = $"Pauzy: {breakCount}";
            label_Total.Text = $"Celkovo: {totalMinutes} min";
        }
    }
}