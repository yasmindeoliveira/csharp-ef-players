using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    [Table("Player")]
    public class Player
    {
        public int playerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Score { get; set; }
        public int NumberOfGamesPlayed { get; set; }
        public int NumberOfGamesWon { get; set; }

    }
}
