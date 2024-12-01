namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPlayers = new ListBox();
            pnlPlayerDetails = new Panel();
            btnEditPlayers = new Button();
            btnRemovePlayer = new Button();
            btnAddPlayer = new Button();
            lblReboundsPerGame = new Label();
            lblFieldGoals = new Label();
            lblAssistsPerGame = new Label();
            lblPointsPerGame = new Label();
            lblTeam = new Label();
            lblPlayerName = new Label();
            picPlayer = new PictureBox();
            pnlPlayerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // lstPlayers
            // 
            lstPlayers.FormattingEnabled = true;
            lstPlayers.ItemHeight = 15;
            lstPlayers.Location = new Point(12, 26);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(221, 229);
            lstPlayers.TabIndex = 0;
            // 
            // pnlPlayerDetails
            // 
            pnlPlayerDetails.Controls.Add(btnEditPlayers);
            pnlPlayerDetails.Controls.Add(btnRemovePlayer);
            pnlPlayerDetails.Controls.Add(btnAddPlayer);
            pnlPlayerDetails.Controls.Add(lblReboundsPerGame);
            pnlPlayerDetails.Controls.Add(lblFieldGoals);
            pnlPlayerDetails.Controls.Add(lblAssistsPerGame);
            pnlPlayerDetails.Controls.Add(lblPointsPerGame);
            pnlPlayerDetails.Controls.Add(lblTeam);
            pnlPlayerDetails.Controls.Add(lblPlayerName);
            pnlPlayerDetails.Controls.Add(picPlayer);
            pnlPlayerDetails.Location = new Point(239, 12);
            pnlPlayerDetails.Name = "pnlPlayerDetails";
            pnlPlayerDetails.Size = new Size(423, 229);
            pnlPlayerDetails.TabIndex = 1;
            // 
            // btnEditPlayers
            // 
            btnEditPlayers.Location = new Point(296, 203);
            btnEditPlayers.Name = "btnEditPlayers";
            btnEditPlayers.Size = new Size(75, 23);
            btnEditPlayers.TabIndex = 9;
            btnEditPlayers.Text = "Edit";
            btnEditPlayers.UseVisualStyleBackColor = true;
            btnEditPlayers.Click += btnEditPlayers_Click;
            // 
            // btnRemovePlayer
            // 
            btnRemovePlayer.Location = new Point(186, 203);
            btnRemovePlayer.Name = "btnRemovePlayer";
            btnRemovePlayer.Size = new Size(75, 23);
            btnRemovePlayer.TabIndex = 8;
            btnRemovePlayer.Text = "Remove";
            btnRemovePlayer.UseVisualStyleBackColor = true;
            btnRemovePlayer.Click += btnRemovePlayer_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(80, 203);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(75, 23);
            btnAddPlayer.TabIndex = 7;
            btnAddPlayer.Text = "Add";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // lblReboundsPerGame
            // 
            lblReboundsPerGame.AutoSize = true;
            lblReboundsPerGame.Location = new Point(12, 136);
            lblReboundsPerGame.Name = "lblReboundsPerGame";
            lblReboundsPerGame.Size = new Size(120, 15);
            lblReboundsPerGame.TabIndex = 6;
            lblReboundsPerGame.Text = "Rebounds Per Game :";
            // 
            // lblFieldGoals
            // 
            lblFieldGoals.AutoSize = true;
            lblFieldGoals.Location = new Point(12, 160);
            lblFieldGoals.Name = "lblFieldGoals";
            lblFieldGoals.Size = new Size(129, 15);
            lblFieldGoals.TabIndex = 5;
            lblFieldGoals.Text = "Field Goals Percentage:";
            // 
            // lblAssistsPerGame
            // 
            lblAssistsPerGame.AutoSize = true;
            lblAssistsPerGame.Location = new Point(12, 112);
            lblAssistsPerGame.Name = "lblAssistsPerGame";
            lblAssistsPerGame.Size = new Size(102, 15);
            lblAssistsPerGame.TabIndex = 4;
            lblAssistsPerGame.Text = "Assists Per Game :";
            // 
            // lblPointsPerGame
            // 
            lblPointsPerGame.AutoSize = true;
            lblPointsPerGame.Location = new Point(12, 88);
            lblPointsPerGame.Name = "lblPointsPerGame";
            lblPointsPerGame.Size = new Size(100, 15);
            lblPointsPerGame.TabIndex = 3;
            lblPointsPerGame.Text = "Points Per Game :";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(12, 64);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(41, 15);
            lblTeam.TabIndex = 2;
            lblTeam.Text = "Team :";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(12, 40);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(45, 15);
            lblPlayerName.TabIndex = 1;
            lblPlayerName.Text = "Name :";
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(202, 23);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(205, 163);
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 251);
            Controls.Add(pnlPlayerDetails);
            Controls.Add(lstPlayers);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trading Cards";
            pnlPlayerDetails.ResumeLayout(false);
            pnlPlayerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPlayers;
        private Panel pnlPlayerDetails;
        private Label lblFieldGoals;
        private Label lblAssistsPerGame;
        private Label lblPointsPerGame;
        private Label lblTeam;
        private Label lblPlayerName;
        private PictureBox picPlayer;
        private Label lblReboundsPerGame;
        private Button btnRemovePlayer;
        private Button btnAddPlayer;
        private Button btnEditPlayers;
    }
}
