using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s){
            int fb = 0;
            int k = 0;
            for(int i = 0; i < s.Length; i++){
                k = 0;
                fb = 1;
                while(k < s.Length){
                    if(s[i] == s[k])
                        fb = 0;
                    k++;
                }
                if(fb == 1)
                    return i;
            }
            return -1;
        }
    }
}
