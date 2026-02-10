namespace Skolsky_pomocnik
{
    partial class MinesweeperControl
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
            this.numericUpDown_Rows = new System.Windows.Forms.NumericUpDown();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.button_StartReset = new System.Windows.Forms.Button();
            this.label_Mines = new System.Windows.Forms.Label();
            this.numericUpDown_Mines = new System.Windows.Forms.NumericUpDown();
            this.label_Columns = new System.Windows.Forms.Label();
            this.numericUpDown_Columns = new System.Windows.Forms.NumericUpDown();
            this.label_Rows = new System.Windows.Forms.Label();
            this.panel_Grid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).BeginInit();
            this.panel_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_Rows
            // 
            this.numericUpDown_Rows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Rows.Location = new System.Drawing.Point(150, 40);
            this.numericUpDown_Rows.Name = "numericUpDown_Rows";
            this.numericUpDown_Rows.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown_Rows.TabIndex = 0;
            this.numericUpDown_Rows.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // panel_Controls
            // 
            this.panel_Controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Controls.Controls.Add(this.button_StartReset);
            this.panel_Controls.Controls.Add(this.label_Mines);
            this.panel_Controls.Controls.Add(this.numericUpDown_Mines);
            this.panel_Controls.Controls.Add(this.label_Columns);
            this.panel_Controls.Controls.Add(this.numericUpDown_Columns);
            this.panel_Controls.Controls.Add(this.label_Rows);
            this.panel_Controls.Controls.Add(this.numericUpDown_Rows);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Controls.Location = new System.Drawing.Point(0, 0);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1130, 100);
            this.panel_Controls.TabIndex = 1;
            // 
            // button_StartReset
            // 
            this.button_StartReset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_StartReset.Location = new System.Drawing.Point(930, 30);
            this.button_StartReset.Name = "button_StartReset";
            this.button_StartReset.Size = new System.Drawing.Size(150, 50);
            this.button_StartReset.TabIndex = 7;
            this.button_StartReset.Text = "Štart";
            this.button_StartReset.UseVisualStyleBackColor = true;
            this.button_StartReset.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Mines
            // 
            this.label_Mines.AutoSize = true;
            this.label_Mines.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Mines.Location = new System.Drawing.Point(627, 42);
            this.label_Mines.Name = "label_Mines";
            this.label_Mines.Size = new System.Drawing.Size(98, 28);
            this.label_Mines.TabIndex = 6;
            this.label_Mines.Text = "Počet mín";
            // 
            // numericUpDown_Mines
            // 
            this.numericUpDown_Mines.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Mines.Location = new System.Drawing.Point(750, 40);
            this.numericUpDown_Mines.Name = "numericUpDown_Mines";
            this.numericUpDown_Mines.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown_Mines.TabIndex = 5;
            this.numericUpDown_Mines.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_Columns
            // 
            this.label_Columns.AutoSize = true;
            this.label_Columns.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Columns.Location = new System.Drawing.Point(300, 40);
            this.label_Columns.Name = "label_Columns";
            this.label_Columns.Size = new System.Drawing.Size(128, 28);
            this.label_Columns.TabIndex = 4;
            this.label_Columns.Text = "Počet stĺpcov";
            // 
            // numericUpDown_Columns
            // 
            this.numericUpDown_Columns.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Columns.Location = new System.Drawing.Point(445, 40);
            this.numericUpDown_Columns.Name = "numericUpDown_Columns";
            this.numericUpDown_Columns.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown_Columns.TabIndex = 3;
            this.numericUpDown_Columns.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label_Rows
            // 
            this.label_Rows.AutoSize = true;
            this.label_Rows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Rows.Location = new System.Drawing.Point(5, 40);
            this.label_Rows.Name = "label_Rows";
            this.label_Rows.Size = new System.Drawing.Size(131, 28);
            this.label_Rows.TabIndex = 2;
            this.label_Rows.Text = "Počet riadkov";
            // 
            // panel_Grid
            // 
            this.panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Grid.Location = new System.Drawing.Point(0, 100);
            this.panel_Grid.Name = "panel_Grid";
            this.panel_Grid.Size = new System.Drawing.Size(1130, 738);
            this.panel_Grid.TabIndex = 2;
            // 
            // MinesweeperControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Grid);
            this.Controls.Add(this.panel_Controls);
            this.Name = "MinesweeperControl";
            this.Size = new System.Drawing.Size(1130, 838);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).EndInit();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Columns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Rows;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Label label_Rows;
        private System.Windows.Forms.Label label_Columns;
        private System.Windows.Forms.NumericUpDown numericUpDown_Columns;
        private System.Windows.Forms.Label label_Mines;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mines;
        private System.Windows.Forms.Button button_StartReset;
        private System.Windows.Forms.Panel panel_Grid;
    }
}
