using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceLikers
{
    public partial class FormMain : FormThatListen
    {
        private AppManager m_AppManager;
        private User m_LoggedInUser;
        private FormCheckInRecommendation m_CheckInRecommensationForm;
        private FormFaceLikers m_FaceLikersForm;

        public FormMain()
        {
            InitializeComponent();
            m_AppManager = AppManager.Instance;
            m_LoggedInUser = m_AppManager.LoggedInUser;
            fetchUserData();
            m_CheckInRecommensationForm = m_AppManager.CheckInForm;
            m_FaceLikersForm = m_AppManager.FriendRaterForm;
        }

        private void fetchUserData()
        {
            userBindingSource.DataSource = m_LoggedInUser;
            pictureBoxProfileImage.Load(m_LoggedInUser.PictureLargeURL);
        }

        private void fetchFriends()
        {
            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    if (!listBoxFriends.Items.Contains(friend.Name))
                    {
                        listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend.Name)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed: " + ex.Message);
            }
        }

        private void fetchPosts()
        {
            try
            {
                foreach (Post post in m_LoggedInUser.WallPosts)
                {
                    if (post.Message != null)
                    {
                        if (!listBoxPosts.Items.Contains(post.Message))
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed: " + ex.Message);
            }
        }

        private void fetchCheckIns()
        {
            try
            {
                foreach (Checkin checkIn in m_LoggedInUser.Checkins)
                {
                    if (checkIn.Place != null && !listBoxCheckIn.Items.Contains(checkIn.Place.Name))
                    {
                        listBoxCheckIn.Invoke(new Action(() => listBoxCheckIn.Items.Add(checkIn.Place.Name)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed: " + ex.Message);
            }
        }

        private void labelFriends_Click(object sender, EventArgs e)
        {
               BlinkLabel label = this.labelFriends as BlinkLabel;
               label.Blink();
               new Thread(fetchFriends).Start();
        }

        private void labelPosts_Click(object sender, EventArgs e)
        {
               BlinkLabel label = this.labelPosts as BlinkLabel;
               label.Blink();
               new Thread(fetchPosts).Start();
        }

        private void labelCheckIns_Click(object sender, EventArgs e)
        {
               BlinkLabel label = this.labelCheckIns as BlinkLabel;
               label.Blink();
               new Thread(fetchCheckIns).Start();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_AppManager.SettingsForm.Close();
            m_AppManager.Logout();
            this.Hide();
            m_AppManager.LoginForm.StartPosition = FormStartPosition.Manual;
            m_AppManager.LoginForm.Location = this.Location;
            m_AppManager.LoginForm.Show();
        }

        private void buttonCheckinFeature_Click(object sender, EventArgs e)
        {
            BlinkButton button = this.buttonCheckinFeature as BlinkButton;
            button.Blink();
            this.Hide();
            m_CheckInRecommensationForm.StartPosition = FormStartPosition.Manual;
            m_CheckInRecommensationForm.Location = this.Location;
            m_CheckInRecommensationForm.Show();
        }

          private void buttonFriendRaterFeature_Click(object sender, EventArgs e)
          {
               BlinkButton button = this.buttonFaceLikerFeature as BlinkButton;
               button.Blink();
               this.Hide();
               m_FaceLikersForm.StartPosition = FormStartPosition.Manual;
               m_FaceLikersForm.Location = this.Location;
               m_FaceLikersForm.Show();
          }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!emailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Email must contain @");
                e.Cancel = true;
            }
            else if (!emailTextBox.Text.Contains("."))
            {
                MessageBox.Show("Email must contain .");
                e.Cancel = true;
            }
        }

        private void birthdayTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isDate(birthdayTextBox.Text))
            {
                MessageBox.Show("Birthday format (dd/mm/yyyy)");
                e.Cancel = true;
            }
        }

        private bool isDate(string i_DateString)
        {
            bool isValidData = i_DateString.Length == 10;

            if (isValidData == true)
            {
                string stringMonth = i_DateString.Substring(0, 2);
                string stringDay = i_DateString.Substring(3, 2);
                string stringYear = i_DateString.Substring(6, 4);
                int intDay = 0, intMonth = 0, intYear = 0;
                char firstSlash = i_DateString[2], secSlash = i_DateString[5];

                try
                {
                    intDay = int.Parse(stringDay);
                    intMonth = int.Parse(stringMonth);
                    intYear = int.Parse(stringYear);
                }
                catch
                {
                    isValidData = false;
                }

                isValidData = isIntInRange(intDay, 31, 1) && isIntInRange(intMonth, 12, 1) && isIntInRange(intYear, 9999, 0)
                && firstSlash.Equals('/') && secSlash.Equals('/');
            }

            return isValidData;
        }

        private bool isIntInRange(int i_NumToCheck, int i_LargestInRange, int i_SmallestInRange)
        {
            return i_NumToCheck <= i_LargestInRange && i_NumToCheck >= i_SmallestInRange;
        }

        private void SetteingsButton_Click(object sender, EventArgs e)
        {
            m_AppManager.SettingsForm.Show();
        }
    }
}