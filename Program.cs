var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var books = new List<Book> {
    new Book{Id = 1, Title = "The title is here.", Author= "The author is here."}
};

app.MapGet("/api", () => {
    Console.WriteLine("The console application is runnning");
    return books;
});


// getithere 
app.Run();


class Book
{
    public int Id { get; set; }
    public required string Title{get; set;}
    public required string Author { get; set; }

}