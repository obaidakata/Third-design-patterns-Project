using System.Drawing;
using System.Windows.Forms;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public class FormThatListen : Form
    {
        private AppManager m_AppManager;

        public FormThatListen()
        {
            m_AppManager = AppManager.Instance;
            m_AppManager.SettingsForm.BackColorChangedListeners += colorChanged;
            m_AppManager.SettingsForm.FontChangedListeners += fontChanged;
        }

        private void colorChanged(Color i_Color)
        {
            this.BackColor = i_Color;
        }

        private void fontChanged(Font i_Font)
        {
            foreach (Control control in Controls[0].Controls)
            {
                changeControlsFont(control, i_Font);
            }
        }

        private void changeControlsFont(Control i_Control, Font i_Font)
        {
            foreach (Control innerControl in i_Control.Controls)
            {
                if(innerControl.Controls.Count > 1)
                {
                    changeControlsFont(innerControl, i_Font);
                }
                else
                {
                    innerControl.Font = i_Font;
                }
            }
        }
    }
}