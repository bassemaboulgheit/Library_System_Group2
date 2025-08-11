namespace Library_System_Group2
{
    public class Library
    {
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

         public void listOfBook()
         {
             if (books_count != 0)
             {
                 for (int i = 0; i < books_count; i++)
                 {
                     Console.WriteLine(books[i]);
                 }
             }
             else
             {
                 Console.WriteLine("there is no book in the Library");
             }
        
         }

    }
}
