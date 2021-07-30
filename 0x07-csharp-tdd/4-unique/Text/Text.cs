using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s){
            int k, count;
            for(int i = 0; i < s.Length; i++){
                count = 0;
                k = 0;
                while(k < s.Length)
                {
                    if(s[i] == s[k])
                        count++;
                    k++;
                }
                if(count == 1)
                    return i;
            }
            return -1;
        }
    }
}
