﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigeon.Messaging
{
    public class ActorAction
    {
        public Action Action { get; set; }
    }

    public class Ping 
    {
        public DateTime LocalUtcNow { get; set; }
    }

    public class Pong 
    {
        public DateTime LocalUtcNow { get; set; }
        public DateTime RemoteUtcNow { get; set; }
    }

    public class Kill 
    {
    }
}
