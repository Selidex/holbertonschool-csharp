using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] Add(double[] vector1, double[] vector2){
        if (vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3) ){
            double[] ret = new double[1] {-1};
            return ret;
        }
        var list = new List<double>();
        for (int i = 0; i < vector2.Length; i++){
            list.Add(vector1[i] + vector2[i]);
        }
        var array = list.ToArray();
        return array;
    }
}
