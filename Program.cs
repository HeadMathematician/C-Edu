using Predavanje1.Classes;
using Newtonsoft.Json;
using System;
using System.Collections;

namespace Predavanje1
{
    public class Program
    {
        //private List<Student> students = new List<Student>();
        //private List<Professor> professors = new List<Professor>();


        // QUEUE - First in first out (FIFO) princip 
        //<-------------------------------------------------------------------------->

        private Queue<Guest> mcDonaldsQueue = new Queue<Guest>();
        private Queue<Order> orderQueue = new Queue<Order>();

        Guest guest1 = new Guest()
        {
            GuestId = 1,
            Name = "Josh",
        };

        Guest guest2 = new Guest()
        {
            GuestId = 2,
            Name = "Susan",
        };

        Guest guest3 = new Guest()
        {
            GuestId = 3,
            Name = "Emily",
        };

        Order order1 = new Order()
        {
            FoodItems = new List<string> { "Chicken nuggets", "Coke" },
            Price = 13,       
        };

        Order order2 = new Order()
        {
            FoodItems = new List<string> { "BigMac menu", "Happy meal" },
            Price = 27,
        };

        Order order3 = new Order()
        {
            FoodItems = new List<string> { "Large fries", "Orange juice", "Snack wrap" },
            Price = 14.5F,
        };

        //<-------------------------------------------------------------------------->

        // STACK - First in last out (FILO) princip

        private Stack<Book> bookStackSmall = new Stack<Book>();
        private Stack<Book> bookStackLarge = new Stack<Book>();
        private Stack<Book> bookStackUndefined = new Stack<Book>();
        private List<Book> bookList = new List<Book>();

        Book book1 = new Book(Book.Size.Small)
        {
            Id = 1,
            Title = "To Kill a Mockingbird",
            Author = "Harper Lee",
        };
        Book book2 = new Book(Book.Size.Small)
        {
            Id = 2,
            Title = "1984",
            Author = "George Orwell",
        };
        Book book3 = new Book(Book.Size.Small)
        {
            Id = 3,
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
        };
        Book book4 = new Book(Book.Size.Small)
        {
            Id = 4,
            Title = "The Catcher in the Rye",
            Author = "J. D. Salinger",
        };
        Book book5 = new Book(Book.Size.Small)
        {
            Id = 5,
            Title = "Pride and Prejudice",
            Author = "Jane Austen",
        };

        Book book6 = new Book(Book.Size.Large)
        {
            Id = 6,
            Title = "The Lord of the Rings",
            Author = "J. R. R. Tolkien",
        };
        Book book7 = new Book(Book.Size.Large)
        {
            Id = 7,
            Title = "Harry Potter and the Sorcerer's Stone",
            Author = "J. K. Rowling",
        };

        Book book8 = new Book();


        //<-------------------------------------------------------------------------->

        //SORTED LIST

        private SortedList<int, char> alphabet = new SortedList<int, char>();

        private void ReadAlphabet(SortedList<int, char> list)
        {
            Console.WriteLine("Key\tValue");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}\t{1}", list.GetKeyAtIndex(i).ToString(), list.GetValueAtIndex(i));
            }

        }

        public Program()
        {
            //students = Student.CreateStudents();
            //professors = Professor.CreateProfessors();

            //Console.WriteLine("All objects:" );

            //foreach(var student in students)
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(student));
            //}
            //foreach(var professor in professors)
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(professor));
            //}

            //Dictionary<Professor, List<Student>> todaysClass = TodaysClass();

            //foreach(var kvp in todaysClass)
            //{
            //    Professor professor = kvp.Key;
            //    List<Student> students = kvp.Value;

            //    Console.WriteLine("\nToday's class: ");
            //    Console.WriteLine("Today's professor is " + professor.Name + " " + professor.LastName + " and he will be teaching " + professor.Subjects.First());
            //    Console.WriteLine("Today's students are: ");
            //    for(int i = 0; i < students.Count; i++)
            //    {
            //        Console.WriteLine(i+1 + "." + " " +students[i].Name + " " + students[i].LastName);
            //    }
            //}


            // QUEUE
            //<-------------------------------------------------------------------------->
            mcDonaldsQueue.Enqueue(guest1);
            mcDonaldsQueue.Enqueue(guest2);
            mcDonaldsQueue.Enqueue(guest3);

            orderQueue.Enqueue(order1);
            orderQueue.Enqueue(order2);
            orderQueue.Enqueue(order3);

            order1.Name = guest1.Name;
            order2.Name = guest2.Name;
            order3.Name = guest3.Name;

            Console.WriteLine("<-----------------QUEUE----------------->");
            Console.WriteLine("\nPeople in McDonalds queue: ");

            foreach (var guest in mcDonaldsQueue)
            {
                Console.WriteLine(guest.Name);
            }

            Console.WriteLine("\nGuests have been served...");
            for (int i = 0; i < orderQueue.Count; i++)
            {
                var number = i + 1;
                var order = orderQueue.ElementAt(i);
                Console.WriteLine("\n" + order.Name + " was number " + number + " in the queue and he/she paid " + order.Price + "$ for: ");
                for (int j = 0; j < order.FoodItems.Count; j++)
                {
                    Console.WriteLine(order.FoodItems[j]);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                orderQueue.Dequeue();
                mcDonaldsQueue.Dequeue();
            }

            Console.WriteLine("McDonalds guest and orders queue after serving: " + JsonConvert.SerializeObject(orderQueue) + " " + JsonConvert.SerializeObject(mcDonaldsQueue));
            //<-------------------------------------------------------------------------->


            // STACK 
            //<-------------------------------------------------------------------------->

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
            bookList.Add(book6);
            bookList.Add(book7);
            bookList.Add(book8);

            foreach (var book in bookList)
            {
                if (book.BookSize == (int)Book.Size.Small)
                    bookStackSmall.Push(book);
                else if (book.BookSize == (int)Book.Size.Large)
                    bookStackLarge.Push(book);
                else
                    bookStackUndefined.Push(book);
            }
            Console.WriteLine("\n<-----------------STACK----------------->");
            Console.WriteLine("\nSmall books in small stack: ");
            Console.WriteLine("");

            GetAllBooks(bookStackSmall);

            Console.WriteLine("\nLarge books in large stack: ");
            Console.WriteLine("");

            GetAllBooks(bookStackLarge);

            Console.WriteLine("\nUndefined books in undefined stack: ");
            Console.WriteLine("");

            GetAllBooks(bookStackUndefined);

            Book poppedBook1 = bookStackSmall.Pop();
            Console.WriteLine("\nToo many books in small stack, I'll just take the first one: " + poppedBook1.Title + " by " + poppedBook1.Author);
            //<-------------------------------------------------------------------------->

            //SORTED LIST

            alphabet.Add(3, 'c');
            alphabet.Add(2, 'b');
            alphabet.Add(1, 'a');
            alphabet.Add(5, 'e');
            alphabet.Add(10, 'j');
            alphabet.Add(25, 'y');
            alphabet.Add(19, 's');
            alphabet.Add(22, 'v');
            alphabet.Add(12, 'l');
            alphabet.Add(7, 'g');
            alphabet.Add(11, 'k');
            alphabet.Add(17, 'q');
            alphabet.Add(24, 'x');
            alphabet.Add(13, 'm');
            alphabet.Add(14, 'n');
            alphabet.Add(23, 'w');
            alphabet.Add(15, 'o');
            alphabet.Add(8, 'h');
            alphabet.Add(20, 't');
            alphabet.Add(16, 'p');
            alphabet.Add(6, 'f');
            alphabet.Add(9, 'i');
            alphabet.Add(4, 'd');
            alphabet.Add(26, 'z');
            alphabet.Add(18, 'r');
            alphabet.Add(21, 'u');

            Console.WriteLine("\n <----------Sorted list----------->");
            Console.WriteLine("\nKeys and Values: ");
            ReadAlphabet(alphabet);
        }


        public void GetAllBooks(Stack<Book> bookStack)
        {
            for (int i = 0; i < bookStack.Count; i++)
            {
                var book = bookStack.ElementAt(i);
                if(book.Id != null)
                {
                    Console.WriteLine(i + 1 + ". " + book.Title + " by " + book.Author);
                }
                else
                {
                    Console.WriteLine("- I don't know what kind of book is this.");
                }
            }
        }

        //private Professor RandomProfessor()
        //{
        //    Random random = new Random();
        //    int randomNumber = random.Next(1, 6);

        //    if(randomNumber == 1)
        //    {
        //        var toReturn = professors.Find(x => x.Id == 1);
        //        return toReturn;
        //    }
        //    else if (randomNumber == 2)
        //    {
        //        var toReturn = professors.Find(x => x.Id == 2);
        //        return toReturn;
        //    }
        //    else
        //    {
        //        Professor substituteProfessor = new Professor()
        //        {
        //            Id = randomNumber,
        //            Name = "Charles",
        //            LastName = "Xavier",
        //            Subjects = new List<string>() { "Telepathy" }
        //        };
        //        return substituteProfessor;
        //    }
        //}

        //private Dictionary<Professor, List<Student>> TodaysClass()
        //{
        //    Professor todaysProfessor = RandomProfessor();

        //    Dictionary<Professor, List<Student>> todaysClass = new Dictionary<Professor, List<Student>>();

        //    todaysClass.Add(todaysProfessor, students);

        //    return todaysClass;
        //}

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.ReadKey();
        }

    }
}
