using System;
using System.Collections.Generic;
using System.Threading;

namespace TicTacToe
{
    public class Minimax
    {
        BoardState currentBoard;
        private Player currentPlayer;
        private Player opponentPlayer;


        public  BestMove getNextMove(Board board)
        {
            currentBoard = new BoardState(board);
            currentPlayer = Board.p1Turn ? board.player2 : board.player1;
            opponentPlayer = Board.p1Turn ? board.player1 : board.player2;

            BestMove bestMove = minimax(5, currentPlayer, Int32.MinValue, Int32.MaxValue);


            return bestMove;
        }

        public int evaluate()
        {
            int score = 0;
            Owner currentPlayerOwner = BoardState.GetOwner(currentPlayer.token);
            Owner opponentPlayerOwner = BoardState.GetOwner(opponentPlayer.token);

            score += EvaluateWin(currentBoard.win1, currentPlayerOwner,opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win2, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win3, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win4, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win5, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win6, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win7, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win8, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win9, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win10, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win11, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win12, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win13, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win14, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win15, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win16, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win17, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win18, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win19, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win20, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win21, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win22, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win23, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win24, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win25, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win26, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win27, currentPlayerOwner, opponentPlayerOwner);
            score += EvaluateWin(currentBoard.win28, currentPlayerOwner, opponentPlayerOwner);
          
            return score;
        }

        private int EvaluateWin(List<BoardSpace> win, Owner currentPlayerOwner, Owner opponentPlayerOwner)
        {
            int score = 0;
            BoardSpace firstSpace = win[0];
            BoardSpace secondSpace = win[1];
            BoardSpace thirdSpace = win[2];
            BoardSpace fourthSpace = win[3];


            // firstSpace evaluation
            if (firstSpace.owner == currentPlayerOwner)
            {
                score = 1;
            }
            else if (firstSpace.owner == opponentPlayerOwner)
            {
                score = -1;
            }

            // secondSpace evaluation
            if (secondSpace.owner == currentPlayerOwner)
            {
                if (score == 1) //firstSpace is currentPlayer
                {
                    score = 10;
                }
                else if (score == -1)
                {
                    return 0;
                }
                else //firstSpace is empty
                {
                    score = 1;
                }
            }
            else if (secondSpace.owner == opponentPlayerOwner)
            {
                if (score == -1)
                {
                    score = -10;
                }
                else if (score == 1)
                {
                    return 0;
                }
                else
                {
                    score = -1;
                }
            }

            // thirdSpace evaluation
            if (thirdSpace.owner == currentPlayerOwner)
            {
                if (score > 0) //firstSpace or secondSpace is currentPlayer
                {
                    score *= 10;
                }
                else if (score < 0)
                {
                    return 0;
                }
                else //firstSpace is empty
                {
                    score = 1;
                }
            }
            else if (thirdSpace.owner == opponentPlayerOwner)
            {
                if (score < 0)
                {
                    score *= 10;
                }
                else if (score > 1)
                {
                    return 0;
                }
                else
                {
                    score = -1;
                }
            }

            // fourthSpace evaluation
            if (fourthSpace.owner == currentPlayerOwner)
            {
                if (score > 0) //firstSpace or secondSpace is currentPlayer
                {
                    score *= 10;
                }
                else if (score < 0)
                {
                    return 0;
                }
                else //firstSpace is empty
                {
                    score = 1;
                }
            }
            else if (fourthSpace.owner == opponentPlayerOwner)
            {
                if (score < 0)
                {
                    score *= 10;
                }
                else if (score > 1)
                {
                    return 0;
                }
                else
                {
                    score = -1;
                }
            }
            
            return score;
        }

        private BestMove minimax(int depth, Player player, int alpha, int beta)
        {
            BestMove currentMove;
            List<BoardSpace> spaces = generateMoves();

            spaces.Shuffle();
            int score;
            string bestPosition = null;
            
            

            if (spaces.Count == 0 || depth == 0)
            {
                score = evaluate();
                return  new BestMove(score,bestPosition);
            }
            else
            {
                foreach (BoardSpace space in spaces)
                {
                    space.owner = BoardState.GetOwner(player.Token);
                    if (player.Token == currentPlayer.Token)
                    {
                        currentMove = minimax(depth - 1, opponentPlayer,alpha,beta);
                        score = currentMove.Score;
                        if (score>alpha)
                        {
                            alpha = score;
                            bestPosition = space.position;
                        }
                    }
                    else
                    {
                        currentMove = minimax(depth - 1, currentPlayer,alpha,beta);
                        score = currentMove.Score;
                        if (score < beta)
                        {
                            beta = score;
                            bestPosition = space.position;
                        }
                       
                    }
                    space.owner = Owner.Empty;
                    if (alpha >= beta)
                    {
                        break;
                    }

                }
            }

            return new BestMove((player.Token == currentPlayer.Token)?alpha:beta, bestPosition);
        }

        private List<BoardSpace> generateMoves()
        {
            List<BoardSpace> nextMoves = new List<BoardSpace>();

            if (currentBoard.IsWin() != null) //somebody won
            {
                return nextMoves;
            }

            foreach (BoardSpace spaceOwner in currentBoard.allSpaces)
            {
                if (spaceOwner.owner == Owner.Empty)
                {
                    nextMoves.Add(spaceOwner);
                }
            }

            return nextMoves;
        }
    }


    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class Shuffler
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

}