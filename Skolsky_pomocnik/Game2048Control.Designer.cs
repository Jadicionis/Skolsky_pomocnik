namespace Skolsky_pomocnik
{
    partial class Game2048Control
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
            this.panel_Score = new System.Windows.Forms.Panel();
            this.label_Score = new System.Windows.Forms.Label();
            this.panel_Grid = new System.Windows.Forms.Panel();
            this.panel_Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Score
            // 
            this.panel_Score.Controls.Add(this.label_Score);
            this.panel_Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Score.Location = new System.Drawing.Point(0, 0);
            this.panel_Score.Name = "panel_Score";
            this.panel_Score.Size = new System.Drawing.Size(1130, 53);
            this.panel_Score.TabIndex = 0;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Score.Location = new System.Drawing.Point(500, 7);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(92, 38);
            this.label_Score.TabIndex = 0;
            this.label_Score.Text = "Skore";
            // 
            // panel_Grid
            // 
            this.panel_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Grid.Location = new System.Drawing.Point(222, 129);
            this.panel_Grid.Name = "panel_Grid";
            this.panel_Grid.Size = new System.Drawing.Size(600, 600);
            this.panel_Grid.TabIndex = 1;
            // 
            // Game2048Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Grid);
            this.Controls.Add(this.panel_Score);
            this.Name = "Game2048Control";
            this.Size = new System.Drawing.Size(1130, 838);
            this.panel_Score.ResumeLayout(false);
            this.panel_Score.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Score;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Panel panel_Grid;
    }
}
