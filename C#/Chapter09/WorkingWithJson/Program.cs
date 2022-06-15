// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text.Json; //JsonSerializer
using System.Text.Json.Serialization; //[JsonInclude]

using static System.Console;
using static System.Environment;
using static System.IO.Path;


Book csharp10 = new Book(title: 
"C# 10 and .NET 6 - Modern Cross-platform Development")
{
    Author = "Mark J  Price",
    PublishDate = new(year: 2021,month: 11,day: 09),
    Pages = 823,
    Created = DateTimeOffset.UtcNow,
};


JsonSerializerOptions options = new JsonSerializerOptions()
{
    IncludeFields = true, //includes all fields
    PropertyNameCaseInsensitive = true,
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

string filePath = Combine(CurrentDirectory, "book.json");

using (stream fileStream = File.Create(filePath))
{
    JsonSer
}

public class Book
{
    //constructor to set non-nullable property
    public Book(string title)
    {
        Title = title;
 
    }

    public string Title {get; set;}
    public string? Author{get; set;}

    //fields
    [JsonInclude] 
    public DataOnly PublishDate;
    
    [JsonInclude]
    public DateTimeOffset Created;

    public ushort Pages;

}