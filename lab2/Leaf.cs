namespace lab2
{
    enum Color
    {
        Green,
        Yellow
    }
    internal class Leaf
    {
        private Color leafColor = Color.Green;
        public Color LeafColor
        {
            get { return leafColor; }
            set { leafColor = value; }
        }
    }
}