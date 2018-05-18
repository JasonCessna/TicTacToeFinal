using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Login
    {
        public String name { get; set; }
        public String password { get; set; }
        public bool isCorrect { get; set; }
        public int priviliges { get; set; }

        public Login() { }

        public Login(String name, String password)
        {
            this.name = name;
            this.password = password;
        }

        public bool checkCredentials(ref Player p, List<Player> pList)
        {
            foreach (Player players in pList)
            {
                if (players.name.Equals(name))
                {
                    if (players.password.Equals(password))
                    {
                        p = players;
                        isCorrect = true;
                        break;
                    }
                }
                isCorrect = false;
            }
            return isCorrect;
        }
    }
}
