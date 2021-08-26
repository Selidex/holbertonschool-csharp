using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Rotate2D(double[,] matrix, double angle){
        if(matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        return matrix;
    }
}