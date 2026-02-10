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
    public partial class CalendarControl : UserControl
    {

        private void UpdateGrid()
        {
            string filterSubject = comboBox_FilterSubject.Text;
            string filterPriority = comboBox_FilterPriority.Text;

            var filtered = events.AsEnumerable();

            if (!string.IsNullOrEmpty(filterSubject) && filterSubject != "Všetky")
                filtered = filtered.Where(ev => ev.Subject == filterSubject);

            if (!string.IsNullOrEmpty(filterPriority) && filterPriority != "Všetky")
                filtered = filtered.Where(ev => ev.Priority == filterPriority);

            dataGridView_Events.DataSource = filtered
                .Select(ev => new
                {
                    Dátum = ev.Date.ToShortDateString(),
                    Predmet = ev.Subject,
                    Event = ev.Name,
                    Priorita = ev.Priority
                })
                .ToList();
        }

        private void InitComboBoxes()
        {
            comboBox_Subject.Items.AddRange(new string[] { "Matematika", "Fyzika", "Slovenský jazyk", "Biológia", "Programovanie", "Informačné a Databázové Systémy", "Tvorba Webstránok", "Sieťové a Serverové Technológie" });
            comboBox_FilterSubject.Items.Add("Všetky");
            comboBox_FilterSubject.Items.AddRange(new string[] { "Matematika", "Fyzika", "Slovenský jazyk", "Biológia", "Programovanie", "Informačné a Databázové Systémy", "Tvorba Webstránok", "Sieťové a Serverové Technológie" });
            comboBox_Priority.Items.AddRange(new string[] { "Vysoká", "Stredná", "Nízka" });
            comboBox_FilterPriority.Items.Add("Všetky");
            comboBox_FilterPriority.Items.AddRange(new string[] { "Vysoká", "Stredná", "Nízka" });

            comboBox_FilterSubject.SelectedIndex = 0;
            comboBox_FilterPriority.SelectedIndex = 0;
        }



        public class CalendarEvent
        {
            public DateTime Date { get; set; }
            public string Subject { get; set; }
            public string Name { get; set; }
            public string Priority { get; set; }
        }

        private List<CalendarEvent> events = new List<CalendarEvent>();

        public CalendarControl()
        {
            InitializeComponent();
            InitComboBoxes();

            comboBox_FilterSubject.SelectedIndexChanged += comboBox_FilterSubject_SelectedIndexChanged;
            comboBox_FilterPriority.SelectedIndexChanged += comboBox_FilterPriority_SelectedIndexChanged;

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(textBox_Event.Text))
            {
                MessageBox.Show("Zadaj názov eventu.");
                return;
            }

            var newEvent = new CalendarEvent
            {
                Date = dateTimePicker_Event.Value.Date,
                Name = textBox_Event.Text.Trim(),
                Subject = comboBox_Subject.Text,
                Priority = comboBox_Priority.Text
            };

            events.Add(newEvent);

            UpdateGrid();

            // Optional: clear inputs
            textBox_Event.Text = "";
            comboBox_Subject.SelectedIndex = -1;
            comboBox_Priority.SelectedIndex = -1;
        }

        private void comboBox_FilterSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void comboBox_FilterPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }


        private void button_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView_Events.Rows.Count == 0)
            {
                MessageBox.Show("Žiadne eventy na export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV|*.csv|Text|*.txt";
                sfd.FileName = "Events";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var lines = new List<string>();
                    // Header
                    lines.Add("Dátum,Predmet,Event,Priorita");

                    foreach (DataGridViewRow row in dataGridView_Events.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            lines.Add($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value}");
                        }
                    }

                    System.IO.File.WriteAllLines(sfd.FileName, lines, Encoding.UTF8);
                    MessageBox.Show("Export hotový!");
                }
            }
        }
    }
}
