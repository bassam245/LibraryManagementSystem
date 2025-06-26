namespace mange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creat colliction off books
            Book b1 = new Book("Algorithm","Elon",3);
            Book b2 = new Book("Date stractour","Micro soft",1);
            Book b3 = new Book("C#","En.Morad",2);
            Book b4 = new Book("OOP","En.Alaa",5);
            Book b5 = new Book("Basics","En.Aya",4);


            //creat colliction of members
            Member m1 = new Member(3,"Bassam");
            Member m2 = new Member(4, "Yomna");
            Member m3 = new Member(2, "Saif");
            Member m4 = new Member(1, "Alaa");


            // Create manager object
            LibrarySystem mange = new LibrarySystem();


            // Add books
            mange.Add_Book(b1);
            mange.Add_Book(b2);
            mange.Add_Book(b3);
            mange.Add_Book(b4);
            mange.Add_Book(b5);


            //Displlay books before sort
            Console.WriteLine("\nDispllay all books before sort");
            Console.WriteLine();
            mange.DisplayAllBooks();


            //Displlay all books after sort
            Console.WriteLine("\nDispllay All books after sorted by id");
            Console.WriteLine();
            mange.Sort_Book();
            mange.DisplayAllBooks();


            //brow book
            Console.WriteLine("\nBorrow book number 3 ");
            mange.borrow(3, m2);
           

            //Displlay all book after borrow

            Console.WriteLine();
            mange.DisplayAllBooks();


            //return book again
            Console.WriteLine("\nReturn book again book number  3 ");
            mange.ReturnBook(3,m2);
            Console.WriteLine();
            mange.DisplayAllBooks();


            //searsh book by id
            Console.Write("\nSearsh for book number 3 : ");
            mange.Searsh_By_id(3);
            mange.Check_Book_found(3);




        }
    }
}
