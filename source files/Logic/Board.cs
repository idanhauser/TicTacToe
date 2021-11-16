using System.Drawing;

namespace B21_Ex05
{
    public class Board
    {
        private readonly int r_Size;
        private Cell[,] m_GameBoard;

        public Cell[,] GameBoard
        {
            get { return GameBoard; }
            set { GameBoard = value; }
        }

        public int Size
        {
            get { return r_Size; }
        }

        public Board(int i_Size)
        {
            r_Size = i_Size;
            m_GameBoard = new Cell[r_Size, r_Size];

            for (int i = 0; i < r_Size; i++)
            {
                for (int j = 0; j < r_Size; j++)
                {
                    m_GameBoard[i, j] = new Cell();
                }
            }
        }

        public bool IsFull()
        {
            bool isFull = true;

            for (int i = 0; i < r_Size; i++)
            {
                for (int j = 0; j < r_Size; j++)
                {
                    if (m_GameBoard[i, j].isEmpty())
                    {
                        isFull = false;
                        break;
                    }
                }
            }

            return isFull;
        }

        public void ResetBoard()
        {
            for (int i = 0; i < r_Size; i++)
            {
                for (int j = 0; j < r_Size; j++)
                {
                    m_GameBoard[i, j].ResetCell();
                }
            }
        }

        public bool CheckForSeries(Cell.eSign i_Sign)
        {
            bool sequence = false;
            Cell.eSign losSign;

            if (CheckRows(out losSign) || CheckColumns(out losSign) || CheckRightDiagonals(out losSign) || CheckLeftDiagonals(out losSign))
            {
                sequence = true;
            }

            return sequence;
        }

        public bool CheckLeftDiagonals(out Cell.eSign o_LoserSign)
        {
            bool isSameSign;
            Cell.eSign currentSign = m_GameBoard[0, 0].Sign;

            isSameSign = true;
            currentSign = m_GameBoard[0, r_Size - 1].Sign;
            for (int i = 0; i < r_Size && isSameSign; i++)
            {
                if (currentSign == Cell.eSign.Empty)
                {
                    isSameSign = false;
                    continue;
                }

                if (currentSign != m_GameBoard[i, r_Size - 1 - i].Sign)
                {
                    isSameSign = false;
                }
            }

            o_LoserSign = currentSign;
            return isSameSign;
        }

        public bool CheckRightDiagonals(out Cell.eSign o_LoserSign)
        {
            bool isSameSign = true;
            Cell.eSign currentSign = m_GameBoard[0, 0].Sign;

            for (int i = 0; i < r_Size && isSameSign; i++)
            {
                if (currentSign == Cell.eSign.Empty)
                {
                    isSameSign = false;
                    continue;
                }

                if (currentSign != m_GameBoard[i, i].Sign)
                {
                    isSameSign = false;
                }
            }

            o_LoserSign = currentSign;
            return isSameSign;
        }

        public bool CheckIfPositionIsFree(Point i_NewPosition)
        {
            Cell chosenCell = m_GameBoard[i_NewPosition.X, i_NewPosition.Y];
            return chosenCell.Sign == Cell.eSign.Empty;
        }

        public bool CheckColumns(out Cell.eSign o_LoserSign)
        {
            bool isSameSign = true;
            Cell.eSign currentSign = Cell.eSign.Empty;
            for (int i = 0; i < r_Size; i++)
            {
                isSameSign = true;
                currentSign = m_GameBoard[0, i].Sign;

                if (currentSign == Cell.eSign.Empty)
                {
                    isSameSign = false;
                    continue;
                }

                for (int j = 0; j < r_Size && isSameSign; j++)
                {
                    if (currentSign != m_GameBoard[j, i].Sign)
                    {
                        isSameSign = false;
                        continue;
                    }
                }

                if (isSameSign)
                {
                    break;
                }
            }

            o_LoserSign = currentSign;
            return isSameSign;
        }

        public bool CheckRows(out Cell.eSign o_LoserSign)
        {
            Cell.eSign currentSign = Cell.eSign.Empty;
            bool isSameSign = true;

            for (int i = 0; i < r_Size; i++)
            {
                isSameSign = true;
                currentSign = m_GameBoard[i, 0].Sign;
                if (currentSign == Cell.eSign.Empty)
                {
                    isSameSign = false;
                    continue;
                }

                for (int j = 0; j < r_Size && isSameSign; j++)
                {
                    if (currentSign != m_GameBoard[i, j].Sign)
                    {
                        isSameSign = false;
                        continue;
                    }
                }

                if (isSameSign)
                {
                    break;
                }
            }

            o_LoserSign = currentSign;
            return isSameSign;
        }

        public Cell this[int x, int y]
        {
            get { return m_GameBoard[x, y]; }
        }

        public bool IsInBounds(Point i_Position)
        {
            return i_Position.X >= 0 && i_Position.X < r_Size && i_Position.Y >= 0 && i_Position.Y < r_Size;
        }
    }
}