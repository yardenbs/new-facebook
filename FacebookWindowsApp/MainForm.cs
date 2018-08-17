using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

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
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            LoggedInUser = m_LogicFacade.LoggedInUser;

            pictureBoxUser.LoadAsync(LoggedInUser.PictureNormalURL);
            labelUserName.Text = LoggedInUser.Name;
            labelUserEmail.Text = LoggedInUser.Email;
            labelUserHometown.Text = (LoggedInUser.Hometown != null) ? LoggedInUser.Hometown.Name : null;
            labelUserSex.Text = (LoggedInUser.Gender != null) ? LoggedInUser.Gender.Value.ToString() : null;
            labelUserBirthday.Text = LoggedInUser.Birthday;
            fetchFriends();
            fetchPosts(); 
            fetchEvents();
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            if (LoggedInUser.Albums.Count != 0)
            {
                FacebookObjectCollection<Album> albums = LoggedInUser.Albums;
                foreach (Album album in albums)
                {
                    listBoxAlbums.Items.Add(album);
                }
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            if (LoggedInUser.Events.Count != 0)
            {
                listBoxEvents.Show();
                foreach (Event userEvent in LoggedInUser.Events)
                {
                    try
                    {
                        listBoxEvents.Items.Add(userEvent);
                        userEvent.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                listBoxEvents.Hide();
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = "Message";

            if (LoggedInUser.Posts.Count != 0)
            {
                listBoxPosts.Show();

                foreach (Post post in LoggedInUser.Posts)
                {
                    try
                    {
                        listBoxPosts.Items.Add(post);
                        post.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                listBoxPosts.Hide();
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
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
            try
            {
                if (!string.IsNullOrEmpty(textBoxPost.Text))
                {
                    LoggedInUser.PostStatus(textBoxPost.Text);
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
            pictureBoxSelectedAlbum.LoadAsync(m_Album.Photos[s_PhotoIdx].PictureNormalURL);
            labelCountPhotoLikes.ResetText();
            labelCountPhotoLikes.Text = m_Album.Photos[s_PhotoIdx].LikedBy.Count.ToString();
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
            listBoxPositive.Items.Clear();
            listBoxNegative.Items.Clear();

            foreach (KeyValuePair<string, bool> pair in i_analyzedPosts)
            {
                if (pair.Value == true)
                {
                    listBoxPositive.Items.Add(pair.Key);
                }
                else
                {
                    listBoxNegative.Items.Add(pair.Key);
                }
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            m_LogicFacade.MoveButtons();
        }
    }
}
