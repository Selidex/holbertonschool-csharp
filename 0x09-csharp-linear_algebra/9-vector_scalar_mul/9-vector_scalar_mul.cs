using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length != 2 && vector.Length != 3){
            double[] ret = {-1};
            return ret;
        }
        var list = new List<double>();
        for(int i = 0; i < vector.Length; i++){
            list.Add(vector[i] * scalar);
        }
        var array = list.ToArray();
        return array;
    }
}