using System;

namespace Recursive_Sort
{
    class Program
    {
        static int[] array = { 10, 98, 78, 4, 54, 25, 84, 41, 30, 87, 6 };

        static void Main(string[] args)
        {
            sort(0, array.Length - 1);
            
            Console.ReadLine();
        }

        static void sort(int l, int r)
        {
            int i = l;
            int j = r;
            int x = array[(l + r) / 2];
            string beforeArrayString = "";
            foreach (int item in array)
            {

                beforeArrayString += beforeArrayString.Length == 0 ? item : (", " + item);
            }

            Console.WriteLine("Before Array: " + beforeArrayString);
            do
            {
                while (array[i] < x) i++;
                while (array[j] > x) j--;
                if (i <= j)
                {
                    int y = array[i];
                    array[i] = array[j];
                    array[j] = y;
                    i++;
                    j--;
                }
            } while (i < j);

            string arrayString = "";
            foreach (int item in array)
            {
                
                arrayString += arrayString.Length == 0 ? item : (", " + item);
            }
            Console.WriteLine("AfterArray: " + arrayString + "; i: "
                + i + "; j: " + j + ", x: " + x);
            if (l<j)
            {
                sort(l, j);
            }
            if (l<r)
            {
                sort(i, r);
            }
        }
    }
}
