using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class HighScoreForm : Form
    {
        private HighScore h;
        public HighScoreForm()
        {
            InitializeComponent();
        }
        public HighScoreForm(List<Player> p)
        {
            InitializeComponent();
            h = new HighScore(p);
            PopulateScores();
        }

        public void PopulateScores()
        {
            h.SetScores(ref highscoreBox);
            highscoreBox.FullRowSelect = true;
        }
    }
}
