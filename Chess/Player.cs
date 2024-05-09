namespace Chess
{
    public class Player
    {
        public int id;
        public string Name;
        private string v;
        private object white;

        public Player(string v, object white)
        {
            this.v = v;
            this.white = white;
        }
    }
}
