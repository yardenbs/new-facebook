using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWindowsApp
{
    public class MemoryGame
    {
        public const int k_DIFFICULTY = 3;
        public const string k_FRIEND_TAG = "FRIEND";
        public const string k_NOT_FRIEND_TAG = "NOT_FRIEND";
        public Button[] MovingButtons { get; set; }
        public FacebookObjectCollection<User> Friends { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private Random m_Random = new Random();
        public event EventHandler GameEnded;

        public MemoryGame(int i_Width, int i_Height, FacebookObjectCollection<User> i_Friends, Button[] i_MovingButtons)
        {
            MovingButtons = i_MovingButtons;
            Friends = i_Friends;
            Width = i_Width;
            Height = i_Height;

            for (int i = 0; i < MovingButtons.Length; i++)
            {
                MovingButtons[i].Click += MovingButton_Click;
            }
        }

        public void StartGame()
        {
            int selectedFriendButtonIndex;

            handleFriendButton(out selectedFriendButtonIndex);

            for (int i = 0; i < k_DIFFICULTY; i++)
            {
                if (i != selectedFriendButtonIndex)
                {
                    handleNotFriendButton(MovingButtons[i]);
                }

                MovingButtons[i].Show();
                MovingButtons[i].Enabled = true;
            }
        }

        public void MoveButtons()
        {
            int x = 2, y = 3;

            for (int i = 0; i < MovingButtons.Length; i++)
            {
                x = (m_Random.Next() % 2 == 0) ? x : -x;
                y = (m_Random.Next() % 2 == 0) ? y : -y;

                Point newLocation = new Point(MovingButtons[i].Location.X + x, MovingButtons[i].Location.Y + y);
                if (newLocation.X > Width)
                {
                    newLocation.X += -x;
                }

                if (newLocation.Y > Height)
                {
                    newLocation.Y += -y;
                }

                MovingButtons[i].Location = newLocation;
            }
        }

        protected virtual void OnEndedGame(EventArgs e)
        {
            if (GameEnded != null)
            {
                GameEnded.Invoke(this, e);
            }
        }

        private void handleNotFriendButton(Button i_NotFriendButton)
        {
            List<string> pictureNames = new List<string> { "face1", "face2", "face3", "face4" };
            int randomPictureIndex = m_Random.Next(0, pictureNames.Count);
            string randomPictureName = pictureNames[randomPictureIndex];

            i_NotFriendButton.Tag = k_NOT_FRIEND_TAG;
            pictureNames.Remove(randomPictureName);
            i_NotFriendButton.Image = Resource.ResourceManager.GetObject(randomPictureName) as Image;
        }

        private void handleFriendButton(out int io_SelectedFriendButton)
        {
            int selectedFriend = m_Random.Next(0, Friends.Count);

            io_SelectedFriendButton = m_Random.Next(0, k_DIFFICULTY);
            MovingButtons[io_SelectedFriendButton].Tag = k_FRIEND_TAG;
            foreach (User friend in Friends)
            {
                if (selectedFriend == 0)
                {
                    MovingButtons[io_SelectedFriendButton].Image = friend.ImageNormal;
                    break;
                }

                selectedFriend--;
            }
        }

        private void MovingButton_Click(object sender, EventArgs e)
        {
            Button movingButton = sender as Button;

            if ((string)movingButton.Tag == k_FRIEND_TAG)
            {
                MessageBox.Show("You are right!, good job");
            }
            else
            {
                MessageBox.Show("No!, it is not your friend!");
            }

            EndGame();
        }

        private void EndGame()
        {
            for (int i = 0; i < MovingButtons.Length; i++)
            {
                MovingButtons[i].Hide();
                MovingButtons[i].Image = null;
            }

            OnEndedGame(null);
        }
    }
}
