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
            this.button_Minimize = new System.Windows.Forms.Button();
            this.label_Header_Title = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
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
            this.panel_Header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(900, 56);
            this.panel_Header.TabIndex = 1;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Header_MouseDown);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Image = global::Skolsky_pomocnik.Properties.Resources.Icon_Minimize;
            this.button_Minimize.Location = new System.Drawing.Point(779, 9);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(40, 40);
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
            this.label_Header_Title.Location = new System.Drawing.Point(309, 13);
            this.label_Header_Title.Name = "label_Header_Title";
            this.label_Header_Title.Size = new System.Drawing.Size(165, 25);
            this.label_Header_Title.TabIndex = 0;
            this.label_Header_Title.Text = "Školský Pomocník";
            // 
            // button_Close
            // 
            this.button_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Image = global::Skolsky_pomocnik.Properties.Resources.Icon_Close;
            this.button_Close.Location = new System.Drawing.Point(849, 9);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 40);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 56);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(220, 544);
            this.panel_Menu.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Header_Title;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Panel panel_Menu;
    }
}

