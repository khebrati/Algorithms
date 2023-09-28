namespace Algorithms;
public class Matrix
{
    public static int[,] AddMatrix(int[,] matrix1,int[,] matrix2)
    {
        var OutMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
        for(int row  = 0; row  < matrix1.GetLength(0); row ++)
        {
            for(int col = 0; col < matrix2.GetLength(1); col ++)
            {
                OutMatrix[row,col] = matrix1[row,col] + matrix2[row,col];
            }
        }
        return OutMatrix;
    }
    public static void WriteMatrix(int[,] matrix)
    {
        Write("{");
        for(int row = 0; row < matrix.GetLength(0); row++)
        {
            Write("{");
            for(int col = 0; col < matrix.GetLength(1); col++)
            {
                Write(matrix[row,col]);
                if(!(col == matrix.GetLength(1) - 1))
                {
                    Write(",");
                }
            }
            Write("}");
        }
        Write("}");
    }
}
