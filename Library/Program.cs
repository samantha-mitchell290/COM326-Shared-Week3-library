using Library;

//Create new lists that will be used to store books and members
List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

//Create and add new book objects to the list
books.Add(new Book("C# for beginners", "BillGates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

//Display all items within the Book list
foreach (Book book in books)
{
    book.DisplayInfo();
}

//Display all members within the members list
foreach (Member member in members)
{
    member.DisplayInfo();
}

//Create a dictionary to track book inventory by ISBN
Dictionary<string, int> bookInventory = new Dictionary<string, int>();

//Add our two sample books to the inventory (ISBN, Quantity)
bookInventory.Add("1234567", 5);
bookInventory.Add("2233445", 2);

//Display the inventory for a specific book using its ISBN key
Console.WriteLine($"Copies of 'C# for beginners' in stock: {bookInventory["1234567"]}");



//Test for missing ISBN in dictionary
Console.WriteLine("Checking inventory for a missing book...");
try
{
    //This ISBN does not exist, so it will throw a KeyNotFoundException
    Console.WriteLine(bookInventory["9999999"]);
}
catch (Exception ex)
{
    Console.WriteLine("Error: that ISBN was not found in the inventory system");
}
finally
{
    Console.WriteLine("Inventory check complete");
}
