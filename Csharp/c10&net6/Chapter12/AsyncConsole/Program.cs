using static System.Console;
using static System.Threading.Thread;
using static System.Threading.Tasks.Task;
using static System.Diagnostics.Process;
using System.Threading.Tasks;
using System.Diagnostics;
using System;



HttpClient client = new HttpClient();

httpResponseMessage response = 
    await client.GetAsync("https://www.microsoft.com");

WriteLine("apple's home page has {0:N0} bytes.", 
    response.Content.Headers.ContentLength);
