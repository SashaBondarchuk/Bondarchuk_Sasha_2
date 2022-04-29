namespace lab2
{
    internal class Branch
    {
        public int LeafCount { get; set; }
        public Leaf[] leaves;
        public Branch(int leafCount)
        {
            if (leafCount < 0)
                LeafCount = 0;
            else
                LeafCount = leafCount;

            leaves = new Leaf[leafCount];

            for (int i = 0; i < leafCount; i++)
            {
                leaves[i] = new Leaf();
            }
        }
    }
}