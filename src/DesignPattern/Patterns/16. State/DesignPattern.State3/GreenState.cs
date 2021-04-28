﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPattern.State3
{
    public class GreenState : TrafficLightState
    {
        public override void Handle(TrafficLight light)
        {
            Console.WriteLine("绿灯行");
            light.SetState(new YellowState());
        }
    }
}
