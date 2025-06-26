namespace mange
{
    internal class LibrarySystem
    {
        Listt<Book>booklist=new Listt<Book>();  
        Listt<Member>Memberlist = new Listt<Member>();
        sort s1= new sort();

        //Allow to add book
        public void Add_Book(Book book)
        {
           


            booklist.Add(book);
        }

        //Allow to Add member
        public void Add_Member(Member member) 
        {
            if(member != null)
            {
                throw new ArgumentException();
            }
            Memberlist.Add(member);

        }
        //check book found or no
    public void Check_Book_found(int id)
        {
            int index = BinarySearch.searsh(booklist, id);
            if (index == -1)
            {
                Console.WriteLine("Book not found in list");
            }
            else
            {
                Console.WriteLine("Book found in list : " + index);
            }
        }
        //Sort sort book by id
        public void Sort_Book()
        {
            s1.sorted(booklist);
        }
        //searsh by id
        public void Searsh_By_id(int id)
        {
            BinarySearch.searsh(booklist, id);
        }
        //brrow book
        public void borrow(int id, Member member)
        {
            BinarySearch.searsh(booklist, id);
            int index = BinarySearch.searsh(booklist, id);
            if (index ==-1)
            {
                Console.WriteLine("Book not found ");
            }
            else
            {
                Book book= booklist[index];
                book.IsIssued = true;
                Console.WriteLine($"Book {book.Tittle} borrowed by : {member.name}");
            }



        }
        //return Book
        public void ReturnBook(int id, Member member)
        {
            BinarySearch.searsh(booklist, id);
            int index = BinarySearch.searsh(booklist, id);
            if (index == -1)
            {
                Console.WriteLine("Book not found ");
            }
            else
            {
                Book book= booklist[index];
                book.IsIssued = false;
                Console.WriteLine($"BOOK {book.Tittle} return by : {member.name}");
            }

        }
        //Displlay all book
        public void DisplayAllBooks()
        {
            booklist.print();
        }



    }
}
