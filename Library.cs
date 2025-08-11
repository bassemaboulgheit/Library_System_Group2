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
 
    }       
}
