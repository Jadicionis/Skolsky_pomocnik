namespace Skolsky_pomocnik
{
    partial class PomodoroTimer
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
            this.panel_Timer = new System.Windows.Forms.Panel();
            this.panel_History = new System.Windows.Forms.Panel();
            this.panel_Other = new System.Windows.Forms.Panel();
            this.label_Timer = new System.Windows.Forms.Label();
            this.listBox_History = new System.Windows.Forms.ListBox();
            this.panel_Options = new System.Windows.Forms.Panel();
            this.panel_Stats = new System.Windows.Forms.Panel();
            this.label_Work_Timer = new System.Windows.Forms.Label();
            this.numericUpDown_Work_Time = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Break_Time = new System.Windows.Forms.NumericUpDown();
            this.label_Break_Time = new System.Windows.Forms.Label();
            this.button_Start_Stop = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_Cycles = new System.Windows.Forms.Label();
            this.label_Pauses = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.panel_Timer.SuspendLayout();
            this.panel_History.SuspendLayout();
            this.panel_Other.SuspendLayout();
            this.panel_Options.SuspendLayout();
            this.panel_Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Work_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Break_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Timer
            // 
            this.panel_Timer.Controls.Add(this.label_Timer);
            this.panel_Timer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Timer.Location = new System.Drawing.Point(0, 0);
            this.panel_Timer.Name = "panel_Timer";
            this.panel_Timer.Size = new System.Drawing.Size(1130, 190);
            this.panel_Timer.TabIndex = 0;
            // 
            // panel_History
            // 
            this.panel_History.Controls.Add(this.listBox_History);
            this.panel_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_History.Location = new System.Drawing.Point(0, 190);
            this.panel_History.Name = "panel_History";
            this.panel_History.Size = new System.Drawing.Size(1130, 410);
            this.panel_History.TabIndex = 1;
            // 
            // panel_Other
            // 
            this.panel_Other.Controls.Add(this.panel_Stats);
            this.panel_Other.Controls.Add(this.panel_Options);
            this.panel_Other.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Other.Location = new System.Drawing.Point(0, 600);
            this.panel_Other.Name = "panel_Other";
            this.panel_Other.Size = new System.Drawing.Size(1130, 238);
            this.panel_Other.TabIndex = 2;
            // 
            // label_Timer
            // 
            this.label_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Timer.Location = new System.Drawing.Point(300, 5);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(472, 191);
            this.label_Timer.TabIndex = 0;
            this.label_Timer.Text = "Timer";
            this.label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox_History
            // 
            this.listBox_History.BackColor = System.Drawing.SystemColors.Window;
            this.listBox_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_History.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_History.FormattingEnabled = true;
            this.listBox_History.ItemHeight = 38;
            this.listBox_History.Location = new System.Drawing.Point(0, 0);
            this.listBox_History.Name = "listBox_History";
            this.listBox_History.Size = new System.Drawing.Size(1130, 410);
            this.listBox_History.TabIndex = 0;
            // 
            // panel_Options
            // 
            this.panel_Options.Controls.Add(this.button_Reset);
            this.panel_Options.Controls.Add(this.button_Start_Stop);
            this.panel_Options.Controls.Add(this.numericUpDown_Break_Time);
            this.panel_Options.Controls.Add(this.label_Break_Time);
            this.panel_Options.Controls.Add(this.numericUpDown_Work_Time);
            this.panel_Options.Controls.Add(this.label_Work_Timer);
            this.panel_Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Options.Location = new System.Drawing.Point(0, 0);
            this.panel_Options.Name = "panel_Options";
            this.panel_Options.Size = new System.Drawing.Size(565, 238);
            this.panel_Options.TabIndex = 0;
            // 
            // panel_Stats
            // 
            this.panel_Stats.Controls.Add(this.label_Total);
            this.panel_Stats.Controls.Add(this.label_Pauses);
            this.panel_Stats.Controls.Add(this.label_Cycles);
            this.panel_Stats.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Stats.Location = new System.Drawing.Point(565, 0);
            this.panel_Stats.Name = "panel_Stats";
            this.panel_Stats.Size = new System.Drawing.Size(565, 238);
            this.panel_Stats.TabIndex = 1;
            // 
            // label_Work_Timer
            // 
            this.label_Work_Timer.AutoSize = true;
            this.label_Work_Timer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Work_Timer.Location = new System.Drawing.Point(42, 30);
            this.label_Work_Timer.Name = "label_Work_Timer";
            this.label_Work_Timer.Size = new System.Drawing.Size(222, 32);
            this.label_Work_Timer.TabIndex = 0;
            this.label_Work_Timer.Text = "Pracovný Čas (min)";
            // 
            // numericUpDown_Work_Time
            // 
            this.numericUpDown_Work_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Work_Time.Location = new System.Drawing.Point(304, 28);
            this.numericUpDown_Work_Time.Name = "numericUpDown_Work_Time";
            this.numericUpDown_Work_Time.Size = new System.Drawing.Size(169, 39);
            this.numericUpDown_Work_Time.TabIndex = 1;
            // 
            // numericUpDown_Break_Time
            // 
            this.numericUpDown_Break_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Break_Time.Location = new System.Drawing.Point(304, 73);
            this.numericUpDown_Break_Time.Name = "numericUpDown_Break_Time";
            this.numericUpDown_Break_Time.Size = new System.Drawing.Size(169, 39);
            this.numericUpDown_Break_Time.TabIndex = 3;
            // 
            // label_Break_Time
            // 
            this.label_Break_Time.AutoSize = true;
            this.label_Break_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Break_Time.Location = new System.Drawing.Point(42, 75);
            this.label_Break_Time.Name = "label_Break_Time";
            this.label_Break_Time.Size = new System.Drawing.Size(228, 32);
            this.label_Break_Time.TabIndex = 2;
            this.label_Break_Time.Text = "Čas prestávky (min)";
            // 
            // button_Start_Stop
            // 
            this.button_Start_Stop.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Start_Stop.Location = new System.Drawing.Point(74, 142);
            this.button_Start_Stop.Name = "button_Start_Stop";
            this.button_Start_Stop.Size = new System.Drawing.Size(160, 60);
            this.button_Start_Stop.TabIndex = 4;
            this.button_Start_Stop.Text = "Spustiť";
            this.button_Start_Stop.UseVisualStyleBackColor = true;
            this.button_Start_Stop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Reset.Location = new System.Drawing.Point(304, 142);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(160, 60);
            this.button_Reset.TabIndex = 5;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_Cycles
            // 
            this.label_Cycles.AutoSize = true;
            this.label_Cycles.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Cycles.Location = new System.Drawing.Point(60, 52);
            this.label_Cycles.Name = "label_Cycles";
            this.label_Cycles.Size = new System.Drawing.Size(79, 45);
            this.label_Cycles.TabIndex = 0;
            this.label_Cycles.Text = "N/A";
            // 
            // label_Pauses
            // 
            this.label_Pauses.AutoSize = true;
            this.label_Pauses.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Pauses.Location = new System.Drawing.Point(60, 148);
            this.label_Pauses.Name = "label_Pauses";
            this.label_Pauses.Size = new System.Drawing.Size(79, 45);
            this.label_Pauses.TabIndex = 1;
            this.label_Pauses.Text = "N/A";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Total.Location = new System.Drawing.Point(309, 97);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(79, 45);
            this.label_Total.TabIndex = 2;
            this.label_Total.Text = "N/A";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PomodoroTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_History);
            this.Controls.Add(this.panel_Other);
            this.Controls.Add(this.panel_Timer);
            this.Name = "PomodoroTimer";
            this.Size = new System.Drawing.Size(1130, 838);
            this.panel_Timer.ResumeLayout(false);
            this.panel_Timer.PerformLayout();
            this.panel_History.ResumeLayout(false);
            this.panel_Other.ResumeLayout(false);
            this.panel_Options.ResumeLayout(false);
            this.panel_Options.PerformLayout();
            this.panel_Stats.ResumeLayout(false);
            this.panel_Stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Work_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Break_Time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Timer;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Panel panel_History;
        private System.Windows.Forms.Panel panel_Other;
        private System.Windows.Forms.ListBox listBox_History;
        private System.Windows.Forms.Panel panel_Stats;
        private System.Windows.Forms.Panel panel_Options;
        private System.Windows.Forms.NumericUpDown numericUpDown_Break_Time;
        private System.Windows.Forms.Label label_Break_Time;
        private System.Windows.Forms.NumericUpDown numericUpDown_Work_Time;
        private System.Windows.Forms.Label label_Work_Timer;
        private System.Windows.Forms.Button button_Start_Stop;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_Cycles;
        private System.Windows.Forms.Label label_Pauses;
        private System.Windows.Forms.Label label_Total;
    }
}
