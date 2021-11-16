using System;
using System.Drawing;

namespace B21_Ex05
{
    public class Game
    {
        private readonly Player r_Player1;
        private readonly Player r_Player2;

        private Board m_GameBoard;
        private Player m_CurrentPlayer;

        public Game(Player.ePlayers i_OpponentMode, int i_BoardSize)
        {
            m_GameBoard = new Board(i_BoardSize);
            r_Player1 = new Player(Cell.eSign.X, Player.ePlayers.Human);
            r_Player2 = new Player(Cell.eSign.O, i_OpponentMode);
            m_CurrentPlayer = r_Player1;
        }

        public bool IncreaseWinnerScore(Player i_Winner)
        {
            bool isIncreased = false;
            if (i_Winner != null)
            {
                i_Winner.Score++;
                isIncreased = true;
            }

            return isIncreased;
        }

        public bool isLosing()
        {
            return m_GameBoard.CheckForSeries(m_CurrentPlayer.Sign);
        }

        public bool IsFull()
        {
            return m_GameBoard.IsFull();
        }

        public void humanPlayerMove(Point i_Position)
        {
            m_GameBoard[i_Position.X, i_Position.Y].Sign = m_CurrentPlayer.Sign;
        }

        public Point computerPlayerMove()
        {
            Point position = ArtificialIntelligence.ComputerPlayerMove(m_GameBoard);
            m_GameBoard[position.X, position.Y].Sign = m_CurrentPlayer.Sign;
            return position;
        }

        public Board Board
        {
            get { return m_GameBoard; }
        }

        public Player CurrentPlayer
        {
            get { return m_CurrentPlayer; }
        }

        public Player Player1
        {
            get { return r_Player1; }
        }

        public Player SwapPlayer()
        {
            if (m_CurrentPlayer == r_Player1)
            {
                m_CurrentPlayer = r_Player2;
            }
            else
            {
                m_CurrentPlayer = r_Player1;
            }

            return m_CurrentPlayer;
        }

        public void RestartGame()
        {
            m_GameBoard.ResetBoard();

            m_CurrentPlayer = r_Player1;
        }
    }
}
