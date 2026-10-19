using System;
using System.Collections.Generic;
using System.Text;

namespace Lk3
{
    internal class Team
    {
        private List<Player> _players;
        
        public Team()
        {
            _players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            _players.Remove(player);
        }
    }
}
