using LibraryManagementSystem;
using System.Collections.Generic;

namespace Library_Management_System_FP
{
    interface ILibraryManager
    {
        IList<User> GetAllUsers();
        IList<Book> GetAllBooks();
        User GetUserByUserName(string userName);
        void AddUser(string userName, int Id);
        void AddBook(string name, string author, int count);
        void RetrieveUserDetails(string fileName);
        void RetrieveBookDetails(string fileName);
        void StoreUserDetails(string fileName);
        void StoreBookDetails(string fileName);
    }
}
