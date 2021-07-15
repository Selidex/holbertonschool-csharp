using System;
using System.Collections.Generic;
using System.Linq;
class List{
    public static int Sum(List<int> myList){
        List<int> unisum = myList.Distinct().ToList();
        int sum = 0;
        for(int i = 0; i < unisum.Count; i++){
            sum += unisum[i];
        }
        return sum;
    }
}