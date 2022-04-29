using System;

namespace lab2
{
    internal class Tree
    {
        private int branchCount;

        private int leafCount;

        public Branch[] branches;
        public Tree(int branchCount)
        {
            if (branchCount <= 0)
                this.branchCount = 1;
            else
                this.branchCount = branchCount;

            branches = new Branch[branchCount];

            Console.WriteLine("Задайте кількість листків на гілці");
            leafCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < branchCount; i++)
            {
                branches[i] = new Branch(leafCount);
            }
        }
       
        public void ToBloom() { Console.WriteLine("Дерево зацвіло"); }
        public void ToFrost() { Console.WriteLine("Дерево покрилось інеєм"); }
        public void LeavesToFall() { Console.WriteLine("Листя опало"); }
        public void LeavesToTurnYellow()
        {
            Console.WriteLine("Листя пожовтіло");
            foreach (var branch in branches)
            {
                foreach (var leaf in branch.leaves)
                {
                    leaf.LeafColor = Color.Yellow;
                }
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Tree tree
                ? tree.branches[0].LeafCount == branches[0].LeafCount 
                && tree.branchCount == branchCount 
                && tree.branches[0].leaves[0].LeafColor == branches[0].leaves[0].LeafColor
                : false;
        }
        public bool Equals(Tree obj)
        {
            return obj != null
                ? obj.branches[0].LeafCount == branches[0].LeafCount && obj.branchCount == branchCount && obj.branches[0].leaves[0].LeafColor == branches[0].leaves[0].LeafColor
                : false;
        }
        public override int GetHashCode()
        {
            return branches[0].leaves[0].LeafColor == Color.Green ? branchCount : branchCount + 1;
        }
        public override string ToString()
        {
            return $"Колір листя: {branches[0].leaves[0].LeafColor}\nКількість гілок: {branchCount}\nКількість листків на гілці: {branches[0].LeafCount}\n";
        }
    }
}