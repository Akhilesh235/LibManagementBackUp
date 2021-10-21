using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem 
{ 

    class User
    {
        public void UserStart()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your User ID");
            string UserID = Console.ReadLine();

            FileStream fs = new FileStream("Users.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();

            if (str != name)
            {
                Console.WriteLine("invalud userID.Try again");            
            }
            sr.Close();
            fs.Close();
         

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


