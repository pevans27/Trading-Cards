using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form2 : Form
    {

        public Image SelectedPlayerImage { get; private set; }
        public PlayerCard NewPlayer { get; private set; }

        private PlayerCard playerToEdit;

        public Form2(PlayerCard player = null)
        {
            InitializeComponent();

            if (player != null)
            {
                // If player is not null, we're in edit mode
                playerToEdit = player;
                btnSave.Text = "Update";  // Change button text to "Update"
                txtName.Text = player.Name;
                txtTeam.Text = player.Team;
                txtPoints.Text = player.Points.ToString();
                txtRebounds.Text = player.Rebounds.ToString();
                txtAssists.Text = player.Assists.ToString();
                txtFg.Text = player.FGPercentage.ToString();
            }
            else
            {
                btnSave.Text = "Add Player"; 
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a Player Photo";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    try
                    {
                        Image selectedImage = Image.FromFile(selectedFilePath);
                        SelectedPlayerImage = selectedImage;

                        lblImageName.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                    

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load the image. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtTeam.Text))
            {
                MessageBox.Show("Please enter the player's name and team.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var photo = SelectedPlayerImage ?? playerToEdit?.Photo ?? Properties.Resources.defaultImage;

            NewPlayer = new PlayerCard
            {
                Name = txtName.Text,
                Team = txtTeam.Text,
                Points = double.TryParse(txtPoints.Text, out var points) ? points : 0,
                Rebounds = double.TryParse(txtRebounds.Text, out var rebounds) ? rebounds : 0,
                Assists = double.TryParse(txtAssists.Text, out var assists) ? assists : 0,
                FGPercentage = double.TryParse(txtFg.Text, out var fgPercentage) ? fgPercentage : 0,
                Photo = photo
            };

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
