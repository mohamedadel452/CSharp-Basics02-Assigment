
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

            #region Q3 ( Is it a compile-time error, a runtime error, or a logical error?)
            Console.WriteLine("\nQ3: int pages = \"464\"; \n Is it a compile-time error, a runtime error, or a logical error?");
            /* Original code: int pages = "464"; 
             * This is a Compile-time error 
             * Becuse we are trying to assign a string value to an integer variable, which is not allowed in C#.
             * So to fix this error, we need to change the type of the variable pages to string or change the value to an integer. 
             */
            Console.WriteLine("\nThis is a Compile-time error because we are trying to assign a string value to an integer variable, which is not allowed in C#.\n");
            // Fixed code:
            int fixedPages = 464;
            Console.WriteLine($"Fixed integer assignment: using int value pages = {fixedPages}\n");
            //Another solution is to change the type of the variable pages to string like this:
            string anotherPages = "464";
            Console.WriteLine($"Another solution: using string value  pages = {anotherPages}\n");

            #endregion

            #region Q4 (Write code that divides 10 by 0 inside a try block,  and catche the exception)

            Console.WriteLine("\nQ4: Write code that divides 10 by 0 inside a try block, and catch the exception");
            try
            {
                int number = 10;
                int result = number / 0; // This will throw a DivideByZeroException

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught an exception of type {ex.GetType()} and the message is: {ex.Message}");
                Console.WriteLine("So We can say that we ");
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Done in finally block");
            }
            #endregion

            #region Q5 (Declare an int pages = 300; then store it in a double variable without using a cast.)
            Console.WriteLine("\nQ5: Declare an int pages = 300; then store it in a double variable without using a cast.");
            int pages = 300;
            double doublePages = pages; 
            /* Implicit conversion from int to double 
             * Because double is a larger data type than int,
             * the conversion is safe and automatic. */
            Console.WriteLine($"The value of pages is: {pages}");
            Console.WriteLine($"The value of doublePages is: {doublePages}");

            #endregion




        }
    }


}

