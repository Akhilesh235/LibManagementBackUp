using LibraryManagementSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Library_Management_System_FP
{
    class LibraryManager : ILibraryManager
    {
        public void AddBook(string name, string author, int count)
        {
            FileStream fs = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);
            Console.WriteLine("\nWrite at the end ");
            var str = Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();;
        }

        public void AddUser(string userName, int Id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Book> GetAllBooks()
        {
            throw new System.NotImplementedException();
        }

        public IList<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserByUserName(string userName)
        {
            throw new System.NotImplementedException();
        }

        public void RetrieveBookDetails(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void RetrieveUserDetails(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void StoreBookDetails(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void StoreUserDetails(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}