using System;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            new FormGameSettings().ShowDialog();
        }
    }
}
