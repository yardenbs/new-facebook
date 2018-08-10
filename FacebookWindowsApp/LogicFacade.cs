using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookWindowsApp
{
    class LogicFacade
    {
        private AppSettings m_AppSettings;
        private  MemoryGame m_MemoryGame;
        private SentimentAnalyzer m_SentimentAnalyzer;

        public User LoggedInUser { get; set; }

        public void LoadAppConfig()
        {
            if (m_AppSettings == null)
            {
                m_AppSettings = AppSettings.LoadFromFile();
            }
        }

        internal void UpdateAppSettings()
        {
            if (!m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        internal void AnalyzePosts(Dictionary<string, bool> analyzedPosts)
        {
            if(m_SentimentAnalyzer == null)
            {
                m_SentimentAnalyzer = new SentimentAnalyzer();
            }

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message == null)
                {
                    continue;
                }

                analyzedPosts.Add(post.Message, m_SentimentAnalyzer.Predict(post.Message));
            }
        }

        internal void Login()
        {
            if (m_AppSettings.RememberUser == true)
            {
                LoggedInUser = FacebookService.Connect(m_AppSettings.LastAccessToken).LoggedInUser;

            }
            else
            {
                handleLogin();
            }
        }

        internal void StartMemoryGame(Button[] i_MovingButtons, EventHandler i_MainForm_GameEnded)
        {
            if (m_MemoryGame == null)
            {
                Size clientSize = i_MovingButtons[0].ClientSize;

                m_MemoryGame = new MemoryGame(clientSize.Width, clientSize.Height, LoggedInUser.Friends, i_MovingButtons);
                m_MemoryGame.GameEnded += i_MainForm_GameEnded;
            }

            m_MemoryGame.StartGame();
        }

        internal void MoveButtons()
        {
            m_MemoryGame.MoveButtons();
        }

        private void handleLogin()
        {
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                LoggedInUser = loginForm.LoggedInUser;
            }
        }

        internal void Logout()
        {
            m_AppSettings.RememberUser = false;
            m_AppSettings.LastAccessToken = null;
            m_AppSettings.SaveToFile();
            FacebookService.Logout(null);
            Application.Exit();
        }
    }
}
