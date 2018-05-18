using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToe
{
    class HighScore
    {
        public List<Player> p;

        public HighScore()
        {
            p = null;
        }

        public HighScore(List<Player> p1)
        {
            p = p1.OrderByDescending(o => o.wins).ToList();
        }

        public void SetScores(ref ListView lview)
        {
            foreach (Player pl in p)
            {
                ListViewItem item = new ListViewItem(new String [] { pl.name, pl.wins.ToString(), pl.losses.ToString(), pl.draws.ToString()});
                lview.Items.Add(item);
            }
        }
    }
}
