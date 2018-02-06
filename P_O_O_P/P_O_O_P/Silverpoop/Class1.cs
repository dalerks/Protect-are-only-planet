using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Silverpoop
{
    public static class PoopClass
    {
        public static void update()
        {
            ServiceReference1.Service1Client poop = new ServiceReference1.Service1Client();
            poop.UpdateAsync();
            
          
        }
    }
}
