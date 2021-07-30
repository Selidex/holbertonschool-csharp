using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s){
            if(s == "")
                return true;
            s = s.ToLower();
            int i = 0;
            int k = s.Length - 1;
            while(i < k){
                while(!Char.IsLetterOrDigit(s[i]))
                    i++;
                while(!Char.IsLetterOrDigit(s[k]))
                    k--;
                if(i >= k)
                    return true;
                if(s[i] != s[k])
                    return false;
            }
            return true;

        }
    }
}
