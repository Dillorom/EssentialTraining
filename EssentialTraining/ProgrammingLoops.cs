﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class ProgrammingLoops
    {
        public int ForLoop()
        {
            var sum = 0;
            for(var i = 0; i < 100; i++)
            {
                sum= sum +1 ;
            }
            return sum;
        }
    }
}