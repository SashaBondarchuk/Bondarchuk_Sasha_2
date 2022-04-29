using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Щоб створити дерево, задайте кількість гілок");
            Tree tree = new Tree(branchCount: int.Parse(Console.ReadLine()));

            Console.WriteLine($"\n{tree}");

            tree.ToBloom();
            tree.LeavesToTurnYellow();
            Console.WriteLine($"Колір листя: {tree.branches[0].leaves[0].LeafColor}");
            tree.LeavesToFall();
            tree.ToFrost();

            Console.WriteLine("\nЩоб створити дерево, задайте кількість гілок");
            Tree tree2 = new Tree(branchCount: int.Parse(Console.ReadLine()));
            Console.WriteLine($"\n{tree2}");
            //Console.WriteLine(tree.Equals(tree2) ? "Дерева однакові" : "Дерева різні");
            //Console.WriteLine(tree.GetHashCode());
            //Console.WriteLine(tree2.GetHashCode());
        }
    }
}
