using System.Windows.Forms;

namespace FaceLikers
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
