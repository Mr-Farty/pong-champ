﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong3.Patterns.AbstractFactory
{
    public abstract class PowerUpFactory
    {
        protected abstract PowerUp MakePowerUp(int TypeOfPowerUp);
        public PowerUp OrderPowerUp(int TypeOfPowerUp)
        {
            PowerUp ThePowerUp = MakePowerUp(TypeOfPowerUp);

            ThePowerUp.MakePowerUp();
            //Random rand = new Random(); //later for adding random positions for powerups
            //int i = rand.Next(7);
            //ThePowerUp.SetData(new Point(792 - (30 * i), -90 + (30 * i)));

                return ThePowerUp;
        }
    }
}
