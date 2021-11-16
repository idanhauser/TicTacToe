namespace B21_Ex05
{
    public class Player
    {
        private readonly ePlayers r_PlayerType;

        private readonly Cell.eSign r_PlayerSign;

        private int m_PlayerScore;

        public enum ePlayers
        {
            Human,
            Computer
        }

        public Player(Cell.eSign i_Sign, ePlayers i_PlayerType)
        {
            r_PlayerSign = i_Sign;
            r_PlayerType = i_PlayerType;
            m_PlayerScore = 0;
        }

        public int Score
        {
            get { return m_PlayerScore; }
            set { m_PlayerScore = value; }
        }

        public Cell.eSign Sign
        {
            get { return r_PlayerSign; }
        }

        public Player.ePlayers PlayerType
        {
            get { return r_PlayerType; }
        }
    }
}