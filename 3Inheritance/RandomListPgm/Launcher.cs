using System;
using System.Collections;

namespace RandomListPgm
{
    public class Launcher
    {
        public static void Main()
        {
            ArrayList listWithStrings = new ArrayList();
            listWithStrings.Add("one");
            listWithStrings.Add("two");
            listWithStrings.Add("ondsadae");
            listWithStrings.Add("twdsadao");
            listWithStrings.Add("on4334e");
            listWithStrings.Add("twerewro");
            listWithStrings.Add("on34432423e");
            listWithStrings.Add("t324242wo");

            RandomList randList = new RandomList();
            string removed = randList.RandomString(listWithStrings);
            Console.WriteLine(removed);
        }
    }
}
