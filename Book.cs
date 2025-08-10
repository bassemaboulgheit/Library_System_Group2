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
    }
}
