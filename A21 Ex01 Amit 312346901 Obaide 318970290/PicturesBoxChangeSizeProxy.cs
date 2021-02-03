using System;
using System.Windows.Forms;
using System.Drawing;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
     public class PicturesBoxChangeSizeProxy : PictureBox
     {
          protected override void OnMouseEnter(EventArgs e)
          {
               base.OnMouseEnter(e);
               this.Dock = System.Windows.Forms.DockStyle.Fill;
          }

          protected override void OnMouseLeave(EventArgs e)
          {
               base.OnMouseLeave(e);
               this.Dock = System.Windows.Forms.DockStyle.None;
               this.Anchor = System.Windows.Forms.AnchorStyles.None;
          }
     }
}