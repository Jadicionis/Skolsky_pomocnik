using Skolsky_pomocnik;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeHelper
{
    public static void ApplyTheme(Control control)
    {
        Color back, fore, border;

        if (ThemeManager.CurrentTheme == Theme.Dark)
        {
            back = Color.FromArgb(30, 30, 30);      // tmavé pozadie
            fore = Color.White;                     // svetlý text
            border = Color.Gray;                    // okraje viditeľné
        }
        else
        {
            back = Color.White;                     // svetlé pozadie
            fore = Color.Black;                     // tmavý text
            border = Color.DarkGray;                // okraje
        }

        ApplyThemeRecursive(control, back, fore, border);
    }

    private static void ApplyThemeRecursive(Control control, Color back, Color fore, Color border)
    {
        // Všeobecné nastavenie pozadia a textu
        if (!(control is Panel) && !(control is UserControl))
        {
            control.BackColor = back;
            control.ForeColor = fore;
        }

        // TextBox/RichTextBox
        if (control is TextBox tb)
        {
            tb.BackColor = back == Color.White ? Color.White : Color.FromArgb(50, 50, 50);
            tb.ForeColor = fore;
            tb.BorderStyle = BorderStyle.FixedSingle;
        }
        else if (control is RichTextBox rtb)
        {
            rtb.BackColor = back == Color.White ? Color.White : Color.FromArgb(50, 50, 50);
            rtb.ForeColor = fore;
            rtb.BorderStyle = BorderStyle.FixedSingle;
        }

        // ListBox
        if (control is ListBox)
        {
            control.BackColor = back == Color.White ? Color.White : Color.FromArgb(50, 50, 50);
            control.ForeColor = fore;
        }

        // DateTimePicker
        if (control is DateTimePicker dtp)
        {
            dtp.CalendarForeColor = fore;
            dtp.CalendarMonthBackground = back;
            dtp.CalendarTitleBackColor = back;
            dtp.CalendarTitleForeColor = fore;
            dtp.CalendarTrailingForeColor = fore;
            dtp.ForeColor = fore;
            dtp.BackColor = back;
        }

        // DataGridView
        if (control is DataGridView dgv)
        {
            dgv.BackgroundColor = back;
            dgv.ForeColor = fore;
            dgv.GridColor = border;
            dgv.DefaultCellStyle.BackColor = back;
            dgv.DefaultCellStyle.ForeColor = fore;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = back;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = fore;
            dgv.RowHeadersDefaultCellStyle.BackColor = back;
            dgv.RowHeadersDefaultCellStyle.ForeColor = fore;
        }

        // Nastavenie okrajov pre Panely a iné Controls
        if (control is Panel || control is GroupBox)
        {
            control.BackColor = back;
            control.ForeColor = fore;
            control.Padding = new Padding(1);
        }

        // Rekurzívne pre všetky podkontroly
        foreach (Control child in control.Controls)
            ApplyThemeRecursive(child, back, fore, border);
    }
}
