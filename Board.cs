using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    
   
    
  
    public partial class Board : Form
    {
        public static char p1Token { get; set; }
        public static char p2Token { get; set; }
        public static string p1Name { get; set; }
        public static string p2Name { get; set; }
        public static Boolean p1Turn { get; set; }
        public static Boolean p2Turn { get; set; }
        public static int p1Diff { get; set; }
        public static int p2Diff { get; set; }
        public static Boolean isOver = false;
        public void scan() { }
        public Player player1;
        public Player player2;
        public dynamic a1, a2, a3, a4, a5;
        public dynamic b1, b2, b3, b4, b5;
        public dynamic c1, c2, c3, c4, c5;
        public dynamic d1, d2, d3, d4, d5;
        public dynamic e1, e2, e3, e4, e5;

       

        public static char P1Token
        {
            get { return Convert.ToChar(p1Token); }
            set { p1Token = value; }
        }
        public static char P2Token
        {
            get { return Convert.ToChar(p2Token); }
            set { p2Token = value; }
        }
        public static string P1Name
        {
            get { return Convert.ToString(p1Name); }
            set { p1Name = value; }
        }
        public static string P2Name
        {
            get { return Convert.ToString(p2Name); }
            set { p2Name = value; }
        }
        public static Boolean P1Turn
        {
            get { return Convert.ToBoolean(p1Turn); }
            set { p1Turn = value; }
        }
        public static Boolean P2Turn
        {
            get { return Convert.ToBoolean(p2Turn); }
            set { p2Turn = value; }
        }
        public static int P1Diff
        {
            get { return Convert.ToInt16(p1Diff); }
            set { p1Diff = value; }
        }
        public static int P2Diff
        {
            get { return Convert.ToInt16(p2Diff); }
            set { p2Diff = value; }
        }

        public void  playAI(string space)
        {
            if (isOver == true) { }
            else
            {
                string makeMoveOn = space;
                // MessageBox.Show(makeMoveOn);
                if (makeMoveOn == "a1") { clickA1(); }
                if (makeMoveOn == "a2") { clickA2(); }
                else if (makeMoveOn == "a3") { clickA3(); }
                else if (makeMoveOn == "a4") { clickA4(); }
                else if (makeMoveOn == "a5") { clickA5(); }
                else if (makeMoveOn == "b1") { clickB1(); }
                else if (makeMoveOn == "b2") { clickB2(); }
                else if (makeMoveOn == "b3") { clickB3(); }
                else if (makeMoveOn == "b4") { clickB4(); }
                else if (makeMoveOn == "b5") { clickB5(); }
                else if (makeMoveOn == "c1") { clickC1(); }
                else if (makeMoveOn == "c2") { clickC2(); }
                else if (makeMoveOn == "c3") { clickC3(); }
                else if (makeMoveOn == "c4") { clickC4(); }
                else if (makeMoveOn == "c5") { clickC5(); }
                else if (makeMoveOn == "d1") { clickD1(); }
                else if (makeMoveOn == "d2") { clickD2(); }
                else if (makeMoveOn == "d3") { clickD3(); }
                else if (makeMoveOn == "d4") { clickD4(); }
                else if (makeMoveOn == "d5") { clickD5(); }
                else if (makeMoveOn == "e1") { clickE1(); }
                else if (makeMoveOn == "e2") { clickE2(); }
                else if (makeMoveOn == "e3") { clickE3(); }
                else if (makeMoveOn == "e4") { clickE4(); }
                else if (makeMoveOn == "e5") { clickE5(); }
                // else MessageBox.Show("No moves found.");
            }
        }

        public char scan(char a)
        {
            if (isOver == true) { return a;}
            else {
            Boolean isWin = false;
            char checkForToken = a;
            //list off all possible win-scenario spaces
            List<Space> win1 = new List<Space>();
            List<Space> win2 = new List<Space>();
            List<Space> win3 = new List<Space>();
            List<Space> win4 = new List<Space>();
            List<Space> win5 = new List<Space>();
            List<Space> win6 = new List<Space>();
            List<Space> win7 = new List<Space>();
            List<Space> win8 = new List<Space>();
            List<Space> win9 = new List<Space>();
            List<Space> win10 = new List<Space>();
            List<Space> win11 = new List<Space>();
            List<Space> win12 = new List<Space>();
            List<Space> win13 = new List<Space>();
            List<Space> win14 = new List<Space>();
            List<Space> win15 = new List<Space>();
            List<Space> win16 = new List<Space>();
            List<Space> win17 = new List<Space>();
            List<Space> win18 = new List<Space>();
            List<Space> win19 = new List<Space>();
            List<Space> win20 = new List<Space>();
            List<Space> win21 = new List<Space>();
            List<Space> win22 = new List<Space>();
            List<Space> win23 = new List<Space>();
            List<Space> win24 = new List<Space>();
            List<Space> win25 = new List<Space>();
            List<Space> win26 = new List<Space>();
            List<Space> win27 = new List<Space>();
            List<Space> win28 = new List<Space>();
            Space X1 = new Space("");
            Space X2 = new Space("");
            Space X3 = new Space("");
            Space X4 = new Space("");
            Space X5 = new Space("");
            Space X6 = new Space("");
            Space X7 = new Space("");
            Space X8 = new Space("");
            Space X9 = new Space("");
            Space X10 = new Space("");
            Space X11 = new Space("");
            Space X12 = new Space("");
            Space X13 = new Space("");
            Space X14 = new Space("");
            Space X15 = new Space("");
            Space X16 = new Space("");
            Space X17 = new Space("");
            Space X18 = new Space("");
            Space X19 = new Space("");
            Space X20 = new Space("");
            Space X21 = new Space("");
            Space X22 = new Space("");
            Space X23 = new Space("");
            Space X24 = new Space("");
            Space X25 = new Space("");
            Space X26 = new Space("");
            Space X27 = new Space("");
            Space X28 = new Space("");
            Space O1 = new Space("");
            Space O2 = new Space("");
            Space O3 = new Space("");
            Space O4 = new Space("");
            Space O5 = new Space("");
            Space O6 = new Space("");
            Space O7 = new Space("");
            Space O8 = new Space("");
            Space O9 = new Space("");
            Space O10 = new Space("");
            Space O11 = new Space("");
            Space O12 = new Space("");
            Space O13 = new Space("");
            Space O14 = new Space("");
            Space O15 = new Space("");
            Space O16 = new Space("");
            Space O17 = new Space("");
            Space O18 = new Space("");
            Space O19 = new Space("");
            Space O20 = new Space("");
            Space O21 = new Space("");
            Space O22 = new Space("");
            Space O23 = new Space("");
            Space O24 = new Space("");
            Space O25 = new Space("");
            Space O26 = new Space("");
            Space O27 = new Space("");
            Space O28 = new Space("");
            //row wins
            win1.Add(a1); win1.Add(a2); win1.Add(a3); win1.Add(a4);  
            win2.Add(a2); win2.Add(a3); win2.Add(a4); win2.Add(a5);
            win3.Add(b1); win3.Add(b2); win3.Add(b3); win3.Add(b4);
            win4.Add(b2); win4.Add(b3); win4.Add(b4); win4.Add(b5);
            win5.Add(c1); win5.Add(c2); win5.Add(c3); win5.Add(c4);
            win6.Add(c2); win6.Add(c3); win6.Add(c4); win6.Add(c5);
            win7.Add(d1); win7.Add(d2); win7.Add(d3); win7.Add(d4);
            win8.Add(d2); win8.Add(d3); win8.Add(d4); win8.Add(d5);
            win9.Add(e1); win9.Add(e2); win9.Add(e3); win9.Add(e4);
            win10.Add(e2); win10.Add(e3); win10.Add(e4); win10.Add(e5);
            //column wins
            win11.Add(a1); win11.Add(b1); win11.Add(c1); win11.Add(d1);
            win12.Add(b1); win12.Add(c1); win12.Add(d1); win12.Add(e1);
            win13.Add(a2); win13.Add(b2); win13.Add(c2); win13.Add(d2);
            win14.Add(b2); win14.Add(c2); win14.Add(d2); win14.Add(e2);
            win15.Add(a3); win15.Add(b3); win15.Add(c3); win15.Add(d3);
            win16.Add(b3); win16.Add(c3); win16.Add(d3); win16.Add(e3);
            win17.Add(a4); win17.Add(b4); win17.Add(c4); win17.Add(d4);
            win18.Add(b4); win18.Add(c4); win18.Add(d4); win18.Add(e4);
            win19.Add(a5); win19.Add(b5); win19.Add(c5); win19.Add(d5);
            win20.Add(b5); win20.Add(c5); win20.Add(d5); win20.Add(e5);
            //diagonal wins
            win21.Add(a1); win21.Add(b2); win21.Add(c3); win21.Add(d4);
            win22.Add(b2); win22.Add(c3); win22.Add(d4); win22.Add(e5);
            win23.Add(a2); win23.Add(b3); win23.Add(c4); win23.Add(d5);
            win24.Add(b1); win24.Add(c2); win24.Add(d3); win24.Add(e4);
            win25.Add(a5); win25.Add(b4); win25.Add(c3); win25.Add(d2);
            win26.Add(b4); win26.Add(c3); win26.Add(d2); win26.Add(e1);
            win27.Add(a4); win27.Add(b3); win27.Add(c2); win27.Add(d1);
            win28.Add(b5); win28.Add(c4); win28.Add(d3); win28.Add(e2); 

            //check for wins
            char owner1 = win1.First().Owner;
            char owner2 = win2.First().Owner;
            char owner3 = win3.First().Owner;
            char owner4 = win4.First().Owner;
            char owner5 = win5.First().Owner;
            char owner6 = win6.First().Owner;
            char owner7 = win7.First().Owner;
            char owner8 = win8.First().Owner;
            char owner9 = win9.First().Owner;
            char owner10 = win10.First().Owner;
            char owner11 = win11.First().Owner;
            char owner12 = win12.First().Owner;
            char owner13 = win13.First().Owner;
            char owner14 = win14.First().Owner;
            char owner15 = win15.First().Owner;
            char owner16 = win16.First().Owner;
            char owner17 = win17.First().Owner;
            char owner18 = win18.First().Owner;
            char owner19 = win19.First().Owner;
            char owner20 = win20.First().Owner;
            char owner21 = win21.First().Owner;
            char owner22 = win22.First().Owner;
            char owner23 = win23.First().Owner;
            char owner24 = win24.First().Owner;
            char owner25 = win25.First().Owner;
            char owner26 = win26.First().Owner;
            char owner27 = win27.First().Owner;
            char owner28 = win28.First().Owner;
            
            if (win1.All(x => x.Owner == owner1) && owner1 != 'e')
                return owner1;
            else if (win1.All(x => x.Owner == owner2) && owner2 != 'e')
                return owner2;
            else if (win3.All(x => x.Owner == owner3) && owner3 != 'e')
                return owner3;
            else if (win4.All(x => x.Owner == owner4) && owner4 != 'e')
                return owner4;
            else if (win5.All(x => x.Owner == owner5) && owner5 != 'e')
                return owner5;
            else if (win6.All(x => x.Owner == owner6) && owner6 != 'e')
                return owner6;
            else if (win7.All(x => x.Owner == owner7) && owner7 != 'e')
                return owner7;
            else if (win8.All(x => x.Owner == owner8) && owner8 != 'e')
                return owner8;
            else if (win9.All(x => x.Owner == owner9) && owner9 != 'e')
                return owner9;
            else if (win10.All(x => x.Owner == owner10) && owner10 != 'e')
                return owner10;
            else if (win11.All(x => x.Owner == owner11) && owner11 != 'e')
                return owner11;
            else if (win12.All(x => x.Owner == owner12) && owner12 != 'e')
                return owner12;
            else if (win13.All(x => x.Owner == owner13) && owner13 != 'e')
                return owner13;
            else if (win14.All(x => x.Owner == owner14) && owner14 != 'e')
                return owner14;
            else if (win15.All(x => x.Owner == owner15) && owner15 != 'e')
                return owner15;
            else if (win16.All(x => x.Owner == owner16) && owner16 != 'e')
                return owner16;
            else if (win17.All(x => x.Owner == owner17) && owner17 != 'e')
                return owner17;
            else if (win18.All(x => x.Owner == owner18) && owner18 != 'e')
                return owner18;
            else if (win19.All(x => x.Owner == owner19) && owner19 != 'e')
                return owner19;
            else if (win20.All(x => x.Owner == owner20) && owner20 != 'e')
                return owner20;
            else if (win21.All(x => x.Owner == owner21) && owner21 != 'e')
                return owner21;
            else if (win22.All(x => x.Owner == owner22) && owner22 != 'e')
                return owner22;
            else if (win23.All(x => x.Owner == owner23) && owner23 != 'e')
                return owner23;
            else if (win24.All(x => x.Owner == owner24) && owner24 != 'e')
                return owner24;
            else if (win25.All(x => x.Owner == owner25) && owner25 != 'e')
                return owner25;
            else if (win26.All(x => x.Owner == owner26) && owner26 != 'e')
                return owner26;
            else if (win27.All(x => x.Owner == owner27) && owner27 != 'e')
                return owner27;
            else if (win28.All(x => x.Owner == owner28) && owner28 != 'e')
                return owner28;
            else
            {
                scanX();
                scanO();

                X1 = sortWinListsX(win1); X2 = sortWinListsX(win2); X3 = sortWinListsX(win3); X4 = sortWinListsX(win4);
                X5 = sortWinListsX(win5); X6 = sortWinListsX(win6); X7 = sortWinListsX(win7); X8 = sortWinListsX(win8);
                X9 = sortWinListsX(win9); X10 = sortWinListsX(win10); X11 = sortWinListsX(win11); X12 = sortWinListsX(win12);
                X13 = sortWinListsX(win13); X14 = sortWinListsX(win14); X15 = sortWinListsX(win15); X16 = sortWinListsX(win16);
                X17 = sortWinListsX(win17); X18 = sortWinListsX(win18); X19 = sortWinListsX(win19); X20 = sortWinListsX(win20);
                X21 = sortWinListsX(win21); X22 = sortWinListsX(win22); X23 = sortWinListsX(win23); X24 = sortWinListsX(win24);
                X25 = sortWinListsX(win25); X26 = sortWinListsX(win26); X27 = sortWinListsX(win27); X28 = sortWinListsX(win28);

                O1 = sortWinListsO(win1); O2 = sortWinListsO(win2); O3 = sortWinListsO(win3); O4 = sortWinListsO(win4);
                O5 = sortWinListsO(win5); O6 = sortWinListsO(win6); O7 = sortWinListsO(win7); O8 = sortWinListsO(win8);
                O9 = sortWinListsO(win9); O10 = sortWinListsO(win10); O11 = sortWinListsO(win11); O12 = sortWinListsO(win12);
                O13 = sortWinListsO(win13); O14 = sortWinListsO(win14); O15 = sortWinListsO(win15); O16 = sortWinListsO(win16);
                O17 = sortWinListsO(win17); O18 = sortWinListsO(win18); O19 = sortWinListsO(win19); O20 = sortWinListsO(win20);
                O21 = sortWinListsO(win21); O22 = sortWinListsO(win22); O23 = sortWinListsO(win23); O24 = sortWinListsO(win24);
                O25 = sortWinListsO(win25); O26 = sortWinListsO(win26); O27 = sortWinListsO(win27); O28 = sortWinListsO(win28);
                //sort each potential win
                List<List<Space>> winableMoves = new List<List<Space>>();

                winableMoves.Add(win1);
                winableMoves.Add(win2);
                winableMoves.Add(win3);
                winableMoves.Add(win4);
                winableMoves.Add(win5);
                winableMoves.Add(win6);
                winableMoves.Add(win7);
                winableMoves.Add(win8);
                winableMoves.Add(win9);
                winableMoves.Add(win10);
                winableMoves.Add(win11);
                winableMoves.Add(win12);
                winableMoves.Add(win13);
                winableMoves.Add(win14);
                winableMoves.Add(win15);
                winableMoves.Add(win16);
                winableMoves.Add(win17);
                winableMoves.Add(win18);
                winableMoves.Add(win19);
                winableMoves.Add(win20);
                winableMoves.Add(win21);
                winableMoves.Add(win22);
                winableMoves.Add(win23);
                winableMoves.Add(win24);
                winableMoves.Add(win25);
                winableMoves.Add(win26);
                winableMoves.Add(win27);
                winableMoves.Add(win28);

                List<Space> movesX = new List<Space>() { X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, X11, X12,
                                                             X13, X14, X15, X16, X19, X20, X21, X22, X23, X24, X25, X26};
                List<Space> movesO = new List<Space>() { O1, O2, O3, O4, O5, O6, O7, O8, O9, O10, O11, O12,
                                                             O13, O14, O15, O16, O19, O20, O21, O22, O23, O24, O25, O26};
                movesX = movesX.OrderByDescending(x => x.WeightX).ToList();
                movesO = movesO.OrderByDescending(o => o.weightO).ToList();
                if (player1.Turn == true && player1.Difficulty > 0)
                {
                    if (movesX.First().WeightX == 0 && movesO.First().WeightO == 0)
                    {
                        if (a1.Owner == 'e')
                            playAI("c4");
                        else playAI("b2");
                    }
                    else
                    {
                        if (player1.Difficulty == 1)
                            playAI(scanX());
                        //playAI(movesX.First().SpaceName);
                        else if (player1.Difficulty == 2)
                        {
                            if (movesX.First().WeightX >= movesO.First().WeightO)
                                playAI(movesX.First().SpaceName);
                            else playAI(movesO.First().SpaceName);
                        }
                        else
                        {

                            //Luis added
                            //Minimax
                            Minimax ai = new Minimax();
                            string bestSpace = ai.getNextMove(this).Space;

                            playAI(bestSpace);
                        }
                    }
                }
                else if (player2.Turn == true && player2.Difficulty > 0)
                {
                    if (movesX.First().WeightX == 0 && movesO.First().WeightO == 0)
                    {
                        if (a1.Owner == 'e')
                            playAI("c4");
                        else playAI("b2");
                    }
                    else
                    {
                        if (player2.Difficulty == 1)
                            playAI(scanO());
                        //  playAI(movesO.First().SpaceName);
                        else if (player2.Difficulty == 2)
                        {
                            if (movesO.First().WeightO >= movesX.First().WeightX)
                                playAI(movesO.First().SpaceName);
                            else playAI(movesX.First().SpaceName);
                        }
                        else
                        {

                            //Luis added
                            //Minimax
                            Minimax ai = new Minimax();
                            string bestSpace = ai.getNextMove(this).Space;

                            playAI(bestSpace);
                        }
                    }
                }
            }
                
               /*
                * int counter = 0;
                for (int i = 0; i < 4; i++){
                    scanX();
                   winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightX)).ToList();
                    if (winableMoves.First().First().Owner != 'e')
                        winableMoves.First().First().WeightX = 0;
                    counter++;
                    if (winableMoves.First().All(x => x.WeightX == 0))
                        MessageBox.Show("Error.");
                } 
                counter = 0;
                MessageBox.Show(winableMoves.First().First().SpaceName);
                for (int i = 0; i < 4; i++)
                {
                    scanO();
                    winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightO)).ToList();
                    if (winableMoves.First().First().Owner != 'e')
                        winableMoves.First().First().WeightO = 0;
                    counter++;
                } 
                counter = 0;
                MessageBox.Show(winableMoves.First().First().SpaceName);
               // winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightX)).ToList();
                int threatX = winableMoves.First().First().WeightX;
                winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightO)).ToList();
                int threatO = winableMoves.First().First().WeightO;
                if (player1.Turn == true && player1.Difficulty > 0)
                {
                    if (player1.Difficulty == 1)
                        winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightX)).ToList();
                    else if (player1.Difficulty == 2)
                    {
                        if (threatX >= threatO)
                            winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightX)).ToList();
                        else winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightO)).ToList();
                    }
                    else winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightO)).ToList();
                    playAI(winableMoves.First().First().SpaceName);
                }
                else if (player2.Turn == true && player2.Difficulty > 0)
                {
                    if (player2.Difficulty == 1)
                        winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightO)).ToList();
                    else if (player2.Difficulty == 2)
                    {
                        if (threatO >= threatX)
                            winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightO)).ToList();
                        else winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightX)).ToList();
                    }
                    else winableMoves = winableMoves.OrderByDescending(x => x.Max(o => o.WeightX)).ToList();
                    playAI(winableMoves.First().First().SpaceName);
                }
               // playAI(winableMoves.First().First().SpaceName);
                //MessageBox.Show("Winnable Moves: " + displayMoves.ToString() + " " + winableMoves.First().First().Owner);
                //winableMoves.Clear();
                */
                return 'e';
            }


        }

        public Space sortWinListsX(List<Space> move)
        {
            for (int i = 0; i < 4; i++)
            {
                move = move.OrderByDescending(x => x.WeightX).ToList();
                if (move.First().Owner != 'e') move.First().WeightX = 0;
            }
            return move.First();
        }
        public Space sortWinListsO(List<Space> move)
        {
            for (int i = 0; i < 4; i++)
            {
                move = move.OrderByDescending(x => x.WeightO).ToList();
                if (move.First().Owner != 'e') move.First().WeightO = 0;
            }
            return move.First();
        }
        public List<Space> addWinningMove(List<Space> move)
        {
            
            Boolean keepMove = true;
            char ownerOfSpace = move.First().Owner;
            for (int iteration = 0; iteration < 4; iteration++)
            {
                int count = 1;
                for (int nestedIteration = 3; nestedIteration < 0; nestedIteration--)
                {
                    if ((move[iteration].Owner == 'x' && move[iteration + count].Owner == 'o') || (move[iteration].Owner == 'x' && move[iteration + count].Owner == 'o')) { }
                    keepMove = false;
                }
                
            }
            if (keepMove == false)
                return null;
            else return move;
        }

        public void play()
        {
            
            player1.Turn = !player1.Turn;
            player2.Turn = !player2.Turn;
            int p1Diff = player1.Difficulty;
            int p2Diff = player2.Difficulty;
            //clickA1();
            if (player1.Turn == true)                
            {
                if (player2.Token == scan(player2.Token))
                {
                    isOver = true;
                    MessageBox.Show(player2.Name + " has won!");
                    labelTurn.Text = player2.Name + " has won!";
                    player1.losses += 1;
                    player2.wins += 1;
                    DisableButtons(this);
                }
                else
                {
                    labelTurn.Text = player1.Name + "'s turn.";                   
                }
            }
            else
            {
                if (player1.Token == scan(player1.Token))
                {
                    isOver = true;
                    MessageBox.Show(player1.Name + " has won!");
                    labelTurn.Text = player1.Name + " has won!";
                    player2.losses += 1;
                    player1.wins += 1;
                    DisableButtons(this);
                }
                else
                {
                    labelTurn.Text = player2.Name + "'s turn.";                    
                }
            }
            

        }

        public dynamic isDraw()
        {
            isOver = true;
            MessageBox.Show("The Game is a tie!");
            labelTurn.Text = "Game is a Tie!";
            DisableButtons(this);
            player1.draws += 1;
            player2.draws += 1;
            return 0;
        }

        protected void DisableButtons(Control root)  
        {
            //score1Lbl.Text = score1.ToString();      
            //score2Lbl.Text = score2.ToString();      
            //turn = true;                             
            //isLocked = true;                         
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is Button)
                {
                    ((Control)ctrl).Enabled = false;      
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

        public Board(Player playerX, Player playerO)
        {
            InitializeComponent();
            P1Token = playerX.Token;
            P2Token = playerO.Token;
            P1Name = playerX.Name;
            P2Name = playerO.Name;
            P1Turn = playerX.Turn;
            P2Turn = playerO.Turn;
            P1Diff = playerX.Difficulty;
            P2Diff = playerO.Difficulty;
            isOver = false;
            //create abstract players
            Player player1X = playerX;
            Player player2O = playerO;
            player1 = player1X;
            player2 = player2O;
            labelTurn.Text = player1.Name + "'s turn.";

            //create abstract spaces
            Space A1 = new Space("a1");
            Space A2 = new Space("a2");
            Space A3 = new Space("a3");
            Space A4 = new Space("a4");
            Space A5 = new Space("a5");
            Space B1 = new Space("b1");
            Space B2 = new Space("b2");
            Space B3 = new Space("b3");
            Space B4 = new Space("b4");
            Space B5 = new Space("b5");
            Space C1 = new Space("c1");
            Space C2 = new Space("c2");
            Space C3 = new Space("c3");
            Space C4 = new Space("c4");
            Space C5 = new Space("c5");
            Space D1 = new Space("d1");
            Space D2 = new Space("d2");
            Space D3 = new Space("d3");
            Space D4 = new Space("d4");
            Space D5 = new Space("d5");
            Space E1 = new Space("e1");
            Space E2 = new Space("e2");
            Space E3 = new Space("e3");
            Space E4 = new Space("e4");
            Space E5 = new Space("e5");
            a1 = A1; a2 = A2; a3 = A3; a4 = A4; a5 = A5;
            b1 = B1; b2 = B2; b3 = B3; b4 = B4; b5 = B5;
            c1 = C1; c2 = C2; c3 = C3; c4 = C4; c5 = C5;
            d1 = D1; d2 = D2; d3 = D3; d4 = D4; d5 = D5;
            e1 = E1; e2 = E2; e3 = E3; e4 = E4; e5 = E5;
            if (player1.Difficulty > 0)
                scan('x');
        }


        public string scanX()
        {
            dynamic bestSpaceX;
            a1.WeightX = a1.LeftNodeX + a1.RightNodeX + a1.TopNodeX + a1.BottomNodeX + a1.TopLeftNodeX + a1.TopRightNodeX + a1.BottomLeftNodeX + a1.BottomRightNodeX;
            a2.WeightX = a2.LeftNodeX + a2.RightNodeX + a2.TopNodeX + a2.BottomNodeX + a2.TopLeftNodeX + a2.TopRightNodeX + a2.BottomLeftNodeX + a2.BottomRightNodeX;
            a3.WeightX = a3.LeftNodeX + a3.RightNodeX + a3.TopNodeX + a3.BottomNodeX + a3.TopLeftNodeX + a3.TopRightNodeX + a3.BottomLeftNodeX + a3.BottomRightNodeX;
            a4.WeightX = a4.LeftNodeX + a4.RightNodeX + a4.TopNodeX + a4.BottomNodeX + a4.TopLeftNodeX + a4.TopRightNodeX + a4.BottomLeftNodeX + a4.BottomRightNodeX;
            a5.WeightX = a5.LeftNodeX + a5.RightNodeX + a5.TopNodeX + a5.BottomNodeX + a5.TopLeftNodeX + a5.TopRightNodeX + a5.BottomLeftNodeX + a5.BottomRightNodeX;
            b1.WeightX = b1.LeftNodeX + b1.RightNodeX + b1.TopNodeX + b1.BottomNodeX + b1.TopLeftNodeX + b1.TopRightNodeX + b1.BottomLeftNodeX + b1.BottomRightNodeX;
            b2.WeightX = b2.LeftNodeX + b2.RightNodeX + b2.TopNodeX + b2.BottomNodeX + b2.TopLeftNodeX + b2.TopRightNodeX + b2.BottomLeftNodeX + b2.BottomRightNodeX;
            b3.WeightX = b3.LeftNodeX + b3.RightNodeX + b3.TopNodeX + b3.BottomNodeX + b3.TopLeftNodeX + b3.TopRightNodeX + b3.BottomLeftNodeX + b3.BottomRightNodeX;
            b4.WeightX = b4.LeftNodeX + b4.RightNodeX + b4.TopNodeX + b4.BottomNodeX + b4.TopLeftNodeX + b4.TopRightNodeX + b4.BottomLeftNodeX + b4.BottomRightNodeX;
            b5.WeightX = b5.LeftNodeX + b5.RightNodeX + b5.TopNodeX + b5.BottomNodeX + b5.TopLeftNodeX + b5.TopRightNodeX + b5.BottomLeftNodeX + b5.BottomRightNodeX;
            c1.WeightX = c1.LeftNodeX + c1.RightNodeX + c1.TopNodeX + c1.BottomNodeX + c1.TopLeftNodeX + c1.TopRightNodeX + c1.BottomLeftNodeX + c1.BottomRightNodeX;
            c2.WeightX = c2.LeftNodeX + c2.RightNodeX + c2.TopNodeX + c2.BottomNodeX + c2.TopLeftNodeX + c2.TopRightNodeX + c2.BottomLeftNodeX + c2.BottomRightNodeX;
            c3.WeightX = c3.LeftNodeX + c3.RightNodeX + c3.TopNodeX + c3.BottomNodeX + c3.TopLeftNodeX + c3.TopRightNodeX + c3.BottomLeftNodeX + c3.BottomRightNodeX;
            c4.WeightX = c4.LeftNodeX + c4.RightNodeX + c4.TopNodeX + c4.BottomNodeX + c4.TopLeftNodeX + c4.TopRightNodeX + c4.BottomLeftNodeX + c4.BottomRightNodeX;
            c5.WeightX = c5.LeftNodeX + c5.RightNodeX + c5.TopNodeX + c5.BottomNodeX + c5.TopLeftNodeX + c5.TopRightNodeX + c5.BottomLeftNodeX + c5.BottomRightNodeX;
            d1.WeightX = d1.LeftNodeX + d1.RightNodeX + d1.TopNodeX + d1.BottomNodeX + d1.TopLeftNodeX + d1.TopRightNodeX + d1.BottomLeftNodeX + d1.BottomRightNodeX;
            d2.WeightX = d2.LeftNodeX + d2.RightNodeX + d2.TopNodeX + d2.BottomNodeX + d2.TopLeftNodeX + d2.TopRightNodeX + d2.BottomLeftNodeX + d2.BottomRightNodeX;
            d3.WeightX = d3.LeftNodeX + d3.RightNodeX + d3.TopNodeX + d3.BottomNodeX + d3.TopLeftNodeX + d3.TopRightNodeX + d3.BottomLeftNodeX + d3.BottomRightNodeX;
            d4.WeightX = d4.LeftNodeX + d4.RightNodeX + d4.TopNodeX + d4.BottomNodeX + d4.TopLeftNodeX + d4.TopRightNodeX + d4.BottomLeftNodeX + d4.BottomRightNodeX;
            d5.WeightX = d5.LeftNodeX + d5.RightNodeX + d5.TopNodeX + d5.BottomNodeX + d5.TopLeftNodeX + d5.TopRightNodeX + d5.BottomLeftNodeX + d5.BottomRightNodeX;
            e1.WeightX = e1.LeftNodeX + e1.RightNodeX + e1.TopNodeX + e1.BottomNodeX + e1.TopLeftNodeX + e1.TopRightNodeX + e1.BottomLeftNodeX + e1.BottomRightNodeX;
            e2.WeightX = e2.LeftNodeX + e2.RightNodeX + e2.TopNodeX + e2.BottomNodeX + e2.TopLeftNodeX + e2.TopRightNodeX + e2.BottomLeftNodeX + e2.BottomRightNodeX;
            e3.WeightX = e3.LeftNodeX + e3.RightNodeX + e3.TopNodeX + e3.BottomNodeX + e3.TopLeftNodeX + e3.TopRightNodeX + e3.BottomLeftNodeX + e3.BottomRightNodeX;
            e4.WeightX = e4.LeftNodeX + e4.RightNodeX + e4.TopNodeX + e4.BottomNodeX + e4.TopLeftNodeX + e4.TopRightNodeX + e4.BottomLeftNodeX + e4.BottomRightNodeX;
            e5.WeightX = e5.LeftNodeX + e5.RightNodeX + e5.TopNodeX + e5.BottomNodeX + e5.TopLeftNodeX + e5.TopRightNodeX + e5.BottomLeftNodeX + e5.BottomRightNodeX;
            
            List<Space> listX = new List<Space>();
            if (a1.Owner == 'e') listX.Add(a1); if (a2.Owner == 'e') listX.Add(a2);
            if (a3.Owner == 'e') listX.Add(a3); if (a4.Owner == 'e') listX.Add(a4);
            if (a5.Owner == 'e') listX.Add(a5);
            if (b1.Owner == 'e') listX.Add(b1); if (b2.Owner == 'e') listX.Add(b2);
            if (b3.Owner == 'e') listX.Add(b3); if (b4.Owner == 'e') listX.Add(b4);
            if (b5.Owner == 'e') listX.Add(b5);
            if (c1.Owner == 'e') listX.Add(c1); if (c2.Owner == 'e') listX.Add(c2);
            if (c3.Owner == 'e') listX.Add(c3); if (c4.Owner == 'e') listX.Add(c4);
            if (c5.Owner == 'e') listX.Add(c5);
            if (d1.Owner == 'e') listX.Add(d1); if (d2.Owner == 'e') listX.Add(d2);
            if (d3.Owner == 'e') listX.Add(d3); if (d4.Owner == 'e') listX.Add(d4);
            if (d5.Owner == 'e') listX.Add(d5);
            if (e1.Owner == 'e') listX.Add(e1); if (e2.Owner == 'e') listX.Add(e2);
            if (e3.Owner == 'e') listX.Add(e3); if (e4.Owner == 'e') listX.Add(e4);
            if (e5.Owner == 'e') listX.Add(e5);
            //IComparer<Space> comparer = new WeightXOrderClass();

            if (listX.Count == 0)
            {
                isDraw();
                return null;
            }
            do
            {
                listX = listX.OrderByDescending(x => x.weightX).ToList();
                if (listX.First().Owner != 'e')
                    listX.First().WeightO = 0;
            } while (listX.First().Owner != 'e');

            bestSpaceX = listX.First();
            listX.Clear();
            //MessageBox.Show(bestSpaceX.SpaceName);
            
            return bestSpaceX.SpaceName;
        }
        public string scanO()
        {
            if (isOver == true) { return ""; }
            else
            {

                dynamic bestSpaceO;
                a1.WeightO = a1.LeftNodeO + a1.RightNodeO + a1.TopNodeO + a1.BottomNodeO + a1.TopLeftNodeO + a1.TopRightNodeO + a1.BottomLeftNodeO + a1.BottomRightNodeO;
                a2.WeightO = a2.LeftNodeO + a2.RightNodeO + a2.TopNodeO + a2.BottomNodeO + a2.TopLeftNodeO + a2.TopRightNodeO + a2.BottomLeftNodeO + a2.BottomRightNodeO;
                a3.WeightO = a3.LeftNodeO + a3.RightNodeO + a3.TopNodeO + a3.BottomNodeO + a3.TopLeftNodeO + a3.TopRightNodeO + a3.BottomLeftNodeO + a3.BottomRightNodeO;
                a4.WeightO = a4.LeftNodeO + a4.RightNodeO + a4.TopNodeO + a4.BottomNodeO + a4.TopLeftNodeO + a4.TopRightNodeO + a4.BottomLeftNodeO + a4.BottomRightNodeO;
                a5.WeightO = a5.LeftNodeO + a5.RightNodeO + a5.TopNodeO + a5.BottomNodeO + a5.TopLeftNodeO + a5.TopRightNodeO + a5.BottomLeftNodeO + a5.BottomRightNodeO;
                b1.WeightO = b1.LeftNodeO + b1.RightNodeO + b1.TopNodeO + b1.BottomNodeO + b1.TopLeftNodeO + b1.TopRightNodeO + b1.BottomLeftNodeO + b1.BottomRightNodeO;
                b2.WeightO = b2.LeftNodeO + b2.RightNodeO + b2.TopNodeO + b2.BottomNodeO + b2.TopLeftNodeO + b2.TopRightNodeO + b2.BottomLeftNodeO + b2.BottomRightNodeO;
                b3.WeightO = b3.LeftNodeO + b3.RightNodeO + b3.TopNodeO + b3.BottomNodeO + b3.TopLeftNodeO + b3.TopRightNodeO + b3.BottomLeftNodeO + b3.BottomRightNodeO;
                b4.WeightO = b4.LeftNodeO + b4.RightNodeO + b4.TopNodeO + b4.BottomNodeO + b4.TopLeftNodeO + b4.TopRightNodeO + b4.BottomLeftNodeO + b4.BottomRightNodeO;
                b5.WeightO = b5.LeftNodeO + b5.RightNodeO + b5.TopNodeO + b5.BottomNodeO + b5.TopLeftNodeO + b5.TopRightNodeO + b5.BottomLeftNodeO + b5.BottomRightNodeO;
                c1.WeightO = c1.LeftNodeO + c1.RightNodeO + c1.TopNodeO + c1.BottomNodeO + c1.TopLeftNodeO + c1.TopRightNodeO + c1.BottomLeftNodeO + c1.BottomRightNodeO;
                c2.WeightO = c2.LeftNodeO + c2.RightNodeO + c2.TopNodeO + c2.BottomNodeO + c2.TopLeftNodeO + c2.TopRightNodeO + c2.BottomLeftNodeO + c2.BottomRightNodeO;
                c3.WeightO = c3.LeftNodeO + c3.RightNodeO + c3.TopNodeO + c3.BottomNodeO + c3.TopLeftNodeO + c3.TopRightNodeO + c3.BottomLeftNodeO + c3.BottomRightNodeO;
                c4.WeightO = c4.LeftNodeO + c4.RightNodeO + c4.TopNodeO + c4.BottomNodeO + c4.TopLeftNodeO + c4.TopRightNodeO + c4.BottomLeftNodeO + c4.BottomRightNodeO;
                c5.WeightO = c5.LeftNodeO + c5.RightNodeO + c5.TopNodeO + c5.BottomNodeO + c5.TopLeftNodeO + c5.TopRightNodeO + c5.BottomLeftNodeO + c5.BottomRightNodeO;
                d1.WeightO = d1.LeftNodeO + d1.RightNodeO + d1.TopNodeO + d1.BottomNodeO + d1.TopLeftNodeO + d1.TopRightNodeO + d1.BottomLeftNodeO + d1.BottomRightNodeO;
                d2.WeightO = d2.LeftNodeO + d2.RightNodeO + d2.TopNodeO + d2.BottomNodeO + d2.TopLeftNodeO + d2.TopRightNodeO + d2.BottomLeftNodeO + d2.BottomRightNodeO;
                d3.WeightO = d3.LeftNodeO + d3.RightNodeO + d3.TopNodeO + d3.BottomNodeO + d3.TopLeftNodeO + d3.TopRightNodeO + d3.BottomLeftNodeO + d3.BottomRightNodeO;
                d4.WeightO = d4.LeftNodeO + d4.RightNodeO + d4.TopNodeO + d4.BottomNodeO + d4.TopLeftNodeO + d4.TopRightNodeO + d4.BottomLeftNodeO + d4.BottomRightNodeO;
                d5.WeightO = d5.LeftNodeO + d5.RightNodeO + d5.TopNodeO + d5.BottomNodeO + d5.TopLeftNodeO + d5.TopRightNodeO + d5.BottomLeftNodeO + d5.BottomRightNodeO;
                e1.WeightO = e1.LeftNodeO + e1.RightNodeO + e1.TopNodeO + e1.BottomNodeO + e1.TopLeftNodeO + e1.TopRightNodeO + e1.BottomLeftNodeO + e1.BottomRightNodeO;
                e2.WeightO = e2.LeftNodeO + e2.RightNodeO + e2.TopNodeO + e2.BottomNodeO + e2.TopLeftNodeO + e2.TopRightNodeO + e2.BottomLeftNodeO + e2.BottomRightNodeO;
                e3.WeightO = e3.LeftNodeO + e3.RightNodeO + e3.TopNodeO + e3.BottomNodeO + e3.TopLeftNodeO + e3.TopRightNodeO + e3.BottomLeftNodeO + e3.BottomRightNodeO;
                e4.WeightO = e4.LeftNodeO + e4.RightNodeO + e4.TopNodeO + e4.BottomNodeO + e4.TopLeftNodeO + e4.TopRightNodeO + e4.BottomLeftNodeO + e4.BottomRightNodeO;
                e5.WeightO = e5.LeftNodeO + e5.RightNodeO + e5.TopNodeO + e5.BottomNodeO + e5.TopLeftNodeO + e5.TopRightNodeO + e5.BottomLeftNodeO + e5.BottomRightNodeO;

                List<Space> listO = new List<Space>();
                if (a1.Owner == 'e') listO.Add(a1); if (a2.Owner == 'e') listO.Add(a2);
                if (a3.Owner == 'e') listO.Add(a3); if (a4.Owner == 'e') listO.Add(a4);
                if (a5.Owner == 'e') listO.Add(a5);
                if (b1.Owner == 'e') listO.Add(b1); if (b2.Owner == 'e') listO.Add(b2);
                if (b3.Owner == 'e') listO.Add(b3); if (b4.Owner == 'e') listO.Add(b4);
                if (b5.Owner == 'e') listO.Add(b5);
                if (c1.Owner == 'e') listO.Add(c1); if (c2.Owner == 'e') listO.Add(c2);
                if (c3.Owner == 'e') listO.Add(c3); if (c4.Owner == 'e') listO.Add(c4);
                if (c5.Owner == 'e') listO.Add(c5);
                if (d1.Owner == 'e') listO.Add(d1); if (d2.Owner == 'e') listO.Add(d2);
                if (d3.Owner == 'e') listO.Add(d3); if (d4.Owner == 'e') listO.Add(d4);
                if (d5.Owner == 'e') listO.Add(d5);
                if (e1.Owner == 'e') listO.Add(e1); if (e2.Owner == 'e') listO.Add(e2);
                if (e3.Owner == 'e') listO.Add(e3); if (e4.Owner == 'e') listO.Add(e4);
                if (e5.Owner == 'e') listO.Add(e5);
                //IComparer<Space> comparer = new WeightOOrderClass();

                if (listO.Count == 0)
                {
                    isDraw();
                    return null;
                }
                do
                {
                    listO = listO.OrderByDescending(x => x.weightO).ToList();
                    if (listO.First().Owner != 'e')
                        listO.First().WeightO = 0;
                } while (listO.First().Owner != 'e');
                bestSpaceO = listO.First();
                listO.Clear();
                //MessageBox.Show(bestSpaceO.SpaceName);

                return bestSpaceO.SpaceName;
            }
        }
        
        private void a1Button_Click(object sender, EventArgs e)
        {
           clickA1();
        }
        private void clickA1()
        {
            if (a1Button.Enabled == true)
            if (player1.turn == true)
            {
                a1.Owner = 'x';
                a2.LeftNodeX += 1;
                b1.TopNodeX += 1;
                b2.TopLeftNodeX += 1;
                a1Button.BackColor = System.Drawing.Color.SlateBlue;
                a1Button.Text = "X";
                a1Button.Enabled = false;
                play();
            }
            else
            {
                a1.Owner = 'o';
                a2.LeftNodeO += 1;
                b1.TopNodeO += 1;
                b2.TopLeftNodeO += 1;
                a1Button.BackColor = System.Drawing.Color.YellowGreen;
                a1Button.Text = "O";
                a1Button.Enabled = false;
                play();
            }
        }
        private void a2Button_Click(object sender, EventArgs e)
        {
            clickA2();
        }

        private void clickA2()
        {
            if (player1.turn == true)
            {
                a2.Owner = 'x';
                a3.LeftNodeX += 1;
                a1.RightNodeX += 1;
                b2.TopNodeX += 1;
                b3.TopLeftNodeX += 1;
                b1.TopRightNodeX += 1;
                a2Button.BackColor = System.Drawing.Color.SlateBlue;
                a2Button.Text = "X";
                a2Button.Enabled = false;
            }
            else
            {
                a2.Owner = 'o';
                a3.LeftNodeO += 1;
                a1.RightNodeX += 1;
                b2.TopNodeO += 1;
                b1.TopRightNodeO += 1;
                b3.TopLeftNodeO += 1;
                a2Button.BackColor = System.Drawing.Color.YellowGreen;
                a2Button.Text = "O";
                a2Button.Enabled = false;
            }
            play();
        }

        private void a3Button_Click(object sender, EventArgs e)
        {
            clickA3();
        }
        private void clickA3()
        {
            if (player1.turn == true)
            {
                a3.Owner = 'x';
                a4.LeftNodeX += 1;
                a2.RightNodeX += 1;
                b3.TopNodeX += 1;
                b4.TopLeftNodeX += 1;
                b2.TopRightNodeX += 1;
                a3Button.BackColor = System.Drawing.Color.SlateBlue;
                a3Button.Text = "X";
                a3Button.Enabled = false;
            }
            else
            {
                a3.Owner = 'o';
                a4.LeftNodeO += 1;
                a2.RightNodeX += 1;
                b3.TopNodeO += 1;
                b2.TopRightNodeO += 1;
                b4.TopLeftNodeO += 1;
                a3Button.BackColor = System.Drawing.Color.YellowGreen;
                a3Button.Text = "O";
                a3Button.Enabled = false;
            }
            play();
        }

        private void a4Button_Click(object sender, EventArgs e)
        {
            clickA4();
        }
        private void clickA4()
        {
            if (player1.turn == true)
            {
                a4.Owner = 'x';
                a5.LeftNodeX += 1;
                a3.RightNodeX += 1;
                b4.TopNodeX += 1;
                b5.TopLeftNodeX += 1;
                b3.TopRightNodeX += 1;
                a4Button.BackColor = System.Drawing.Color.SlateBlue;
                a4Button.Text = "X";
                a4Button.Enabled = false;
            }
            else
            {
                a4.Owner = 'o';
                a5.LeftNodeO += 1;
                a3.RightNodeX += 1;
                b4.TopNodeO += 1;
                b3.TopRightNodeO += 1;
                b5.TopLeftNodeO += 1;
                a4Button.BackColor = System.Drawing.Color.YellowGreen;
                a4Button.Text = "O";
                a4Button.Enabled = false;
            }
            play();
        }

        private void a5Button_Click(object sender, EventArgs e)
        {
            clickA5();
        }
        private void clickA5()
        {
            if (player1.turn == true)
            {
                a5.Owner = 'x';
                a4.RightNodeX += 1;
                b5.TopNodeX += 1;
                b4.TopRightNodeX += 1;
                a5Button.BackColor = System.Drawing.Color.SlateBlue;
                a5Button.Text = "X";
                a5Button.Enabled = false;
            }
            else
            {
                a5.Owner = 'o';
                a4.RightNodeX += 1;
                b5.TopNodeO += 1;
                b4.TopRightNodeO += 1;
                a5Button.BackColor = System.Drawing.Color.YellowGreen;
                a5Button.Text = "O";
                a5Button.Enabled = false;
            }
            play();
        }
        private void b1Button_Click(object sender, EventArgs e)
        {
            clickB1();
        }
        private void clickB1()
        {
            if (player1.turn == true)
            {
                b1.Owner = 'x';
                b2.LeftNodeX += 1;
                c1.TopNodeX += 1;
                c2.TopLeftNodeX += 1;
                a1.BottomNodeX += 1;
                a2.BottomLeftNodeX += 1;
                b1Button.BackColor = System.Drawing.Color.SlateBlue;
                b1Button.Text = "X";
                b1Button.Enabled = false;
            }
            else
            {
                b1.Owner = 'o';
                b2.LeftNodeO += 1;
                c1.TopNodeO += 1;
                c2.TopLeftNodeO += 1;
                a1.BottomNodeO += 1;
                a2.BottomLeftNodeO += 1;
                b1Button.BackColor = System.Drawing.Color.YellowGreen;
                b1Button.Text = "O";
                b1Button.Enabled = false;
            }
            play();
        }
        private void b2Button_Click(object sender, EventArgs e)
        {
            clickB2();
        }
        private void clickB2()
        {
            if (player1.turn == true)
            {
                b2.Owner = 'x';
                b1.RightNodeX += 1;
                b3.LeftNodeX += 1;
                c1.TopRightNodeX += 1;
                c2.TopNodeX += 1;
                c3.TopLeftNodeX += 1;
                a1.BottomRightNodeX += 1;
                a2.BottomNodeX += 1;
                a3.BottomLeftNodeX += 1;
                b2Button.BackColor = System.Drawing.Color.SlateBlue;
                b2Button.Text = "X";
                b2Button.Enabled = false;
            }
            else
            {
                b2.Owner = 'o';
                b1.RightNodeO += 1;
                b3.LeftNodeO += 1;
                c1.TopRightNodeO += 1;
                c2.TopNodeO += 1;
                c3.TopLeftNodeO += 1;
                a1.BottomRightNodeO += 1;
                a2.BottomNodeO += 1;
                a3.BottomLeftNodeO += 1;
                b2Button.BackColor = System.Drawing.Color.YellowGreen;
                b2Button.Text = "O";
                b2Button.Enabled = false;
            }
            play();
        }
        private void b3Button_Click(object sender, EventArgs e)
        {
            clickB3();
        }
        private void clickB3()
        {
            if (player1.turn == true)
            {
                b3.Owner = 'x';
                b2.RightNodeX += 1;
                b4.LeftNodeX += 1;
                c2.TopRightNodeX += 1;
                c3.TopNodeX += 1;
                c4.TopLeftNodeX += 1;
                a2.BottomRightNodeX += 1;
                a3.BottomNodeX += 1;
                a4.BottomLeftNodeX += 1;
                b3Button.BackColor = System.Drawing.Color.SlateBlue;
                b3Button.Text = "X";
                b3Button.Enabled = false;
            }
            else
            {
                b3.Owner = 'o';
                b2.RightNodeO += 1;
                b4.LeftNodeO += 1;
                c2.TopRightNodeO += 1;
                c3.TopNodeO += 1;
                c4.TopLeftNodeO += 1;
                a2.BottomRightNodeO += 1;
                a3.BottomNodeO += 1;
                a4.BottomLeftNodeO += 1;
                b3Button.BackColor = System.Drawing.Color.YellowGreen;
                b3Button.Text = "O";
                b3Button.Enabled = false;
            }
            play();
        }

        private void b4Button_Click(object sender, EventArgs e)
        {
            clickB4();
        }
        private void clickB4()
        {
            if (player1.turn == true)
            {
                b4.Owner = 'x';
                b3.RightNodeX += 1;
                b5.LeftNodeX += 1;
                c3.TopRightNodeX += 1;
                c4.TopNodeX += 1;
                c5.TopLeftNodeX += 1;
                a3.BottomRightNodeX += 1;
                a4.BottomNodeX += 1;
                a5.BottomLeftNodeX += 1;
                b4Button.BackColor = System.Drawing.Color.SlateBlue;
                b4Button.Text = "X";
                b4Button.Enabled = false;
            }
            else
            {
                b4.Owner = 'o';
                b3.RightNodeO += 1;
                b5.LeftNodeO += 1;
                c3.TopRightNodeO += 1;
                c4.TopNodeO += 1;
                c5.TopLeftNodeO += 1;
                a3.BottomRightNodeO += 1;
                a4.BottomNodeO += 1;
                a5.BottomLeftNodeO += 1;
                b4Button.BackColor = System.Drawing.Color.YellowGreen;
                b4Button.Text = "O";
                b4Button.Enabled = false;
            }
            play();
        }

        private void b5Button_Click(object sender, EventArgs e)
        {
            clickB5();
        }
        private void clickB5()
        {
            if (player1.turn == true)
            {
                b5.Owner = 'x';
                b4.RightNodeX += 1;
                c4.TopRightNodeX += 1;
                c5.TopNodeX += 1;
                a4.BottomRightNodeX += 1;
                a5.BottomNodeX += 1;
                b5Button.BackColor = System.Drawing.Color.SlateBlue;
                b5Button.Text = "X";
                b5Button.Enabled = false;
            }
            else
            {
                b5.Owner = 'o';
                b4.RightNodeO += 1;
                c4.TopRightNodeO += 1;
                c5.TopNodeO += 1;
                a4.BottomRightNodeO += 1;
                a5.BottomNodeO += 1;
                b5Button.BackColor = System.Drawing.Color.YellowGreen;
                b5Button.Text = "O";
                b5Button.Enabled = false;
            }
            play();
        }

        private void c1Button_Click(object sender, EventArgs e)
        {
            clickC1();
        }
        private void clickC1()
        {
            if (player1.turn == true)
            {
                c1.Owner = 'x';
                c2.LeftNodeX += 1;
                d1.TopNodeX += 1;
                d2.TopLeftNodeX += 1;
                b1.BottomNodeX += 1;
                b2.BottomLeftNodeX += 1;
                c1Button.BackColor = System.Drawing.Color.SlateBlue;
                c1Button.Text = "X";
                c1Button.Enabled = false;
            }
            else
            {
                c1.Owner = 'o';
                c2.LeftNodeO += 1;
                d1.TopNodeO += 1;
                d2.TopLeftNodeO += 1;
                b1.BottomNodeO += 1;
                b2.BottomLeftNodeO += 1;
                c1Button.BackColor = System.Drawing.Color.YellowGreen;
                c1Button.Text = "O";
                c1Button.Enabled = false;
            }
            play();
        }
        private void c2Button_Click(object sender, EventArgs e)
        {
            clickC2();
        }
        private void clickC2()
        {
            if (player1.turn == true)
            {
                c2.Owner = 'x';
                c1.RightNodeX += 1;
                c3.LeftNodeX += 1;
                d1.TopRightNodeX += 1;
                d2.TopNodeX += 1;
                d3.TopLeftNodeX += 1;
                b1.BottomRightNodeX += 1;
                b2.BottomNodeX += 1;
                b3.BottomLeftNodeX += 1;
                c2Button.BackColor = System.Drawing.Color.SlateBlue;
                c2Button.Text = "X";
                c2Button.Enabled = false;
            }
            else
            {
                c2.Owner = 'o';
                c1.RightNodeO += 1;
                c3.LeftNodeO += 1;
                d1.TopRightNodeO += 1;
                d2.TopNodeO += 1;
                d3.TopLeftNodeO += 1;
                b1.BottomRightNodeO += 1;
                b2.BottomNodeO += 1;
                b3.BottomLeftNodeO += 1;
                c2Button.BackColor = System.Drawing.Color.YellowGreen;
                c2Button.Text = "O";
                c2Button.Enabled = false;
            }
            play();
        }
        private void c3Button_Click(object sender, EventArgs e)
        {
            clickC3();
        }
        private void clickC3()
        {
            if (player1.turn == true)
            {
                c3.Owner = 'x';
                c2.RightNodeX += 1;
                c4.LeftNodeX += 1;
                d2.TopRightNodeX += 1;
                d3.TopNodeX += 1;
                d4.TopLeftNodeX += 1;
                b2.BottomRightNodeX += 1;
                b3.BottomNodeX += 1;
                b4.BottomLeftNodeX += 1;
                c3Button.BackColor = System.Drawing.Color.SlateBlue;
                c3Button.Text = "X";
                c3Button.Enabled = false;
            }
            else
            {
                c3.Owner = 'o';
                c2.RightNodeO += 1;
                c4.LeftNodeO += 1;
                d2.TopRightNodeO += 1;
                d3.TopNodeO += 1;
                d4.TopLeftNodeO += 1;
                b2.BottomRightNodeO += 1;
                b3.BottomNodeO += 1;
                b4.BottomLeftNodeO += 1;
                c3Button.BackColor = System.Drawing.Color.YellowGreen;
                c3Button.Text = "O";
                c3Button.Enabled = false;
            }
            play();
        }
        private void c4Button_Click(object sender, EventArgs e)
        {
            clickC4();
        }
        private void clickC4()
        {
            if (player1.turn == true)
            {
                c4.Owner = 'x';
                c3.RightNodeX += 1;
                c5.LeftNodeX += 1;
                d3.TopRightNodeX += 1;
                d4.TopNodeX += 1;
                d5.TopLeftNodeX += 1;
                b3.BottomRightNodeX += 1;
                b4.BottomNodeX += 1;
                b5.BottomLeftNodeX += 1;
                c4Button.BackColor = System.Drawing.Color.SlateBlue;
                c4Button.Text = "X";
                c4Button.Enabled = false;
            }
            else
            {
                c4.Owner = 'o';
                c3.RightNodeO += 1;
                c5.LeftNodeO += 1;
                d3.TopRightNodeO += 1;
                d4.TopNodeO += 1;
                d5.TopLeftNodeO += 1;
                b3.BottomRightNodeO += 1;
                b4.BottomNodeO += 1;
                b5.BottomLeftNodeO += 1;
                c4Button.BackColor = System.Drawing.Color.YellowGreen;
                c4Button.Text = "O";
                c4Button.Enabled = false;
            }
            play();
        }
        private void c5Button_Click(object sender, EventArgs e)
        {
            clickC5();
        }
        private void clickC5()
        {
            if (player1.turn == true)
            {
                c5.Owner = 'x';
                c4.RightNodeX += 1;
                d4.TopRightNodeX += 1;
                d5.TopNodeX += 1;
                b4.BottomRightNodeX += 1;
                b5.BottomNodeX += 1;
                c5Button.BackColor = System.Drawing.Color.SlateBlue;
                c5Button.Text = "X";
                c5Button.Enabled = false;
            }
            else
            {
                c5.Owner = 'o';
                c4.RightNodeO += 1;
                d4.TopRightNodeO += 1;
                d5.TopNodeO += 1;
                b4.BottomRightNodeO += 1;
                b5.BottomNodeO += 1;
                c5Button.BackColor = System.Drawing.Color.YellowGreen;
                c5Button.Text = "O";
                c5Button.Enabled = false;
            }
            play();
        }
        private void d1Button_Click(object sender, EventArgs e)
        {
            clickD1();
        }
        private void clickD1()
        {
            if (player1.turn == true)
            {
                d1.Owner = 'x';
                d2.LeftNodeX += 1;
                e1.TopNodeX += 1;
                e2.TopLeftNodeX += 1;
                c1.BottomNodeX += 1;
                c2.BottomLeftNodeX += 1;
                d1Button.BackColor = System.Drawing.Color.SlateBlue;
                d1Button.Text = "X";
                d1Button.Enabled = false;
            }
            else
            {
                d1.Owner = 'o';
                d2.LeftNodeO += 1;
                e1.TopNodeO += 1;
                e2.TopLeftNodeO += 1;
                c1.BottomNodeO += 1;
                c2.BottomLeftNodeO += 1;
                d1Button.BackColor = System.Drawing.Color.YellowGreen;
                d1Button.Text = "O";
                d1Button.Enabled = false;
            }
            play();
        }
        private void d2Button_Click(object sender, EventArgs e)
        {
            clickD2();
        }
        private void clickD2()
        {
            if (player1.turn == true)
            {
                d2.Owner = 'x';
                d1.RightNodeX += 1;
                d3.LeftNodeX += 1;
                e1.TopRightNodeX += 1;
                e2.TopNodeX += 1;
                e3.TopLeftNodeX += 1;
                c1.BottomRightNodeX += 1;
                c2.BottomNodeX += 1;
                c3.BottomLeftNodeX += 1;
                d2Button.BackColor = System.Drawing.Color.SlateBlue;
                d2Button.Text = "X";
                d2Button.Enabled = false;
            }
            else
            {
                d2.Owner = 'o';
                d1.RightNodeO += 1;
                d3.LeftNodeO += 1;
                e1.TopRightNodeO += 1;
                e2.TopNodeO += 1;
                e3.TopLeftNodeO += 1;
                c1.BottomRightNodeO += 1;
                c2.BottomNodeO += 1;
                c3.BottomLeftNodeO += 1;
                d2Button.BackColor = System.Drawing.Color.YellowGreen;
                d2Button.Text = "O";
                d2Button.Enabled = false;
            }
            play();
        }
        private void d3Button_Click(object sender, EventArgs e)
        {
            clickD3();
        }
        private void clickD3()
        {
            if (player1.turn == true)
            {
                d3.Owner = 'x';
                d2.RightNodeX += 1;
                d4.LeftNodeX += 1;
                e2.TopRightNodeX += 1;
                e3.TopNodeX += 1;
                e4.TopLeftNodeX += 1;
                c2.BottomRightNodeX += 1;
                c3.BottomNodeX += 1;
                c4.BottomLeftNodeX += 1;
                d3Button.BackColor = System.Drawing.Color.SlateBlue;
                d3Button.Text = "X";
                d3Button.Enabled = false;
            }
            else
            {
                d3.Owner = 'o';
                d2.RightNodeO += 1;
                d4.LeftNodeO += 1;
                e2.TopRightNodeO += 1;
                e3.TopNodeO += 1;
                e4.TopLeftNodeO += 1;
                c2.BottomRightNodeO += 1;
                c3.BottomNodeO += 1;
                c4.BottomLeftNodeO += 1;
                d3Button.BackColor = System.Drawing.Color.YellowGreen;
                d3Button.Text = "O";
                d3Button.Enabled = false;
            }
            play();
        }
        private void d4Button_Click(object sender, EventArgs e)
        {
            clickD4();
        }
        private void clickD4()
        {
            if (player1.turn == true)
            {
                d4.Owner = 'x';
                d3.RightNodeX += 1;
                d5.LeftNodeX += 1;
                e3.TopRightNodeX += 1;
                e4.TopNodeX += 1;
                e5.TopLeftNodeX += 1;
                c3.BottomRightNodeX += 1;
                c4.BottomNodeX += 1;
                c5.BottomLeftNodeX += 1;
                d4Button.BackColor = System.Drawing.Color.SlateBlue;
                d4Button.Text = "X";
                d4Button.Enabled = false;
            }
            else
            {
                d4.Owner = 'o';
                d3.RightNodeO += 1;
                d5.LeftNodeO += 1;
                e3.TopRightNodeO += 1;
                e4.TopNodeO += 1;
                e5.TopLeftNodeO += 1;
                c3.BottomRightNodeO += 1;
                c3.BottomNodeO += 1;
                c5.BottomLeftNodeO += 1;
                d4Button.BackColor = System.Drawing.Color.YellowGreen;
                d4Button.Text = "O";
                d4Button.Enabled = false;
            }
            play();
        }
        private void d5Button_Click(object sender, EventArgs e)
        {
            clickD5();
        }
        private void clickD5()
        {
            if (player1.turn == true)
            {
                d5.Owner = 'x';
                d4.RightNodeX += 1;
                e4.TopRightNodeX += 1;
                e5.TopNodeX += 1;
                c4.BottomRightNodeX += 1;
                c5.BottomNodeX += 1;
                d5Button.BackColor = System.Drawing.Color.SlateBlue;
                d5Button.Text = "X";
                d5Button.Enabled = false;
            }
            else
            {
                d5.Owner = 'o';
                d4.RightNodeO += 1;
                e4.TopRightNodeO += 1;
                e5.TopNodeO += 1;
                c4.BottomRightNodeO += 1;
                c5.BottomNodeO += 1;
                d5Button.BackColor = System.Drawing.Color.YellowGreen;
                d5Button.Text = "O";
                d5Button.Enabled = false;
            }
            play();
        }
        private void e1Button_Click(object sender, EventArgs e)
        {
            clickE1();
        }
        private void clickE1()
        {
            if (player1.turn == true)
            {
                e1.Owner = 'x';
                e2.LeftNodeX += 1;
                d1.BottomNodeX += 1;
                d2.BottomLeftNodeX += 1;
                e1Button.BackColor = System.Drawing.Color.SlateBlue;
                e1Button.Text = "X";
                e1Button.Enabled = false;
            }
            else
            {
                e1.Owner = 'o';
                e2.LeftNodeO += 1;
                d1.BottomNodeO += 1;
                d2.BottomLeftNodeO += 1;
                e1Button.BackColor = System.Drawing.Color.YellowGreen;
                e1Button.Text = "O";
                e1Button.Enabled = false;
            }
            play();
        }
        private void e2Button_Click(object sender, EventArgs e)
        {
            clickE2();
        }
        private void clickE2()
        {
            if (player1.turn == true)
            {
                e2.Owner = 'x';
                e1.RightNodeX += 1;
                e3.LeftNodeX += 1;
                d1.BottomRightNodeX += 1;
                d2.BottomNodeX += 1;
                d3.BottomLeftNodeX += 1;
                e2Button.BackColor = System.Drawing.Color.SlateBlue;
                e2Button.Text = "X";
                e2Button.Enabled = false;
            }
            else
            {
                e2.Owner = 'o';
                e1.RightNodeO += 1;
                e3.LeftNodeO += 1;
                d1.BottomRightNodeO += 1;
                d2.BottomNodeO += 1;
                d3.BottomLeftNodeO += 1;
                e2Button.BackColor = System.Drawing.Color.YellowGreen;
                e2Button.Text = "O";
                e2Button.Enabled = false;
            }
            play();
        }

        private void e3Button_Click(object sender, EventArgs e)
        {
            clickE3();
        }
        private void clickE3()
        {
            if (player1.turn == true)
            {
                e3.Owner = 'x';
                e2.RightNodeX += 1;
                e4.LeftNodeX += 1;
                d2.BottomRightNodeX += 1;
                d3.BottomNodeX += 1;
                d4.BottomLeftNodeX += 1;
                e3Button.BackColor = System.Drawing.Color.SlateBlue;
                e3Button.Text = "X";
                e3Button.Enabled = false;
            }
            else
            {
                e3.Owner = 'o';
                e2.RightNodeO += 1;
                e4.LeftNodeO += 1;
                d2.BottomRightNodeO += 1;
                d3.BottomNodeO += 1;
                d4.BottomLeftNodeO += 1;
                e3Button.BackColor = System.Drawing.Color.YellowGreen;
                e3Button.Text = "O";
                e3Button.Enabled = false;
            }
            play();
        }
        private void e4Button_Click(object sender, EventArgs e)
        {
            clickE4();
        }
        private void clickE4()
        {
            if (player1.turn == true)
            {
                e4.Owner = 'x';
                e3.RightNodeX += 1;
                e5.LeftNodeX += 1;
                d3.BottomRightNodeX += 1;
                d4.BottomNodeX += 1;
                d5.BottomLeftNodeX += 1;
                e4Button.BackColor = System.Drawing.Color.SlateBlue;
                e4Button.Text = "X";
                e4Button.Enabled = false;
            }
            else
            {
                e4.Owner = 'o';
                e3.RightNodeO += 1;
                e5.LeftNodeO += 1;
                d3.BottomRightNodeO += 1;
                d4.BottomNodeO += 1;
                d5.BottomLeftNodeO += 1;
                e4Button.BackColor = System.Drawing.Color.YellowGreen;
                e4Button.Text = "O";
                e4Button.Enabled = false;
            }
            play();
        }
        private void e5Button_Click(object sender, EventArgs e)
        {
            clickE5();
        }
        private void clickE5()
        {
            if (player1.turn == true)
            {
                e5.Owner = 'x';
                e4.RightNodeX += 1;
                d4.BottomRightNodeX += 1;
                d5.BottomNodeX += 1;
                e5Button.BackColor = System.Drawing.Color.SlateBlue;
                e5Button.Text = "X";
                e5Button.Enabled = false;
            }
            else
            {
                e5.Owner = 'o';
                e4.RightNodeO += 1;
                d4.BottomRightNodeO += 1;
                d5.BottomNodeO += 1;
                e5Button.BackColor = System.Drawing.Color.YellowGreen;
                e5Button.Text = "O";
                e5Button.Enabled = false;
            }
            play();
        }

       

    }
}
