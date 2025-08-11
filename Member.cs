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
                BorrowedBooks[BorrowedCount] = id;
                BorrowedCount++;
                return true;
            }
            else
            {
                Console.WriteLine($"This member can not borrow more than book {BorrowedBooks.Length} ");
                return false;
            }
        }



    }
}
