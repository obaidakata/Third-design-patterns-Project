using System.Windows.Forms;

namespace FaceLikers
{
     public class BlinkLabel : Label
     {
          private ControlBlinker m_ControlBlinker = new ControlBlinker();

          public void Blink()
          {
               m_ControlBlinker.Blink(this);
          }
     }
}