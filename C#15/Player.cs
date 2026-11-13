using System;
using System.Collections.Generic;
using System.Text;

namespace C_15
{
    internal class Player
    {
        public string Name;
        public int Score;
        public bool IsActive;

        public Player(string name, int score, bool isActive)
        {
            Name = name;
            Score = score;
            IsActive = isActive;
        }
    }
}
