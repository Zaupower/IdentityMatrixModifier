using IdentityMAtrixModifier;

class Program
{
    static void Main(string[] args)
    {
        int lengthRow = 6;
        int lengthCol = 2;
        MatrixCalculator mtCalculator = new MatrixCalculator();
        int[,] initialMatrix = mtCalculator.GenMatrix(lengthRow, lengthCol);
        
        Console.WriteLine("Initial matrix");
        mtCalculator.PrintMatrix(initialMatrix);
        Console.WriteLine("Modified Matrix");
        
        int[,] modifiedMatrix = mtCalculator.IdentityMAtrixModifier(initialMatrix);
        mtCalculator.PrintMatrix(modifiedMatrix);
        
        Console.WriteLine("Final state of initial Matrix");
        mtCalculator.PrintMatrix(initialMatrix);
    }

}