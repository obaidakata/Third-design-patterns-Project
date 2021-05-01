using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceLikers
{
    public sealed class AppManager
    {
        private const string AppId = "2695170000736846";
        private LoginResult m_LoginResult;
        private FormLogIn m_FormLogin = null;
        private FormMain m_FormMain = null;
        private FormSettings m_FormSettings = null;
        private FormCheckInRecommendation m_FormCheckIn = null;
        private FormFaceLikers m_FormFriendRater = null;

        public static AppManager Instance
        {
            get
            {
                return Singleton<AppManager>.Instance;
            }
        }

        public FormFaceLikers FriendRaterForm
        {
            get
            {
                if (m_FormFriendRater == null)
                {
                    m_FormFriendRater = new FormFaceLikers();
                }

                return m_FormFriendRater;
            }
        }

        public FormMain MainForm
        {
            get
            {
                if (m_FormMain == null)
                {
                    m_FormMain = new FormMain();
                }

                return m_FormMain;
            }
        }

        public FormSettings SettingsForm
        {
            get
            {
                if (m_FormSettings == null)
                {
                    m_FormSettings = new FormSettings();
                }

                return m_FormSettings;
            }
        }

        public FormCheckInRecommendation CheckInForm
        {
            get
            {
                if (m_FormCheckIn == null)
                {
                    m_FormCheckIn = new FormCheckInRecommendation();
                }

                return m_FormCheckIn;
            }
        }

        public FormLogIn LoginForm
        {
            get
            {
                if (m_FormLogin == null)
                {
                    m_FormLogin = new FormLogIn();
                }

                return m_FormLogin;
            }
        }

        private AppManager(){ } 

        public User LoggedInUser
        {
            get
            {
                if (m_LoginResult != null)
                {
                    return m_LoginResult.LoggedInUser;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Login()
        {
            try
            {
                m_LoginResult = FacebookWrapper.FacebookService.Login(
                                                            AppId,
                                                            "email",
                                                             "public_profile",
                                                             "publish_to_groups",
                                                             "groups_access_member_info",
                                                             "publish_to_groups",
                                                             "pages_read_engagement",
                                                             "pages_manage_posts");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed: " + ex.Message);
            }
        }

        public void Logout()
        {
            try
            {
                FacebookService.Logout(null, AppId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed: " + ex.Message);
            }
            finally
            {
                m_FormMain = null;
                m_FormCheckIn = null;
                m_FormFriendRater = null;
                m_FormSettings = null;
            }
        }

        public void ReturnToMainForm(Point i_Location)
        {
            MainForm.StartPosition = FormStartPosition.Manual;
            MainForm.Location = i_Location;
            MainForm.Show();
        }
    }
}