﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace FaceLikers
{
     public class ControlBlinker
     {
          public void Blink(Control i_Control)
          {
               i_Control.Visible = false;
               System.Threading.Thread.Sleep(750);
               i_Control.Visible = true;
          }
     }
}