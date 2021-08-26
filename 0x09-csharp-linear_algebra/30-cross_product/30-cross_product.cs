using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] CrossProduct(double[] vector1, double[] vector2){
        if(vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};
        double a = vector1[0], b = vector1[1], c = vector1[2], d = vector2[0], e = vector2[1], f = vector2[2];
        double[] ret = new double[3];
        ret[0] = (b * f) - (c * e);
        ret[1] = (c * d) - (a * f);
        ret[2] = (a * e) - (b * d);

        return ret;
    }
}