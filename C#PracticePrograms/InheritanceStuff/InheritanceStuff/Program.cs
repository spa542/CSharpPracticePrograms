using System;

namespace InheritanceStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Ryan Rosiak");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Ryan Rosiak", "http://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            
            Console.ReadLine();

        }
    }
}
