using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class FormTicTacToeMisere : Form
    {
        private int m_BoardSize;
        private Button[,] m_ButtonArray;

        public FormTicTacToeMisere(int i_BoardSize)
        {
            InitializeComponent();
            m_BoardSize = i_BoardSize;
        }

        public int BoardSize
        {
            get { return m_BoardSize; }
            set { m_BoardSize = value; }
        }

        public int Player1Score
        {
            get { return int.Parse(player1Score.Text); }
            set { player1Score.Text = value.ToString(); }
        }

        public int Player2Score
        {
            get { return int.Parse(player2Score.Text); }
            set { player2Score.Text = value.ToString(); }
        }

        public string Player1Lable
        {
            set { player2Score.Text = value; }
        }

        public string Player2Lable
        {
            set { player2Score.Text = value; }
        }

        public Button[,] ButtonsArray
        {
            get { return m_ButtonArray; }
            set { m_ButtonArray = value; }
        }

        private void FormTicTacToeMisere_Load(object sender, EventArgs e)
        {
        }

        internal void SwapPlayerBold()
        {
            if(player1Lable.Font.Bold == true)
            {
                player2Lable.Font = new Font(player2Lable.Font, FontStyle.Bold);
                player2Score.Font = new Font(player2Score.Font, FontStyle.Bold);

                player1Lable.Font = new Font(player1Lable.Font, FontStyle.Regular);
                player1Score.Font = new Font(player1Score.Font, FontStyle.Regular);
            }
            else
            {
                player1Lable.Font = new Font(player1Lable.Font, FontStyle.Bold);
                player1Score.Font = new Font(player1Score.Font, FontStyle.Bold);

                player2Lable.Font = new Font(player2Lable.Font, FontStyle.Regular);
                player2Score.Font = new Font(player2Score.Font, FontStyle.Regular);
            }
        }

        internal void RestartBoard()
        {
            boldPlayer1();

            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    m_ButtonArray[i, j].BackColor = Color.Transparent;
                    m_ButtonArray[i, j].Text = string.Empty;
                    m_ButtonArray[i, j].Enabled = true;
                }
            } 
        }

        private void boldPlayer1()
        {
            if(player2Lable.Font.Bold == true)
            {
                SwapPlayerBold();
            }
        }
    }
}
