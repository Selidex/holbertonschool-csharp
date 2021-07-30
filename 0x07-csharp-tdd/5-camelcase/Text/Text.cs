using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s){
            if(s == null || s == "")
                return 0;
            int count = 1;
            for(int i = 0; i < s.Length; i++){
                if(char.IsUpper(s[i]))
                    count++;
            }
            return count;
        }
    }
}
