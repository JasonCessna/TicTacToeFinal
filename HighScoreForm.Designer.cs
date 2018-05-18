namespace TicTacToe
{
    partial class HighScoreForm
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
            this.highscoreBox = new System.Windows.Forms.ListView();
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Losses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Draw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // highscoreBox
            // 
            this.highscoreBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pName,
            this.Wins,
            this.Losses,
            this.Draw});
            this.highscoreBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highscoreBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.highscoreBox.Location = new System.Drawing.Point(0, 0);
            this.highscoreBox.Name = "highscoreBox";
            this.highscoreBox.Size = new System.Drawing.Size(245, 231);
            this.highscoreBox.TabIndex = 6;
            this.highscoreBox.UseCompatibleStateImageBehavior = false;
            this.highscoreBox.View = System.Windows.Forms.View.Details;
            // 
            // pName
            // 
            this.pName.Text = "Name";
            // 
            // Wins
            // 
            this.Wins.Text = "Wins";
            this.Wins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Losses
            // 
            this.Losses.Text = "Losses";
            this.Losses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Draw
            // 
            this.Draw.Text = "Draws";
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 231);
            this.Controls.Add(this.highscoreBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HighScoreForm";
            this.Text = "High Scores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView highscoreBox;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ColumnHeader Wins;
        private System.Windows.Forms.ColumnHeader Losses;
        private System.Windows.Forms.ColumnHeader Draw;
    }
}