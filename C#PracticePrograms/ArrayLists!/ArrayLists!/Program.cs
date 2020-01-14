using System;
using System.Collections;

namespace ArrayLists_
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring ArrayList
            ArrayList myArrList = new ArrayList();
            ArrayList myArrList2 = new ArrayList(100);



            myArrList.Add(25);
            myArrList.Add("Hello");
            myArrList.Add(13.37);
            myArrList.Add(13);
            myArrList.Add(128);
            myArrList.Add(25.3);
            foreach (object obj in myArrList)
            {
                Console.WriteLine("   {0}", obj);
            }

            myArrList.Remove(128);

            double sum = 0;

            Console.WriteLine("Removing 128...");
            foreach(object obj in myArrList)
            {
                Console.WriteLine("   {0}", obj);
            }

            foreach (object obj in myArrList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine("The sum is " + sum);
            Console.Read();
        }
    }
}
