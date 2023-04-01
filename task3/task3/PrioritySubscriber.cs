﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace task3
{
    class PrioritySubscriber
    {
        public int Priority { get; set; }

        public PrioritySubscriber(int priority)
        {
            Priority = priority;
        }
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Priority {Priority} subscriber handling event");
        }
    }
}
