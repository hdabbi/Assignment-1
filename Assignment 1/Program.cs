using System;

namespace Assignment_1
{
    class Program
    {
        public static void Main()
        {
            int x,i,n;
            int[] a = new int[100];

            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements in the array :\n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter Number {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter Target Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            findInitialAndLast(a, x);
        }
        static void findInitialAndLast(int[] arr,
                                         int x)
        {
            int n = arr.Length;
            int initial = -1, last = -1;

            for (int i = 0; i < n; i++)
            {
                if (x != arr[i])
                    continue;
                if (initial == -1)
                    initial = i;
                last = i;
            }
            if (initial != -1)
            {
                
                Console.WriteLine("Output: "+ "[" + initial + ","+ last + "]");
                                  
            }
            else
                Console.Write("[-1 -1]");
        }

        
    }
}
/*static void Main(string[] args)
        {
            int i, n, k;
            int[] a = new int[100];
            
            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements in the array :\n", n);
            
            for (i = 0; i < n; i++)
            {
                Console.Write("Enter Number {0} : ", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.Write("Enter Target Number to  : ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
        }
    }
}*/
