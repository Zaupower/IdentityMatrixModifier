namespace IdentityMAtrixModifier;

public class MatrixCalculator
{
    
    public int[,] GenMatrix(int leghthRow,int lenghtCol)
    {
        Random rn = new Random();
        int[,] matrix = new int[leghthRow,lenghtCol];
        int row, col;
         
        for (row = 0; row < leghthRow; row++)
        {
            for (col = 0; col < lenghtCol; col++)
            {
                matrix[row,col] = rn.Next(-50, 100);
            }
        }
        return matrix;
    }

    public int[,]IdentityMAtrixModifier(int[,] originalMatrix)
    {
        int row, col;

        int[,] modifiedMatrix = new int[originalMatrix.GetLength(0), originalMatrix.GetLength(1)];
        
        try
        {
            modifiedMatrix = (int[,]) originalMatrix.Clone();
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error copying values");
            foreach (var element in modifiedMatrix)
            {
                Console.WriteLine(element);
            }
        }
        
        int lenghtRow = modifiedMatrix.GetLength(0);
        int lenghtCol = modifiedMatrix.GetLength(1);
        for (row = 0; row < lenghtRow; row++)
        {
            for (col = 0; col < lenghtCol; col++)
            {
                // Checking if row is equal to column
                if (row > col)
                {
                    modifiedMatrix[row, col] = 0;
                }else if (row < col)
                {
                    modifiedMatrix[row, col] = 1; 
                }
            }
        }
        return modifiedMatrix;
    }
    public void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write("{0} \t", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    
}