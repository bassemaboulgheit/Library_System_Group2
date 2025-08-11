namespace Library_System_Group2
{
    public class Library
    {

        Book[] books;
        int books_count;
        Member[] members;
        int members_count;
        public Library()
        {
            books = new Book[20];
            members = new Member[20];
            books_count = 0;
            members_count = 0;
        }
        

        public void AddBook(Book book)
        {      
           if (books_count >= books.Length)
           {
              Console.WriteLine("your library is full of books");
           }

           else
           { 
             for (int i = 0; i < books_count; i++)
                  {
                      if (books[i].Equals(book))
                      {
                          Console.WriteLine("the id of book should be unique");
                          return;
                      }
                  }

              books[books_count] = book;
              Console.WriteLine("Book added successfully");
              books_count++;
           }
      }
      //-------------RemoveBook------------------//
      public void RemoveBook(int id)
      {
            int index = FindBooks(id);
            if (index == -1)
            {
                Console.WriteLine("the book is not found");

            }
            else
            {
                if (!books[index].IsAvailable)
                {
                    Console.WriteLine("The book is'nt Available ");
                    return;

                }
                for (int i = index; i < books_count - 1; i++)
                {
                    books[i] = books[i + 1];
                }
                books[books_count - 1] = null;
                books_count--;
                Console.WriteLine("Book deleted successfully");
            }
      }
      //-------------FindBooks------------------//
         public int FindBooks(int id)
         {
             for (int i = 0; i < books_count; i++)
             {
                 if (books[i].Id == id)
                 {
                     return i;
                 }
        
             }
             return -1;
         }
      //-------------listOfBook------------------//
         public void listOfBook()
         {
             if (books_count != 0)
             {
                 for (int i = 0; i < books_count; i++)
                 {
                     Console.WriteLine(books[i]);
                 }
             }
             else
             {
                 Console.WriteLine("there is no book in the Library");
             }
        
         }

    }
}

      
   

