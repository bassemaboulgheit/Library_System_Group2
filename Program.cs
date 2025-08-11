namespace Library_System_Group2
{
    internal class Program
    {
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

                                        Console.Write("enter book id: ");
                                        int bid = int.Parse(Console.ReadLine());
                                        Console.Write("enter title: ");
                                        string title = Console.ReadLine();
                                        Console.Write("enter author: ");
                                        string author = Console.ReadLine();
                                        library.AddBook(new Book(bid, title, author));
                                                
                                        break;
                    
                                    case 1: // remove book
                                        
                                        Console.Write("enter book id: ");
                                        library.RemoveBook(int.Parse(Console.ReadLine()));
                    
                                        break;
                    
                                    case 2:  //add member

                                        Console.Write("enter member id: ");
                                        int mid = int.Parse(Console.ReadLine());
                                        Console.Write("enter name: ");
                                        string name = Console.ReadLine();
                                        library.AddMember(new Member(mid, name));
                    
                                        break;
                    
                                    case 3: //remove member

                                        Console.Write("enter member id: ");
                                        library.RemoveMember(int.Parse(Console.ReadLine()));
                    
                                        break;
                    
                                    case 4:  //borrow book

                                        Console.Write("enter member id: ");
                                        int bmid = int.Parse(Console.ReadLine());
                                        Console.Write("enter book id: ");
                                        int bbid = int.Parse(Console.ReadLine());
                                        library.borrowBook(bmid, bbid);
                                          
                                        break;
                    
                                    case 5:  // return book

                                        Console.Write("enter member id: ");
                                        int rmid = int.Parse(Console.ReadLine());
                                        Console.Write("enter book id: ");
                                        int rbid = int.Parse(Console.ReadLine());
                                        library.ReturnBook(rmid, rbid);
                                        
                                        break;
                    
                                    case 6:  // list books

                                        library.listOfBook();
          
                                        break;
                    
                                    case 7:  // list members

                                        library.listOfMember();
                                        
                                        break;
                    
                                    case 8:  // exit
                                        
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
}
