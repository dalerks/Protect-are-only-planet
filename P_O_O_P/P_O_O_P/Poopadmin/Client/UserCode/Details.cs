using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class Details
    {
        partial void Sync_Execute()
        {
            try
            {
                ServiceReference1.Service1Client poop = new ServiceReference1.Service1Client();
                poop.UpdateAsync();
                this.Refresh();
            }
            catch (Exception e)
            {
            }

        }
    }
}
