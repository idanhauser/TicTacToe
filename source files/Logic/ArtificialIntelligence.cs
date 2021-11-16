using System;
using System.Drawing;

namespace B21_Ex05
{
    public class ArtificialIntelligence
    {
        private const int k_BestValue = int.MaxValue;
        private const int k_WorstValue = int.MinValue;
        private const int k_VictoryValue = 10;
        private static int m_RandomMove;
        private static int m_MaxDepth;

        public static void initComputerPlayer(int i_BoardSize)
        {
            m_RandomMove = i_BoardSize - 1;

            if (i_BoardSize == 3 || i_BoardSize == 4)
            {
                m_MaxDepth = 5;
            }
            else if (i_BoardSize == 9)
            {
                m_MaxDepth = 2;
            }
            else
            {
                m_MaxDepth = 3;
            }
        }

        public static Point ComputerPlayerMove(Board i_GameBoard)
        {
            Point pos = new Point();
            Random rand = new Random();

            if (m_RandomMove == 0 || i_GameBoard.Size == 3)
            {
                pos = AIMove(i_GameBoard);
            }
            else
            {
                do
                {
                    pos.X = rand.Next(0, i_GameBoard.Size);
                    pos.Y = rand.Next(0, i_GameBoard.Size);
                }
                while (!i_GameBoard.CheckIfPositionIsFree(pos));
                m_RandomMove--;
            }

            return pos;
        }

        public static Point AIMove(Board i_GameBoard)
        {
            Point bestMove = new Point(-1, -1);
            int bestVal = k_WorstValue;

            for (var i = 0; i < i_GameBoard.Size; i++)
            {
                for (var j = 0; j < i_GameBoard.Size; j++)
                {
                    if (i_GameBoard[i, j].Sign == Cell.eSign.Empty)
                    {
                        i_GameBoard[i, j].Sign = Cell.eSign.O; // fix - use computer sign
                        int moveVal = miniMax(i_GameBoard, 0, m_MaxDepth, false);
                        i_GameBoard[i, j].Sign = Cell.eSign.Empty;

                        if (moveVal > bestVal)
                        {
                            bestMove.X = i;
                            bestMove.Y = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }

            return bestMove;
        }

        private static int miniMax(Board i_Board, int i_Depth, int i_MaxDepth, bool i_IsMax)
        {
            int score = evaluate(i_Board);

            if (score == k_VictoryValue || score == -k_VictoryValue)
            {
                return score - i_Depth;
            }

            if (i_Board.IsFull() || i_Depth == i_MaxDepth)
            {
                return 0;
            }

            if (i_IsMax)
            {
                int best = k_WorstValue;
                for (int i = 0; i < i_Board.Size; i++)
                {
                    for (int j = 0; j < i_Board.Size; j++)
                    {
                        if (i_Board[i, j].Sign == Cell.eSign.Empty)
                        {
                            i_Board[i, j].Sign = Cell.eSign.O;
                            best = Math.Max(best, miniMax(i_Board, i_Depth + 1, i_MaxDepth, !i_IsMax));
                            i_Board[i, j].Sign = Cell.eSign.Empty;
                        }
                    }
                }

                return best;
            }
            else
            {
                int best = k_BestValue;
                for (int i = 0; i < i_Board.Size; i++)
                {
                    for (int j = 0; j < i_Board.Size; j++)
                    {
                        if (i_Board[i, j].Sign == Cell.eSign.Empty)
                        {
                            i_Board[i, j].Sign = Cell.eSign.X;
                            best = Math.Min(best, miniMax(i_Board, i_Depth + 1, i_MaxDepth, !i_IsMax));
                            i_Board[i, j].Sign = Cell.eSign.Empty;
                        }
                    }
                }

                return best;
            }
        }

        private static int evaluate(Board i_Board)
        {
            Cell.eSign losSign;

            for (var row = 0; row < i_Board.Size; row++)
            {
                if (i_Board.CheckRows(out losSign))
                {
                    if (losSign == Cell.eSign.O)
                    {
                        return -k_VictoryValue;
                    }
                    else if (losSign == Cell.eSign.X)
                    {
                        return k_VictoryValue;
                    }
                }
            }

            for (int col = 0; col < i_Board.Size; col++)
            {
                if (i_Board.CheckColumns(out losSign))
                {
                    if (losSign == Cell.eSign.O)
                    {
                        return -k_VictoryValue;
                    }
                    else if (losSign == Cell.eSign.X)
                    {
                        return k_VictoryValue;
                    }
                }
            }

            if (i_Board.CheckRightDiagonals(out losSign))
            {
                if (losSign == Cell.eSign.O)
                {
                    return -k_VictoryValue;
                }
                else if (losSign == Cell.eSign.X)
                {
                    return k_VictoryValue;
                }
            }

            if (i_Board.CheckLeftDiagonals(out losSign))
            {
                if (losSign == Cell.eSign.O)
                {
                    return -k_VictoryValue;
                }
                else if (losSign == Cell.eSign.X)
                {
                    return k_VictoryValue;
                }
            }

            return 0;
        }
    }
}