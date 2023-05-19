using System.Reflection;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 23, 45, 23, 666, 777, 567, 34, 56, 888 };

            //bool result = HasDuplicate();

            //if (result == true)
            //{
            //    Console.WriteLine("duplicate value exist");
            //}
            //else
            //{
            //    Console.WriteLine("duplicate value does not exist");

            //}
            SumOfNum();


        }
        static int result(int[] array)
        {
            int sumof2 = 0;
            int sumof3 = 0;
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 9 && array[i] < 100 && array[i] % 2 == 1)
                {
                    sumof2 += array[i];
                }
                else if (array[i] > 99 && array[i] < 1000)
                {
                    sumof3 += array[i];
                }

            }
            result = sumof3 - sumof2;
            return result;
        }

        static bool HasDuplicateAddition()
        {
            int[] arr = { 23, 45, 23, 666, 777, 567, 34, 56, 888 };
            int[] indexes = new int[arr.Length];

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = -1;
            }
            int myIndex = 0;

            bool isDuplicate = false;

            for (int i = 0; i < arr.Length; i++)
            {

                bool isExist = false;
                for (int z = 0; z < indexes.Length; z++)
                {
                    if (i == indexes[z])
                    {
                        isExist = true;
                    }
                }

                if (isExist == false)
                {

                    for (int x = 0; x < arr.Length; x++)
                    {
                        if (arr[i] == arr[x] && i != x)
                        {
                            isDuplicate = true;
                            Console.WriteLine(arr[i]);
                            indexes[myIndex] = x;
                            myIndex++;

                        }
                    }
                }





            }




            return isDuplicate;
        }
        static bool HasDuplicate()
        {
            int[] arr = { 23, 45, 23, 666, 777, 567, 34, 56, 888 };

            bool isDuplicate = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int x = 0; x < arr.Length; x++)
                {
                    if (arr[i] == arr[x] && i != x)
                    {
                        isDuplicate = true;
                    }
                }
            }

            return isDuplicate;
        }

        static void SumOfNum()
        {
            int[] arr = { 12, 13, 16, 1976, 765 };


            //int modul = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                int modul = 0;
                int sum = 0;
                while (num != 0)
                {
                    modul = num % 10;
                    num = (num - modul) / 10;
                    sum += modul;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }

            }





        }
    }
}