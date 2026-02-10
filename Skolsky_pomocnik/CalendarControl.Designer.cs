namespace Skolsky_pomocnik
{
    partial class CalendarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_AddEvent = new System.Windows.Forms.Panel();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Priority = new System.Windows.Forms.ComboBox();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.textBox_Event = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Event = new System.Windows.Forms.DateTimePicker();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.comboBox_FilterPriority = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterSubject = new System.Windows.Forms.ComboBox();
            this.button_Export = new System.Windows.Forms.Button();
            this.dataGridView_Events = new System.Windows.Forms.DataGridView();
            this.panel_AddEvent.SuspendLayout();
            this.panel_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AddEvent
            // 
            this.panel_AddEvent.Controls.Add(this.button_Add);
            this.panel_AddEvent.Controls.Add(this.comboBox_Priority);
            this.panel_AddEvent.Controls.Add(this.comboBox_Subject);
            this.panel_AddEvent.Controls.Add(this.textBox_Event);
            this.panel_AddEvent.Controls.Add(this.dateTimePicker_Event);
            this.panel_AddEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AddEvent.Location = new System.Drawing.Point(0, 0);
            this.panel_AddEvent.Name = "panel_AddEvent";
            this.panel_AddEvent.Size = new System.Drawing.Size(1130, 80);
            this.panel_AddEvent.TabIndex = 0;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Add.Location = new System.Drawing.Point(800, 20);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 30);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Pridať";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBox_Priority
            // 
            this.comboBox_Priority.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Priority.FormattingEnabled = true;
            this.comboBox_Priority.Location = new System.Drawing.Point(670, 20);
            this.comboBox_Priority.Name = "comboBox_Priority";
            this.comboBox_Priority.Size = new System.Drawing.Size(120, 29);
            this.comboBox_Priority.TabIndex = 4;
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Location = new System.Drawing.Point(430, 20);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(230, 29);
            this.comboBox_Subject.TabIndex = 3;
            // 
            // textBox_Event
            // 
            this.textBox_Event.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.textBox_Event.Location = new System.Drawing.Point(170, 20);
            this.textBox_Event.Name = "textBox_Event";
            this.textBox_Event.Size = new System.Drawing.Size(250, 29);
            this.textBox_Event.TabIndex = 2;
            this.textBox_Event.Text = "Názov Eventu";
            // 
            // dateTimePicker_Event
            // 
            this.dateTimePicker_Event.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_Event.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Event.Location = new System.Drawing.Point(10, 20);
            this.dateTimePicker_Event.Name = "dateTimePicker_Event";
            this.dateTimePicker_Event.Size = new System.Drawing.Size(150, 29);
            this.dateTimePicker_Event.TabIndex = 1;
            // 
            // panel_Filter
            // 
            this.panel_Filter.Controls.Add(this.comboBox_FilterPriority);
            this.panel_Filter.Controls.Add(this.comboBox_FilterSubject);
            this.panel_Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Filter.Location = new System.Drawing.Point(0, 80);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(1130, 40);
            this.panel_Filter.TabIndex = 6;
            // 
            // comboBox_FilterPriority
            // 
            this.comboBox_FilterPriority.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_FilterPriority.FormattingEnabled = true;
            this.comboBox_FilterPriority.Location = new System.Drawing.Point(250, 5);
            this.comboBox_FilterPriority.Name = "comboBox_FilterPriority";
            this.comboBox_FilterPriority.Size = new System.Drawing.Size(120, 29);
            this.comboBox_FilterPriority.TabIndex = 1;
            this.comboBox_FilterPriority.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterPriority_SelectedIndexChanged);
            // 
            // comboBox_FilterSubject
            // 
            this.comboBox_FilterSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_FilterSubject.FormattingEnabled = true;
            this.comboBox_FilterSubject.Location = new System.Drawing.Point(10, 5);
            this.comboBox_FilterSubject.Name = "comboBox_FilterSubject";
            this.comboBox_FilterSubject.Size = new System.Drawing.Size(230, 29);
            this.comboBox_FilterSubject.TabIndex = 0;
            this.comboBox_FilterSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterSubject_SelectedIndexChanged);
            // 
            // button_Export
            // 
            this.button_Export.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Export.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Export.Location = new System.Drawing.Point(0, 798);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(1130, 40);
            this.button_Export.TabIndex = 7;
            this.button_Export.Text = "Export CSV/TXT";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // dataGridView_Events
            // 
            this.dataGridView_Events.AllowUserToAddRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Events.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Events.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Events.Location = new System.Drawing.Point(0, 120);
            this.dataGridView_Events.Name = "dataGridView_Events";
            this.dataGridView_Events.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Events.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_Events.RowHeadersWidth = 62;
            this.dataGridView_Events.RowTemplate.Height = 28;
            this.dataGridView_Events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Events.Size = new System.Drawing.Size(1130, 678);
            this.dataGridView_Events.TabIndex = 8;
            // 
            // CalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_Events);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.panel_AddEvent);
            this.Name = "CalendarControl";
            this.Size = new System.Drawing.Size(1130, 838);
            this.panel_AddEvent.ResumeLayout(false);
            this.panel_AddEvent.PerformLayout();
            this.panel_Filter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AddEvent;
        private System.Windows.Forms.TextBox textBox_Event;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Event;
        private System.Windows.Forms.ComboBox comboBox_Priority;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_FilterPriority;
        private System.Windows.Forms.ComboBox comboBox_FilterSubject;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.DataGridView dataGridView_Events;
    }
}
