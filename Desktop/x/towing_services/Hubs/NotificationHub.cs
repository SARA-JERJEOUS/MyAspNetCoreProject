﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace towing_services.Hubs
{

    public class NotificationHub : Hub
    {
      
            public async Task SendNotification(string message)
            {
                await Clients.All.SendAsync("ReceiveNotification", message);
            }
        }
    }

