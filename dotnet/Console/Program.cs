using System.Text.RegularExpressions;
using static System.Console;

class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix1 = {{1,2,3},{4,5,6},{7,8,9}};
        int[,] matrix2 = {{-1,-2,-3},{-4,-5,-6},{-7,-8,-9}};
        WriteMatrix(AddMatrix(matrix1,matrix2));

    }
    static void WriteMatrix(int[,] matrix)
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
    static int[,] AddMatrix(int[,] matrix1,int[,] matrix2)
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
}