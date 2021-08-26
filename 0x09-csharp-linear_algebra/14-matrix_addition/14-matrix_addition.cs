using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Add(double[,] matrix1, double[,] matrix2){
        if ((matrix1.Length != matrix2.Length) || (matrix1.Length != 2 && matrix1.Length != 3))
            return new double[,] {{-1}};
        for(int i = 0; i < matrix1.Length; i++){
            for(int j = 0; j < matrix1.Length; j++){
                matrix1[i, j] += matrix2[i, j];
            }
        }
        return matrix1;
    }
}