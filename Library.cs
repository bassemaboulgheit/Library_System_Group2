namespace Library_System_Group2
{
    public class Library
    {
        ////////ReturnBook////////////
         public void ReturnBook(int member_id, int book_id)
    
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
///////////////Find_member////////////////////
    
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
///////////////Find_Book////////////////////
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

    }
}
