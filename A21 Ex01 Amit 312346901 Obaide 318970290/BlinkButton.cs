using System.Windows.Forms;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
     public class BlinkButton : Button
     {
          private ControlBlinker m_ControlBlinker = new ControlBlinker();

          public void Blink()
          {
               m_ControlBlinker.Blink(this);
          }
     }
}
