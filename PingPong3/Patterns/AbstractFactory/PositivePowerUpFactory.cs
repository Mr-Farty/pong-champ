using PingPong3.Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong3.Patterns.AbstractFactory
{
    public class PositivePowerUpFactory : PowerUpFactory
    {


        protected override PowerUp MakePowerUp(int typeOfPowerup, IMediator medi)
        {
            PowerUp thePowerUp = null;
            if (typeOfPowerup.Equals(0))
            {
                thePowerUp = new PositiveSplitPowerUp(medi);
                //thePowerUp.SetData(new Point(100, 384), new Size(50, 50), Color.White); //later for random spawn position
            }
            else if (typeOfPowerup.Equals(1))
            {
                thePowerUp = new PositiveSpeedPowerUp(medi);
                //thePowerUp.SetData(new Point(100, 384), new Size(50, 50), Color.White); //later for random spawn position
            }
            else if (typeOfPowerup.Equals(2))
            {
                thePowerUp = new PositiveSoftnessPowerUp(medi);
                //thePowerUp.SetData(new Point(100, 384), new Size(50, 50), Color.White); //later for random spawn position
            }
            return thePowerUp;
        }
    }
}
