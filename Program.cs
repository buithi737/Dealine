using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   
        static void input_arr(int [] arr ,int n)
        {
            
            for(int i = 0; i < n; i++)
            {
                string nhap = Console.ReadLine();
                int temp = Convert.ToInt32(nhap);
                arr[i] = temp;
            } 
        }
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

        static int So_Phan_Tu_Khac_Nhau(int[] arr, ref int[] arr1)
        {
            arr1 = new int[arr.Length];
            int x = 1;
            arr1[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < x; j++)
                {
                    if (arr[i] == arr1[j])
                        count++;
                }
                if (count == 0)
                {
                    arr1[x] = arr[i];
                    x++;
                }
            }
            return x;
        }
        static void SL_Xuat_hien(int [] arr, int a)
        {  
            int[] save = new int[a];
            So_Phan_Tu_Khac_Nhau(arr, ref save);
            for (int i = 0; i < So_Phan_Tu_Khac_Nhau(arr, ref save); i++)
            {
                int temp = save[i];
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (temp == arr[j]) count++;
                }
                Console.WriteLine(temp + ": " + count + " TIme");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap so luong phan tu n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[n];    
            input_arr(arr, n);
            SL_Xuat_hien(arr, n);
        }
    }
}
