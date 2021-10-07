﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong3.Patterns.Factory
{
    public class WallFactory
    {
        public Wall MakeWall(int randomNumber)
        {

            if (randomNumber == 0)
            {
                return new Speed();

            }
            else if (randomNumber == 1)
            {
                return new Explode();
            }
            else if (randomNumber == 3)
            {
                return new Split();
            }
            else return null;
        }
    }
}
