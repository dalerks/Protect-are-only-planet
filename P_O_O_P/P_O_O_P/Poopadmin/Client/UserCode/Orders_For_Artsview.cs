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
    public partial class Orders_For_Artsview
    {
        partial void Mark_Sent_Execute()
        {
           

            foreach (Order_Detail detail in  this.DataWorkspace.poopstatsData.Order_Details)
            {
                if (detail.OrderDetailID== this.Orders_For_Arts.SelectedItem.OrderDetailID)
                {
                    detail.Sent = 9999;
                }
            }
            this.Save();

        }
    }
}
