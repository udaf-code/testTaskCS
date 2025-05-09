using System.Runtime.InteropServices;

namespace testTaskCS
{
    class testTask
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 1, 2, 7, 4, 6 };
            Console.WriteLine(SummTwoMin(array));
            int[] arrayTwo = Gen(100000000);
            Console.WriteLine(SummTwoMin(arrayTwo));
            int[] arrayThree = { 5};
            Console.WriteLine(SummTwoMin(arrayThree));

        }

        private static int? SummTwoMin (int[] array)
        {
            if (array.Length < 2)
            {
                Console.WriteLine("недостаточно аргументов");
                return null;
            }
            var minHeap = new SortedSet<int>();
                foreach (var num in array)
                {
                    minHeap.Add(num);
                    if (minHeap.Count > 2)
                        minHeap.Remove(minHeap.Max);
                }

            int first = minHeap.ElementAt(0);
            int second = minHeap.ElementAt(1);
            int summ = first+second;
            return summ;
        }

        //private static int Summ ()

        private static int[] Gen (int num)
        {
            Random random = new Random();
            int[] array = new int[num];
            for (int i = 0;i < array.Length; i++)
            {
                array[i] = random.Next();
            }
            return array;

        }

    }
}
