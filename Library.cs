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
 
    }       

}

      
   

