using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using B21_Ex05;

namespace TicTacToeGUI
{
    public class GameManager
    {
        private const int k_ButtonSize = 44;
        private readonly int r_boardSize;
        private FormTicTacToeMisere m_GameBoard;
        private Game m_NewGame;
        private Player.ePlayers r_gameType;

        public GameManager(int i_BoardSize, Player.ePlayers i_PlayerType)
        {
            r_gameType = i_PlayerType;
            r_boardSize = i_BoardSize;
            createNewGame(r_boardSize, r_gameType);
            m_GameBoard.ShowDialog();
        }

        private void createNewGame(int i_BoardSize, Player.ePlayers i_GameType)
        {
            m_NewGame = new Game(i_GameType, i_BoardSize);
            m_GameBoard = new FormTicTacToeMisere(i_BoardSize);
            drawBoard();
            m_GameBoard.SwapPlayerBold();
            m_GameBoard.ShowDialog();
        }

        private void drawBoard()
        {
            int horizotal = 10;
            int vertical = 10;

            m_GameBoard.ButtonsArray = new Button[m_GameBoard.BoardSize, m_GameBoard.BoardSize];

            m_GameBoard.Height = (k_ButtonSize * m_GameBoard.BoardSize) + 80;
            m_GameBoard.Width = (k_ButtonSize * m_GameBoard.BoardSize) + 40;

            for (int i = 0; i < m_GameBoard.BoardSize; i++)
            {
                for (int j = 0; j < m_GameBoard.BoardSize; j++)
                {
                    m_GameBoard.ButtonsArray[i, j] = new Button();
                    m_GameBoard.ButtonsArray[i, j].Size = new Size(k_ButtonSize, k_ButtonSize);
                    m_GameBoard.ButtonsArray[i, j].Location = new Point(horizotal, vertical);
                    m_GameBoard.ButtonsArray[i, j].Enabled = true;
                    m_GameBoard.ButtonsArray[i, j].Name = string.Format("{0},{1}", i, j);
                    m_GameBoard.Controls.Add(m_GameBoard.ButtonsArray[i, j]);
                    m_GameBoard.ButtonsArray[i, j].Click += button_Click;
                    horizotal += k_ButtonSize;
                }

                vertical += k_ButtonSize;
                horizotal = 10;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string[] pos = clickedButton.Name.Split(',');
            Point currPosition = new Point(int.Parse(pos[0]), int.Parse(pos[1]));

            executeMove(currPosition);
            handleNextMove();
        }
        
        private void executeMove(Point i_CurrPosition)
        {
            executeVisualMove(i_CurrPosition);
            executeLogicMove(i_CurrPosition);
        }

        private void executeVisualMove(Point i_CurrPosition)
        {
            if (m_NewGame.CurrentPlayer == m_NewGame.Player1)
            {
                m_GameBoard.ButtonsArray[i_CurrPosition.X, i_CurrPosition.Y].Text = "X";
                m_GameBoard.ButtonsArray[i_CurrPosition.X, i_CurrPosition.Y].BackColor = Color.Orchid;
            }
            else
            {
                m_GameBoard.ButtonsArray[i_CurrPosition.X, i_CurrPosition.Y].Text = "O";
                m_GameBoard.ButtonsArray[i_CurrPosition.X, i_CurrPosition.Y].BackColor = Color.PaleTurquoise;
            }

            m_GameBoard.ButtonsArray[i_CurrPosition.X, i_CurrPosition.Y].Enabled = false;
        }

        private void executeLogicMove(Point i_CurrPosition)
        {
            m_NewGame.humanPlayerMove(i_CurrPosition);
        }

        private void handleNextMove()
        {
            if (!checkEndGame())
            {
                switchTurn();
                Point position;

                if (m_NewGame.CurrentPlayer.PlayerType == Player.ePlayers.Computer)
                {
                    position = m_NewGame.computerPlayerMove();
                    executeMove(position);
                    checkEndGame();
                    switchTurn();
                }
            }            
        }

        private void switchTurn()
        {
            m_NewGame.SwapPlayer();
            m_GameBoard.SwapPlayerBold();
        }

        private bool checkEndGame()
        {
            bool endGame = false;

            if (m_NewGame.isLosing())
            {
                handleGameOver(m_NewGame.SwapPlayer());
                endGame = true;
            }
            else if (m_NewGame.IsFull())
            {
                handleGameOver(null);
                endGame = true;
            }

            return endGame;
        }

        private void handleGameOver(Player i_WinnerPlayer)
        {
            DialogResult result;
            increaseWinnerScore(i_WinnerPlayer);

            string endOfGameMsg = announceWinner(i_WinnerPlayer);
            endOfGameMsg = endOfGameMsg + Environment.NewLine + @"Do You Want To Play Another Round? ";
            result = MessageBox.Show(endOfGameMsg.ToString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            isPlayAgain(result);
        }

        private void increaseWinnerScore(Player i_WinnerPlayer)
        {
            m_NewGame.IncreaseWinnerScore(i_WinnerPlayer);
            
            if(i_WinnerPlayer != null)
            {
                if (i_WinnerPlayer == m_NewGame.Player1)
                {
                    m_GameBoard.Player1Score++;
                }
                else
                {
                    m_GameBoard.Player2Score++;
                }
            }  
        }

        private void isPlayAgain(DialogResult i_Result)
        {
            if (i_Result == DialogResult.Yes)
            {
                replayGame();
            }
            else if (i_Result == DialogResult.No)
            {
                MessageBox.Show(@"ByeBye");
                m_GameBoard.Close();
                Application.Exit();
            }
        }

        private void replayGame()
        {
            m_NewGame.RestartGame();
            m_GameBoard.RestartBoard();
        }

        private string announceWinner(Player i_Winner)
        {
            string announce;

            if (i_Winner == null)
            {
                announce = string.Format(@"its a Tie!");
            }
            else
            {
                announce = string.Format("the player with the sign '{0}' is the Winner!", i_Winner.Sign.ToString());
            }

            return announce;
        }
    }
}
