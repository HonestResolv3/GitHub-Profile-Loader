using System;
using System.Drawing;
using System.Windows.Forms;
using Octokit;

namespace GitHubProfileLoader
{
    public partial class frmGitHubProfileLoader : Form
    {

        string input = "";
        public frmGitHubProfileLoader()
        {
            InitializeComponent();
        }

        private void frmGitHubProfileLoader_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FF21252B");
        }

        private async void btnLoadUserInfo_Click(object sender, EventArgs e)
        {
            if (txtUserInput.Text.Equals(""))
            {
                MessageBox.Show("Please enter a user name to look up", "Error");
            }
            else
            {
                clearInput(2);
                readUserInfo();
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            clearInput(1);
        }

        private void clearInput(int choice)
        {
            switch (choice) {
                case 1:
                    txtUserInput.Text = "";
                    lblUserFollowers.Text = "User Followers: ";
                    lblUsersFollowing.Text = "Users Following: ";
                    lblUserName.Text = "Username: ";
                    lblStatus.Text = "Status: Ready";
                    pboxAvatar.Image = null;
                    GC.Collect();
                    break;
                case 2:
                    lblUserFollowers.Text = "User Followers: ";
                    lblUsersFollowing.Text = "Users Following: ";
                    lblUserName.Text = "Username: ";
                    lblStatus.Text = "Status: Ready";
                    pboxAvatar.Image = null;
                    GC.Collect();
                    break;
            }
        }

        private async void readUserInfo()
        {
            try
            {
                var github = new GitHubClient(new ProductHeaderValue("GHubProfileLoader"));
                var user = await github.User.Get(input);
                pboxAvatar.Load(user.AvatarUrl);
                lblUserName.Text += txtUserInput.Text;
                lblUserFollowers.Text += user.Followers;
                lblUsersFollowing.Text += user.Following;
                lblStatus.Text = "Status: Loaded!";
                user = null;
                github = null;
                GC.Collect();
                btnLoadUserInfo.Enabled = false;
                btnLoadUserInfo.Text = "Clear Input First";
            }
            catch (Exception)
            {
                MessageBox.Show("That is not a valid user, please try again", "Error");
            }
        }

        private void btnEnterUsername_Click(object sender, EventArgs e)
        {
            input = Microsoft.VisualBasic.Interaction.InputBox("What is the username you want to add?", "Add Username");
            if (input.Equals(""))
            {
                MessageBox.Show("Please enter a user name to look up", "Error");
            }
            else
            {
                txtUserInput.Text = input;
            }
        }
    }
}
