namespace B21_Ex05
{
    public class Cell
    {
        private eSign m_Sign = eSign.Empty;

        public enum eSign
        {
            Empty = ' ',
            X = 'X',
            O = 'O'
        }

        public Cell()
        {
            m_Sign = eSign.Empty;
        }

        public Cell.eSign Sign
        {
            get { return m_Sign; }
            set { m_Sign = value; }
        }

        public bool isEmpty()
        {
            return m_Sign == Cell.eSign.Empty;
        }

        public void ResetCell()
        {
            m_Sign = Cell.eSign.Empty;
        }
    }
}