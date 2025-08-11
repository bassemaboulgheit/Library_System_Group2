namespace Library_System_Group2
{
    public class Library
    {
        

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
    }
}
