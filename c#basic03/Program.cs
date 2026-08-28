namespace c_basic03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ans.q1
            #region && operator
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot borrow this book");
            //} 
            #endregion

            //ans.q2
            #region switchcases()
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //} 
            #endregion

            // ans.q3
            #region ternary operator()
            //int pages = 464;
            //string sizeLabel= pages > 300 ? "long book" : "Small book";
            //Console.WriteLine(sizeLabel); 
            #endregion

            // ans.q4
            #region printForloop()
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i = 0; i < books.Length; i++) {
            //    Console.WriteLine($"{i + 1}. {books[i]}"); 
            #endregion

            // ans.q5
            #region whileLoop()
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //} 
            #endregion


            // ans.q6
            #region doWhile()
            //int i = 0;
            //do { 
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i < 3); 
            #endregion

            // ans.q7
            #region foreach()
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //} 
            #endregion

            // ans.q8
            #region break()
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //    {

            //        break;
            //    }
            //    Console.WriteLine(books[i]);
            //} 
            #endregion


        }
    }
}
