using System;
using System.Collections.Generic;

class VectorMath {
    public static double Magnitude(double[] vector){
            double k = 0;
            
            if (vector.Length != 2 && vector.Length != 3)
                return -1;
            for (int i = 0; i < vector.Length; i++){
                k += Math.Pow(vector[i], 2);
            }
            return Math.Round(Math.Sqrt(k), 2);
        }

}