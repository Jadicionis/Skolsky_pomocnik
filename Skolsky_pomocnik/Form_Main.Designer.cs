namespace Skolsky_pomocnik
{
    partial class Form_Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Header = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.label_Header_Title = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Menu_Title = new System.Windows.Forms.Panel();
            this.button_Pomodoro = new System.Windows.Forms.Button();
            this.label_Menu = new System.Windows.Forms.Label();
            this.button_calculator = new System.Windows.Forms.Button();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_Menu_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.button_Close);
            this.panel_Header.Controls.Add(this.button_Minimize);
            this.panel_Header.Controls.Add(this.label_Header_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1350, 85);
            this.panel_Header.TabIndex = 1;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Image = global::Skolsky_pomocnik.Properties.Resources.Icon_Close;
            this.button_Close.Location = new System.Drawing.Point(1275, 10);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(60, 62);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Image = global::Skolsky_pomocnik.Properties.Resources.Icon_Minimize;
            this.button_Minimize.Location = new System.Drawing.Point(1169, 10);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(60, 62);
            this.button_Minimize.TabIndex = 1;
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // label_Header_Title
            // 
            this.label_Header_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Header_Title.AutoSize = true;
            this.label_Header_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Header_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header_Title.Location = new System.Drawing.Point(465, 20);
            this.label_Header_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Header_Title.Name = "label_Header_Title";
            this.label_Header_Title.Size = new System.Drawing.Size(253, 40);
            this.label_Header_Title.TabIndex = 0;
            this.label_Header_Title.Text = "Školský Pomocník";
            // 
            // panel_Menu
            // 
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.panel_Buttons);
            this.panel_Menu.Controls.Add(this.panel_Menu_Title);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 85);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(220, 838);
            this.panel_Menu.TabIndex = 2;
            // 
            // panel_Menu_Title
            // 
            this.panel_Menu_Title.Controls.Add(this.label_Menu);
            this.panel_Menu_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu_Title.Name = "panel_Menu_Title";
            this.panel_Menu_Title.Size = new System.Drawing.Size(218, 100);
            this.panel_Menu_Title.TabIndex = 5;
            // 
            // button_Pomodoro
            // 
            this.button_Pomodoro.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Pomodoro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Pomodoro.Location = new System.Drawing.Point(0, 44);
            this.button_Pomodoro.Name = "button_Pomodoro";
            this.button_Pomodoro.Size = new System.Drawing.Size(218, 44);
            this.button_Pomodoro.TabIndex = 4;
            this.button_Pomodoro.Text = "Pomodoro Časovač";
            this.button_Pomodoro.UseVisualStyleBackColor = true;
            this.button_Pomodoro.Click += new System.EventHandler(this.button_Pomodoro_Click);
            // 
            // label_Menu
            // 
            this.label_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Menu.AutoSize = true;
            this.label_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Menu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_Menu.Location = new System.Drawing.Point(39, 31);
            this.label_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(120, 32);
            this.label_Menu.TabIndex = 2;
            this.label_Menu.Text = "Navigácia";
            // 
            // button_calculator
            // 
            this.button_calculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_calculator.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_calculator.Location = new System.Drawing.Point(0, 0);
            this.button_calculator.Name = "button_calculator";
            this.button_calculator.Size = new System.Drawing.Size(218, 44);
            this.button_calculator.TabIndex = 3;
            this.button_calculator.Text = "Kalkulačka";
            this.button_calculator.UseVisualStyleBackColor = true;
            this.button_calculator.Click += new System.EventHandler(this.button_calculator_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(220, 85);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1130, 838);
            this.panel_Content.TabIndex = 3;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.button_Pomodoro);
            this.panel_Buttons.Controls.Add(this.button_calculator);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 100);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(218, 736);
            this.panel_Buttons.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 923);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu_Title.ResumeLayout(false);
            this.panel_Menu_Title.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Header_Title;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_calculator;
        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Menu_Title;
        private System.Windows.Forms.Button button_Pomodoro;
        private System.Windows.Forms.Panel panel_Buttons;
    }
}

