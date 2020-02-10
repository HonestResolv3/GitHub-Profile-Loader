using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Octokit;

namespace GitHubProfileLoader
{
    public partial class frmGitHubProfileLoader : Form
    {

        string input = "";
        string repoInput = "";

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
                input = txtUserInput.Text;
                clearInput();
                readUserInfo();
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void clearInput()
        {
            lblFullName.Text = "Full Name: ";
            lblUserFollowers.Text = "User Followers: ";
            lblUsersFollowing.Text = "Users Following: ";
            lblUserName.Text = "Username: ";
            lblStatus.Text = "Status: Ready";
            lblOwnedRepositories.Text = "Public Repos: ";
            pboxAvatar.Image = null;
            btnLoadUserInfo.Enabled = true;
            btnLoadUserInfo.Text = "Load User Info";
            GC.Collect();
        }

        private async void readUserInfo()
        {
           try
           {
                var github = new GitHubClient(new ProductHeaderValue("GitHubProfileLoader"));
                var user = await github.User.Get(input);
                pboxAvatar.Load(user.AvatarUrl);
                lblFullName.Text += user.Name;
                lblUserName.Text += txtUserInput.Text;
                lblUserFollowers.Text += user.Followers;
                lblUsersFollowing.Text += user.Following;
                lblOwnedRepositories.Text += user.PublicRepos;
                lblStatus.Text = "Status: Loaded!";
                user = null;
                github = null;
                GC.Collect();
                btnLoadUserInfo.Enabled = false;
                btnLoadUserInfo.Text = "Clear Input First";
                if (lblFullName.Text.Equals("Full Name: "))
                {
                    lblFullName.Text = "Full Name: N/A";
                }

           }
           catch (Octokit.NotFoundException)
           {
               MessageBox.Show("That is not a valid user, please try again", "Error");
               GC.Collect();
           }
           catch (Octokit.AbuseException)
           {
               MessageBox.Show("There was an error running this program (API call abuse)", "Error");
                GC.Collect();
            }
           catch (Exception)
           {
                MessageBox.Show("There was an error running this program (Can be API call abuse)", "Error");
                GC.Collect();
            }
        }
    }
}
