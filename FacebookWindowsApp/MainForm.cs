using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWindowsApp
{
    public partial class MainForm : Form
    {
        private LogicFacade m_LogicFacade;
        private Album m_Album;
        private static int s_PhotoIdx = 0;

        public User LoggedInUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
            m_LogicFacade = new LogicFacade();
            m_LogicFacade.LoadAppConfig();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_LogicFacade.UpdateAppSettings();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelFeature1.Hide();
            panelFeature2.Hide();
            m_LogicFacade.Login();
            this.Show();
            backgroundWorkerUserInfo.RunWorkerAsync();
        }

        private void fetchUserInfo()
        {
            LoggedInUser = m_LogicFacade.LoggedInUser;
            userBindingSource.DataSource = LoggedInUser;
            labelUserName.Invoke(new Action(() => labelUserName.Text = LoggedInUser.Name));
            fetchFriends();
            fetchPosts();
            fetchEvents();
            fetchAlbums();
            fetchClassifiers();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));

            if (LoggedInUser.Albums.Count != 0)
            {
                FacebookObjectCollection<Album> albums = LoggedInUser.Albums;
                foreach (Album album in albums)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                }
            }
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = LoggedInUser.Events;
        }

        private void fetchPosts()
        {
            postBindingSource.DataSource = LoggedInUser.Posts;
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));

            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogicFacade.Logout();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            backgroundWorkerPost.RunWorkerAsync();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = null;
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            m_Album = listBoxAlbums.SelectedItem as Album;
            if (m_Album.Count != 0)
            {
                s_PhotoIdx = 0;
                updateImage();
            }
        }

        private void updateImage()
        {
            pictureBoxSelectedAlbum.Invoke(new Action(() =>
                                        pictureBoxSelectedAlbum.LoadAsync(m_Album.Photos[s_PhotoIdx].PictureNormalURL)));
            labelCountPhotoLikes.Invoke(new Action(() => labelCountPhotoLikes.ResetText()));
            labelCountPhotoLikes.Invoke(new Action(() =>
                                        labelCountPhotoLikes.Text = m_Album.Photos[s_PhotoIdx].LikedBy.Count.ToString()));
        }

        private void buttonRightScroll_Click(object sender, EventArgs e)
        {
            if (m_Album != null)
            {
                s_PhotoIdx = (s_PhotoIdx < m_Album.Photos.Count - 1) ? ++s_PhotoIdx : 0;
                updateImage();
            }
        }

        private void buttonHomeScreen_Click(object sender, EventArgs e)
        {
            panelFeature1.Hide();
            panelFeature2.Hide();
            labelUserName.ForeColor = buttonHomeScreen.FlatAppearance.BorderColor;
        }

        private void buttonFeature1Screen_Click(object sender, EventArgs e)
        {
            panelFeature1.Show();
            panelFeature2.Hide();
            labelUserName.ForeColor = buttonFeature1Screen.FlatAppearance.BorderColor;
        }

        private void buttonFeature2Screen_Click(object sender, EventArgs e)
        {
            panelFeature1.Hide();
            panelFeature2.Show();
            labelUserName.ForeColor = buttonFeature2Screen.FlatAppearance.BorderColor;
        }

        private void buttonStartMemoryGame_Click(object sender, EventArgs e)
        {
            Button[] movingButtons = new Button[] { buttonMemory1, buttonMemory2, buttonMemory3 };

            buttonStartMemoryGame.Hide();
            m_LogicFacade.StartMemoryGame(movingButtons, MainForm_GameEnded, ClientSize);
            timerGame.Start();
        }

        private void MainForm_GameEnded(object sender, EventArgs e)
        {
            buttonStartMemoryGame.Show();
            timerGame.Stop();
        }

        private void buttonSentiment_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> analyzedPosts = new Dictionary<string, bool>();

            m_LogicFacade.AnalyzePosts(analyzedPosts);
            populateLists(analyzedPosts);
        }

        private void populateLists(Dictionary<string, bool> i_analyzedPosts)
        {
            ListBox listBox;

            listBoxPositive.Items.Clear();
            listBoxNegative.Items.Clear();

            foreach (KeyValuePair<string, bool> pair in i_analyzedPosts)
            {
                if (pair.Value == true)
                {
                    listBox = listBoxPositive;
                }
                else
                {
                    listBox = listBoxNegative;
                }

                listBox.Items.Add(pair.Key);
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            m_LogicFacade.MoveButtons();
        }

        private void fetchClassifiers()
        {
            foreach (String classifierName in m_LogicFacade.GetClassifiers())
            {
                listBoxClassifiers.Items.Add(convertCamelCaseToWords(classifierName));
            }
        }

        private String convertCamelCaseToWords(string classifierName)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                System.Text.RegularExpressions.Regex.Replace(
                    classifierName,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }

        private void listBoxClassifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_LogicFacade.SetSentimentAnalyzer(((String)listBoxClassifiers.SelectedItem).Replace(" ", ""));
            textBoxExplanation.Clear();
            listBoxPositive.Items.Clear();
            listBoxNegative.Items.Clear();
            textBoxExplanation.Text = m_LogicFacade.GetClassifierExplanation();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            fetchUserInfo();
        }

        private void backgroundWorkerPost_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxPost.Text))
                {
                    LoggedInUser.PostStatus(textBoxPost.Text);
                    new Thread(() => LoggedInUser.ReFetch("posts")).Start();
                    fetchPosts();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                textBoxPost.Clear();
            }
        }
    }
}