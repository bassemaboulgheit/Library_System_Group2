namespace Library_System_Group2
{
    public class Book
    {
        public int Id;
        public string Title;
        public string Author;
        public bool IsAvailable = true;
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
         public override string ToString()
         {
             return $" Book ID : {Id}  His title : {Title} His author : {Author}  :: IsAvailable:{IsAvailable}  ";
         }
        public override bool Equals(object? obj)
        {
           if (obj is Book b)
           {
              return this.Id == b.Id;
           }
            return false;
         }
     }
 }
