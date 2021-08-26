using System;
using System.Collections.Generic;

class VectorMath{
    public static double[,] Add(double[,] matrix1, double[,] matrix2){
        if (matrix1.Length != matrix2.Length)
            return -1;
        if (matrix1.Length != 2 && matrix1.Length != 3)
            return -1;
        if (matrix2.Length != 2 && matrix2.Length != 3)
            return -1;
        if(matrix1.Length != matrix1[i].Length || matrix2.Length != matrix2[i].Length)
            return -1;

        int x = matrix1.Length;
        if (x == 2)
            double[,] ret = new double[2,2];
        if (x == 3)
            double[,,] ret = new double[3,3,3];
        for(int i = 0; i < x; i++){
            for(int j = 0; j < x; j++)
                ret[i][j] = matrix1[i][j] + matrix2[i][j];
        }
        return ret;
    }
}