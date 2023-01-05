// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;


internal class Program
{
    private static void Main(string[] args)
    {
        //OutputFileSystemInfo();
        //WorkWithDrives();
        //WorkWithDirectories();
        WorkWithFiles();

        static void OutputFileSystemInfo()

        {
            WriteLine(format: "{0,-33} {1}", arg0: "Path.PathSeparator",
                      arg1: PathSeparator);
            WriteLine(format: "{0,-33} {1}", arg0: "Path.DirectorySeparatorChar",
                      arg1: DirectorySeparatorChar);
            WriteLine(format: "{0,-33} {1}", arg0: "Directory.GetCurrentDirectory()",
                      arg1: GetCurrentDirectory());
            WriteLine(format: "{0,-33} {1}", arg0: "Environment.CurrentDirectory",
                      arg1: CurrentDirectory);
            WriteLine(format: "{0,-33} {1}", arg0: "Environment.SystemDirectory",
                      arg1: SystemDirectory);
            WriteLine(format: "{0,-33} {1}", arg0: "Path.GetTempPath()",
                      arg1: GetTempPath());
            WriteLine(value: "GetFolderPath(SpecialFolder");
            WriteLine(format: "{0,-33} {1}", arg0: " .System)",
                      arg1: GetFolderPath(folder: SpecialFolder.System));
            WriteLine(format: "{0,-33} {1}", arg0: " .ApplicationData)",
                      arg1: GetFolderPath(folder: SpecialFolder.ApplicationData));
            WriteLine(format: "{0,-33} {1}", arg0: " .MyDocuments)",
                      arg1: GetFolderPath(folder: SpecialFolder.MyDocuments));
            WriteLine(format: "{0,-33} {1}", arg0: " .Personal)",
                      arg1: GetFolderPath(folder: SpecialFolder.Personal));
        }


        static void WorkWithDrives()
        {
            WriteLine(format: "{0, -30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
                       "NAME", "TYPE", "FORMAT", "SIZE {BYTES}", "FREE SPACE");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    WriteLine(format: "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
                    drive.Name, drive.DriveType, drive.DriveFormat,
                    drive.TotalSize, drive.AvailableFreeSpace);
                }
                else
                {
                    WriteLine(format: "{0,-30} | {1,-10}", arg0: drive.Name, arg1: drive.DriveType);
                }
            }
        }


        static void WorkWithDirectories()
        {
            //define a directory path for a new folder
            //starting in the user's folder
            string newFolder = Combine(
                path1: GetFolderPath(folder: SpecialFolder.Personal),
                path2: "Code", path3: "Chatper09", path4: "NewFolder");

            WriteLine(value: $"Working with: {newFolder}");

            //check if it exists
            WriteLine(value: "Creating it ....");
            CreateDirectory(path: newFolder);
            WriteLine(value: $"Does it exist: {Exists(path: newFolder)}");
            Write(value: "Confirm the directory exist, and then press ENTER: ");
            ReadLine();

            WriteLine(value: "Deleting it ...");
            Delete(path: newFolder, recursive: true);
            WriteLine(value: $"Dose it exist? {Exists(path: newFolder)}");

        }


        static void WorkWithFiles()
        {
            //defien a directory path to output files
            // starting in the user's folder

            string dir = Combine(
                //path1: GetFolderPath(folder: SpecialFolder.Personal),
                //path2:"csharp10&.net6",
                //path3: "Chapter09", path4: "OutputFiles"); *default paramter
                path1:CurrentDirectory,path2:"OutputFiles");


            CreateDirectory(path: dir);

            //define file paths
            string textFile = Combine(path1: dir, path2: "Dummy.txt");
            string backupFile = Combine(path1: dir, path2: "Dummy.bak");
            WriteLine(value: $"Working with: {textFile}");

            //check if a file exist
            WriteLine(value: $"Does it exist? {File.Exists(path: textFile)}");

            //creat a new text file and input the content
            StreamWriter textWriter = File.CreateText(path: textFile);
            textWriter.WriteLine(value: "Hello, C#!");
            textWriter.Close();
            
            //creat a new text file and wirte to a line to it
            StreamWriter bakWriter = File.CreateText(path: backupFile);
            bakWriter.Close();

            WriteLine(value: $"Does it exist? {File.Exists(path: backupFile)}");

            //read form the text file backup
            WriteLine(value: $"Reading contents of {backupFile}");
            StreamReader textReader = File.OpenText(path: backupFile);
            WriteLine(value: textReader.ReadToEnd());
            textReader.Close();


            //managing paths
            WriteLine(value: $"Folder Name: {(textFile)}");
            WriteLine(value: $"File Name: {GetFileName(path: textFile)}");

            WriteLine(format: "File Name without Extension: {0}",
                      arg0: GetFileNameWithoutExtension(path: textFile));
            WriteLine(value: $"File Extension: {GetExtension(path: textFile)}");
            WriteLine(value: $"Random File Name: {GetRandomFileName()}");
            WriteLine(value: $"Temporary File Name: {GetTempFileName()}");


            //Getting file information
            FileInfo info = new FileInfo(fileName: backupFile);
            WriteLine(value: $"{backupFile}:");
            WriteLine(value: $"Contains {info.Length} bytes");
            WriteLine(value: $"Last accessed {info.LastAccessTime}");
            WriteLine(value: $"Has readonly set to {info.IsReadOnly}");


            //Controlling how you work with files
            WriteLine(format: "Is the backup file compressed? {0}",
            arg0: info.Attributes.HasFlag(flag: FileAttributes.Compressed));


           
        }
    }
}
