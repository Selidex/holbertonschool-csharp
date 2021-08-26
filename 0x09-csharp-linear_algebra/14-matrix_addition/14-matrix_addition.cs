using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Add(double[,] matrix1, double[,] matrix2){
        int x0 = matrix1.GetLength(0), x1 = matrix1.GetLength(1), y0 = matrix2.GetLength(0), y1 = matrix2.GetLength(1);
        if (x0 != x1 || y0 != y1 || x0 != y0 || (x0 != 2 && x0 !=3) || (y0 != 2 && y0 != 3))
            return new double[,]{{-1}};
        double[,] ret = new double[x0,x0]; 
        for(int i = 0; i < matrix1.GetLength(0); i++){
            for(int j = 0; j < matrix1.GetLength(1); j++){
                ret[i,j] = matrix2[i, j] + matrix1[i, j];
            }
        }
        return ret;
    }
}