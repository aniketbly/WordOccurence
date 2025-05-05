using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  // aniket

namespace WordOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Shivani Mishra";
            int count = 0;
            char[] arr = str.ToLower().ToArray();
            
            for(int i=0;i<arr.Length;i++)
            {
                count = 0;
                for (int j=0;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("Char:- " + arr[i] + "-Count:-" + count);
            }
            

        }
    }
}
