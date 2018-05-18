using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    [Serializable()]
   public class Player
    {
        public char token { get; set; }
        public string name { get; set; }
        public Boolean turn { get; set; }
        public int difficulty { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int draws { get; set; }
        public String password { get; set; }

        public char Token
        {
            get { return token; }
            set { token = Convert.ToChar(value); }
        }
        public string Name
        {
            get { return name; }
            set { name = value.ToString(); }
        }
        public Boolean Turn
        {
            get { return turn; }
            set { turn = Convert.ToBoolean(value); }
        }
        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        public Player(char a, string b, Boolean c, int d)
        {
            token = a;
            name = b;
            turn = c;
            difficulty = d;

        }

        public Player(String name, String password, int wins, int losses, int draws)
        {
            this.name = name;
            this.password = password;
            this.wins = wins;
            this.losses = losses;
            this.draws = draws;
        }

        public void play()
        {
            
            
        }
    }

}
