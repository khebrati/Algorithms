using System.Text.RegularExpressions;
using static System.Console;
using static Algorithms.Matrix;
class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix1 = {{1,2,3},{4,5,6},{7,8,9}};
        int[,] matrix2 = {{-1,-2,-3},{-4,-5,-6},{-7,-8,-9}};
        WriteMatrix(MultiplyMatrix(matrix1,matrix2));
    }
}