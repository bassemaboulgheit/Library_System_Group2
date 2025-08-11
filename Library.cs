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
               ////////////FindBook////////////////////
        
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
      
   ////////////AddBooK///////////////
      
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
            ////////////listOfBook////////////////////
      
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
//////////////////////////Find_member/////////////////
        public int Find_member(int id)
        {
            for (int i = 0; i < members_count; i++)
            {
                if (members[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
//////////////////////////AddMember/////////////////
      
        public void AddMember(Member member)
        {
            if (members_count >= members.Length)
            {
                Console.WriteLine("your library is full of members");
            }
            else
            {
               
                
                    for (int i = 0; i < members_count; i++)
                    {
                        if (members[i].Equals(member))
                        {
                            Console.WriteLine("the id of member should be unique");
                            return;
                        }
                    }
                
                members[members_count] = member;
                Console.WriteLine("member added successfully");
                members_count++;
            }
        }
//////////////////////////RemoveMember/////////////////
        public void RemoveMember(int id)
        {
            int index = Find_member(id);
            if (index == -1)
            {
                Console.WriteLine("the member is not found");
                return;
            }
            for (int i = 0; i < members[index].BorrowedCount; i++)
            {
                if(members[index].BorrowedBooks[i]!= 0)
                {
                    int m = FindBooks(members[index].BorrowedBooks[i]);
                    if(m!=-1)
                    {
                        books[m].IsAvailable = true;

                    }
                    
                }
            }

            for (int i = index; i < members_count - 1; i++)

            {
                members[i] = members[i + 1];
            }
            members[--members_count] = null;
            Console.WriteLine("member deleted successfully");

        }
 /////////////////////////listofmembers/////////////////////////
        public void listOfMember()
        {
            if (members_count != 0)
            {
                for (int i = 0; i < members_count; i++)
                {
                    Console.WriteLine(members[i]);
                }
            }
            else
            {
                Console.WriteLine("There is no member in the Library");
            }
    }  
 /////////////////////////borrowBook/////////////////////////
      
        public void borrowBook(int member_id, int book_id)
        {
            int index1 = Find_member(member_id);
            int index2 = FindBooks(book_id);
            if (index1 == -1 || index2 == -1)
            {
                Console.WriteLine("can not fount member or book");
            }
            else
            {
                for (int i = 0; i < members[index1].BorrowedCount; i++)
                {
                    if (members[index1].BorrowedBooks[i] == book_id)
                    {
                        Console.WriteLine("This member already borrowed this book");
                        return;
                    }
                }
                if (!books[index2].IsAvailable)
                {
                    Console.WriteLine("the book is not available");
                    return;
                }
             
                if (members[index1].MBorrowBook(book_id))
                {
                    books[index2].IsAvailable = false;
                    Console.WriteLine($"member ID : {members[index1].Id} borrow book ID : {books[index2].Id} titled : {books[index2].Title}");
                }
                books[books_count - 1] = null;
                books_count--;
                Console.WriteLine("Book deleted successfully");

            }

        }
  ////////////////////returnBook//////////////////////
 
          public void ReturnBook(int member_id, int book_id)
          {
              int index1 = Find_member(member_id);
              int index2 = FindBooks(book_id);
              if (index1 == -1 || index2 == -1)
              {
                  Console.WriteLine("cannot find member or book");
              }
              else
              {
                  if (members[index1].MReturnBook(book_id))
                  {
                      books[index2].IsAvailable = true;
                      Console.WriteLine($"member : {members[index1].Id} returns book : {books[index2].Id} titled: {books[index2].Title}");
                  }
                  else
                  {
                      Console.WriteLine("this book is not borrowed by this member");
                  }
             }

       }
   
    }
 }

   

