namespace Library_System_Group2
{
    public class Library
    {

        
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
                    Console.WriteLine("Book is borrowed successfully");

                }
                 books[books_count - 1] = null; 
                 books_count--;
                 Console.WriteLine("Book deleted from library successfully");
            }
        }


        //-------------------------start new methods over required for member------------------------------//


        // edit member
        public void EditMember(int id, string newName)
        {
            int index = Find_member(id);
            if (index == -1)
            {
                Console.WriteLine("member not found");
            }
            else
            {
                members[index].Name = newName;
                Console.WriteLine("member updated successfully");
            }
        }
        
        // remove all members
        public void RemoveAllMembers()
        {
            if (members_count == 0)
            {
                Console.WriteLine("no members to remove");
            }
            else
            {
                for (int i = 0; i < members_count; i++)
                {
                    members[i] = null;
                }
                members_count = 0;
                Console.WriteLine("all members removed successfully");
            }
        }

//-------------------------end new methods over required for member------------------------------//

 
    }       

}

      
   

