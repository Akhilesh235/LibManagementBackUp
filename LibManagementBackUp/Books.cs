using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Book
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int Count { get; private set; }

        public Book(string name, string author, int count)
        {
            Id = Guid.NewGuid();
            Name = name;
            Author = author;
            Count = count;
        }



        public void RetreiveBookDetails()
        {
            Console.WriteLine("\nBook ID : " + Id);
            Console.Write(" Title of Book : " + Name);
            Console.Write(" Author : " + Author);
            Console.Write(" Count: " + Count);
          

        }

    }
}
