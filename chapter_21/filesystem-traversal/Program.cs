using System.IO;

string? input = null;
List<FileInfo> csvFiles = new();

// Make sure the input is valid
while (input == null)
{
    System.Console.Write("Please enter a path: ");
    input = Console.ReadLine();
}

DirectoryInfo startDirectory = new DirectoryInfo(input);

// Add all subdirectories to an array
DirectoryInfo[] subDirectories = startDirectory.GetDirectories("*", SearchOption.AllDirectories);

// Search the subdirectories for .csv files
for (int i = 0; i < subDirectories.Length; i++)
{
    FileInfo[] files = subDirectories[i].GetFiles();
    for (int j = 0; j < files.Length; j++)
    {
        string ending = files[j].Name.Split('/').Last();
        if (ending == ".csv")
        {
            csvFiles.Add(files[j]);
        }
    }
}

foreach (FileInfo file in csvFiles)
{
    System.Console.WriteLine(file.Directory.FullName + "/" + file.Name);
}