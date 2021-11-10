﻿using PingPong3.Patterns.Command;
using PingPong3.Patterns.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong3.Forms
{
    public abstract class PongForm : Form
    {
        public BallItem _ball;
        public int _level;
        //---command----
        public GameController _commandController;
        public int playerSelfScore;
        public int playerOtherScore;
        public int _playerSelfIndex;
        protected Background background;

        public abstract int GenerateBallX();
        public abstract int GenerateBallY();
        public abstract void notifyResetBallSignal(int velocityX, int velocityY);
        public abstract void SendScoreSignal(int score, int player);

        public Background Background
        {
            set { background = value; }
        }

        public virtual void setBackgroundTheme()
        {
            background.setBackgroundTheme();
        }
    }
}