using System;
using System.Collections.Generic;

class MyQueue{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search){
        System.Console.WriteLine("Number of items: {0}", aQueue.Count);
        if(aQueue.Count == 0)
            System.Console.WriteLine("Queue is empty");
        else
            System.Console.WriteLine("First item: {0}", aQueue.Peek());
        aQueue.Enqueue(newItem);
        System.Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        if(aQueue.Contains(search))
        {
            var k = "";
            while(k != search)
                k = aQueue.Dequeue();
        }
        return aQueue;
    }
}