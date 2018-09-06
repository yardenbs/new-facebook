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
        private IEnumerator<Photo> m_AlbumIterator;
        public User LoggedInUser { get; set; }
        private SentiRadio m_selectedSentiRadio;
        private Action<Dictionary<string, Prediction>> displayResultMethod;

        enum SentiRadio
        {
            ALL_POSTS,
            SELECTED_POST,
            CUSTOM_SENTENCE,
        }

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
            m_AlbumIterator = (listBoxAlbums.SelectedItem as Album).Photos.GetEnumerator();
            if (m_AlbumIterator.MoveNext())
            {
                updateImage();
            }
        }

        private void updateImage()
        {
            pictureBoxSelectedAlbum.Invoke(new Action(() =>
                                        pictureBoxSelectedAlbum.LoadAsync(m_AlbumIterator.Current.PictureNormalURL)));
            labelCountPhotoLikes.Invoke(new Action(() => labelCountPhotoLikes.ResetText()));
            labelCountPhotoLikes.Invoke(new Action(() =>
                                        labelCountPhotoLikes.Text = m_AlbumIterator.Current.LikedBy.Count.ToString()));
        }

        private void buttonRightScroll_Click(object sender, EventArgs e)
        {
            if (!m_AlbumIterator.MoveNext())
            {
                m_AlbumIterator.Reset();
                m_AlbumIterator.MoveNext();
            }
            updateImage();
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
            Dictionary<string, Prediction> analyzedPosts = new Dictionary<string, Prediction>();

            initDict(ref analyzedPosts);

            m_LogicFacade.AnalyzePosts(ref analyzedPosts);
            displayResultMethod(analyzedPosts);
        }

        private void initDict(ref Dictionary<string, Prediction> analyzedPosts)
        {
            switch (m_selectedSentiRadio)
            {
                case SentiRadio.ALL_POSTS:
                    foreach ( Post post in LoggedInUser.Posts)
                    {
                        if (post.Message != null)
                        {
                            analyzedPosts.Add(post.Message, null);
                        }
                    }
                    break;
                case SentiRadio.SELECTED_POST:
                    if (listBoxSelectPostToAnalyze.SelectedItem != null)
                    {
                        analyzedPosts.Add((listBoxSelectPostToAnalyze.SelectedItem as Post).Message, null);
                    }
                    break;
                case SentiRadio.CUSTOM_SENTENCE:
                    analyzedPosts.Add( textBoxToAnalyze.Text, null);
                    break;
            }
        }

        private void populateLists(Dictionary<string, Prediction> i_AnalyzedPosts)
        {
            ListBox listBox;

            listBoxPositive.Items.Clear();
            listBoxNegative.Items.Clear();

            foreach (KeyValuePair<string, Prediction> pair in i_AnalyzedPosts)
            {
                if (pair.Value.isPositive == true)
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

        private void radioButtonAllPosts_CheckedChanged(object sender, EventArgs e)
        {
            this.m_selectedSentiRadio = SentiRadio.ALL_POSTS;
            initPanel(panelAllPosts);
            displayResultMethod = populateLists;
        }

        private void displayScore(Dictionary<string, Prediction> i_AnalyzedPost)
        {
            Prediction pred = new Prediction();

            foreach (string item in i_AnalyzedPost.Keys)
            {
                pred = i_AnalyzedPost[item];
            }

            textBoxPos.Text = pred.PosScore.ToString();
            textBoxNeg.Text = pred.NegScore.ToString();
        }

        private void radioButtonSelectedPost_CheckedChanged(object sender, EventArgs e)
        {
            this.m_selectedSentiRadio = SentiRadio.SELECTED_POST;
            populateListBox();
            initPanel(panelSelectedPost);
            displayResultMethod = displayScore;
        }

        private void radioButtonCustomSentence_CheckedChanged(object sender, EventArgs e)
        {
            this.m_selectedSentiRadio = SentiRadio.CUSTOM_SENTENCE;
            initPanel(panelCustomSentence);
            displayResultMethod = displayScore;
        }

        private void initPanel(Panel pnl)
        {
            pnl.Update();

            if (listBoxClassifiers.SelectedValue != null)
            {
                buttonSentiment.Enabled = true;
            }
            hideAllPanels();
            pnl.Show();
        }

        private void populateListBox()
        {
            listBoxSelectPostToAnalyze.DisplayMember = "Message";

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxSelectPostToAnalyze.Items.Add(post);
                }
            }
        }

        private void hideAllPanels()
        {
            panelAllPosts.Hide();
            panelCustomSentence.Hide();
            panelSelectedPost.Hide();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            m_LogicFacade.MoveButtons();
        }

        private void fetchClassifiers()
        {
            foreach (String classifierName in m_LogicFacade.GetClassifiers())
            {
                listBoxClassifiers.Invoke(
                    new Action(() => listBoxClassifiers.Items.Add(convertCamelCaseToWords(classifierName))));
            }
        }

        private String convertCamelCaseToWords(string i_ClassifierName)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                System.Text.RegularExpressions.Regex.Replace(
                    i_ClassifierName,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }

        private void listBoxClassifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( radioButtonAllPosts.Checked || radioButtonCustomSentence.Checked || radioButtonSelectedPost.Checked)
            {
                buttonSentiment.Enabled = true;
            }

            enableNormRadioBtns();
            m_LogicFacade.SetSentimentAnalyzer(((String)listBoxClassifiers.SelectedItem).Replace(" ", ""));
            textBoxExplanation.Clear();
            listBoxPositive.Items.Clear();
            listBoxNegative.Items.Clear();
            textBoxExplanation.Text = m_LogicFacade.GetClassifierExplanation();
        }

        private void enableNormRadioBtns()
        {
            radioButtonNorm1.Enabled = true;
            radioButtonActualFreq.Enabled = true;
            radioButtonBinary.Enabled = true;
            radioButtonCrazyRandom.Enabled = true;
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
                MessageBox.Show("Sorry, it appears Facebook \nhas disabled this feature :(");
                buttonPost.Invoke(new Action(() => buttonPost.Enabled = false));
            }
            finally
            {
                textBoxPost.Invoke(new Action(() => textBoxPost.Clear()));
            }
        }

        private void radioButtonBinary_CheckedChanged(object sender, EventArgs e)
        {
            m_LogicFacade.setNormStrategy("Binary");
        }

        private void radioButtonActualFreq_CheckedChanged(object sender, EventArgs e)
        {
            m_LogicFacade.setNormStrategy("Actual");
        }

        private void radioButtonNorm1_CheckedChanged(object sender, EventArgs e)
        {
            m_LogicFacade.setNormStrategy("Norm1");
        }

        private void radioButtonCrazyRandom_CheckedChanged(object sender, EventArgs e)
        {
            m_LogicFacade.setNormStrategy("Crazy");
        }
    }
}