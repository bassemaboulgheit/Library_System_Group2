namespace Library_System_Group2
{
    internal class Program
    {
        // start validation for read integer id or string names

        
          static int ReadInt(string message)
          {
              int value;
              while (true)
              {
                  Console.Write(message);
                  string input = Console.ReadLine();
                  if (int.TryParse(input, out value))
                  {
                      return value;
                  }
                  else
                  {
        
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine(" error: Please enter a number value");
                      Console.ResetColor();
                  }
              }
          }
        
          static string ReadString(string message)
          {
              while (true)
              {
                  Console.Write(message);
                  string input = Console.ReadLine();
                  if (!string.IsNullOrWhiteSpace(input) && !input.Any(char.IsDigit))
                  {
                      return input;
                  }
                  else
                  {
        
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine(" error: Please enter letters only");
                      Console.ResetColor();
                  }
              }
          }

        // end validation  for read integer id or string names
        
        static void Main(string[] args)
        {
                    
                        //----------------start main-------------------
                    
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        Console.InputEncoding = System.Text.Encoding.UTF8;
                    
                        Library library = new Library();
                    
                        string[] menu = {
                            "Add Book",
                            "Remove Book",
                            "Add Member",
                            "Remove Member",
                            "Borrow Book",
                            "Return Book",
                            "List Books",
                            "List Members",
                            //new methods over required
                            "Edit Book",
                            "Edit Member",
                            "Remove All Books",
                            "Remove All Members",            
                            "Exit"
                        };
                    
                        int currentItem = 0;
                        ConsoleKeyInfo key;
                    
                        while (true)
                        {
                    
                            Console.SetCursorPosition(0, 0);
                            Console.Write(new string(' ', Console.WindowWidth * (menu.Length + 3)));
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Library Management System\n");
                    
                            for (int i = 0; i < menu.Length; i++)
                            {
                                if (i == currentItem)
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write($"> {menu[i]}");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine($"  {menu[i]}");
                                }
                            }
                    
                    
                            key = Console.ReadKey(true);
                    
                            if (key.Key == ConsoleKey.DownArrow)
                            {
                                currentItem++;
                                if (currentItem >= menu.Length) currentItem = 0;
                            }
                            else if (key.Key == ConsoleKey.UpArrow)
                            {
                                currentItem--;
                                if (currentItem < 0) currentItem = menu.Length - 1;
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                switch (currentItem)
                                {
                                    case 0:  // add book

                                        int bid = ReadInt("enter book id: ");
                                        string title = ReadString("enter title: ");
                                        string author = ReadString("enter author: ");
                                        library.AddBook(new Book(bid, title, author));
                                                
                                        break;
                    
                                    case 1: // remove book
                                        
                                        library.RemoveBook(ReadInt("enter book id: "));
                    
                                        break;
                    
                                    case 2:  //add member

                                        int mid = ReadInt("enter member id: ");
                                        string name = ReadString("enter name: ");
                                        library.AddMember(new Member(mid, name));
                    
                                        break;
                    
                                    case 3: //remove member

                                        library.RemoveMember(ReadInt("enter member id: "));
                    
                                        break;
                    
                                    case 4:  //borrow book

                                        int bmid = ReadInt("enter member id: ");
                                        int bbid = ReadInt("enter book id: ");
                                        library.borrowBook(bmid, bbid);
                                          
                                        break;
                    
                                    case 5:  // return book

                                        int rmid = ReadInt("enter member id: ");
                                        int rbid = ReadInt("enter book id: ");
                                        library.ReturnBook(rmid, rbid);
                                        
                                        break;
                    
                                    case 6:  // list books

                                        library.listOfBook();
          
                                        break;
                    
                                    case 7:  // list members

                                        library.listOfMember();
                                        
                                        break;
                                    case 8: // edit book
                                        int ebid = ReadInt("enter book id: ");
                                        string newTitle = ReadString("enter new title: ");
                                        string newAuthor = ReadString("enter new author: ");
                                        library.EditBook(ebid, newTitle, newAuthor);
                                        break;
                                    
                                    case 9: // edit member
                                        int emid = ReadInt("enter member id: ");
                                        string newName = ReadString("enter new name: ");
                                        library.EditMember(emid, newName);
                                        break;
                                    
                                    case 10: // remove all books
                                        library.RemoveAllBooks();
                                        break;
                                    
                                    case 11: // remove all members
                                        library.RemoveAllMembers();
                                        break;
                                    case 12:  // exit
                                        
                                        return;
                                }
                    
                                Console.WriteLine("\nPress Enter to return to menu...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    
                    }
                    //-----------------end main------------------
                          
    }
}
