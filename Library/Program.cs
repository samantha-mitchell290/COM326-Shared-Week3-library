using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

Book book = new Book();
// This information is for one book in our library
book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

book.DisplayInfo();

// This is another book in our library
Book book1 = new Book();
book1.Title = "C# Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55667778";

book1.DisplayInfo();

// Create new instances of the Member class
// These new members are created using the
// Member constructor in the Members class
Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

Console.WriteLine("Current library members");
member.DisplayInfo();
member1.DisplayInfo();

