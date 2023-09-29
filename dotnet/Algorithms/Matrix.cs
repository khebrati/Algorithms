namespace Algorithms;
public static class Matrix
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
    public static int[,] MultiplyMatrix(int[,] matrixA,int[,] matrixB)
    {
        
        int[,] resultMatrix = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
        int sum;
        for(int rowA = 0;rowA < matrixA.GetLength(0); rowA++)
        {
            for(int colB = 0; colB < matrixB.GetLength(1); colB++)
            {
                sum = 0;
                for(int colA_or_rowB = 0; colA_or_rowB < matrixB.GetLength(0);colA_or_rowB++)
                {
                    sum += matrixA[rowA,colA_or_rowB] + matrixB[colA_or_rowB,colB];
                }
                resultMatrix[rowA,colB] = sum;
            }
        }
        return resultMatrix;
    }
}
