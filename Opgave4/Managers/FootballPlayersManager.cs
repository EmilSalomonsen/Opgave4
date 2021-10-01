using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskStudieAktivitetsOpgave;

namespace Opgave4.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer {Id = _nextId++, Name = "Emil", Price = 100, ShirtNumber = 10},
            new FootballPlayer {Id = _nextId++, Name = "Kasper", Price = 100, ShirtNumber = 11},
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(footballplayer => footballplayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFootballPlayer)
        {
            newFootballPlayer.Id = _nextId++;
            Data.Add(newFootballPlayer);
            return newFootballPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballplayer = Data.Find(footballplayer1 => footballplayer1.Id == id);
            if (footballplayer == null) return null;
            Data.Remove(footballplayer);
            return footballplayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer footballplayer = Data.Find(footballplayer1 => footballplayer1.Id == id);
            if (footballplayer == null) return null;
            footballplayer.Name = updates.Name;
            footballplayer.ShirtNumber = updates.ShirtNumber;
            return footballplayer;
        }
    }
}
