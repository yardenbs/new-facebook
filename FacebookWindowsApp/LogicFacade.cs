using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace FacebookWindowsApp
{
    internal class LogicFacade
    {
        private AppSettings m_AppSettings;
        private MemoryGame m_MemoryGame;
        private SentimentAnalyzer m_SentimentAnalyzer;
        private SentimentAnalyzerFactory m_SentiFactory = new SentimentAnalyzerFactory();

        public User LoggedInUser { get; set; }

        public void LoadAppConfig()
        {
            if (m_AppSettings == null)
            {
                m_AppSettings = AppSettings.LoadFromFile();
            }
        }

        public void UpdateAppSettings()
        {
            if (!m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        public List<String> getClassifiers()
        {
            return m_SentiFactory.ClassifiersList.Keys.ToList();
        }

        public void SetSentimentAnalyzer(String i_classifier)
        {
            m_SentimentAnalyzer = m_SentiFactory.createSentimentAnalyzer(i_classifier);
        }

        public String getClassifierExplanation()
        {
            return m_SentimentAnalyzer.ClassifierExplanation;
        }

        public void AnalyzePosts(Dictionary<string, bool> i_AnalyzedPosts)
        {
            if (m_SentimentAnalyzer == null)
            {
                m_SentimentAnalyzer = new SvmModel();
            }

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message == null)
                {
                    continue;
                }

                i_AnalyzedPosts.Add(post.Message, m_SentimentAnalyzer.Predict(post.Message));
            }
        }

        public void Login()
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

        public void StartMemoryGame(Button[] i_MovingButtons, EventHandler i_MainForm_GameEnded, Size i_ClientSize)
        {
            if (m_MemoryGame == null)
            {
                Size clientSize = i_MovingButtons[0].ClientSize;

                m_MemoryGame = new MemoryGame(i_ClientSize, LoggedInUser.Friends, i_MovingButtons);
                m_MemoryGame.GameEnded += i_MainForm_GameEnded;
            }

            m_MemoryGame.StartGame();
        }

        public void MoveButtons()
        {
            m_MemoryGame.MoveButtons();
        }

        public void Logout()
        {
            m_AppSettings.RememberUser = false;
            m_AppSettings.LastAccessToken = null;
            m_AppSettings.SaveToFile();
            FacebookService.Logout(null);
            Application.Exit();
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
    }
}