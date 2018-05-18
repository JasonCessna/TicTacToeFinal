namespace TicTacToe
{
    partial class MainMenu
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
            this.buttonXLogin = new System.Windows.Forms.Button();
            this.buttonOLogin = new System.Windows.Forms.Button();
            this.labelXDifficulty = new System.Windows.Forms.Label();
            this.labelODifficulty = new System.Windows.Forms.Label();
            this.labelXName = new System.Windows.Forms.Label();
            this.labelXPassword = new System.Windows.Forms.Label();
            this.labelOPassword = new System.Windows.Forms.Label();
            this.labelOName = new System.Windows.Forms.Label();
            this.textBoxXName = new System.Windows.Forms.TextBox();
            this.textBoxOName = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxXPassword = new System.Windows.Forms.TextBox();
            this.textBoxOPassword = new System.Windows.Forms.TextBox();
            this.comboBoxXDifficulty = new System.Windows.Forms.ComboBox();
            this.comboBoxODifficulty = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonXLogin
            // 
            this.buttonXLogin.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonXLogin.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXLogin.Location = new System.Drawing.Point(15, 199);
            this.buttonXLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonXLogin.Name = "buttonXLogin";
            this.buttonXLogin.Size = new System.Drawing.Size(215, 74);
            this.buttonXLogin.TabIndex = 0;
            this.buttonXLogin.Text = "X Player Login";
            this.buttonXLogin.UseVisualStyleBackColor = false;
            this.buttonXLogin.Click += new System.EventHandler(this.buttonXLogin_Click);
            // 
            // buttonOLogin
            // 
            this.buttonOLogin.BackColor = System.Drawing.Color.Gold;
            this.buttonOLogin.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOLogin.Location = new System.Drawing.Point(242, 199);
            this.buttonOLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonOLogin.Name = "buttonOLogin";
            this.buttonOLogin.Size = new System.Drawing.Size(219, 74);
            this.buttonOLogin.TabIndex = 1;
            this.buttonOLogin.Text = "O Player Login";
            this.buttonOLogin.UseVisualStyleBackColor = false;
            this.buttonOLogin.Click += new System.EventHandler(this.buttonOLogin_Click);
            // 
            // labelXDifficulty
            // 
            this.labelXDifficulty.AutoSize = true;
            this.labelXDifficulty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelXDifficulty.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXDifficulty.ForeColor = System.Drawing.Color.Silver;
            this.labelXDifficulty.Location = new System.Drawing.Point(11, 133);
            this.labelXDifficulty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelXDifficulty.MinimumSize = new System.Drawing.Size(215, 0);
            this.labelXDifficulty.Name = "labelXDifficulty";
            this.labelXDifficulty.Size = new System.Drawing.Size(215, 21);
            this.labelXDifficulty.TabIndex = 2;
            this.labelXDifficulty.Text = "X Player Difficulty";
            this.labelXDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelODifficulty
            // 
            this.labelODifficulty.AutoSize = true;
            this.labelODifficulty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelODifficulty.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelODifficulty.ForeColor = System.Drawing.Color.Silver;
            this.labelODifficulty.Location = new System.Drawing.Point(245, 133);
            this.labelODifficulty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelODifficulty.MinimumSize = new System.Drawing.Size(215, 0);
            this.labelODifficulty.Name = "labelODifficulty";
            this.labelODifficulty.Size = new System.Drawing.Size(215, 21);
            this.labelODifficulty.TabIndex = 3;
            this.labelODifficulty.Text = "O Player Difficulty";
            this.labelODifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXName
            // 
            this.labelXName.AutoSize = true;
            this.labelXName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelXName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXName.ForeColor = System.Drawing.Color.Silver;
            this.labelXName.Location = new System.Drawing.Point(11, 10);
            this.labelXName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelXName.MinimumSize = new System.Drawing.Size(215, 0);
            this.labelXName.Name = "labelXName";
            this.labelXName.Size = new System.Drawing.Size(215, 21);
            this.labelXName.TabIndex = 4;
            this.labelXName.Text = "X Player Name";
            this.labelXName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelXName.Click += new System.EventHandler(this.labelXName_Click);
            // 
            // labelXPassword
            // 
            this.labelXPassword.AutoSize = true;
            this.labelXPassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelXPassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXPassword.ForeColor = System.Drawing.Color.Silver;
            this.labelXPassword.Location = new System.Drawing.Point(11, 71);
            this.labelXPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelXPassword.MinimumSize = new System.Drawing.Size(215, 0);
            this.labelXPassword.Name = "labelXPassword";
            this.labelXPassword.Size = new System.Drawing.Size(215, 21);
            this.labelXPassword.TabIndex = 5;
            this.labelXPassword.Text = "X Player Password";
            this.labelXPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOPassword
            // 
            this.labelOPassword.AutoSize = true;
            this.labelOPassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOPassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPassword.ForeColor = System.Drawing.Color.Silver;
            this.labelOPassword.Location = new System.Drawing.Point(245, 71);
            this.labelOPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOPassword.MinimumSize = new System.Drawing.Size(215, 0);
            this.labelOPassword.Name = "labelOPassword";
            this.labelOPassword.Size = new System.Drawing.Size(215, 21);
            this.labelOPassword.TabIndex = 6;
            this.labelOPassword.Text = "O Player Password";
            this.labelOPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOName
            // 
            this.labelOName.AutoSize = true;
            this.labelOName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOName.ForeColor = System.Drawing.Color.Silver;
            this.labelOName.Location = new System.Drawing.Point(245, 10);
            this.labelOName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOName.MinimumSize = new System.Drawing.Size(215, 0);
            this.labelOName.Name = "labelOName";
            this.labelOName.Size = new System.Drawing.Size(215, 21);
            this.labelOName.TabIndex = 7;
            this.labelOName.Text = "O Player Name";
            this.labelOName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxXName
            // 
            this.textBoxXName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXName.Location = new System.Drawing.Point(15, 36);
            this.textBoxXName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxXName.Name = "textBoxXName";
            this.textBoxXName.Size = new System.Drawing.Size(215, 30);
            this.textBoxXName.TabIndex = 8;
            this.textBoxXName.Text = "Guest";
            this.textBoxXName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOName
            // 
            this.textBoxOName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOName.Location = new System.Drawing.Point(245, 36);
            this.textBoxOName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxOName.Name = "textBoxOName";
            this.textBoxOName.Size = new System.Drawing.Size(215, 30);
            this.textBoxOName.TabIndex = 9;
            this.textBoxOName.Text = "Guest";
            this.textBoxOName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPlay.Font = new System.Drawing.Font("Century Schoolbook", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(15, 277);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(215, 78);
            this.buttonPlay.TabIndex = 10;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxXPassword
            // 
            this.textBoxXPassword.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxXPassword.Location = new System.Drawing.Point(15, 97);
            this.textBoxXPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxXPassword.Name = "textBoxXPassword";
            this.textBoxXPassword.Size = new System.Drawing.Size(215, 31);
            this.textBoxXPassword.TabIndex = 11;
            this.textBoxXPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOPassword
            // 
            this.textBoxOPassword.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxOPassword.Location = new System.Drawing.Point(245, 97);
            this.textBoxOPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxOPassword.Name = "textBoxOPassword";
            this.textBoxOPassword.Size = new System.Drawing.Size(215, 31);
            this.textBoxOPassword.TabIndex = 13;
            this.textBoxOPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxXDifficulty
            // 
            this.comboBoxXDifficulty.AllowDrop = true;
            this.comboBoxXDifficulty.AutoCompleteCustomSource.AddRange(new string[] {
            "Player",
            "AI Easy",
            "AI Medium",
            "AI Hard"});
            this.comboBoxXDifficulty.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxXDifficulty.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.comboBoxXDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXDifficulty.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxXDifficulty.FormattingEnabled = true;
            this.comboBoxXDifficulty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxXDifficulty.Items.AddRange(new object[] {
            "Player",
            "AI Easy",
            "AI Medium",
            "AI Hard"});
            this.comboBoxXDifficulty.Location = new System.Drawing.Point(15, 159);
            this.comboBoxXDifficulty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxXDifficulty.Name = "comboBoxXDifficulty";
            this.comboBoxXDifficulty.Size = new System.Drawing.Size(215, 30);
            this.comboBoxXDifficulty.TabIndex = 15;
            // 
            // comboBoxODifficulty
            // 
            this.comboBoxODifficulty.AllowDrop = true;
            this.comboBoxODifficulty.AutoCompleteCustomSource.AddRange(new string[] {
            "Player",
            "AI Easy",
            "AI Medium",
            "AI Hard"});
            this.comboBoxODifficulty.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxODifficulty.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.comboBoxODifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxODifficulty.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxODifficulty.FormattingEnabled = true;
            this.comboBoxODifficulty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxODifficulty.Items.AddRange(new object[] {
            "Player",
            "AI Easy",
            "AI Medium",
            "AI Hard"});
            this.comboBoxODifficulty.Location = new System.Drawing.Point(245, 159);
            this.comboBoxODifficulty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxODifficulty.Name = "comboBoxODifficulty";
            this.comboBoxODifficulty.Size = new System.Drawing.Size(215, 30);
            this.comboBoxODifficulty.TabIndex = 16;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Crimson;
            this.buttonReset.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(242, 277);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(215, 78);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "High Score";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(476, 369);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxODifficulty);
            this.Controls.Add(this.comboBoxXDifficulty);
            this.Controls.Add(this.textBoxOPassword);
            this.Controls.Add(this.textBoxXPassword);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxOName);
            this.Controls.Add(this.textBoxXName);
            this.Controls.Add(this.labelOName);
            this.Controls.Add(this.labelOPassword);
            this.Controls.Add(this.labelXPassword);
            this.Controls.Add(this.labelXName);
            this.Controls.Add(this.labelODifficulty);
            this.Controls.Add(this.labelXDifficulty);
            this.Controls.Add(this.buttonOLogin);
            this.Controls.Add(this.buttonXLogin);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Tic Tac Toe Shenanigans";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonXLogin;
        private System.Windows.Forms.Button buttonOLogin;
        private System.Windows.Forms.Label labelXDifficulty;
        private System.Windows.Forms.Label labelODifficulty;
        private System.Windows.Forms.Label labelXName;
        private System.Windows.Forms.Label labelXPassword;
        private System.Windows.Forms.Label labelOPassword;
        private System.Windows.Forms.Label labelOName;
        private System.Windows.Forms.TextBox textBoxXName;
        private System.Windows.Forms.TextBox textBoxOName;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxXPassword;
        private System.Windows.Forms.TextBox textBoxOPassword;
        private System.Windows.Forms.ComboBox comboBoxXDifficulty;
        private System.Windows.Forms.ComboBox comboBoxODifficulty;
        private System.Windows.Forms.Button buttonReset;
    }
}

