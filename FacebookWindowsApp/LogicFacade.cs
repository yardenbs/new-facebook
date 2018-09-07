using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FacebookWindowsApp
{
    internal class LogicFacade
    {
        private AppSettings m_AppSettings;
        private MemoryGame m_MemoryGame;
        private SentimentAnalyzer m_SentimentAnalyzer;
        private static PostCollection m_postCollection;
        private static IEnumerator<string> m_postIt;
        private readonly int SHORT_SENTENCE_LEN = 4;
        //private Func<>

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

        public List<string> GetClassifiers()
        {
            return SentimentAnalyzerFactory.ClassifiersList.Keys.ToList();
        }

        public void SetSentimentAnalyzer(string i_Classifier)
        {
            m_SentimentAnalyzer = SentimentAnalyzerFactory.createSentimentAnalyzer(i_Classifier);
        }

        public string GetClassifierExplanation()
        {
            return m_SentimentAnalyzer.ClassifierExplanation;
        }

        public void AnalyzePosts(ref Dictionary<string, Prediction> i_AnalyzedPosts)
        {
            Dictionary<string, Prediction> result = new Dictionary<string, Prediction>(i_AnalyzedPosts.Count);

            foreach (string str in i_AnalyzedPosts.Keys)
            {
                result[str] = m_SentimentAnalyzer.Predict(str);
            }

            i_AnalyzedPosts = result;
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

        internal void setNormStrategy(string stratName)
        {
            switch (stratName)
            {
                case "Binary":
                    m_SentimentAnalyzer.NormalizationMethod = (num, lst) => num > 0 ? 1.0f : 0.0f;
                    break;
                case "Actual":
                    m_SentimentAnalyzer.NormalizationMethod = (num, lst) => (float)num;
                    break;
                case "Norm1":
                    m_SentimentAnalyzer.NormalizationMethod = (num, lst) => (float)num/lst.Count + num;
                    break;
                case "Crazy":
                default:
                    Random rand = new Random();
                    m_SentimentAnalyzer.NormalizationMethod = (num, lst) => (float)rand.NextDouble();
                    break;
            }
        }

        internal string initPostTextBox()
        {
            m_postCollection = new PostCollection(LoggedInUser, (str) => str.Split(' ').Length > SHORT_SENTENCE_LEN);
            m_postIt = (m_postCollection as IEnumerable<string>).GetEnumerator();
            m_postIt.MoveNext();

            return m_postIt.Current;
        }

        internal static string getNextPost()
        {
            if (!m_postIt.MoveNext())
            {
                m_postIt = (m_postCollection as IEnumerable<string>).GetEnumerator();
                m_postIt.MoveNext();
            }

            return m_postIt.Current;
        }
    }
}