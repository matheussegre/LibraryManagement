namespace LibraryManagement.API.Comunication.Request;

public class RequestGetAllBooks
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public List<string> Genre { get; set; } = [];
    public decimal Price { get; set; }
    public int InStock { get; set; }
}
