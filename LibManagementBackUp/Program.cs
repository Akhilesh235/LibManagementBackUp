using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();
            List<User> UsersInLibrary = new List<User>();
            StartProgram sp = new StartProgram();
            sp.StartOption();
        }            
    }
}
