using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWindowsApp
{
    public partial class LoginForm : Form
    {
        private const string k_AppId = "1845748158804248";
        private AppSettings m_AppSettings;

        public User LoggedInUser { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            m_AppSettings = AppSettings.Instance;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = loginAndInit() ? DialogResult.OK : DialogResult.Cancel;
        }

        private bool loginAndInit()
        {
            bool logged = false;
            LoginResult result = FacebookService.Login(k_AppId,
                "public_profile",
                "user_friends",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_photos",
                "user_gender",
                "user_birthday",
                "user_posts",
                "email"
                );

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                this.LoggedInUser = result.LoggedInUser;
                m_AppSettings.LastAccessToken = result.AccessToken;
                logged = true;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

            return logged;
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.RememberUser = checkBoxRememberUser.Checked;
        }
    }
}
