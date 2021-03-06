﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    public delegate Player InstantiatePlayer(string name, int seat);

    public class TournamentEntrant
    {
        public string name;
        public int score;
        private InstantiatePlayer playerGenerator;

        public TournamentEntrant(string name, InstantiatePlayer playerGenerator)
        {
            this.name = name;
            this.playerGenerator = playerGenerator;
            score = 0;
        }

        public Player GetPlayer(int seat)
        {
            return playerGenerator.Invoke(name, seat);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
