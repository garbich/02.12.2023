namespace Myspace
{

    class Program
    {
        public static void Main(String[] args)
        {
            List<Man> mans = new List<Man>();
            mans.Add(new Man("Artyr", 16));
            mans.Add(new Man("Ostap", 26));
            mans.Add(new Man("Nazar", 19));
            mans.Add(new Man("Artem", 19));
            
            List<Man> mans2 = mans.FindAll((man) => man.Age > 25);

            Console.Write("Man more then 25: ");
            mans2.ForEach((man) => Console.Write(man.Name + " " + man.Age + " "));
            Console.WriteLine();
            Console.WriteLine();

            List<Man> mans3 = mans;

            mans.RemoveAll((man) => man.Age < 18);

            Console.Write("List after delete mans which less then 18: ");
            mans3.ForEach((man) => Console.Write(man.Name + " " + man.Age + " "));
            Console.WriteLine();
            Console.WriteLine();

            List<Man> mans4 = mans;

            Console.Write("Sort list: ");
            mans.Sort((m1, m2) => m1.Name.CompareTo(m2.Name + " "));
            mans.ForEach((m) => Console.Write(m.Name + " " + m.Age + " "));
            Console.WriteLine();
            Console.WriteLine();

           

        }
    }
}