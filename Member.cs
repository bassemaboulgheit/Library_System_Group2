using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System_Group2
{
    public class Member
    {
        
        public int Id;
        public string Name;
        public int[] BorrowedBooks;
        public int BorrowedCount;
        public Member(int id, string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new int[3];
            BorrowedCount = 0;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Borrowed Books: {BorrowedCount}";
        
        }
        public override bool Equals(object? obj)
        {
            if (obj is Member b)
            {
                return this.Id == b.Id;
            }
            return false;
        }
        public bool MBorrowBook(int id)
        {
            
            if (BorrowedCount < BorrowedBooks.Length)
            {
                BorrowedBooks[BorrowedCount] = Id;
                BorrowedCount++;
                return true ;
            }
            else
            {
                Console.WriteLine($"This member can not borrow more than book {BorrowedBooks.Length} ");
                return false ;
            }
        }
        public bool MReturnBook(int BookId)
        {
            int index = -1;
            for (int i = 0; i < BorrowedCount; i++)
            {
                if (BorrowedBooks[i] == BookId)
                {
                    index = i;
                    break;
                }
        
            }
            if (index != -1)
            {
                BorrowedBooks[index] = 0;
                BorrowedCount--;
                return true ;
        
            }
            return false ;
        
        }
        public bool MReturnBook(int BookId)
        {
            int index = -1;
            for (int i = 0; i < BorrowedCount; i++)
            {
                if (BorrowedBooks[i] == BookId)
                {
                    index = i;
                    break;
                }

            }
            if (index != -1)
            {
                for (int i = index; i < BorrowedCount - 1; i++)
                {
                    BorrowedBooks[i] = BorrowedBooks[i + 1];
                }
                BorrowedBooks[BorrowedCount - 1] = 0;
                BorrowedCount--;

                return true;

            }
            return false;

        }


    }
}
