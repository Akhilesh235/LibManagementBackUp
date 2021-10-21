using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class StartProgram
    {
        //List<User> Users = new List<User>();
        //List<User> GetUsers()
        //{
        //    return Users;
        //}
        //List<Book> Books = new List<Book>();
        //List<Book> GetBooks()
        //{
        //    return Books;
        //}

        public void StartOption()
        {
            if (!File.Exists("Users.txt"))
            {
                FileStream fs = new FileStream("Users.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Seek(0, SeekOrigin.End);
                StreamWriter streamWriter = new StreamWriter(fs);
                Console.WriteLine("Write anything here ");
                var str = Console.ReadLine();
                streamWriter.WriteLine(str);
                streamWriter.Flush();
                streamWriter.Close();
                fs.Close();

                //User admin = new User("Admin", 001);
                //Users.Add(admin);
                //string adminjson = JsonConvert.SerializeObject(Users);
                //File.WriteAllText("users.json", adminjson);
            }

            if (!File.Exists("Books.txt"))
            {
                FileStream fs = new FileStream("Books.txt", FileMode.CreateNew, FileAccess.ReadWrite);
                fs.Seek(0, SeekOrigin.End);
                StreamWriter streamWriter = new StreamWriter(fs);
                Console.WriteLine("");
                var str = Console.ReadLine();
                streamWriter.WriteLine(str);
                streamWriter.Flush();
                streamWriter.Close();
                fs.Close();

                //string emptybookjson = JsonConvert.SerializeObject(Books);
                //File.WriteAllText("books.json", emptybookjson);
            }

            Console.WriteLine("Welcome to Library");
            bool loop = true;
            while (loop == true)
            {
                Start:
                Console.WriteLine("Choose the following option : ");
                Console.WriteLine("1. Librarian");
                Console.WriteLine("2. User ");
                Console.WriteLine("3. Exit Program\n");

                int choose = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                switch (choose)
                {
                    case 1:
                        {
                            Librarian librarian = new Librarian();
                            librarian.LibrarianStart();
                            break;
                        }

                    case 2:
                        {
                            User user = new User();
                            user.UserStart();
                            break;
                        }

                    case 3:
                        {
                            loop = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("!!! Invalid Input !!! Please try again");
                            goto Start;
                        }
                }
            }
            
        }
    }
}
