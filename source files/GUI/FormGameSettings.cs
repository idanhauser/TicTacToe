using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B21_Ex05;

namespace TicTacToeGUI
{
    public partial class FormGameSettings : Form
    {
        const string k_defultText = "[Computer]";
        private int m_BoardSize = 3;

        public FormGameSettings()
        {
            InitializeComponent();
        }

        private void FormWindowControl_Load(object sender, EventArgs e)
        {

        }

        private void button_StartGame(object sender, EventArgs e)
        {
            this.Visible = false;
            GameManager newGame;

            if (checkBoxPlayer2.Checked == true)
            {
                newGame = new GameManager(m_BoardSize, Player.ePlayers.Human);
            }
            else
            {
                newGame = new GameManager(m_BoardSize, Player.ePlayers.Computer);
            }
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked == true)
            {
                textBoxNamePlayer2.Enabled = true;
                textBoxNamePlayer2.Text = "";
            }
            else
            {
                textBoxNamePlayer2.Enabled = false;
                textBoxNamePlayer2.Text = k_defultText;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked == true)
            {
                textBoxNamePlayer2.Enabled = true;
            }
            else
            {
                textBoxNamePlayer2.Enabled = false;
                textBoxNamePlayer2.Text = k_defultText;
            }
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
           m_BoardSize = (int)numericUpDownRows.Value;
            this.numericUpDownCols.Value = m_BoardSize;
        }

        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            m_BoardSize = (int)numericUpDownCols.Value;
            this.numericUpDownRows.Value = m_BoardSize;
        }
    }
}
