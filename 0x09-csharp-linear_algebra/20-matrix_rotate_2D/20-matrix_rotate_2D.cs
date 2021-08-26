﻿using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Rotate2D(double[,] matrix, double angle){
        if(matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        if (angle == 0)
            return matrix;
        double[,] ret = new double[2,2];
        ret[0,0] = Math.Round((matrix[0,0] * Math.Cos(angle)) - (matrix[0,1] * Math.Sin(angle)), 2);
        ret[0,1] = Math.Round((matrix[0,0] * Math.Sin(angle)) + (matrix[0,1] * Math.Cos(angle)), 2);
        ret[1,0] = Math.Round((matrix[1,0] * Math.Cos(angle)) - (matrix[1,1] * Math.Sin(angle)), 2);
        ret[1,1] = Math.Round((matrix[1,0] * Math.Sin(angle)) + (matrix[1,1] * Math.Cos(angle)), 2);
        return ret;
    }
}