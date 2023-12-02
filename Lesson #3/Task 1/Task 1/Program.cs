namespace Myspace
{
    delegate void FilterDelegate(int[] arr);

    class Program
    { 
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 5, 6, 3, 7, 8, 10, 13, 17, 18 };

            FilterDelegate parni;
            parni = (arr) =>
            {
                foreach (int i in arr)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            };

            Console.Write("Parni: ");
            parni.Invoke(arr);
            Console.WriteLine();

            FilterDelegate neparni = (arr) => {
                foreach (int i in arr)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            };

            Console.Write("Neparni: ");
            neparni.Invoke(arr);
            Console.WriteLine();

            FilterDelegate moreThenTen = (arr) =>
            {
                foreach (int i in arr)
                {
                    if (i > 10)
                    {
                        Console.Write(i + " ");
                    }
                }
            };

            Console.Write("more than 10: ");
            increseTen.Invoke(arr);
       
        }
    }
}
