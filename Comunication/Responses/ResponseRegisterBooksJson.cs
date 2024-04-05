namespace LibraryManagement.API.Comunication.Responses;

public class ResponseRegisterBooksJson
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
}
