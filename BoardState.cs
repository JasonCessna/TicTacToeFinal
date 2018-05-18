using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class BoardState
    {
        public List<BoardSpace> allSpaces = new List<BoardSpace>();
        public BoardSpace a1, a2, a3, a4, a5;
        public BoardSpace b1, b2, b3, b4, b5;
        public BoardSpace c1, c2, c3, c4, c5;
        public BoardSpace d1, d2, d3, d4, d5;
        public BoardSpace e1, e2, e3, e4, e5;

        public List<BoardSpace> win1 = new List<BoardSpace>();
        public List<BoardSpace> win2 = new List<BoardSpace>();
        public List<BoardSpace> win3 = new List<BoardSpace>();
        public List<BoardSpace> win4 = new List<BoardSpace>();
        public List<BoardSpace> win5 = new List<BoardSpace>();
        public List<BoardSpace> win6 = new List<BoardSpace>();
        public List<BoardSpace> win7 = new List<BoardSpace>();
        public List<BoardSpace> win8 = new List<BoardSpace>();
        public List<BoardSpace> win9 = new List<BoardSpace>();
        public List<BoardSpace> win10 = new List<BoardSpace>();
        public List<BoardSpace> win11 = new List<BoardSpace>();
        public List<BoardSpace> win12 = new List<BoardSpace>();
        public List<BoardSpace> win13 = new List<BoardSpace>();
        public List<BoardSpace> win14 = new List<BoardSpace>();
        public List<BoardSpace> win15 = new List<BoardSpace>();
        public List<BoardSpace> win16 = new List<BoardSpace>();
        public List<BoardSpace> win17 = new List<BoardSpace>();
        public List<BoardSpace> win18 = new List<BoardSpace>();
        public List<BoardSpace> win19 = new List<BoardSpace>();
        public List<BoardSpace> win20 = new List<BoardSpace>();
        public List<BoardSpace> win21 = new List<BoardSpace>();
        public List<BoardSpace> win22 = new List<BoardSpace>();
        public List<BoardSpace> win23 = new List<BoardSpace>();
        public List<BoardSpace> win24 = new List<BoardSpace>();
        public List<BoardSpace> win25 = new List<BoardSpace>();
        public List<BoardSpace> win26 = new List<BoardSpace>();
        public List<BoardSpace> win27 = new List<BoardSpace>();
        public List<BoardSpace> win28 = new List<BoardSpace>();


        public BoardState(Board board)
        {
            this.a1 = new BoardSpace(board.a1);
            this.a2 = new BoardSpace(board.a2);
            this.a3 = new BoardSpace(board.a3);
            this.a4 = new BoardSpace(board.a4);
            this.a5 = new BoardSpace(board.a5);
            this.b1 = new BoardSpace(board.b1);
            this.b2 = new BoardSpace(board.b2);
            this.b3 = new BoardSpace(board.b3);
            this.b4 = new BoardSpace(board.b4);
            this.b5 = new BoardSpace(board.b5);
            this.c1 = new BoardSpace(board.c1);
            this.c2 = new BoardSpace(board.c2);
            this.c3 = new BoardSpace(board.c3);
            this.c4 = new BoardSpace(board.c4);
            this.c5 = new BoardSpace(board.c5);
            this.d1 = new BoardSpace(board.d1);
            this.d2 = new BoardSpace(board.d2);
            this.d3 = new BoardSpace(board.d3);
            this.d4 = new BoardSpace(board.d4);
            this.d5 = new BoardSpace(board.d5);
            this.e1 = new BoardSpace(board.e1);
            this.e2 = new BoardSpace(board.e2);
            this.e3 = new BoardSpace(board.e3);
            this.e4 = new BoardSpace(board.e4);
            this.e5 = new BoardSpace(board.e5);

            CollectAllAvailableSpaces();
            CreateAllWinningConditions();
        }

        public static Owner GetOwner(char o)
        {
            if (o.Equals('x'))
            {
                return Owner.X;
            }
            else if (o.Equals('o'))
            {
                return Owner.O;
            }
            else
            {
                return Owner.Empty;
            }

        }

       
        private void CollectAllAvailableSpaces()
        {
            allSpaces.Add(a1);
            allSpaces.Add(a2);
            allSpaces.Add(a3);
            allSpaces.Add(a4);
            allSpaces.Add(a5);
            allSpaces.Add(b1);
            allSpaces.Add(b2);
            allSpaces.Add(b3);
            allSpaces.Add(b4);
            allSpaces.Add(b5);
            allSpaces.Add(c1);
            allSpaces.Add(c2);
            allSpaces.Add(c3);
            allSpaces.Add(c4);
            allSpaces.Add(c5);
            allSpaces.Add(d1);
            allSpaces.Add(d2);
            allSpaces.Add(d3);
            allSpaces.Add(d4);
            allSpaces.Add(d5);
            allSpaces.Add(e1);
            allSpaces.Add(e2);
            allSpaces.Add(e3);
            allSpaces.Add(e4);
            allSpaces.Add(e5);
        }
        private void CreateAllWinningConditions()
        {
            //list off all possible win-scenario spaces
            //row wins
            win1.Add(a1);
            win1.Add(a2);
            win1.Add(a3);
            win1.Add(a4);
            win2.Add(a2);
            win2.Add(a3);
            win2.Add(a4);
            win2.Add(a5);
            win3.Add(b1);
            win3.Add(b2);
            win3.Add(b3);
            win3.Add(b4);
            win4.Add(b2);
            win4.Add(b3);
            win4.Add(b4);
            win4.Add(b5);
            win5.Add(c1);
            win5.Add(c2);
            win5.Add(c3);
            win5.Add(c4);
            win6.Add(c2);
            win6.Add(c3);
            win6.Add(c4);
            win6.Add(c5);
            win7.Add(d1);
            win7.Add(d2);
            win7.Add(d3);
            win7.Add(d4);
            win8.Add(d2);
            win8.Add(d3);
            win8.Add(d4);
            win8.Add(d5);
            win9.Add(e1);
            win9.Add(e2);
            win9.Add(e3);
            win9.Add(e4);
            win10.Add(e2);
            win10.Add(e3);
            win10.Add(e4);
            win10.Add(e5);
            //column wins
            win11.Add(a1);
            win11.Add(b1);
            win11.Add(c1);
            win11.Add(d1);
            win12.Add(b1);
            win12.Add(c1);
            win12.Add(d1);
            win12.Add(e1);
            win13.Add(a2);
            win13.Add(b2);
            win13.Add(c2);
            win13.Add(d2);
            win14.Add(b2);
            win14.Add(c2);
            win14.Add(d2);
            win14.Add(e2);
            win15.Add(a3);
            win15.Add(b3);
            win15.Add(c3);
            win15.Add(d3);
            win16.Add(b3);
            win16.Add(c3);
            win16.Add(d3);
            win16.Add(e3);
            win17.Add(a4);
            win17.Add(b4);
            win17.Add(c4);
            win17.Add(d4);
            win18.Add(b4);
            win18.Add(c4);
            win18.Add(d4);
            win18.Add(e4);
            win19.Add(a5);
            win19.Add(b5);
            win19.Add(c5);
            win19.Add(d5);
            win20.Add(b5);
            win20.Add(c5);
            win20.Add(d5);
            win20.Add(e5);
            //diagonal wins
            win21.Add(a1);
            win21.Add(b2);
            win21.Add(c3);
            win21.Add(d4);
            win22.Add(b2);
            win22.Add(c3);
            win22.Add(d4);
            win22.Add(e5);
            win23.Add(a2);
            win23.Add(b3);
            win23.Add(c4);
            win23.Add(d5);
            win24.Add(b1);
            win24.Add(c2);
            win24.Add(d3);
            win24.Add(e4);
            win25.Add(a5);
            win25.Add(b4);
            win25.Add(c3);
            win25.Add(d2);
            win26.Add(b4);
            win26.Add(c3);
            win26.Add(d2);
            win26.Add(e1);
            win27.Add(a4);
            win27.Add(b3);
            win27.Add(c2);
            win27.Add(d1);
            win28.Add(b5);
            win28.Add(c4);
            win28.Add(d3);
            win28.Add(e2);
        }
        public BoardSpace IsWin()
        {
            Boolean isWin = false;
            if (allSpaces.All(x => x.owner != Owner.Empty))
            {
                
                 return null;
            }
            if (win1.First().owner != Owner.Empty   && win1.All(x => x.owner == win1.First().owner))
                return win1.First();
            else if (win2.First().owner != Owner.Empty && win2.All(x => x.owner == win2.First().owner))
                return win2.First();
            else if (win3.First().owner != Owner.Empty && win3.All(x => x.owner == win3.First().owner))
                return win3.First();
            else if (win4.First().owner != Owner.Empty && win4.All(x => x.owner == win4.First().owner))
                return win4.First();
            else if (win5.First().owner != Owner.Empty && win5.All(x => x.owner == win5.First().owner))
                return win5.First();
            else if (win6.First().owner != Owner.Empty && win6.All(x => x.owner == win6.First().owner))
                return win6.First();
            else if (win7.First().owner != Owner.Empty && win7.All(x => x.owner == win7.First().owner))
                return win7.First();
            else if (win8.First().owner != Owner.Empty && win8.All(x => x.owner == win8.First().owner))
                return win8.First();
            else if (win9.First().owner != Owner.Empty && win9.All(x => x.owner == win9.First().owner))
                return win9.First();
            else if (win10.First().owner != Owner.Empty && win10.All(x => x.owner == win10.First().owner))
                return win10.First();
            else if (win11.First().owner != Owner.Empty && win11.All(x => x.owner == win11.First().owner))
                return win11.First();
            else if (win12.First().owner != Owner.Empty && win12.All(x => x.owner == win12.First().owner))
                return win12.First();
            else if (win13.First().owner != Owner.Empty && win13.All(x => x.owner == win13.First().owner))
                return win13.First();
            else if (win14.First().owner != Owner.Empty && win14.All(x => x.owner == win14.First().owner))
                return win14.First();
            else if (win15.First().owner != Owner.Empty && win15.All(x => x.owner == win15.First().owner))
                return win15.First();
            else if (win16.First().owner != Owner.Empty && win16.All(x => x.owner == win16.First().owner))
                return win16.First();
            else if (win17.First().owner != Owner.Empty && win17.All(x => x.owner == win17.First().owner))
                return win17.First();
            else if (win18.First().owner != Owner.Empty && win18.All(x => x.owner == win18.First().owner))
                return win18.First();
            else if (win19.First().owner != Owner.Empty && win19.All(x => x.owner == win19.First().owner))
                return win19.First();
            else if (win20.First().owner != Owner.Empty && win20.All(x => x.owner == win20.First().owner))
                return win20.First();
            else if (win21.First().owner != Owner.Empty && win21.All(x => x.owner == win21.First().owner))
                return win21.First();
            else if (win22.First().owner != Owner.Empty && win22.All(x => x.owner == win22.First().owner))
                return win22.First();
            else if (win23.First().owner != Owner.Empty && win23.All(x => x.owner == win23.First().owner))
                return win23.First();
            else if (win24.First().owner != Owner.Empty && win24.All(x => x.owner == win24.First().owner))
                return win24.First();
            else if (win25.First().owner != Owner.Empty && win25.All(x => x.owner == win25.First().owner))
                return win25.First();
            else if (win26.First().owner != Owner.Empty && win26.All(x => x.owner == win26.First().owner))
                return win26.First();
            else if (win27.First().owner != Owner.Empty && win27.All(x => x.owner == win27.First().owner))
                return win27.First();
            else if (win28.First().owner != Owner.Empty && win28.All(x => x.owner == win28.First().owner))
                return win28.First();

            return null;
        }


    }
}