using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceLikers
{
    public partial class FormCheckInRecommendation : FormThatListen
    {
        private string m_Location;
        private AppManager m_AppManager;
        private string[] m_ButtonsNames;
        private eURLType m_LastURLType;

        public FormCheckInRecommendation()
        {
            InitializeComponent();
            m_AppManager = AppManager.Instance;
            webBrowser.ScriptErrorsSuppressed = true;
            splitContainer1.Dock = DockStyle.Fill;
            m_ButtonsNames = URLFactory.GetSupportedURLTypes();
            createButtons(); 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_AppManager.ReturnToMainForm(this.Location);
        }

        private void createButtons()
        {
            buttonsRow.ColumnCount = m_ButtonsNames.Length;
            buttonsRow.ColumnStyles.Clear();
            int width = 100 / buttonsRow.ColumnCount;
            foreach (string buttonName in m_ButtonsNames)
            {
                Button buttonToAdd = new Button();
                buttonToAdd.Text = buttonName;
                buttonToAdd.Click += button_Click;
                buttonToAdd.Dock = DockStyle.Fill;
                buttonsRow.Controls.Add(buttonToAdd);
                buttonsRow.ColumnStyles.Add(new ColumnStyle { SizeType = SizeType.Percent, Width = width });
            }
        }

        private void fetchCheckIns()
        {
            try
            {
                foreach (Checkin checkIn in m_AppManager.LoggedInUser.Checkins)
                {
                    if (checkIn.Place != null && !listBoxCheckIns.Items.Contains(checkIn.Place.Name))
                    {
                        listBoxCheckIns.Items.Add(checkIn.Place.Name);
                    }
                }
                listBoxCheckIns.Items.Add("Berlin");
                listBoxCheckIns.Items.Add("Tel aviv");
                listBoxCheckIns.Items.Add("Haifa");

                if (listBoxCheckIns.Items.Count == 0)
                {
                    checkInLable.Text = "No checkIn to show";
                }
                else
                {
                    listBoxCheckIns.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Failed: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox)
            {
                m_Location = (sender as ListBox).Text.Replace(' ', '+');
                refreshPage();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button senderAsButton = sender as Button;
                eURLType type;
                if (Enum.TryParse<eURLType>(senderAsButton.Text, out type))
                {
                    m_LastURLType = type;
                    refreshPage();
                }
            }
        }

        private void refreshPage()
        {
            IURL urlX = URLFactory.CreateURL(m_LastURLType);
            Uri url = urlX.GetURL(m_Location);
            webBrowser.Navigate(url);
        }

        private void FormCheckInRecommendation_Shown(object sender, EventArgs e)
        {
            fetchCheckIns();
        }
    }
}