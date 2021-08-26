using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        if (matrix1.GetLength(0) != matrix2.GetLength(1))
            return new double[,] {{-1}};
        double[,] ret = new double[matrix1.GetLength(0),matrix2.GetLength(1)];
        double[] v1 = new double[matrix1.GetLength(0)];
        double[] v2 = new double[matrix2.GetLength(1)];
        for (int i = 0; i < ret.GetLength(0); i++){
            for (int j = 0; j < ret.GetLength(1); j++){
                for (int x = 0; x < matrix1.GetLength(0); x++)
                    v1[x] = matrix1[i, x];
                for (int y = 0; i < matrix2.GetLength(1); y++)
                    v2[y] = matrix2[y, j];
                ret[i, j] = DotProduct(v1, v2);
            }
        }
        return ret;
    }
    public static double DotProduct(double[] vector1, double[] vector2){
        double k = 0;
        for (int i = 0; i < vector1.Length; i++){
            k += vector1[i] * vector2[i];
        }
        return k;
    }
}