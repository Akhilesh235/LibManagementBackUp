using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem 
{ 

    class User
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Fine { get; private set; }
        public void UserStart()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your User ID");
            int UserID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Password");
            string UserPassword = Console.ReadLine();

            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Borrow a Book ");
            Console.WriteLine("2. Return a Book ");
            Console.WriteLine("3. Check your details ");

            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        break;
                    }

                case 2:
                    {
                        break;
                    }

                case 3:
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        //public IList<Book> _bookIssued;
        //public IList<Book> BooksIssued
        //{
        //    get
        //    {
        //        if (_bookIssued == null)
        //            _bookIssued = new List<Book>();
        //        return _bookIssued;
        //    }
        //    private set
        //    {
        //        _bookIssued = value;
        //    }
        //}
        //public User(string userName, int userID)
        //{
        //    Name = userName;
        //    ID = userID;
        //    Fine = 0;
        //    _bookIssued = new List<Book>();
        //}

        //public void retreiveUserDetails()
        //{
        //    Console.WriteLine("UserID : " + ID);
        //    Console.WriteLine("Username : " + Name);
        //    Console.WriteLine("Borrowed books by the user : ");
        //    foreach (var bk in _bookIssued)
        //    {
        //        Console.WriteLine(bk.Name);
        //    }

        //}
    }
}


