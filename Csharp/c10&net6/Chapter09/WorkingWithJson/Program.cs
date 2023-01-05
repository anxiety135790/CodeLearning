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

string filePath = Combine(path1: CurrentDirectory, path2: "book.json");

using (stream fileStream = File.Create(path: filePath))
{
    JsonSerializer.Serialize<Book>(
    utf8Json: fileStream, value: csharp10, options);

    WriteLine(format:"Written {0:N0} bytes of JSON to {1)",
    arg0: new FileInfo(fileName: filePath).Length,
    arg1: filePath);

    WriteLine();
;
    //Display  the serialized object graph
    WriteLine(value: File.ReadAllText(path: filePath));
    
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