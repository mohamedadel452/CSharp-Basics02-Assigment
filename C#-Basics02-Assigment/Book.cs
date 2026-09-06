
/// <summary>
/// Represents a book with a title and number of pages.
/// </summary>
class Book
{

    #region Creating The Properties
    public string Title { get; set; }
    public int Pages { get; set; }
    #endregion

    #region Creating The Constructor
    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }
    #endregion

}