using System;
using System.Collections.Generic;

class MyStack{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search){
        System.Console.WriteLine("Number of items: {0}", aStack.Count);
        if(aStack.Count == 0)
            System.Console.WriteLine("Stack is empty");
        else
            System.Console.WriteLine("Top item: {0}", aStack.Peek());
        System.Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));
        if(aStack.Contains(search)){
            var k = "";
            while(k != search)
                k = aStack.Pop();
            
        }
        aStack.Push(newItem);
        return aStack;
    }
}
