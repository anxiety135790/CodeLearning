// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Diagnostics;
using Microsoft.Extensions.Configuration;


// write to a text file in the project folder
Trace.Listeners.Add(new TextWriterTraceListener(
 File.CreateText(Path.Combine(Environment.GetFolderPath(
 Environment.SpecialFolder.DesktopDirectory), "log.txt"))));
// text writer is buffered, so this option calls
// Flush() on all listeners after writing
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace say, I am watching!");

//dotnet run --configuration Release
//dotnet run --configuration Debug
//When running with the Debug configuration, both Debug and Trace are active and will write to any trace listeners. 
//When running with the Release configuration, only Trace will write to any trace listeners. 



// dotnet add package Microsoft.Extensions.Configuration
// dotnet add package Microsoft.Extensions.Configuration.Binder
// dotnet add package Microsoft.Extensions.Configuration.Json
// dotnet add package Microsoft.Extensions.Configuration.FileExtension
//dotnet add package adds a reference to a NuGet package to your project file.
//It will be downloaded during the build process. 
//dotnet add reference adds a project-to-project 
//reference to your project file. 
//The referenced project will be compiled 
//if needed during the build process.

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json",
optional: true, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
displayName: "PacktSwitch",
description: "This switch is set via a JSON config.");
configuration.GetSection("PacktSwitch").Bind(ts);


Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");