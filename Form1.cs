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
    public partial class Form1 : Form
    {          
            //declare booleans
        bool isLocked = true; //IF START BUTTON HASN'T BEEN PUSHED, BUTTONS ARE NOT PLAYABLE
        bool isThreat = false; //IF DEFENSIVE THREAT IS GREATER THAN OFFENSIVE OPPORTUNITY
        bool turn = true; //TRUE == X TURN; FALSE == O TURN
        bool custColor1 = false;  //if player chose a custom color for player 1
        bool custColor2 = false;  //if player chose a custom color for player 2
        int turnCount = 0;
        private NameList nameList;
        string player1Name = "Player 1";    //Player 1's default name
        string player2Name = "Player 2";    //Player 2's default name
        int score1 = 0;     //Player 1's score
        int score2 = 0;     //Player 2's score
        int gameMode = 0;   //GAME MODE: 0 = PvP, 1 = vsEasy, 2 = vsMedium, 3 = vsHard

        public Form1()
        {
            InitializeComponent();      
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isLocked == false)
            {
                
                    if (turn)                //check player's turn
                    {
                        b.Text = "X";        //change box's text
                        b.BackColor = System.Drawing.Color.SlateBlue; //default X color
                        b.Tag = "X";

                    }
                    else
                    {
                        b.Text = "O";        //change box's text
                        b.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                        b.Tag = "O";
                    }
                    ChangeColors(this);  //Check for custom color option and change defaults
                    turn = !turn;           //change turn
                    b.Enabled = false;      //turn button off
                    checkForWinner();       //check rows, columns, and diagnols
                    aiScanner(gameMode);

               }
               else MessageBox.Show("Press \"START\" to begin!");


        }

        private void aiScanner(int a)
        {
            
                int horAThreat = 0;
                int horAOpportunity = 0;
                int horBThreat = 0;
                int horBOpportunity = 0;
                int horCThreat = 0;
                int horCOpportunity = 0;
                int horDThreat = 0;
                int horDOpportunity = 0;
                bool checkNext = true;
                //check horizontal first
                //ROW A

                if (turnCount == 1)
                    if (b1.Text == "X")
                    {
                        a1.Text = "O";        //change box's text
                        a1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                        a1.Tag = "O";
                        turn = !turn;           //change turn
                        a1.Enabled = false;      //turn button off
                        checkForWinner();
                    }
                    else
                    {
                        b1.Text = "O";        //change box's text
                        b1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                        b1.Tag = "O";
                        turn = !turn;           //change turn
                        b1.Enabled = false;      //turn button off
                        checkForWinner();
                    }
                    if (turn == false)
                       {
                //A
                if (a1.Text == "X")
                    horAThreat++;
                else if (a1.Text == "O")
                    horAOpportunity++;
                if (a2.Text == "X")
                    horAThreat++;
                else if (a2.Text == "O")
                    horAOpportunity++;
                if (a3.Text == "X")
                    horAThreat++;
                else if (a3.Text == "O")
                    horAOpportunity++;
                if (a4.Text == "X")
                    horAThreat++;
                else if (a4.Text == "O")
                    horAOpportunity++;
                //B
                if (b1.Text == "X")
                    horBThreat++;
                else if (b1.Text == "O")
                    horBOpportunity++;
                if (b2.Text == "X")
                    horBThreat++;
                else if (b2.Text == "O")
                    horBOpportunity++;
                if (b3.Text == "X")
                    horBThreat++;
                else if (b3.Text == "O")
                    horBOpportunity++;
                if (b4.Text == "X")
                    horBThreat++;
                else if (b4.Text == "O")
                    horBOpportunity++;
                //C
                if (c1.Text == "X")
                    horCThreat++;
                else if (c1.Text == "O")
                    horCOpportunity++;
                if (c2.Text == "X")
                    horCThreat++;
                else if (c2.Text == "O")
                    horCOpportunity++;
                if (c3.Text == "X")
                    horCThreat++;
                else if (c3.Text == "O")
                    horCOpportunity++;
                if (c4.Text == "X")
                    horCThreat++;
                else if (c4.Text == "O")
                    horCOpportunity++;
                //D
                if (d1.Text == "X")
                    horDThreat++;
                else if (d1.Text == "O")
                    horDOpportunity++;
                if (d2.Text == "X")
                    horDThreat++;
                else if (d2.Text == "O")
                    horDOpportunity++;
                if (d3.Text == "X")
                    horDThreat++;
                else if (d3.Text == "O")
                    horDOpportunity++;
                if (d4.Text == "X")
                    horDThreat++;
                else if (d4.Text == "O")
                    horDOpportunity++;
                



                if (a1.Text == a2.Text)
                {
                    if (a1.Text == "X")
                        horAThreat++;
                    else horAOpportunity++;
                }
                if (a2.Text == a3.Text)
                {
                    if (a2.Text == "X")
                        horAThreat++;
                    else horAOpportunity++;
                }
                if (a3.Text == a4.Text)
                {
                    if (a3.Text == "X")
                        horAThreat++;
                    else horAOpportunity++;
                }
               // if (horAOpportunity > 1 || horAThreat > 1)
                   // checkNext = false;

               
                    //ROW B
                    if (b1.Text == b2.Text)
                    {
                        if (b1.Text == "X")
                            horBThreat++;
                        else horBOpportunity++;
                    }
                    if (b2.Text == b3.Text)
                    {
                        if (b2.Text == "X")
                            horBThreat++;
                        else horBOpportunity++;
                    }
                    if (b3.Text == b4.Text)
                    {
                        if (b3.Text == "X")
                            horBThreat++;
                        else horBOpportunity++;
                    }
                
            
                    //ROW C
                    if (c1.Text == c2.Text)
                    {
                        if (c1.Text == "X")
                            horCThreat++;
                        else horCOpportunity++;
                    }
                    if (c2.Text == c3.Text)
                    {
                        if (c2.Text == "X")
                            horCThreat++;
                        else horCOpportunity++;
                    }
                    if (c3.Text == c4.Text)
                    {
                        if (c3.Text == "X")
                            horCThreat++;
                        else horCOpportunity++;
                    }
                
                //ROW D
                
                    if (d1.Text == d2.Text)
                    {
                        if (d1.Text == "X")
                            horDThreat++;
                        else horDOpportunity++;
                    }
                    if (d2.Text == d3.Text)
                    {
                        if (d2.Text == "X")
                            horDThreat++;
                        else horDOpportunity++;
                    }
                    if (d3.Text == d4.Text)
                    {
                        if (d3.Text == "X")
                            horDThreat++;
                        else horDOpportunity++;
                    }
                














                if (a == 1)
                {////////threat dominates opportunity only if it's greater
                    if (a1.Enabled == false && a2.Enabled == false && a3.Enabled == false && a4.Enabled == false)
                    {
                        horAThreat = 0;
                        horAOpportunity = 0;
                    }
                    if (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false && b4.Enabled == false)
                    {
                        horBThreat = 0;
                        horBOpportunity = 0;
                    }
                    if (c1.Enabled == false && c2.Enabled == false && c3.Enabled == false && c4.Enabled == false)
                    {
                        horCThreat = 0;
                        horCOpportunity = 0;
                    }
                    if (d1.Enabled == false && d2.Enabled == false && d3.Enabled == false && d4.Enabled == false)
                    {
                        horDThreat = 0;
                        horDOpportunity = 0;
                    }




                    if (horAThreat < horAOpportunity || horBThreat < horBOpportunity || horCThreat < horCOpportunity || horDThreat < horDOpportunity ||
                        horAThreat == horAOpportunity || horBThreat == horBOpportunity || horCThreat == horCOpportunity || horDThreat == horDOpportunity)
                    {
                        if (horAOpportunity > horBOpportunity && horAOpportunity > horCOpportunity && horAOpportunity > horBOpportunity)
                        {
                            if (a1.Text != "X" && a1.Text != "O")
                            {
                                a1.Text = "O";        //change box's text
                                a1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a1.Tag = "O";
                                turn = !turn;           //change turn
                                a1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (a2.Text != "X" && a2.Text != "O")
                            {
                                a2.Text = "O";        //change box's text
                                a2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a2.Tag = "O";
                                turn = !turn;           //change turn
                                a2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (a3.Text != "X" && a3.Text != "O")
                            {
                                a3.Text = "O";        //change box's text
                                a3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a3.Tag = "O";
                                turn = !turn;           //change turn
                                a3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (a4.Text != "X" && a4.Text != "O")
                            {
                                a4.Text = "O";        //change box's text
                                a4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a4.Tag = "O";
                                turn = !turn;           //change turn
                                a4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                        else if (horBOpportunity > horAOpportunity && horBOpportunity > horCOpportunity && horBOpportunity > horDOpportunity)
                        {
                            if (b1.Text != "X" && b1.Text != "O")
                            {
                                b1.Text = "O";        //change box's text
                                b1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b1.Tag = "O";
                                turn = !turn;           //change turn
                                b1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (b2.Text != "X" && b2.Text != "O")
                            {
                                b2.Text = "O";        //change box's text
                                b2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b2.Tag = "O";
                                turn = !turn;           //change turn
                                b2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (b3.Text != "X" && b3.Text != "O")
                            {
                                b3.Text = "O";        //change box's text
                                b3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b3.Tag = "O";
                                turn = !turn;           //change turn
                                b3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (b4.Text != "X" && b4.Text != "O")
                            {
                                b4.Text = "O";        //change box's text
                                b4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b4.Tag = "O";
                                turn = !turn;           //change turn
                                b4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                        else if (horCOpportunity > horAOpportunity && horCOpportunity > horBOpportunity && horCOpportunity > horDOpportunity)
                        {
                            if (c1.Text != "X" && c1.Text != "O")
                            {
                                c1.Text = "O";        //change box's text
                                c1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c1.Tag = "O";
                                turn = !turn;           //change turn
                                c1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (c2.Text != "X" && c2.Text != "O")
                            {
                                c2.Text = "O";        //change box's text
                                c2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c2.Tag = "O";
                                turn = !turn;           //change turn
                                c2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (c3.Text != "X" && c3.Text != "O")
                            {
                                c3.Text = "O";        //change box's text
                                c3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c3.Tag = "O";
                                turn = !turn;           //change turn
                                c3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (c4.Text != "X" && c4.Text != "O")
                            {
                                c4.Text = "O";        //change box's text
                                c4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c4.Tag = "O";
                                turn = !turn;           //change turn
                                c4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                        else if (horDOpportunity > horAOpportunity && horDOpportunity > horBOpportunity && horDOpportunity > horCOpportunity)
                        {
                            if (d1.Text != "X" && d1.Text != "O")
                            {
                                d1.Text = "O";        //change box's text
                                d1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d1.Tag = "O";
                                turn = !turn;           //change turn
                                d1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (d2.Text != "X" && d2.Text != "O")
                            {
                                d2.Text = "O";        //change box's text
                                d2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d2.Tag = "O";
                                turn = !turn;           //change turn
                                d2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (d3.Text != "X" && d3.Text != "O")
                            {
                                d3.Text = "O";        //change box's text
                                d3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d3.Tag = "O";
                                turn = !turn;           //change turn
                                d3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (d4.Text != "X" && d4.Text != "O")
                            {
                                d4.Text = "O";        //change box's text
                                d4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d4.Tag = "O";
                                turn = !turn;           //change turn
                                d4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            if (turn == false) aiScanner(gameMode);
                        }
                    }/////////////////IF THREAT IS GREATER
                    else
                    {
                        if (horAThreat > horBThreat && horAThreat > horCThreat && horAThreat > horBThreat)
                        {
                            if (a1.Text != "X" && a1.Text != "O")
                            {
                                a1.Text = "O";        //change box's text
                                a1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a1.Tag = "O";
                                turn = !turn;           //change turn
                                a1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (a2.Text != "X" && a2.Text != "O")
                            {
                                a2.Text = "O";        //change box's text
                                a2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a2.Tag = "O";
                                turn = !turn;           //change turn
                                a2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (a3.Text != "X" && a3.Text != "O")
                            {
                                a3.Text = "O";        //change box's text
                                a3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a3.Tag = "O";
                                turn = !turn;           //change turn
                                a3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (a4.Text != "X" && a4.Text != "O")
                            {
                                a4.Text = "O";        //change box's text
                                a4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                a4.Tag = "O";
                                turn = !turn;           //change turn
                                a4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                        else if (horBThreat > horAThreat && horBThreat > horCThreat && horBThreat > horDThreat)
                        {
                            if (b1.Text != "X" && b1.Text != "O")
                            {
                                b1.Text = "O";        //change box's text
                                b1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b1.Tag = "O";
                                turn = !turn;           //change turn
                                b1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (b2.Text != "X" && b2.Text != "O")
                            {
                                b2.Text = "O";        //change box's text
                                b2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b2.Tag = "O";
                                turn = !turn;           //change turn
                                b2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (b3.Text != "X" && b3.Text != "O")
                            {
                                b3.Text = "O";        //change box's text
                                b3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b3.Tag = "O";
                                turn = !turn;           //change turn
                                b3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (b4.Text != "X" && b4.Text != "O")
                            {
                                b4.Text = "O";        //change box's text
                                b4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                b4.Tag = "O";
                                turn = !turn;           //change turn
                                b4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                        else if (horCThreat > horAThreat && horCThreat > horBThreat && horCThreat > horDThreat)
                        {
                            if (c1.Text != "X" && c1.Text != "O")
                            {
                                c1.Text = "O";        //change box's text
                                c1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c1.Tag = "O";
                                turn = !turn;           //change turn
                                c1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (c2.Text != "X" && c2.Text != "O")
                            {
                                c2.Text = "O";        //change box's text
                                c2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c2.Tag = "O";
                                turn = !turn;           //change turn
                                c2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (c3.Text != "X" && c3.Text != "O")
                            {
                                c3.Text = "O";        //change box's text
                                c3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c3.Tag = "O";
                                turn = !turn;           //change turn
                                c3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (c4.Text != "X" && c4.Text != "O")
                            {
                                c4.Text = "O";        //change box's text
                                c4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                c4.Tag = "O";
                                turn = !turn;           //change turn
                                c4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                        else if (horDThreat > horAThreat && horDThreat > horBThreat && horDThreat > horCThreat)
                        {
                            if (d1.Text != "X" && d1.Text != "O")
                            {
                                d1.Text = "O";        //change box's text
                                d1.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d1.Tag = "O";
                                turn = !turn;           //change turn
                                d1.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (d2.Text != "X" && d2.Text != "O")
                            {
                                d2.Text = "O";        //change box's text
                                d2.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d2.Tag = "O";
                                turn = !turn;           //change turn
                                d2.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (d3.Text != "X" && d3.Text != "O")
                            {
                                d3.Text = "O";        //change box's text
                                d3.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d3.Tag = "O";
                                turn = !turn;           //change turn
                                d3.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                            else if (d4.Text != "X" && d4.Text != "O")
                            {
                                d4.Text = "O";        //change box's text
                                d4.BackColor = System.Drawing.Color.YellowGreen;  //default O color
                                d4.Tag = "O";
                                turn = !turn;           //change turn
                                d4.Enabled = false;      //turn button off
                                checkForWinner();
                            }
                        }
                    }
                }
                else if (a == 2)
                {/////////threat dominates opportunity only if equal or greater

                }
                else if (a == 3)
                {////////threat always dominates opportunity

                }
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////UPDATE BELOW/////////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void checkForWinner()
        {
            bool isWinner = false; //IF isWinner == TRUE GAME ENDS
            bool isRow = false;    //IF isRow == TRUE, GAME WON BY ROW
            bool isVert = false;   //IF isVert == TRUE, GAME WON BY COLUMN
            bool isDiag = false;   //IF isDiag == TRUE, GAME WON BY DIAGNOL
            bool isDraw = false;   //IF isDraw == TRUE, GAME IS A TIE
            String typeOfWin = "";
            

            isRow = Row();
            isVert = Vert();
            isDiag = Diag();
            isDraw = Draw();

            //isVert = true;
            //check rows
             if (isRow)
            {   
                isWinner = true;
                typeOfWin = "row";
            }
            //check columns
            else if (isVert)
            {
                isWinner = true;
                typeOfWin = "column";
            }
            //check diagnols
            else if (isDiag)
            {
                isWinner = true;
                typeOfWin = "diaganol";
            }
             else if (isDraw)
             {
                 MessageBox.Show("Game ended in a draw.");
             }
            turnCount++;
            if (isWinner)           
            {
                String winner = "";
                                                //REQUESTED: If Player1 can select X or O
                                                //change the following code to compensate
                if (turn)           //CHECK TURN: IF TURN = O, WINNER = X ELSE WINNER = O
                {
                    winner = player2Name + " (O)";      //ADDED: Display selected name + letter
                    score2++;       //add 1 to score (feature added 8/31/15)
                }
                else
                {
                    winner = player1Name + " (X)";      //ADED: Display selected name + letter
                    score1++;      //add 1 to score (feature added 8/31/15)
                }                   //REQUESTED: Score deteriorates after turn amount
                                    //or assign a higher score to certain moves (diagnol 3, column 2, row 1)
                turnCount = (turnCount / 2);    //assign turns individual players made
                MessageBox.Show(winner + " wins with 4-in-a-" + typeOfWin + " in " + turnCount + " moves!");
              
                DisableButtons(this);           //BUG FIXED: DisableButtons called before turn was displayed
                                                //therefor always showing Player 2 (O) as winner
            }

        }

        protected void DisableButtons(Control root)  //BUG FIXED 8/28/15 (WAS TRYING TO CHANGE EVERY CONTROL, NOT JUST BUTTONS) -Jason
        {
            score1Lbl.Text = score1.ToString();      //FEATURE ADDED 8/31/15
            score2Lbl.Text = score2.ToString();      //Update scores after each game finished
            turn = true;                             //BUG FIXED 8/31/15 - RESET TURN TO HAVE X START EVERY GAME
            isLocked = true;                         //BUG FIXED 8/31/15: BOARD WAS NOT RE-LOCKING AFTER VICTORY -Jason
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is Button)
                {
                    ((Control)ctrl).Enabled = false;      //DISABLE BUTTON
                }
                else
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        DisableButtons(ctrl);                           //RECURSIVELY CALL FUNCTION UNTIL ALL BUTTONS ARE DISABLED
                    }
                }
            }
        }


        protected void EnableButtons(Control root) //use with File -> New
        {
            
            int btnCounter = 1;
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is Button)
                {
                    ((Control)ctrl).Enabled = true;  
                    if (((Control)ctrl).Text == "PLAYING!")         //CHECK FOR START BUTTON
                    {
                        ((Control)ctrl).Text = "START";             //REVERT TEXT BACK TO START
                        ((Control)ctrl).BackColor = Color.Lime;     //REVERT START BUTTON COLOR
                    }
                    else if (((Control)ctrl).Text == "START") { }  //IF ACTIVE START BUTTON, DO NOTHING
                    else if (btnCounter % 2 == 0)
                    {
                        ((Control)ctrl).Tag = "";                           //BUG FIXED - REVERT TAG BACK TO NOTHING - Jason 8/31/15
                        ((Control)ctrl).Text = "\\" + (Char)btnCounter;  //CHANGE TEXT TO PREVIOUS BACK-TEXT
                        ((Control)ctrl).BackColor = Color.Silver;        //REVERT BUTTON COLOR
                    }
                    else
                    {
                        ((Control)ctrl).Text = "/ " + (Char)btnCounter;  //CHANGE TEXT TO PREVIOUS BACK-TEXT
                        ((Control)ctrl).BackColor = Color.Silver;        //REVERT BUTTON COLOR
                    }
                    btnCounter++;                                        //KEEP BUTTON COUNTER IN ORDER TO FORCE ALL
                }                                                        //TEXT TO BE DIFFERENT ON EVERY BUTTON
                else
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        EnableButtons(ctrl);                            //RECURSIVELY CALL FUNCTION UNTIL ALL BUTTONS ARE ENABLED
                    }
                }
            }
        }
        //BUGS BELOW:
        //Colors from previous game re-appear -FIXED -Jason
        //Colors changed in game will make whatever color wasn't changed to black -FIXED -Jason
        //Colors will not be changed from default on most-recent play (keep?)
        //Colors will only change X if both X and O are changed; O can only be changed if X isn't --FIXED by erasing the "else" if -Jason 8/31/15
        //ADD-ON REQUEST: After check for winner, change the winning 4 to different 
        protected void ChangeColors(Control root) //use with Edit -> Colors -> Player 1
        {
            if (custColor1 == true)
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is Button)
                {
                    if (((Control)ctrl).Tag == "X")
                    {
                        if(((Control)ctrl).Enabled == false)                //BUG FIXED - COLORS ONLY CHANGE ON CURRENT GAME -Jason 8/31/15
                        ((Control)ctrl).BackColor = colorDialog1.Color;

                    }                                                        //TEXT TO BE DIFFERENT ON EVERY BUTTON
                    /*else if (((Control)ctrl).Tag == "O")
                    {
                        if (((Control)ctrl).Enabled == false)
                        ((Control)ctrl).BackColor = colorDialog2.Color;     //BUG FIXED - COLORS ONLY CHANGED ON CURRENT GAME -Jason 8/31/15
                    }*/
                    else
                    {
                        if (ctrl.Controls.Count > 0)
                        {
                            ChangeColors(ctrl);                            //RECURSIVELY CALL FUNCTION UNTIL ALL BUTTONS ARE ENABLED
                        }
                    }
                }
            }
             if (custColor2 == true)
                foreach (Control ctrl in root.Controls)
                {
                    if (ctrl is Button)
                    {
                        /*if (((Control)ctrl).Tag == "X")
                        {
                            if (((Control)ctrl).Enabled == false)                //BUG FIXED - COLORS ONLY CHANGE ON CURRENT GAME -Jason 8/31/15
                                ((Control)ctrl).BackColor = colorDialog1.Color;

                        }                                                        //TEXT TO BE DIFFERENT ON EVERY BUTTON
                        else*/ if (((Control)ctrl).Tag == "O")
                        {
                            if (((Control)ctrl).Enabled == false)
                                ((Control)ctrl).BackColor = colorDialog2.Color;     //BUG FIXED - COLORS ONLY CHANGED ON CURRENT GAME -Jason 8/31/15
                        }
                        else
                        {
                            if (ctrl.Controls.Count > 0)
                            {
                                ChangeColors(ctrl);                            //RECURSIVELY CALL FUNCTION UNTIL ALL BUTTONS ARE ENABLED
                            }
                        }
                    }
                }
        }

       
        private bool Row()      //ADDED 8/31/15 - Jason: If winning 4, change color
        {                   ///BUG HERE: All buttons starting with a null text field makes this a win every turn?  //BUG FIXED 8/28/15 -Jason
            if (a1.Text == a2.Text && a2.Text == a3.Text && a3.Text == a4.Text)
            {
                a1.BackColor = Color.Crimson;
                a2.BackColor = Color.Crimson;
                a3.BackColor = Color.Crimson;
                a4.BackColor = Color.Crimson;
                return true;
            }
            else if (a5.Text == a2.Text && a2.Text == a3.Text && a3.Text == a4.Text)
            {
                a5.BackColor = Color.Crimson;
                a2.BackColor = Color.Crimson;
                a3.BackColor = Color.Crimson;
                a4.BackColor = Color.Crimson;
                return true;
            }
            else if (b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == b4.Text)
            {
                b1.BackColor = Color.Crimson;
                b2.BackColor = Color.Crimson;
                b3.BackColor = Color.Crimson;
                b4.BackColor = Color.Crimson;
                return true;
            }
            else if (b5.Text == b2.Text && b2.Text == b3.Text && b3.Text == b4.Text)
            {
                b5.BackColor = Color.Crimson;
                b2.BackColor = Color.Crimson;
                b3.BackColor = Color.Crimson;
                b4.BackColor = Color.Crimson;
                return true;
            }
            else if (c1.Text == c2.Text && c2.Text == c3.Text && c3.Text == c4.Text)
            {
                c1.BackColor = Color.Crimson;
                c2.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                c4.BackColor = Color.Crimson;
                return true;
            }
            else if (c5.Text == c2.Text && c2.Text == c3.Text && c3.Text == c4.Text)
            {
                c5.BackColor = Color.Crimson;
                c2.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                c4.BackColor = Color.Crimson;
                return true;
            }
            else if (d1.Text == d2.Text && d2.Text == d3.Text && d3.Text == d4.Text)
            {
                d1.BackColor = Color.Crimson;
                d2.BackColor = Color.Crimson;
                d3.BackColor = Color.Crimson;
                d4.BackColor = Color.Crimson;
                return true;
            }
            else if (d5.Text == d2.Text && d2.Text == d3.Text && d3.Text == d4.Text)
            {
                d5.BackColor = Color.Crimson;
                d2.BackColor = Color.Crimson;
                d3.BackColor = Color.Crimson;
                d4.BackColor = Color.Crimson;
                return true;
            }
            else if (e1.Text == e2.Text && e2.Text == e3.Text && e3.Text == e4.Text)
            {
                e1.BackColor = Color.Crimson;
                e2.BackColor = Color.Crimson;
                e3.BackColor = Color.Crimson;
                e4.BackColor = Color.Crimson;
                return true;
            }
            else if (e5.Text == e2.Text && e2.Text == e3.Text && e3.Text == e4.Text)
            {
                e5.BackColor = Color.Crimson;
                e2.BackColor = Color.Crimson;
                e3.BackColor = Color.Crimson;
                e4.BackColor = Color.Crimson;
                return true;
            }
            else
                return false;
        }
        private bool Vert()
        {
            if (a1.Text == b1.Text && b1.Text == c1.Text && c1.Text == d1.Text)
            {
                a1.BackColor = Color.Crimson;
                b1.BackColor = Color.Crimson;
                c1.BackColor = Color.Crimson;
                d1.BackColor = Color.Crimson;
                return true;
            }
            else if (e1.Text == b1.Text && b1.Text == c1.Text && c1.Text == d1.Text)
            {
                e1.BackColor = Color.Crimson;
                b1.BackColor = Color.Crimson;
                c1.BackColor = Color.Crimson;
                d1.BackColor = Color.Crimson;
                return true;
            }
            else if (a2.Text == b2.Text && b2.Text == c2.Text && c2.Text == d2.Text)
            {
                a2.BackColor = Color.Crimson;
                b2.BackColor = Color.Crimson;
                c2.BackColor = Color.Crimson;
                d2.BackColor = Color.Crimson;
                return true;
            }
            else if (e2.Text == b2.Text && b2.Text == c2.Text && c2.Text == d2.Text)
            {
                e2.BackColor = Color.Crimson;
                b2.BackColor = Color.Crimson;
                c2.BackColor = Color.Crimson;
                d2.BackColor = Color.Crimson;
                return true;
            }
            else if (a3.Text == b3.Text && b3.Text == c3.Text && c3.Text == d3.Text)
            {
                a3.BackColor = Color.Crimson;
                b3.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                d3.BackColor = Color.Crimson;
                return true;
            }
            else if (e3.Text == b3.Text && b3.Text == c3.Text && c3.Text == d3.Text)
            {
                e3.BackColor = Color.Crimson;
                b3.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                d3.BackColor = Color.Crimson;
                return true;
            }
            else if (a4.Text == b4.Text && b4.Text == c4.Text && c4.Text == d4.Text)
            {
                a4.BackColor = Color.Crimson;
                b4.BackColor = Color.Crimson;
                c4.BackColor = Color.Crimson;
                d4.BackColor = Color.Crimson;
                return true;
            }
            else if (e4.Text == b4.Text && b4.Text == c4.Text && c4.Text == d4.Text)
            {
                e4.BackColor = Color.Crimson;
                b4.BackColor = Color.Crimson;
                c4.BackColor = Color.Crimson;
                d4.BackColor = Color.Crimson;
                return true;
            }
            else if (a5.Text == b5.Text && b5.Text == c5.Text && c5.Text == d5.Text)
            {
                a5.BackColor = Color.Crimson;
                b5.BackColor = Color.Crimson;
                c5.BackColor = Color.Crimson;
                d5.BackColor = Color.Crimson;
                return true;
            }
            else if (e5.Text == b5.Text && b5.Text == c5.Text && c5.Text == d5.Text)
            {
                e5.BackColor = Color.Crimson;
                b5.BackColor = Color.Crimson;
                c5.BackColor = Color.Crimson;
                d5.BackColor = Color.Crimson;
                return true;
            }
            else
                return false;
        }
        private bool Diag()
        {
            if (a1.Text == b2.Text && b2.Text == c3.Text && c3.Text == d4.Text)
            {
                a1.BackColor = Color.Crimson;
                b2.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                d4.BackColor = Color.Crimson;
                return true;//
            }
            else if (e5.Text == b2.Text && b2.Text == c3.Text && c3.Text == d4.Text)
            {
                e5.BackColor = Color.Crimson;
                b2.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                d4.BackColor = Color.Crimson;
                return true;//
            }
            else if (a5.Text == b4.Text && b4.Text == c3.Text && c3.Text == d2.Text)
            {
                a5.BackColor = Color.Crimson;
                b4.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                d2.BackColor = Color.Crimson;
                return true;//
            }
            else if (e1.Text == b4.Text && b4.Text == c3.Text && c3.Text == d2.Text)
            {
                e1.BackColor = Color.Crimson;
                b4.BackColor = Color.Crimson;
                c3.BackColor = Color.Crimson;
                d2.BackColor = Color.Crimson;
                return true;//
            }
            else if (b1.Text == c2.Text && c2.Text == d3.Text && d3.Text == e4.Text)
            {
                b1.BackColor = Color.Crimson;
                c2.BackColor = Color.Crimson;
                d3.BackColor = Color.Crimson;
                e4.BackColor = Color.Crimson;
                return true;//
            }
            else if (a2.Text == b3.Text && b3.Text == c4.Text && c4.Text == d5.Text)
            {
                a2.BackColor = Color.Crimson;
                b3.BackColor = Color.Crimson;
                c4.BackColor = Color.Crimson;
                d5.BackColor = Color.Crimson;
                return true;//
            }
            else if (a4.Text == b3.Text && b3.Text == c2.Text && c2.Text == d1.Text)
            {
                a4.BackColor = Color.Crimson;
                b3.BackColor = Color.Crimson;
                c2.BackColor = Color.Crimson;
                d1.BackColor = Color.Crimson;
                return true;//
            }
            else if (b5.Text == c4.Text && c4.Text == d3.Text && d3.Text == e2.Text)
            {
                b5.BackColor = Color.Crimson;
                c4.BackColor = Color.Crimson;
                d3.BackColor = Color.Crimson;
                e2.BackColor = Color.Crimson;
                return true;//
            }
            return false;
        }
        private bool Draw() //check the whole board to determine if all the buttons where clicked in order to 
        {
            if (a1.Enabled != true && a2.Enabled != true && a3.Enabled != true && a4.Enabled != true && a5.Enabled != true
                && b1.Enabled != true && b2.Enabled != true && b3.Enabled != true && b4.Enabled != true && b5.Enabled != true
                && c1.Enabled != true && c2.Enabled != true && c3.Enabled != true && c4.Enabled != true && c5.Enabled != true
                && d1.Enabled != true && d2.Enabled != true && d3.Enabled != true && d4.Enabled != true && d5.Enabled != true
                && e1.Enabled != true && e2.Enabled != true && e3.Enabled != true && e4.Enabled != true && e5.Enabled != true)
            {
                isLocked = true;
                turn = true;
                return true;
            }

            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
       

        //MENU ON-CLICK HANDLERS
        //FILE - NEW
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EnableButtons(this);
            //Needs a reset score function. 
        }
        //FILE - QUIT
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //HELP - HOW TO PLAY
        private void howToPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //HELP - ABOUT
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team Name: Tic Tac Shenanigans\nTeam Members/Roles:\nJose Fidel Huertero- SQA\nMir Abutaiab- SQA\n" + 
            "Ana Segura- Secretary\nJason Cessna- Team Lead\nLuis Gonzalez- SQA", "Tic Tac Toe - Shenanigans");
        }
        //SCORE - PvP
        private void pvPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //SCORE - PvEasy
        private void vsEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //SCORE - PvMedium
        private void vsMediumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //SCORE - PvHard
        private void vsHardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (gameMode < 2)
            {
                isLocked = false; //unlock the board
                startButton.Enabled = false; //make start button no longer clickable
                startButton.Text = "PLAYING!"; //change text to playing
                startButton.ForeColor = Color.White;    //Reset button's color
                turnCount = 0;                  //Reset turn count
                turn = true;                    //Reset turn (guarantee X starts)
            }
            else MessageBox.Show("AI Mode not yet Available\n" +
                                 "Select Player vs Player mode to play.");
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //File -> New -> Player Vs Hard
        private void playerVsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameMode = 3;
            if (player2Name != "AI Hard")
                score2 = 0;
            player2Name = "AI Hard";
            p2ScoreLbl.Text = player2Name + "'s Score:";
            DisableButtons(this);
            EnableButtons(this);
        }
        //File -> New -> Player vs Player
        private void playerVsPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gameMode = 0;

            if (player2Name == "AI Hard" || player2Name == "AI Medium" || player2Name == "AI Easy")
                player2Name = "Player 2";
            p2ScoreLbl.Text = player2Name + "'s Score:";
            DisableButtons(this);
            EnableButtons(this);
            
        }
        //File -> New -> Player vs Easy
        private void playerVsAIEasyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gameMode = 1;

            if (player2Name != "AI Easy")
                score2 = 0;
            player2Name = "AI Easy";
            p2ScoreLbl.Text = player2Name + "'s Score:";
            DisableButtons(this);
            EnableButtons(this);
        }
        //File -> New -> Player vs Medium ((((Some reason this is mislabeled)
        private void playerVsAIHardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gameMode = 2;

            if (player2Name != "AI Medium")
                score2 = 0;
            player2Name = "AI Medium";
            p2ScoreLbl.Text = player2Name + "'s Score:";
            DisableButtons(this);
            EnableButtons(this);
        }
        //EDIT -> COLOR -> X
        private void player1ToolStripMenuItem_Click(object sender, EventArgs e) //Edit -> Colors -> Player 1
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                custColor1 = true;
                ChangeColors(this);
             }
        }
        //EDIT -> COLOR -> O
        private void player2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                custColor2 = true;
                ChangeColors(this);
            }

        }
        //EDIT -> NAME -> PLAYER 1
        private void player1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NameList nameList = new NameList();
            nameList.ShowDialog();
           // while (NameList.ActiveForm.Activated == 1) { }
            if (player1Name != NameList.getName())          //RESET SCORE IF NEW PLAYER NAME
                score1 = 0;
            player1Name = NameList.getName();
            p1ScoreLbl.Text = player1Name + "'s Score:";
        }
        //EDIT -> NAME -> PLAYER 2
        private void player2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gameMode == 0)
            {
                NameList nameList = new NameList();
                nameList.ShowDialog();
                // while (NameList.ActiveForm.Activated == 1) { }
                if (player2Name != NameList.getName())          //RESET SCORE IF NEW PLAYER NAME
                    score2 = 0;
                player2Name = NameList.getName();
                p2ScoreLbl.Text = player2Name + "'s Score:";
            }
            else MessageBox.Show("Wrong game mode selected.\n" +
                                 "Select Player vs Player to add Player 2");
        }


        //FLUFF:
       private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

 
    }
}
/* * * TICTACSHEN 1.1 UPDATES 8/31/15 * * *
 * * * Features added:
 * Colors change for winning 4-in-a-row
 * Player name change displayed on change
 * Scores update with each game
 * Scores reset if new player name selected
 * Display player name and token on victory
 * Updated sizing, colors, and layout
 * Added gamemode integer - no AI implemented yet, but this will determine
 * whether or not Player 2 selects and which AI function will be called every move
 * Got rid of Difficulty menu options
 * Game Mode (file -> new) completely resets board with a new game mode
 * Game Mode (file -> new) checks for a new player type and resets score if true
 * * * Bugs fixed:
 * Turn resets when game is restarted (X now begins every game)
 * Board locks every victory / draw
 * Colors changing mid-game or post-game won't make O's backcolor all black
 * Colors changing mid-game or post game won't force next game's ChangeColor() function
 * update to the previous game's picks (by resetting button tags via game reset)
 */