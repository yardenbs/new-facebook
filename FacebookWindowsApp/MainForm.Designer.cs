namespace FacebookWindowsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonHomeScreen = new System.Windows.Forms.Button();
            this.buttonFeature1Screen = new System.Windows.Forms.Button();
            this.buttonFeature2Screen = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelFeature2 = new System.Windows.Forms.Panel();
            this.labelMemoryGame = new System.Windows.Forms.Label();
            this.buttonMemory2 = new FacebookWindowsApp.CircularButton();
            this.buttonMemory1 = new FacebookWindowsApp.CircularButton();
            this.buttonMemory3 = new FacebookWindowsApp.CircularButton();
            this.buttonStartMemoryGame = new System.Windows.Forms.Button();
            this.panelFeature1 = new System.Windows.Forms.Panel();
            this.textBoxExplanation = new System.Windows.Forms.TextBox();
            this.labelNegative = new System.Windows.Forms.Label();
            this.labelPositive = new System.Windows.Forms.Label();
            this.listBoxNegative = new System.Windows.Forms.ListBox();
            this.listBoxPositive = new System.Windows.Forms.ListBox();
            this.buttonSentiment = new System.Windows.Forms.Button();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelCountPhotoLikes = new System.Windows.Forms.Label();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.buttonRightScroll = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxSelectedAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.labelUserBirthday = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelUserHometown = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserSex = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelFeature2.SuspendLayout();
            this.panelFeature1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbum)).BeginInit();
            this.panelUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxUser.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(183, 158);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer.Panel1.Controls.Add(this.buttonHomeScreen);
            this.splitContainer.Panel1.Controls.Add(this.buttonFeature1Screen);
            this.splitContainer.Panel1.Controls.Add(this.buttonFeature2Screen);
            this.splitContainer.Panel1.Controls.Add(this.labelUserName);
            this.splitContainer.Panel1.Controls.Add(this.buttonLogout);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Panel2.Controls.Add(this.panelFeature2);
            this.splitContainer.Panel2.Controls.Add(this.panelFeature1);
            this.splitContainer.Panel2.Controls.Add(this.labelEvents);
            this.splitContainer.Panel2.Controls.Add(this.labelLikes);
            this.splitContainer.Panel2.Controls.Add(this.labelCountPhotoLikes);
            this.splitContainer.Panel2.Controls.Add(this.labelAlbums);
            this.splitContainer.Panel2.Controls.Add(this.labelPosts);
            this.splitContainer.Panel2.Controls.Add(this.buttonRightScroll);
            this.splitContainer.Panel2.Controls.Add(this.listBoxAlbums);
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxSelectedAlbum);
            this.splitContainer.Panel2.Controls.Add(this.listBoxEvents);
            this.splitContainer.Panel2.Controls.Add(this.listBoxPosts);
            this.splitContainer.Panel2.Controls.Add(this.panelUserDetails);
            this.splitContainer.Panel2.Controls.Add(this.buttonPost);
            this.splitContainer.Panel2.Controls.Add(this.textBoxPost);
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxFriend);
            this.splitContainer.Panel2.Controls.Add(this.labelFriends);
            this.splitContainer.Panel2.Controls.Add(this.listBoxFriends);
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxUser);
            this.splitContainer.Size = new System.Drawing.Size(396, 485);
            this.splitContainer.SplitterDistance = 44;
            this.splitContainer.TabIndex = 3;
            // 
            // buttonHomeScreen
            // 
            this.buttonHomeScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHomeScreen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonHomeScreen.FlatAppearance.BorderSize = 2;
            this.buttonHomeScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonHomeScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHomeScreen.Location = new System.Drawing.Point(259, 7);
            this.buttonHomeScreen.Name = "buttonHomeScreen";
            this.buttonHomeScreen.Size = new System.Drawing.Size(23, 23);
            this.buttonHomeScreen.TabIndex = 4;
            this.buttonHomeScreen.UseVisualStyleBackColor = false;
            this.buttonHomeScreen.Click += new System.EventHandler(this.buttonHomeScreen_Click);
            // 
            // buttonFeature1Screen
            // 
            this.buttonFeature1Screen.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonFeature1Screen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFeature1Screen.FlatAppearance.BorderSize = 2;
            this.buttonFeature1Screen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonFeature1Screen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.buttonFeature1Screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeature1Screen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFeature1Screen.Location = new System.Drawing.Point(286, 7);
            this.buttonFeature1Screen.Name = "buttonFeature1Screen";
            this.buttonFeature1Screen.Size = new System.Drawing.Size(23, 23);
            this.buttonFeature1Screen.TabIndex = 3;
            this.buttonFeature1Screen.UseVisualStyleBackColor = false;
            this.buttonFeature1Screen.Click += new System.EventHandler(this.buttonFeature1Screen_Click);
            // 
            // buttonFeature2Screen
            // 
            this.buttonFeature2Screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFeature2Screen.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonFeature2Screen.FlatAppearance.BorderSize = 2;
            this.buttonFeature2Screen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonFeature2Screen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonFeature2Screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeature2Screen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFeature2Screen.Location = new System.Drawing.Point(312, 7);
            this.buttonFeature2Screen.Name = "buttonFeature2Screen";
            this.buttonFeature2Screen.Size = new System.Drawing.Size(23, 23);
            this.buttonFeature2Screen.TabIndex = 2;
            this.buttonFeature2Screen.UseVisualStyleBackColor = false;
            this.buttonFeature2Screen.Click += new System.EventHandler(this.buttonFeature2Screen_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserName.Location = new System.Drawing.Point(3, 11);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(45, 20);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Name";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonLogout.Location = new System.Drawing.Point(339, 7);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(55, 24);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelFeature2
            // 
            this.panelFeature2.AutoScroll = true;
            this.panelFeature2.BackColor = System.Drawing.Color.LimeGreen;
            this.panelFeature2.Controls.Add(this.labelMemoryGame);
            this.panelFeature2.Controls.Add(this.buttonMemory2);
            this.panelFeature2.Controls.Add(this.buttonMemory1);
            this.panelFeature2.Controls.Add(this.buttonMemory3);
            this.panelFeature2.Controls.Add(this.buttonStartMemoryGame);
            this.panelFeature2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeature2.Location = new System.Drawing.Point(0, 0);
            this.panelFeature2.Name = "panelFeature2";
            this.panelFeature2.Size = new System.Drawing.Size(377, 915);
            this.panelFeature2.TabIndex = 26;
            // 
            // labelMemoryGame
            // 
            this.labelMemoryGame.AutoSize = true;
            this.labelMemoryGame.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoryGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMemoryGame.Location = new System.Drawing.Point(58, 7);
            this.labelMemoryGame.Name = "labelMemoryGame";
            this.labelMemoryGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMemoryGame.Size = new System.Drawing.Size(295, 66);
            this.labelMemoryGame.TabIndex = 6;
            this.labelMemoryGame.Text = "    Do you remember\r\nwho is your friend\r\n";
            // 
            // buttonMemory2
            // 
            this.buttonMemory2.Enabled = false;
            this.buttonMemory2.Location = new System.Drawing.Point(156, 187);
            this.buttonMemory2.Name = "buttonMemory2";
            this.buttonMemory2.Size = new System.Drawing.Size(104, 108);
            this.buttonMemory2.TabIndex = 5;
            this.buttonMemory2.UseVisualStyleBackColor = true;
            this.buttonMemory2.Visible = false;
            // 
            // buttonMemory1
            // 
            this.buttonMemory1.Enabled = false;
            this.buttonMemory1.Location = new System.Drawing.Point(29, 101);
            this.buttonMemory1.Name = "buttonMemory1";
            this.buttonMemory1.Size = new System.Drawing.Size(102, 113);
            this.buttonMemory1.TabIndex = 4;
            this.buttonMemory1.UseVisualStyleBackColor = true;
            this.buttonMemory1.Visible = false;
            // 
            // buttonMemory3
            // 
            this.buttonMemory3.Enabled = false;
            this.buttonMemory3.Location = new System.Drawing.Point(274, 107);
            this.buttonMemory3.Name = "buttonMemory3";
            this.buttonMemory3.Size = new System.Drawing.Size(100, 103);
            this.buttonMemory3.TabIndex = 3;
            this.buttonMemory3.UseVisualStyleBackColor = true;
            this.buttonMemory3.Visible = false;
            // 
            // buttonStartMemoryGame
            // 
            this.buttonStartMemoryGame.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonStartMemoryGame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMemoryGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonStartMemoryGame.Location = new System.Drawing.Point(135, 114);
            this.buttonStartMemoryGame.Name = "buttonStartMemoryGame";
            this.buttonStartMemoryGame.Size = new System.Drawing.Size(131, 40);
            this.buttonStartMemoryGame.TabIndex = 0;
            this.buttonStartMemoryGame.Text = "START";
            this.buttonStartMemoryGame.UseVisualStyleBackColor = false;
            this.buttonStartMemoryGame.Click += new System.EventHandler(this.buttonStartMemoryGame_Click);
            // 
            // panelFeature1
            // 
            this.panelFeature1.BackColor = System.Drawing.Color.Coral;
            this.panelFeature1.Controls.Add(this.textBoxExplanation);
            this.panelFeature1.Controls.Add(this.labelNegative);
            this.panelFeature1.Controls.Add(this.labelPositive);
            this.panelFeature1.Controls.Add(this.listBoxNegative);
            this.panelFeature1.Controls.Add(this.listBoxPositive);
            this.panelFeature1.Controls.Add(this.buttonSentiment);
            this.panelFeature1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeature1.Location = new System.Drawing.Point(0, 0);
            this.panelFeature1.Name = "panelFeature1";
            this.panelFeature1.Size = new System.Drawing.Size(377, 915);
            this.panelFeature1.TabIndex = 25;
            // 
            // textBoxExplanation
            // 
            this.textBoxExplanation.Location = new System.Drawing.Point(76, 445);
            this.textBoxExplanation.Multiline = true;
            this.textBoxExplanation.Name = "textBoxExplanation";
            this.textBoxExplanation.Size = new System.Drawing.Size(230, 335);
            this.textBoxExplanation.TabIndex = 27;
            this.textBoxExplanation.Text = resources.GetString("textBoxExplanation.Text");
            // 
            // labelNegative
            // 
            this.labelNegative.AutoSize = true;
            this.labelNegative.Location = new System.Drawing.Point(254, 75);
            this.labelNegative.Name = "labelNegative";
            this.labelNegative.Size = new System.Drawing.Size(79, 13);
            this.labelNegative.TabIndex = 4;
            this.labelNegative.Text = "Negative Posts";
            // 
            // labelPositive
            // 
            this.labelPositive.AutoSize = true;
            this.labelPositive.Location = new System.Drawing.Point(58, 76);
            this.labelPositive.Name = "labelPositive";
            this.labelPositive.Size = new System.Drawing.Size(73, 13);
            this.labelPositive.TabIndex = 3;
            this.labelPositive.Text = "Positive Posts";
            // 
            // listBoxNegative
            // 
            this.listBoxNegative.FormattingEnabled = true;
            this.listBoxNegative.Location = new System.Drawing.Point(192, 92);
            this.listBoxNegative.Name = "listBoxNegative";
            this.listBoxNegative.Size = new System.Drawing.Size(181, 316);
            this.listBoxNegative.TabIndex = 2;
            // 
            // listBoxPositive
            // 
            this.listBoxPositive.FormattingEnabled = true;
            this.listBoxPositive.Location = new System.Drawing.Point(4, 92);
            this.listBoxPositive.Name = "listBoxPositive";
            this.listBoxPositive.Size = new System.Drawing.Size(182, 316);
            this.listBoxPositive.TabIndex = 1;
            // 
            // buttonSentiment
            // 
            this.buttonSentiment.Location = new System.Drawing.Point(148, 29);
            this.buttonSentiment.Name = "buttonSentiment";
            this.buttonSentiment.Size = new System.Drawing.Size(75, 23);
            this.buttonSentiment.TabIndex = 0;
            this.buttonSentiment.Text = "Analyze!";
            this.buttonSentiment.UseVisualStyleBackColor = true;
            this.buttonSentiment.Click += new System.EventHandler(this.buttonSentiment_Click);
            // 
            // labelEvents
            // 
            this.labelEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEvents.BackColor = System.Drawing.Color.Magenta;
            this.labelEvents.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelEvents.Location = new System.Drawing.Point(7, 510);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Padding = new System.Windows.Forms.Padding(0, 0, 106, 0);
            this.labelEvents.Size = new System.Drawing.Size(288, 24);
            this.labelEvents.TabIndex = 24;
            this.labelEvents.Text = "events";
            this.labelEvents.UseMnemonic = false;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.BackColor = System.Drawing.Color.Black;
            this.labelLikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLikes.Location = new System.Drawing.Point(106, 875);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(43, 18);
            this.labelLikes.TabIndex = 23;
            this.labelLikes.Text = "Likes";
            // 
            // labelCountPhotoLikes
            // 
            this.labelCountPhotoLikes.AutoSize = true;
            this.labelCountPhotoLikes.BackColor = System.Drawing.Color.Black;
            this.labelCountPhotoLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountPhotoLikes.ForeColor = System.Drawing.Color.Magenta;
            this.labelCountPhotoLikes.Location = new System.Drawing.Point(151, 875);
            this.labelCountPhotoLikes.Name = "labelCountPhotoLikes";
            this.labelCountPhotoLikes.Size = new System.Drawing.Size(18, 20);
            this.labelCountPhotoLikes.TabIndex = 22;
            this.labelCountPhotoLikes.Text = "0";
            // 
            // labelAlbums
            // 
            this.labelAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlbums.BackColor = System.Drawing.Color.Magenta;
            this.labelAlbums.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelAlbums.Location = new System.Drawing.Point(7, 596);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Padding = new System.Windows.Forms.Padding(0, 0, 106, 0);
            this.labelAlbums.Size = new System.Drawing.Size(288, 24);
            this.labelAlbums.TabIndex = 21;
            this.labelAlbums.Text = "albums";
            this.labelAlbums.UseMnemonic = false;
            // 
            // labelPosts
            // 
            this.labelPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPosts.BackColor = System.Drawing.Color.Magenta;
            this.labelPosts.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPosts.Location = new System.Drawing.Point(7, 432);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Padding = new System.Windows.Forms.Padding(0, 0, 106, 0);
            this.labelPosts.Size = new System.Drawing.Size(288, 24);
            this.labelPosts.TabIndex = 20;
            this.labelPosts.Text = "posts";
            this.labelPosts.UseMnemonic = false;
            // 
            // buttonRightScroll
            // 
            this.buttonRightScroll.BackColor = System.Drawing.Color.Black;
            this.buttonRightScroll.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRightScroll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRightScroll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRightScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightScroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRightScroll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRightScroll.Location = new System.Drawing.Point(296, 869);
            this.buttonRightScroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRightScroll.Name = "buttonRightScroll";
            this.buttonRightScroll.Size = new System.Drawing.Size(75, 30);
            this.buttonRightScroll.TabIndex = 16;
            this.buttonRightScroll.Text = "Next -->";
            this.buttonRightScroll.UseVisualStyleBackColor = false;
            this.buttonRightScroll.Click += new System.EventHandler(this.buttonRightScroll_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAlbums.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 15;
            this.listBoxAlbums.Location = new System.Drawing.Point(9, 628);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAlbums.MaximumSize = new System.Drawing.Size(79, 287);
            this.listBoxAlbums.MinimumSize = new System.Drawing.Size(79, 287);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(79, 287);
            this.listBoxAlbums.Sorted = true;
            this.listBoxAlbums.TabIndex = 14;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxSelectedAlbum
            // 
            this.pictureBoxSelectedAlbum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxSelectedAlbum.Location = new System.Drawing.Point(99, 630);
            this.pictureBoxSelectedAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSelectedAlbum.Name = "pictureBoxSelectedAlbum";
            this.pictureBoxSelectedAlbum.Size = new System.Drawing.Size(272, 228);
            this.pictureBoxSelectedAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedAlbum.TabIndex = 13;
            this.pictureBoxSelectedAlbum.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEvents.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.IntegralHeight = false;
            this.listBoxEvents.ItemHeight = 15;
            this.listBoxEvents.Location = new System.Drawing.Point(7, 538);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(288, 51);
            this.listBoxEvents.TabIndex = 11;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPosts.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 15;
            this.listBoxPosts.Location = new System.Drawing.Point(7, 459);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(288, 47);
            this.listBoxPosts.TabIndex = 10;
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelUserDetails.Controls.Add(this.labelUserBirthday);
            this.panelUserDetails.Controls.Add(this.labelBirthday);
            this.panelUserDetails.Controls.Add(this.labelUserHometown);
            this.panelUserDetails.Controls.Add(this.labelEmail);
            this.panelUserDetails.Controls.Add(this.labelUserSex);
            this.panelUserDetails.Controls.Add(this.labelUserEmail);
            this.panelUserDetails.Controls.Add(this.labelHometown);
            this.panelUserDetails.Controls.Add(this.labelSex);
            this.panelUserDetails.Location = new System.Drawing.Point(163, 7);
            this.panelUserDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(211, 158);
            this.panelUserDetails.TabIndex = 9;
            // 
            // labelUserBirthday
            // 
            this.labelUserBirthday.AutoSize = true;
            this.labelUserBirthday.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserBirthday.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelUserBirthday.Location = new System.Drawing.Point(76, 73);
            this.labelUserBirthday.MinimumSize = new System.Drawing.Size(20, 18);
            this.labelUserBirthday.Name = "labelUserBirthday";
            this.labelUserBirthday.Size = new System.Drawing.Size(20, 18);
            this.labelUserBirthday.TabIndex = 11;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBirthday.Location = new System.Drawing.Point(4, 71);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(56, 18);
            this.labelBirthday.TabIndex = 10;
            this.labelBirthday.Text = "birthday";
            // 
            // labelUserHometown
            // 
            this.labelUserHometown.AutoSize = true;
            this.labelUserHometown.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserHometown.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelUserHometown.Location = new System.Drawing.Point(76, 50);
            this.labelUserHometown.MinimumSize = new System.Drawing.Size(20, 18);
            this.labelUserHometown.Name = "labelUserHometown";
            this.labelUserHometown.Size = new System.Drawing.Size(20, 18);
            this.labelUserHometown.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Location = new System.Drawing.Point(3, 5);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 18);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "email";
            // 
            // labelUserSex
            // 
            this.labelUserSex.AutoSize = true;
            this.labelUserSex.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserSex.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelUserSex.Location = new System.Drawing.Point(77, 30);
            this.labelUserSex.MinimumSize = new System.Drawing.Size(20, 18);
            this.labelUserSex.Name = "labelUserSex";
            this.labelUserSex.Size = new System.Drawing.Size(20, 18);
            this.labelUserSex.TabIndex = 8;
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmail.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelUserEmail.Location = new System.Drawing.Point(48, 7);
            this.labelUserEmail.MinimumSize = new System.Drawing.Size(20, 18);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(20, 18);
            this.labelUserEmail.TabIndex = 6;
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHometown.Location = new System.Drawing.Point(3, 48);
            this.labelHometown.MinimumSize = new System.Drawing.Size(20, 18);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(65, 18);
            this.labelHometown.TabIndex = 7;
            this.labelHometown.Text = "hometown";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSex.Location = new System.Drawing.Point(3, 27);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(27, 18);
            this.labelSex.TabIndex = 7;
            this.labelSex.Text = "sex";
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPost.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonPost.Location = new System.Drawing.Point(8, 173);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(82, 40);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPost.Location = new System.Drawing.Point(96, 174);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(199, 39);
            this.textBoxPost.TabIndex = 5;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxFriend.Location = new System.Drawing.Point(183, 264);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(150, 142);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 4;
            this.pictureBoxFriend.TabStop = false;
            // 
            // labelFriends
            // 
            this.labelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFriends.BackColor = System.Drawing.Color.Magenta;
            this.labelFriends.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelFriends.Location = new System.Drawing.Point(7, 218);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Padding = new System.Windows.Forms.Padding(0, 0, 106, 0);
            this.labelFriends.Size = new System.Drawing.Size(288, 24);
            this.labelFriends.TabIndex = 3;
            this.labelFriends.Text = "friends";
            this.labelFriends.UseMnemonic = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFriends.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 15;
            this.listBoxFriends.Location = new System.Drawing.Point(7, 246);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(124, 182);
            this.listBoxFriends.TabIndex = 2;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(396, 485);
            this.Controls.Add(this.splitContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 528);
            this.MinimumSize = new System.Drawing.Size(416, 528);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelFeature2.ResumeLayout(false);
            this.panelFeature2.PerformLayout();
            this.panelFeature1.ResumeLayout(false);
            this.panelFeature1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbum)).EndInit();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelUserSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelUserEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.Label labelUserHometown;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelUserBirthday;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonRightScroll;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxSelectedAlbum;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelCountPhotoLikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Button buttonHomeScreen;
        private System.Windows.Forms.Button buttonFeature1Screen;
        private System.Windows.Forms.Button buttonFeature2Screen;
        private System.Windows.Forms.Panel panelFeature1;
        private System.Windows.Forms.Panel panelFeature2;
        private System.Windows.Forms.Button buttonStartMemoryGame;
        private CircularButton buttonMemory2;
        private CircularButton buttonMemory1;
        private CircularButton buttonMemory3;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelMemoryGame;
	    private System.Windows.Forms.Button buttonSentiment;
        private System.Windows.Forms.ListBox listBoxNegative;
        private System.Windows.Forms.ListBox listBoxPositive;
        private System.Windows.Forms.Label labelNegative;
        private System.Windows.Forms.Label labelPositive;
        private System.Windows.Forms.TextBox textBoxExplanation;
    }
}

