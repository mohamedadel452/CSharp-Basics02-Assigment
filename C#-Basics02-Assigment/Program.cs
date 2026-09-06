
// This is a simple C# program that demonstrates the use of classes and methods
namespace BookAssigment
{
    // This is the main class of the program
    class Program
    {

        // Entry point of the program
        static void Main(string[] args)
        {

            // Class of Book created with the title and  pages

            #region Q1 (Creating an instance of the Book class And store it on a variable of type Object And Print it and its properties)


            Console.WriteLine("Q1 (Creating an instance of the Book class And store it on a variable of type Object)");

            Object book1 = new Book("Kotlin In Action", 500);

            // Print the object And it will print the name of the class 
            Console.WriteLine($"Printing the book object: {book1}");

            //  Print the title and pages of the book 
           
            Console.WriteLine("Printing the title and pages of the book");
            Console.WriteLine($"The title of the book is: {((Book)book1).Title}");
            Console.WriteLine($"The number of pages in the book is: {((Book)book1).Pages}");

            #endregion

            #region Q2 ( Using the Book class above, print the result of calling ToString(), Equals(), GetHashCode(), and GetType())
            // Print the result of calling ToString(), Equals(), GetHashCode(), and GetType() on the book object
            Console.WriteLine("\nQ2 ( Using the Book class above, print the result of calling ToString(), Equals(), GetHashCode(), and GetType())");
            Console.WriteLine($"ToString() : {book1.ToString()}");
            Console.WriteLine($"Equals() : {book1.Equals(book1)}");
            Console.WriteLine($"GetHashCode() : {book1.GetHashCode()}");
            Console.WriteLine($"GetType() : {book1.GetType()}");
            #endregion

        }
    }


}

