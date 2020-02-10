namespace GitHubProfileLoader
{
    partial class frmGitHubProfileLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGitHubProfileLoader));
            this.lblUserName = new System.Windows.Forms.Label();
            this.pboxAvatar = new System.Windows.Forms.PictureBox();
            this.lblUserFollowers = new System.Windows.Forms.Label();
            this.lblUsersFollowing = new System.Windows.Forms.Label();
            this.btnLoadUserInfo = new System.Windows.Forms.Button();
            this.lblUtilityCommands = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.lblParameters = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.lblProfileURLPrompt = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblOwnedRepositories = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(185, 95);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(349, 26);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Username:";
            // 
            // pboxAvatar
            // 
            this.pboxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxAvatar.Location = new System.Drawing.Point(22, 64);
            this.pboxAvatar.Name = "pboxAvatar";
            this.pboxAvatar.Size = new System.Drawing.Size(156, 154);
            this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAvatar.TabIndex = 1;
            this.pboxAvatar.TabStop = false;
            // 
            // lblUserFollowers
            // 
            this.lblUserFollowers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFollowers.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserFollowers.Location = new System.Drawing.Point(185, 129);
            this.lblUserFollowers.Name = "lblUserFollowers";
            this.lblUserFollowers.Size = new System.Drawing.Size(349, 26);
            this.lblUserFollowers.TabIndex = 4;
            this.lblUserFollowers.Text = "User Followers:";
            // 
            // lblUsersFollowing
            // 
            this.lblUsersFollowing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersFollowing.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsersFollowing.Location = new System.Drawing.Point(185, 161);
            this.lblUsersFollowing.Name = "lblUsersFollowing";
            this.lblUsersFollowing.Size = new System.Drawing.Size(349, 26);
            this.lblUsersFollowing.TabIndex = 5;
            this.lblUsersFollowing.Text = "Users Following:";
            // 
            // btnLoadUserInfo
            // 
            this.btnLoadUserInfo.Location = new System.Drawing.Point(86, 257);
            this.btnLoadUserInfo.Name = "btnLoadUserInfo";
            this.btnLoadUserInfo.Size = new System.Drawing.Size(136, 26);
            this.btnLoadUserInfo.TabIndex = 10;
            this.btnLoadUserInfo.Text = "Load User Info";
            this.btnLoadUserInfo.UseVisualStyleBackColor = true;
            this.btnLoadUserInfo.Click += new System.EventHandler(this.btnLoadUserInfo_Click);
            // 
            // lblUtilityCommands
            // 
            this.lblUtilityCommands.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilityCommands.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUtilityCommands.Location = new System.Drawing.Point(57, 227);
            this.lblUtilityCommands.Name = "lblUtilityCommands";
            this.lblUtilityCommands.Size = new System.Drawing.Size(204, 26);
            this.lblUtilityCommands.TabIndex = 9;
            this.lblUtilityCommands.Text = "User Detail Commands";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(334, 258);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(140, 22);
            this.txtUserInput.TabIndex = 15;
            // 
            // lblParameters
            // 
            this.lblParameters.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameters.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParameters.Location = new System.Drawing.Point(285, 228);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(184, 26);
            this.lblParameters.TabIndex = 13;
            this.lblParameters.Text = "Program Parameters";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(271, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "User:";
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(86, 283);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(136, 26);
            this.btnClearInput.TabIndex = 11;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // lblProfileURLPrompt
            // 
            this.lblProfileURLPrompt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileURLPrompt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProfileURLPrompt.Location = new System.Drawing.Point(34, 35);
            this.lblProfileURLPrompt.Name = "lblProfileURLPrompt";
            this.lblProfileURLPrompt.Size = new System.Drawing.Size(133, 26);
            this.lblProfileURLPrompt.TabIndex = 1;
            this.lblProfileURLPrompt.Text = "Profile Picture";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(205, 315);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 26);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status: Ready";
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullName.Location = new System.Drawing.Point(185, 64);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(349, 26);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name: ";
            // 
            // lblOwnedRepositories
            // 
            this.lblOwnedRepositories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedRepositories.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOwnedRepositories.Location = new System.Drawing.Point(185, 192);
            this.lblOwnedRepositories.Name = "lblOwnedRepositories";
            this.lblOwnedRepositories.Size = new System.Drawing.Size(349, 26);
            this.lblOwnedRepositories.TabIndex = 6;
            this.lblOwnedRepositories.Text = "Public Repos:";
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserDetails.Location = new System.Drawing.Point(210, 9);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(118, 26);
            this.lblUserDetails.TabIndex = 16;
            this.lblUserDetails.Text = "User Details";
            // 
            // frmGitHubProfileLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(543, 349);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.lblOwnedRepositories);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProfileURLPrompt);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblUtilityCommands);
            this.Controls.Add(this.btnLoadUserInfo);
            this.Controls.Add(this.lblUsersFollowing);
            this.Controls.Add(this.lblUserFollowers);
            this.Controls.Add(this.pboxAvatar);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGitHubProfileLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Profile Loader | By DefyTheRush";
            this.Load += new System.EventHandler(this.frmGitHubProfileLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pboxAvatar;
        private System.Windows.Forms.Label lblUserFollowers;
        private System.Windows.Forms.Label lblUsersFollowing;
        private System.Windows.Forms.Button btnLoadUserInfo;
        private System.Windows.Forms.Label lblUtilityCommands;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Label lblProfileURLPrompt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblOwnedRepositories;
        private System.Windows.Forms.Label lblUserDetails;
    }
}
