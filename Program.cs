using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void min_max()
        {
            Console.Write("Nhap n phan tu: ");
            string n = Console.ReadLine();
            int a = Convert.ToInt32(n);
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                string nhap = Console.ReadLine();
                int temp = Convert.ToInt32(nhap);
                arr[i] = temp;
            }
            int min = arr[0], max = arr[0];
            for (int i = 1; i < a; i++)
            {
                if (max < arr[i]) max = arr[i];
                if (min > arr[i]) min = arr[i];
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            min_max();
        }
    }
}
