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



    }
}
