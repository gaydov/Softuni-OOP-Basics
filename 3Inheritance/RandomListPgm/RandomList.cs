using System;
using System.Collections;

public class RandomList : ArrayList
{
    public string RandomString(ArrayList list)
    {
        Random rand = new Random();
        int elementToBeRemoved = rand.Next(0, list.Count - 1);
        string str = (string)list[elementToBeRemoved];
        list.Remove(str);
        return str;
    }
}

