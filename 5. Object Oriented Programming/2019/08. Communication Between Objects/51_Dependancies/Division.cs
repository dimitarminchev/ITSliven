﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class Division : IStrategy
    {
        public int Calculate(int first, int second)
        {
            return first / second;
        }
    }
}
