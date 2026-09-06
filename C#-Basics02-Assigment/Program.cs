
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

            #region Q6 (Declare a double price = 49.99; then convert it into an int using a cast.)
            Console.WriteLine("\nQ6: Declare a double price = 49.99; then convert it into an int using a cast.");
            double price = 49.99;
            int intPrice = (int)price; 
            /* Explicit conversion from double to int using a cast
             * Because we are converting from a larger data type to a smaller one
             *  we need to be careful about potential data loss. */
            Console.WriteLine($"The value of price is: {price}");
            Console.WriteLine($"The value of intPrice is: {intPrice}");
            Console.WriteLine($"There is an implicit conversion from double to int, but it will truncate the decimal part.");
            Console.WriteLine("So We need to be careful when converting from a larger data type to a smaller one.");

            #endregion

            #region Q7 (Given string pagesText = "464";, convert it into an int using the Convert class.)
            Console.WriteLine("\nQ7: Given string pagesText = \"464\";, convert it into an int using the Convert class.");
            //we will use the Convert.ToInt32() method to convert a string to an int.
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine($"The value of pagesText is: {pagesText}");
            Console.WriteLine($"The value of convertedPages is: {convertedPages}");

            #endregion

            #region Q8 (Parse and TryParse)
            Console.WriteLine("\nQ8: Parse and TryParse");
            // Given string yearText = "2023";, convert it using int.Parse().
            Console.WriteLine("-Given string yearText = \"2023\";, convert it using int.Parse().");
            string yearText = "2023";
            int parsedYear = int.Parse(yearText);
            Console.WriteLine($"String \"{yearText}\" parsed using int.Parse(): {parsedYear}");
            // Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
           Console.WriteLine("\n-Given string badText = \"abc\";, use int.TryParse() to safely try converting it, and print \"Invalid number\" if it fails.");
            string badText = "abc";
            bool isSuccess = int.TryParse(badText, out int output);
            if( isSuccess)
            {
                // If parsing is successful, print the parsed value
                Console.WriteLine("Parsed successfully: " + output);
            }
            // If parsing fails, print "Invalid number"
            else Console.WriteLine("Invalid number");


            #endregion

            #region Q9 (Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.)
            Console.WriteLine("\nQ9: Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.");
            int pagesNumber = 464;
            string pagesString = pagesNumber.ToString();
            // Print the value of pages and pagesString, and the type of pagesString
            Console.WriteLine($"The value of pages is: {pagesNumber}");
            Console.WriteLine($"After conversion to string");
            Console.WriteLine($"The value of pagesString is: {pagesString}");
            // Print the type of pagesString using GetType()
            // This will show that pagesString is of type System.String
            Console.WriteLine($"The type of pagesString is: {pagesString.GetType()}");

            #endregion

            #region Q10 (Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.)
            Console.WriteLine("\nQ10: Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.");
            int copies = 100;// Declare an int variable copies and assign it the value 100
            object boxedCopies = copies;// Box the int variable copies into an object variable boxedCopies
            int unboxedCopies = (int)boxedCopies;// Unbox the object variable boxedCopies back into an int variable unboxedCopies
            Console.WriteLine($"Printing values after boxing and unboxing:");
            Console.WriteLine($"The value of copies is: {copies}");
            Console.WriteLine($"The value of boxedCopies is: {boxedCopies}");
            Console.WriteLine($"The value of unboxedCopies is: {unboxedCopies}");

            #endregion


        }
    }


}

