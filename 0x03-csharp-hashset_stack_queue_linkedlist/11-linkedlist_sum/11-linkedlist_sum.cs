using System;
using System.Collections.Generic;

class LList{
    public static int Sum(LinkedList<int> myLList){
        if(myLList.First == null)
            return 0;
        int sum = 0;
        LinkedListNode<int> summer = myLList.First;
        while(summer != null)
        {
            sum += summer.Value;
            summer = summer.Next;
        }
        return sum;
    }
}