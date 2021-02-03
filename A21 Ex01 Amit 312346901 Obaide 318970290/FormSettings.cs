using System;
using System.Drawing;
using System.Windows.Forms;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public partial class FormSettings : Form
    {
        public event Action<Color> BackColorChangedListeners;

        public event Action<Font> FontChangedListeners;

        private Font m_DefaultFont;
        private Color m_DefaultBackGroundColor;

        public FormSettings()
        {
            InitializeComponent();
            m_DefaultBackGroundColor  = Color.FromArgb(153, 180, 209);
            m_DefaultFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            currentBackColor.BackColor = m_DefaultBackGroundColor;
            updateLablesFont(m_DefaultFont);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColorChangedListeners?.Invoke(colorDialog1.Color);
                currentBackColor.BackColor = colorDialog1.Color;
            }
        }

        private void updateLablesFont(Font i_Font)
        {
            colorLabel.Font = i_Font;
            currentFontLabel.Font = i_Font;
            currentFont.Text = i_Font.Name + " " + i_Font.Size;
            currentFont.Text += i_Font.Bold ? " Bold" : " Normal";
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                FontChangedListeners?.Invoke(fontDialog1.Font);
                updateLablesFont(fontDialog1.Font);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            FontChangedListeners?.Invoke(m_DefaultFont);
            updateLablesFont(m_DefaultFont);
            BackColorChangedListeners?.Invoke(m_DefaultBackGroundColor);
            currentBackColor.BackColor = m_DefaultBackGroundColor;
        }
    }
}