using IdentityMAtrixModifier;

class Program
{
    static void Main(string[] args)
    {
        MatrixCalculator mtCalculator = new MatrixCalculator();
        int[,] initialMatrix = mtCalculator.GenMatrix(3);
        
        Console.WriteLine("Initial matrix");
        mtCalculator.PrintMatrix(initialMatrix);
        Console.WriteLine("Modified Matrix");
        
        int[,] modifiedMatrix = mtCalculator.IdentityMAtrixModifier(initialMatrix);
        mtCalculator.PrintMatrix(modifiedMatrix);
        
        Console.WriteLine("Final state of initial Matrix");
        mtCalculator.PrintMatrix(initialMatrix);
    }

}