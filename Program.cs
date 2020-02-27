

using System;
namespace A2_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int t = 9;
            int j = 0;
            int[] r = new int[100];
            //ArrayList array = new ArrayList();
            int a = 0;
            for (int i = 0; i < l1.Length; i++)
            {
                if (l1[i] == t)
                {
                    //Console.Write(i + " ");
                    
                    //array.Add(i);
                    a = 1;
                    r[j] = Convert.ToInt32(i);
                    
                    //Console.WriteLine("arra");
                    // Console.Write( i + " ");
                    //Console.WriteLine("targetn found at " + i + "th position");

                }
                j++;

            }
            if (a == 0)
            {
                Console.WriteLine("[-1,1]");
            }
            else
            {
                //if((r.count)!=0)
                //{
                    for (int k = 0; k < r.Length; k++)
                    {
                    if(r[k] !=0)
                    Console.Write(r[k] + " ");
                    }
                //}
            }
        }
    }
}
