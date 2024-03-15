
using System.ComponentModel;

internal class Program
{
    static List<string> titles =new List<string>();
        static List<string> authors =new List<string>();
        static List<int> publicationyears =new List<int>();
    private static void Main(string[] args)
    {
        
        Console.WriteLine("what do you want to do");

        Console.WriteLine("if you want to add a book to the library type 1");
        Console.WriteLine("if you want to view all books type 2");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Addbook();
        }
        if (choice ==2)
        {
            Viewbooks();
        }
     Console.WriteLine(titles[0]);
     Console.WriteLine(authors[0]);
     Console.WriteLine(publicationyears[0]);
    }
    
       public static void Addbook()
        {
       Console.WriteLine("what is the title of this book");
       string title = Console.ReadLine();
       Console.WriteLine($"who is the author of {title}");
       string author = Console.ReadLine();
       Console.WriteLine($"what is the publication year of {title}");
       int publicationyear = int.Parse(Console.ReadLine());
       titles.Add(title);
       authors.Add(author);
       publicationyears.Add(publicationyear);
}
       public static void Viewbooks()
       {
        ;




       }
        }
        
