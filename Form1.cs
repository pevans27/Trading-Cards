using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            lstPlayers.DrawItem += lstPlayers_DrawItem;
            lstPlayers.MouseClick += lstPlayers_MouseClick;
        }

        BindingList<PlayerCard> players = new BindingList<PlayerCard>
        {
            new PlayerCard { Name = "LeBron James", Team = "Lakers", Photo = Properties.Resources.lebron, Points = 25.4, Rebounds = 7.8, Assists = 7.4, FGPercentage = 50 },
            new PlayerCard { Name = "Stephen Curry", Team = "Warriors", Photo = Properties.Resources.curry, Points = 30.1, Rebounds = 5.5, Assists = 6.2, FGPercentage = 48 },
            new PlayerCard { Name = "Giannis Antetokounmpo", Team = "Bucks", Photo = Properties.Resources.giannis, Points = 29.9, Rebounds = 11.6, Assists = 5.8, FGPercentage = 56 },
            new PlayerCard { Name = "Kevin Durant", Team = "Suns", Photo = Properties.Resources.durant, Points = 28.2, Rebounds = 6.7, Assists = 5.1, FGPercentage = 53 },
            new PlayerCard { Name = "Luka Dončić", Team = "Mavericks", Photo = Properties.Resources.luka, Points = 28.8, Rebounds = 8.2, Assists = 9.1, FGPercentage = 47 },
            new PlayerCard { Name = "Joel Embiid", Team = "Sixers", Photo = Properties.Resources.embiid, Points = 33.1, Rebounds = 10.1, Assists = 4.2, FGPercentage = 54 },
            new PlayerCard { Name = "Nikola Jokić", Team = "Nuggets", Photo = Properties.Resources.jokić, Points = 24.5, Rebounds = 11.8, Assists = 9.9, FGPercentage = 56 },
            new PlayerCard { Name = "Jimmy Butler", Team = "Heat", Photo = Properties.Resources.butler, Points = 21.4, Rebounds = 6.9, Assists = 5.5, FGPercentage = 47 },
            new PlayerCard { Name = "Kawhi Leonard", Team = "Clippers", Photo = Properties.Resources.kahwi, Points = 23.8, Rebounds = 6.5, Assists = 3.7, FGPercentage = 49 },
            new PlayerCard { Name = "Anthony Davis", Team = "Lakers", Photo = Properties.Resources.davis, Points = 24.2, Rebounds = 9.0, Assists = 2.4, FGPercentage = 52 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPlayers.DataSource = players;
            lstPlayers.DisplayMember = "Name";
            lstPlayers.DrawMode = DrawMode.OwnerDrawFixed;
            lstPlayers.ItemHeight = 60;
        }

        private void lstPlayers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            PlayerCard player = (PlayerCard)lstPlayers.Items[e.Index];

            Color backgroundColor = player.Team == "Lakers" ? Color.LightYellow : Color.White;
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            int imageX = 10;
            int imageY = e.Bounds.Top + 5;
            int imageWidth = 50;
            int imageHeight = 50;

            e.Graphics.DrawImage(player.Photo, imageX, imageY, imageWidth, imageHeight);

            e.Graphics.DrawString(player.Name, e.Font, Brushes.Black, imageX + imageWidth + 10, imageY);
        }

        private void lstPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstPlayers.IndexFromPoint(e.Location);
            if (index < 0)
            {
                RemovePlayerInfo(); 
                return;
            }

            PlayerCard player = (PlayerCard)lstPlayers.Items[index];

            picPlayer.Image = player.Photo;
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;

            // Define team color and set the form's background and controls
            Color teamColor;
            switch (player.Team)
            {
                case "Lakers":
                    teamColor = Color.Gold;
                    this.BackColor = Color.LightGoldenrodYellow;
                    break;
                case "Warriors":
                    teamColor = Color.Blue;
                    this.BackColor = Color.LightSkyBlue;
                    break;
                case "Bucks":
                    teamColor = Color.ForestGreen;
                    this.BackColor = Color.LightGreen;
                    break;
                case "Suns":
                    teamColor = Color.Orange;
                    this.BackColor = Color.LightCoral;
                    break;
                case "Mavericks":
                    teamColor = Color.Teal;
                    this.BackColor = Color.LightCyan;
                    break;
                case "Sixers":
                    teamColor = Color.RoyalBlue;
                    this.BackColor = Color.LightSteelBlue;
                    break;
                case "Nuggets":
                    teamColor = Color.Yellow;
                    this.BackColor = Color.LightYellow;
                    break;
                case "Heat":
                    teamColor = Color.Red;
                    this.BackColor = Color.LightPink;
                    break;
                case "Clippers":
                    teamColor = Color.BlueViolet;
                    this.BackColor = Color.Lavender;
                    break;
                default:
                    teamColor = Color.White;
                    this.BackColor = Color.White;
                    break;
            }

            picPlayer.BackColor = teamColor;

            // Update labels with the selected player's data
            lblPlayerName.Text = $"Name: {player.Name}";
            lblPlayerName.BackColor = teamColor;
            lblPlayerName.ForeColor = IsDarkColor(teamColor) ? Color.White : Color.Black;

            lblTeam.Text = $"Team: {player.Team}";
            lblTeam.BackColor = teamColor;
            lblTeam.ForeColor = IsDarkColor(teamColor) ? Color.White : Color.Black;

            lblPointsPerGame.Text = $"Points Per Game: {player.Points}";
            lblPointsPerGame.ForeColor = player.Points > 25 ? Color.Green : player.Points < 20 ? Color.Red : Color.Black;
            lblPointsPerGame.BackColor = Color.Transparent;

            lblAssistsPerGame.Text = $"Assists Per Game: {player.Assists}";
            lblAssistsPerGame.ForeColor = player.Assists > 7 ? Color.Blue : Color.Black;
            lblAssistsPerGame.BackColor = Color.Transparent;

            lblReboundsPerGame.Text = $"Rebounds Per Game: {player.Rebounds}";
            lblReboundsPerGame.ForeColor = player.Rebounds > 10 ? Color.Yellow : Color.Black;
            lblReboundsPerGame.BackColor = Color.Transparent;

            lblFieldGoals.Text = $"Field Goals: {player.FGPercentage}%";
            lblFieldGoals.ForeColor = player.FGPercentage > 50 ? Color.Green : player.FGPercentage < 45 ? Color.Red : Color.Black;
            lblFieldGoals.BackColor = Color.Transparent;
        }


        private bool IsDarkColor(Color color)
        {
            int brightness = (int)((color.R * 0.299) + (color.G * 0.587) + (color.B * 0.114));
            return brightness < 128;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Form2 addPlayerForm = new Form2();
            var result = addPlayerForm.ShowDialog();

            if (result == DialogResult.OK && addPlayerForm.NewPlayer != null)
            {
                players.Add(addPlayerForm.NewPlayer); // Add to BindingList
                lstPlayers.SelectedIndex = players.Count - 1; // Optionally, select the new player
            }
        }



        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex >= 0)
            {
                if (picPlayer.Image != null)
                {
                    PlayerCard selectedPlayer = (PlayerCard)lstPlayers.SelectedItem;

                    var result = MessageBox.Show($"Are you sure you want to remove {selectedPlayer.Name}?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        players.Remove(selectedPlayer);

                        RemovePlayerInfo();
                    }
                }

            }
        }
        private void RemovePlayerInfo()
        {
            picPlayer.Image = null;

            lblPlayerName.Text = "Name: ";
            lblTeam.Text = "Team: ";
            lblPointsPerGame.Text = "Points Per Game: ";
            lblAssistsPerGame.Text = "Assists Per Game: ";
            lblReboundsPerGame.Text = "Rebounds Per Game: ";
            lblFieldGoals.Text = "Field Goals: ";

            this.BackColor = Color.White;
            picPlayer.BackColor = Color.Transparent;

            lblPlayerName.BackColor = Color.Transparent;
            lblTeam.BackColor = Color.Transparent;

            lblPlayerName.ForeColor = Color.Black;
            lblTeam.ForeColor = Color.Black;

            lblPointsPerGame.ForeColor = Color.Black;
            lblAssistsPerGame.ForeColor = Color.Black;
            lblReboundsPerGame.ForeColor = Color.Black;
            lblFieldGoals.ForeColor = Color.Black;
        }

        private void btnEditPlayers_Click(object sender, EventArgs e)
        {

            if (lstPlayers.SelectedIndex >= 0)
            {

                PlayerCard selectedPlayer = (PlayerCard)lstPlayers.SelectedItem;
                Form2 editPlayerForm = new Form2(selectedPlayer);  
                var result = editPlayerForm.ShowDialog();

                // Check if the user clicked "Save" (DialogResult.OK)
                if (result == DialogResult.OK && editPlayerForm.NewPlayer != null)
                {

                    PlayerCard updatedPlayer = editPlayerForm.NewPlayer;
                    int selectedIndex = players.IndexOf(selectedPlayer);
                    players[selectedIndex] = updatedPlayer;
                    players.ResetItem(selectedIndex);
                    UpdatePlayerDisplay(updatedPlayer);


                    lstPlayers.SelectedItem = updatedPlayer;

                    lstPlayers.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a player to edit.");
            }
        }

        private void UpdatePlayerDisplay(PlayerCard player)
        {
            picPlayer.Image = player.Photo;
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;

           
            Color teamColor;
            switch (player.Team)
            {
                case "Lakers":
                    teamColor = Color.Gold;
                    this.BackColor = Color.LightGoldenrodYellow;
                    break;
                case "Warriors":
                    teamColor = Color.Blue;
                    this.BackColor = Color.LightSkyBlue;
                    break;
                case "Bucks":
                    teamColor = Color.ForestGreen;
                    this.BackColor = Color.LightGreen;
                    break;
                case "Suns":
                    teamColor = Color.Orange;
                    this.BackColor = Color.LightCoral;
                    break;
                case "Mavericks":
                    teamColor = Color.Teal;
                    this.BackColor = Color.LightCyan;
                    break;
                case "Sixers":
                    teamColor = Color.RoyalBlue;
                    this.BackColor = Color.LightSteelBlue;
                    break;
                case "Nuggets":
                    teamColor = Color.Yellow;
                    this.BackColor = Color.LightYellow;
                    break;
                case "Heat":
                    teamColor = Color.Red;
                    this.BackColor = Color.LightPink;
                    break;
                case "Clippers":
                    teamColor = Color.BlueViolet;
                    this.BackColor = Color.Lavender;
                    break;
                default:
                    teamColor = Color.White;
                    this.BackColor = Color.White;
                    break;
            }

            picPlayer.BackColor = teamColor;

            // Update labels with the selected player's data
            lblPlayerName.Text = $"Name: {player.Name}";
            lblPlayerName.BackColor = teamColor;
            lblPlayerName.ForeColor = IsDarkColor(teamColor) ? Color.White : Color.Black;

            lblTeam.Text = $"Team: {player.Team}";
            lblTeam.BackColor = teamColor;
            lblTeam.ForeColor = IsDarkColor(teamColor) ? Color.White : Color.Black;

            lblPointsPerGame.Text = $"Points Per Game: {player.Points}";
            lblPointsPerGame.ForeColor = player.Points > 25 ? Color.Green : player.Points < 20 ? Color.Red : Color.Black;
            lblPointsPerGame.BackColor = Color.Transparent;

            lblAssistsPerGame.Text = $"Assists Per Game: {player.Assists}";
            lblAssistsPerGame.ForeColor = player.Assists > 7 ? Color.Blue : Color.Black;
            lblAssistsPerGame.BackColor = Color.Transparent;

            lblReboundsPerGame.Text = $"Rebounds Per Game: {player.Rebounds}";
            lblReboundsPerGame.ForeColor = player.Rebounds > 10 ? Color.Yellow : Color.Black;
            lblReboundsPerGame.BackColor = Color.Transparent;

            lblFieldGoals.Text = $"Field Goals: {player.FGPercentage}%";
            lblFieldGoals.ForeColor = player.FGPercentage > 50 ? Color.Green : player.FGPercentage < 45 ? Color.Red : Color.Black;
            lblFieldGoals.BackColor = Color.Transparent;
        }

    }
}






