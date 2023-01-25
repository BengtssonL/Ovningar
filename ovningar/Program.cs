using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of authors you want to create:");
             int numberOfAuthors = int.Parse(Console.ReadLine());

             Author[] authors = new Author[numberOfAuthors];

             for (int i = 0; i < numberOfAuthors; i++)
             {
                 Console.WriteLine("Enter the name of author {0}:", i + 1);
                 string name = Console.ReadLine();
                 Console.WriteLine("Enter the email of author {0}:", i + 1);
                 string email = Console.ReadLine();
                 Console.WriteLine("Enter the gender of author {0} (M/F):", i + 1);
                 char gender = char.Parse(Console.ReadLine());

                 authors[i] = new Author(name, email, gender);
             }

             for (int i = 0; i < numberOfAuthors; i++)
             {
                 Console.WriteLine(authors[i].ToString());
             }
         }
            
    }

}
