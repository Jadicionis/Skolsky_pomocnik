namespace Skolsky_pomocnik
{
    partial class PasswordGeneratorControl
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
            this.panel_Options = new System.Windows.Forms.Panel();
            this.label_Password_Length = new System.Windows.Forms.Label();
            this.trackBar_Password_Length = new System.Windows.Forms.TrackBar();
            this.label_LengthofPassword = new System.Windows.Forms.Label();
            this.checkBox_Uppercase = new System.Windows.Forms.CheckBox();
            this.checkBox_Lowercase = new System.Windows.Forms.CheckBox();
            this.checkBox_Numbers = new System.Windows.Forms.CheckBox();
            this.checkBox_Symbols = new System.Windows.Forms.CheckBox();
            this.checkBox_Ambiguous = new System.Windows.Forms.CheckBox();
            this.Generate = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.checkBox_AutoCopy = new System.Windows.Forms.CheckBox();
            this.panel_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Password_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Options
            // 
            this.panel_Options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Options.Controls.Add(this.checkBox_AutoCopy);
            this.panel_Options.Controls.Add(this.checkBox_Ambiguous);
            this.panel_Options.Controls.Add(this.checkBox_Symbols);
            this.panel_Options.Controls.Add(this.checkBox_Numbers);
            this.panel_Options.Controls.Add(this.checkBox_Lowercase);
            this.panel_Options.Controls.Add(this.checkBox_Uppercase);
            this.panel_Options.Controls.Add(this.label_LengthofPassword);
            this.panel_Options.Controls.Add(this.trackBar_Password_Length);
            this.panel_Options.Controls.Add(this.label_Password_Length);
            this.panel_Options.Location = new System.Drawing.Point(0, 384);
            this.panel_Options.Name = "panel_Options";
            this.panel_Options.Size = new System.Drawing.Size(400, 454);
            this.panel_Options.TabIndex = 0;
            // 
            // label_Password_Length
            // 
            this.label_Password_Length.AutoSize = true;
            this.label_Password_Length.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_Password_Length.Location = new System.Drawing.Point(20, 20);
            this.label_Password_Length.Name = "label_Password_Length";
            this.label_Password_Length.Size = new System.Drawing.Size(160, 38);
            this.label_Password_Length.TabIndex = 0;
            this.label_Password_Length.Text = "Dĺžka hesla";
            // 
            // trackBar_Password_Length
            // 
            this.trackBar_Password_Length.LargeChange = 1;
            this.trackBar_Password_Length.Location = new System.Drawing.Point(20, 70);
            this.trackBar_Password_Length.Maximum = 32;
            this.trackBar_Password_Length.Minimum = 6;
            this.trackBar_Password_Length.Name = "trackBar_Password_Length";
            this.trackBar_Password_Length.Size = new System.Drawing.Size(354, 69);
            this.trackBar_Password_Length.TabIndex = 1;
            this.trackBar_Password_Length.Value = 12;
            this.trackBar_Password_Length.ValueChanged += new System.EventHandler(this.trackBar_Password_Length_ValueChanged);
            // 
            // label_LengthofPassword
            // 
            this.label_LengthofPassword.AutoSize = true;
            this.label_LengthofPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_LengthofPassword.Location = new System.Drawing.Point(264, 20);
            this.label_LengthofPassword.Name = "label_LengthofPassword";
            this.label_LengthofPassword.Size = new System.Drawing.Size(44, 38);
            this.label_LengthofPassword.TabIndex = 2;
            this.label_LengthofPassword.Text = "12";
            // 
            // checkBox_Uppercase
            // 
            this.checkBox_Uppercase.AutoSize = true;
            this.checkBox_Uppercase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Uppercase.Location = new System.Drawing.Point(20, 130);
            this.checkBox_Uppercase.Name = "checkBox_Uppercase";
            this.checkBox_Uppercase.Size = new System.Drawing.Size(198, 36);
            this.checkBox_Uppercase.TabIndex = 3;
            this.checkBox_Uppercase.Text = "Veľké písmená";
            this.checkBox_Uppercase.UseVisualStyleBackColor = true;
            // 
            // checkBox_Lowercase
            // 
            this.checkBox_Lowercase.AutoSize = true;
            this.checkBox_Lowercase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Lowercase.Location = new System.Drawing.Point(20, 180);
            this.checkBox_Lowercase.Name = "checkBox_Lowercase";
            this.checkBox_Lowercase.Size = new System.Drawing.Size(192, 36);
            this.checkBox_Lowercase.TabIndex = 4;
            this.checkBox_Lowercase.Text = "Malé písmená";
            this.checkBox_Lowercase.UseVisualStyleBackColor = true;
            // 
            // checkBox_Numbers
            // 
            this.checkBox_Numbers.AutoSize = true;
            this.checkBox_Numbers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Numbers.Location = new System.Drawing.Point(20, 230);
            this.checkBox_Numbers.Name = "checkBox_Numbers";
            this.checkBox_Numbers.Size = new System.Drawing.Size(90, 36);
            this.checkBox_Numbers.TabIndex = 5;
            this.checkBox_Numbers.Text = "Čísla";
            this.checkBox_Numbers.UseVisualStyleBackColor = true;
            // 
            // checkBox_Symbols
            // 
            this.checkBox_Symbols.AutoSize = true;
            this.checkBox_Symbols.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Symbols.Location = new System.Drawing.Point(20, 280);
            this.checkBox_Symbols.Name = "checkBox_Symbols";
            this.checkBox_Symbols.Size = new System.Drawing.Size(213, 36);
            this.checkBox_Symbols.TabIndex = 6;
            this.checkBox_Symbols.Text = "Špeciálne znaky";
            this.checkBox_Symbols.UseVisualStyleBackColor = true;
            // 
            // checkBox_Ambiguous
            // 
            this.checkBox_Ambiguous.AutoSize = true;
            this.checkBox_Ambiguous.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Ambiguous.Location = new System.Drawing.Point(20, 330);
            this.checkBox_Ambiguous.Name = "checkBox_Ambiguous";
            this.checkBox_Ambiguous.Size = new System.Drawing.Size(209, 36);
            this.checkBox_Ambiguous.TabIndex = 7;
            this.checkBox_Ambiguous.Text = "Ľahko čitateľné";
            this.checkBox_Ambiguous.UseVisualStyleBackColor = true;
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Generate.Location = new System.Drawing.Point(463, 564);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(200, 60);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Generovať heslo";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button_Copy.Location = new System.Drawing.Point(765, 564);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(200, 60);
            this.button_Copy.TabIndex = 9;
            this.button_Copy.Text = "Kopírovať do schránky";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Password.Location = new System.Drawing.Point(172, 163);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.ReadOnly = true;
            this.textBox_Password.Size = new System.Drawing.Size(650, 64);
            this.textBox_Password.TabIndex = 10;
            // 
            // checkBox_AutoCopy
            // 
            this.checkBox_AutoCopy.AutoSize = true;
            this.checkBox_AutoCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_AutoCopy.Location = new System.Drawing.Point(20, 380);
            this.checkBox_AutoCopy.Name = "checkBox_AutoCopy";
            this.checkBox_AutoCopy.Size = new System.Drawing.Size(327, 36);
            this.checkBox_AutoCopy.TabIndex = 8;
            this.checkBox_AutoCopy.Text = "Automatické Skopírovanie";
            this.checkBox_AutoCopy.UseVisualStyleBackColor = true;
            // 
            // PasswordGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.panel_Options);
            this.Name = "PasswordGeneratorControl";
            this.Size = new System.Drawing.Size(1130, 838);
            this.panel_Options.ResumeLayout(false);
            this.panel_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Password_Length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Options;
        private System.Windows.Forms.TrackBar trackBar_Password_Length;
        private System.Windows.Forms.Label label_Password_Length;
        private System.Windows.Forms.Label label_LengthofPassword;
        private System.Windows.Forms.CheckBox checkBox_Ambiguous;
        private System.Windows.Forms.CheckBox checkBox_Symbols;
        private System.Windows.Forms.CheckBox checkBox_Numbers;
        private System.Windows.Forms.CheckBox checkBox_Lowercase;
        private System.Windows.Forms.CheckBox checkBox_Uppercase;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.CheckBox checkBox_AutoCopy;
    }
}
