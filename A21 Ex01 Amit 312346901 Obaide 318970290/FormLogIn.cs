using System;
using System.Windows.Forms;

namespace FaceLikers
{
     public partial class FormLogIn : Form
     {
          private AppManager m_AppManager;

          public FormLogIn()
          {
               InitializeComponent();
          }

          private void buttonLogin_Click(object sender, EventArgs e)
          {
               m_AppManager = AppManager.Instance;
               try
               {
                    m_AppManager.Login();
                    BlinkButton button = this.buttonLogin as BlinkButton;
                    button.Blink();
                    this.Hide();
                    m_AppManager.MainForm.StartPosition = FormStartPosition.Manual;
                    m_AppManager.MainForm.Location = this.Location;
                    m_AppManager.MainForm.Show();
               }
               catch(Exception ex)
               {
                    MessageBox.Show("Operation Failed: " + ex.Message);
               }
          }
     }
}