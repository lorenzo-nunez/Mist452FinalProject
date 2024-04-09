using System.ComponentModel;

namespace Mist452FinalProject.Models
{
    public class Game
    {
        public int GameID { get; set; }

        [DisplayName("Game Date: ")]

        public string opponent { get; set; }

        public string score { get; set; }

        public int posessionStat { get; set; }

        public int shotsStat { get; set; }
        public int SavesStat { get; set; }
        public int foulsStat { get; set; }
        public int filmURL { get; set; }
    }
}
