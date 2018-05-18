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
    public partial class MainMenu : Form
    {       public string player1Name;
            public string player2Name;
            public int player1Difficulty;
            public int player2Difficulty;
            public Boolean allowPlay = false;
            public Boolean loginOne = false;
            public Boolean loginTwo = false;
            public List<Player> playerList;
            public Player player1 = null;
            public Player player2 = null;

        public MainMenu()
        {
            InitializeComponent();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            PlayerSerialize.DeserializePlayer(ref playerList);
            if (playerList == null)
            {
                playerList = new List<Player>();
                playerList.Add(new Player("Jose", "123456", 4, 5, 7));
                playerList.Add(new Player("Jason", "123456", 8, 3, 1));
                playerList.Add(new Player("Ana", "123456", 6, 2, 2));
                playerList.Add(new Player("Luis", "123456", 5, 3, 4));
                playerList.Add(new Player("Mir", "123456", 7, 5, 7));
                PlayerSerialize.SerializePlayer(playerList);
            }
        }            

        private void labelXName_Click(object sender, EventArgs e)
        {

        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (loginOne == true || loginTwo == true)
            {
                //Player player1 = new Player('x', player1Name, true, player1Difficulty);
                //Player player2 = new Player('o', player2Name, false, player2Difficulty);
                player1.token = 'x';
                player1.turn = true;
                player2.token = 'o';
                player2.turn = false;
                Board openBoard = new Board(player1, player2);
                openBoard.Show();

            }

        }

        private void buttonXLogin_Click(object sender, EventArgs e)
        {
            Boolean allowLogin = false;
            Login login = null;
            if (comboBoxXDifficulty.Text == "Player")
            {
                if (textBoxXName.Text.Equals("Guest"))
                {
                    player1Name = textBoxXName.Text;
                    player1 = new Player("Guest", "", 0, 0, 0);
                    player1.difficulty = 0;
                    allowLogin = true;
                }
                else
                {
                    login = new Login(textBoxXName.Text, textBoxXPassword.Text);
                    if (login.checkCredentials(ref player1, playerList) == true)
                    {
                        player1.difficulty = 0;
                        allowLogin = true;

                    }
                    else
                    {
                        allowLogin = false;
                    }
                }
                //player1Difficulty = 0;
                //allowLogin = true;
            }
            else if (comboBoxXDifficulty.Text == "AI Easy")
            {

                player1 = new Player("AI Easy", "", 0, 0, 0);
                player1.difficulty = 1;
                textBoxXName.Text = "AI Easy";
                allowLogin = true;
            }
            else if (comboBoxXDifficulty.Text == "AI Medium")
            {
                player1 = new Player("AI Medium", "", 0, 0, 0);
                player1.difficulty = 2;
                textBoxXName.Text = "AI Medium";
                allowLogin = true;
            }
            else if (comboBoxXDifficulty.Text == "AI Hard")
            {
                player1 = new Player("AI Hard", "", 0, 0, 0);
                player1.difficulty = 3;
                textBoxXName.Text = "AI Hard";
                allowLogin = true;
            }
            else MessageBox.Show("Must select difficulty before continuing");
            if (allowLogin == true)
            {
                //player1Name = textBoxXName.Text;
                MessageBox.Show("Login Succesfull");
                loginOne = true;
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void buttonOLogin_Click(object sender, EventArgs e)
        {
            Boolean allowLogin = false;
            Login login = null;
            if (comboBoxODifficulty.Text == "Player")
            {
                if (textBoxOName.Text.Equals("Guest"))
                {
                    player2Name = textBoxOName.Text;
                    player2 = new Player("Guest", "", 0, 0, 0);
                    player2.difficulty = 0;
                    allowLogin = true;
                }
                else
                {
                    login = new Login(textBoxOName.Text, textBoxOPassword.Text);
                    if (login.checkCredentials(ref player2, playerList) == true)
                    {
                        player2.difficulty = 0;
                        allowLogin = true;

                    }
                    else
                    {
                        allowLogin = false;
                    }
                }
                //player2Difficulty = 0;
                //allowLogin = true;
            }
            else if (comboBoxODifficulty.Text == "AI Easy")
            {
                player2 = new Player("AI Easy", "", 0, 0, 0);
                player2.difficulty = 1;
                textBoxOName.Text = "AI Easy";
                allowLogin = true;
            }
            else if (comboBoxODifficulty.Text == "AI Medium")
            {
                player2 = new Player("AI Medium", "", 0, 0, 0);
                player2.difficulty = 2;
                textBoxOName.Text = "AI Medium";
                allowLogin = true;
            }
            else if (comboBoxODifficulty.Text == "AI Hard")
            {
                player2 = new Player("AI Hard", "", 0, 0, 0);
                player2.difficulty = 3;
                textBoxOName.Text = "AI Hard";
                allowLogin = true;
            }
            else MessageBox.Show("Must select difficulty before continuing");
            if (allowLogin == true)
            {
                //player2Name = textBoxOName.Text;
                MessageBox.Show("Login Succesfull");
                loginTwo = true;
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            HighScoreForm f = new HighScoreForm(playerList);
            f.ShowDialog();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayerSerialize.SerializePlayer(playerList);
        }
    }
}
