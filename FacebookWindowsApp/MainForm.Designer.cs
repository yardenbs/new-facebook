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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonHomeScreen = new System.Windows.Forms.Button();
            this.buttonFeature1Screen = new System.Windows.Forms.Button();
            this.buttonFeature2Screen = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelFeature1 = new System.Windows.Forms.Panel();
            this.labelClassifierExplanation = new System.Windows.Forms.Label();
            this.labelClassifierType = new System.Windows.Forms.Label();
            this.listBoxClassifiers = new System.Windows.Forms.ListBox();
            this.textBoxExplanation = new System.Windows.Forms.TextBox();
            this.labelNegative = new System.Windows.Forms.Label();
            this.labelPositive = new System.Windows.Forms.Label();
            this.listBoxNegative = new System.Windows.Forms.ListBox();
            this.listBoxPositive = new System.Windows.Forms.ListBox();
            this.buttonSentiment = new System.Windows.Forms.Button();
            this.panelFeature2 = new System.Windows.Forms.Panel();
            this.labelMemoryGame = new System.Windows.Forms.Label();
            this.buttonMemory2 = new FacebookWindowsApp.CircularButton();
            this.buttonMemory1 = new FacebookWindowsApp.CircularButton();
            this.buttonMemory3 = new FacebookWindowsApp.CircularButton();
            this.buttonStartMemoryGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerUserInfo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerPost = new System.ComponentModel.BackgroundWorker();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelFeature1.SuspendLayout();
            this.panelFeature2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.ForeColor = System.Drawing.SystemColors.Info;
            birthdayLabel.Location = new System.Drawing.Point(156, 35);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(63, 15);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.Info;
            emailLabel.Location = new System.Drawing.Point(156, 61);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 15);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.ForeColor = System.Drawing.SystemColors.Info;
            cityLabel.Location = new System.Drawing.Point(156, 87);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(34, 15);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.ForeColor = System.Drawing.SystemColors.Info;
            countryLabel.Location = new System.Drawing.Point(156, 113);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 15);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "Country:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Info;
            descriptionLabel.Location = new System.Drawing.Point(6, 35);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.ForeColor = System.Drawing.SystemColors.Info;
            endTimeLabel.Location = new System.Drawing.Point(6, 114);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.ForeColor = System.Drawing.SystemColors.Info;
            locationLabel.Location = new System.Drawing.Point(6, 61);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.SystemColors.Info;
            nameLabel.Location = new System.Drawing.Point(6, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.ForeColor = System.Drawing.SystemColors.Info;
            startTimeLabel.Location = new System.Drawing.Point(6, 88);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 8;
            startTimeLabel.Text = "Start Time:";
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
            this.splitContainer.Panel2.Controls.Add(this.panelFeature1);
            this.splitContainer.Panel2.Controls.Add(this.panelFeature2);
            this.splitContainer.Panel2.Controls.Add(this.panel3);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
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
            this.splitContainer.Panel2.Controls.Add(this.buttonPost);
            this.splitContainer.Panel2.Controls.Add(this.textBoxPost);
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxFriend);
            this.splitContainer.Panel2.Controls.Add(this.labelFriends);
            this.splitContainer.Panel2.Controls.Add(this.listBoxFriends);
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
            // panelFeature1
            // 
            this.panelFeature1.BackColor = System.Drawing.Color.Coral;
            this.panelFeature1.Controls.Add(this.labelClassifierExplanation);
            this.panelFeature1.Controls.Add(this.labelClassifierType);
            this.panelFeature1.Controls.Add(this.listBoxClassifiers);
            this.panelFeature1.Controls.Add(this.textBoxExplanation);
            this.panelFeature1.Controls.Add(this.labelNegative);
            this.panelFeature1.Controls.Add(this.labelPositive);
            this.panelFeature1.Controls.Add(this.listBoxNegative);
            this.panelFeature1.Controls.Add(this.listBoxPositive);
            this.panelFeature1.Controls.Add(this.buttonSentiment);
            this.panelFeature1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeature1.Location = new System.Drawing.Point(0, 0);
            this.panelFeature1.Name = "panelFeature1";
            this.panelFeature1.Size = new System.Drawing.Size(379, 1040);
            this.panelFeature1.TabIndex = 25;
            // 
            // labelClassifierExplanation
            // 
            this.labelClassifierExplanation.AutoSize = true;
            this.labelClassifierExplanation.Location = new System.Drawing.Point(201, 29);
            this.labelClassifierExplanation.Name = "labelClassifierExplanation";
            this.labelClassifierExplanation.Size = new System.Drawing.Size(109, 13);
            this.labelClassifierExplanation.TabIndex = 30;
            this.labelClassifierExplanation.Text = "Classifier Explanation:";
            // 
            // labelClassifierType
            // 
            this.labelClassifierType.AutoSize = true;
            this.labelClassifierType.Location = new System.Drawing.Point(34, 29);
            this.labelClassifierType.Name = "labelClassifierType";
            this.labelClassifierType.Size = new System.Drawing.Size(84, 13);
            this.labelClassifierType.TabIndex = 29;
            this.labelClassifierType.Text = "Select Classifier:";
            // 
            // listBoxClassifiers
            // 
            this.listBoxClassifiers.FormattingEnabled = true;
            this.listBoxClassifiers.Location = new System.Drawing.Point(9, 45);
            this.listBoxClassifiers.Name = "listBoxClassifiers";
            this.listBoxClassifiers.Size = new System.Drawing.Size(129, 108);
            this.listBoxClassifiers.TabIndex = 28;
            this.listBoxClassifiers.SelectedIndexChanged += new System.EventHandler(this.listBoxClassifiers_SelectedIndexChanged);
            // 
            // textBoxExplanation
            // 
            this.textBoxExplanation.Location = new System.Drawing.Point(144, 45);
            this.textBoxExplanation.Multiline = true;
            this.textBoxExplanation.Name = "textBoxExplanation";
            this.textBoxExplanation.ReadOnly = true;
            this.textBoxExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExplanation.Size = new System.Drawing.Size(226, 107);
            this.textBoxExplanation.TabIndex = 27;
            // 
            // labelNegative
            // 
            this.labelNegative.AutoSize = true;
            this.labelNegative.Location = new System.Drawing.Point(241, 204);
            this.labelNegative.Name = "labelNegative";
            this.labelNegative.Size = new System.Drawing.Size(79, 13);
            this.labelNegative.TabIndex = 4;
            this.labelNegative.Text = "Negative Posts";
            // 
            // labelPositive
            // 
            this.labelPositive.AutoSize = true;
            this.labelPositive.Location = new System.Drawing.Point(58, 206);
            this.labelPositive.Name = "labelPositive";
            this.labelPositive.Size = new System.Drawing.Size(73, 13);
            this.labelPositive.TabIndex = 3;
            this.labelPositive.Text = "Positive Posts";
            // 
            // listBoxNegative
            // 
            this.listBoxNegative.FormattingEnabled = true;
            this.listBoxNegative.Location = new System.Drawing.Point(192, 222);
            this.listBoxNegative.Name = "listBoxNegative";
            this.listBoxNegative.Size = new System.Drawing.Size(181, 186);
            this.listBoxNegative.TabIndex = 2;
            // 
            // listBoxPositive
            // 
            this.listBoxPositive.FormattingEnabled = true;
            this.listBoxPositive.Location = new System.Drawing.Point(4, 222);
            this.listBoxPositive.Name = "listBoxPositive";
            this.listBoxPositive.Size = new System.Drawing.Size(182, 186);
            this.listBoxPositive.TabIndex = 1;
            // 
            // buttonSentiment
            // 
            this.buttonSentiment.Enabled = false;
            this.buttonSentiment.Location = new System.Drawing.Point(148, 174);
            this.buttonSentiment.Name = "buttonSentiment";
            this.buttonSentiment.Size = new System.Drawing.Size(75, 23);
            this.buttonSentiment.TabIndex = 0;
            this.buttonSentiment.Text = "Analyze!";
            this.buttonSentiment.UseVisualStyleBackColor = true;
            this.buttonSentiment.Click += new System.EventHandler(this.buttonSentiment_Click);
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
            this.panelFeature2.Size = new System.Drawing.Size(379, 1040);
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
            // panel3
            // 
            this.panel3.Controls.Add(descriptionLabel);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Controls.Add(endTimeLabel);
            this.panel3.Controls.Add(this.endTimeDateTimePicker);
            this.panel3.Controls.Add(locationLabel);
            this.panel3.Controls.Add(this.locationTextBox);
            this.panel3.Controls.Add(nameLabel);
            this.panel3.Controls.Add(this.nameTextBox);
            this.panel3.Controls.Add(startTimeLabel);
            this.panel3.Controls.Add(this.startTimeDateTimePicker);
            this.panel3.Location = new System.Drawing.Point(7, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 138);
            this.panel3.TabIndex = 27;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(75, 32);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(491, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(75, 110);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(491, 20);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(75, 58);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(491, 20);
            this.locationTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(75, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(491, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(75, 84);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(491, 20);
            this.startTimeDateTimePicker.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(cityLabel);
            this.panel2.Controls.Add(this.cityTextBox);
            this.panel2.Controls.Add(countryLabel);
            this.panel2.Controls.Add(this.countryTextBox);
            this.panel2.Controls.Add(birthdayLabel);
            this.panel2.Controls.Add(this.birthdayTextBox);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.imageNormalPictureBox);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 164);
            this.panel2.TabIndex = 26;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Hometown.Location.City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.cityTextBox.Location = new System.Drawing.Point(216, 89);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(148, 13);
            this.cityTextBox.TabIndex = 8;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // countryTextBox
            // 
            this.countryTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.countryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Hometown.Location.Country", true));
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.countryTextBox.Location = new System.Drawing.Point(216, 115);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(148, 13);
            this.countryTextBox.TabIndex = 10;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.birthdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.birthdayTextBox.Location = new System.Drawing.Point(216, 37);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(148, 13);
            this.birthdayTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.emailTextBox.Location = new System.Drawing.Point(216, 63);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 13);
            this.emailTextBox.TabIndex = 5;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(6, 12);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(146, 143);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(7, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 28);
            this.panel1.TabIndex = 25;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(6, 5);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelEvents
            // 
            this.labelEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEvents.BackColor = System.Drawing.Color.Magenta;
            this.labelEvents.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelEvents.Location = new System.Drawing.Point(7, 546);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Padding = new System.Windows.Forms.Padding(0, 0, 106, 0);
            this.labelEvents.Size = new System.Drawing.Size(419, 24);
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
            this.labelLikes.Location = new System.Drawing.Point(102, 1015);
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
            this.labelCountPhotoLikes.Location = new System.Drawing.Point(147, 1015);
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
            this.labelAlbums.Location = new System.Drawing.Point(5, 769);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Padding = new System.Windows.Forms.Padding(0, 0, 106, 0);
            this.labelAlbums.Size = new System.Drawing.Size(417, 25);
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
            this.labelPosts.Size = new System.Drawing.Size(419, 24);
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
            this.buttonRightScroll.Location = new System.Drawing.Point(292, 1009);
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
            this.listBoxAlbums.CausesValidation = false;
            this.listBoxAlbums.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 15;
            this.listBoxAlbums.Location = new System.Drawing.Point(5, 798);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAlbums.MaximumSize = new System.Drawing.Size(79, 242);
            this.listBoxAlbums.MinimumSize = new System.Drawing.Size(79, 242);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(79, 242);
            this.listBoxAlbums.Sorted = true;
            this.listBoxAlbums.TabIndex = 14;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxSelectedAlbum
            // 
            this.pictureBoxSelectedAlbum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxSelectedAlbum.Location = new System.Drawing.Point(95, 797);
            this.pictureBoxSelectedAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSelectedAlbum.Name = "pictureBoxSelectedAlbum";
            this.pictureBoxSelectedAlbum.Size = new System.Drawing.Size(272, 201);
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
            this.listBoxEvents.Location = new System.Drawing.Point(7, 574);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(419, 51);
            this.listBoxEvents.TabIndex = 11;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 15;
            this.listBoxPosts.Location = new System.Drawing.Point(7, 459);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(422, 47);
            this.listBoxPosts.TabIndex = 10;
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
            this.textBoxPost.Size = new System.Drawing.Size(205, 39);
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
            this.labelFriends.Size = new System.Drawing.Size(419, 24);
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
            // backgroundWorkerUserInfo
            // 
            this.backgroundWorkerUserInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorkerPost
            // 
            this.backgroundWorkerPost.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPost_DoWork);
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelFeature1.ResumeLayout(false);
            this.panelFeature1.PerformLayout();
            this.panelFeature2.ResumeLayout(false);
            this.panelFeature2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.ListBox listBoxClassifiers;
        private System.Windows.Forms.Label labelClassifierType;
        private System.Windows.Forms.Label labelClassifierExplanation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUserInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPost;
    }
}
