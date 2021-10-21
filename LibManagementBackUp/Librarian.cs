using System;
using System.IO;

namespace LibraryManagementSystem
{
    class Librarian 
    {

        public void LibrarianStart()
        {
            Top:
            Console.WriteLine("Enter your Librarian ID");
            int LibrarianID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Password");
            string LibrarianPassword = Console.ReadLine();

            if(LibrarianID != 001 || LibrarianPassword != "password" )
            {
                Console.WriteLine("ID and/or Password is wrong. Try Again");
                goto Top;
            }

            Console.WriteLine("Welcome Librarian!");
            Console.WriteLine(" ");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please choose the following options");
                Console.WriteLine("1. Add New Books");
                Console.WriteLine("2. Add New Users");
                Console.WriteLine("3. Search for Book : ");
                Console.WriteLine("3. Go Back to Previous Menu ");

                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                        AddBookDetails:
                            FileStream fs = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter streamWriter = new StreamWriter(fs);
                            Console.WriteLine("Enter Book Details");
                            Console.WriteLine("");
                            Console.WriteLine("Title of Book :");
                            string name = Console.ReadLine();
                            Console.WriteLine("Author :");
                            string author = Console.ReadLine();
                            Console.WriteLine("Number of Copies :");
                            int count = int.Parse(Console.ReadLine());
                            Guid obj = Guid.NewGuid();
                            Console.WriteLine("Book ID for this book is " + obj);

                            streamWriter.WriteLine("Title of Book : {0}", name);
                            streamWriter.WriteLine("Author : {0}", author);
                            streamWriter.WriteLine("Number of Copies : {0}", count);
                            streamWriter.WriteLine("Book ID : {0}\n", obj);
                            streamWriter.WriteLine(" ");
                            streamWriter.Flush();
                            streamWriter.Close();
                            fs.Close();

                            Console.WriteLine("Would you like to add another Book? Yes/No");
                            string option = Console.ReadLine();
                            option.ToLower();

                            switch (option)
                            {
                                case "yes":
                                    {
                                        goto AddBookDetails;
                                    }

                                case "no":
                                    {
                                        break;
                                    }
                            }

                            break;
                        }

                    case 2:
                        {
                        AddNewUserDetails:
                            FileStream fs = new FileStream("Users.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter streamWriter = new StreamWriter(fs);
                            Console.WriteLine("Enter User Details");
                            Console.WriteLine("");
                            Console.WriteLine("Full Name :");
                            string name = Console.ReadLine();
                            Console.WriteLine("Username :");
                            string Username = Console.ReadLine();

                            streamWriter.WriteLine("User: {0}", name);
                            streamWriter.WriteLine("User ID : {0}\n", Username);
                            streamWriter.Flush();
                            streamWriter.Close();
                            fs.Close();

                            Console.WriteLine("Would you like to add another User? Yes/No");
                            string option = Console.ReadLine();
                            option.ToLower();

                            switch (option)
                            {
                                case "yes":
                                    {
                                        goto AddNewUserDetails;
                                    }

                                case "no":
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            loop = false;                            
                            break;
                        }
                }
                
            }
            

            
        }
       

    }
}
