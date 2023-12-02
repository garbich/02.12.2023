namespace Myspace
{
    internal class Man
    {
        public Man()
        {

        } 
        public Man(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }


        public void printList(List<Man> mans)
        {
            foreach (Man man in mans)
            {
                Console.Write($"{man.Name} {man.Age} ");
            }
        }

    }
}