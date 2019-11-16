
/// <summary> 
/// STUDENT: Brandon Crandall
/// SYNOPSIS:Using the classes in the System.IO namespace I'm going to use various methods to create and manipulate files.
/// </summary>


using System.IO;
using System;

namespace Demonstration_Programs
{    
    class FileManipulation
    {
               public static void RunFileManipulation()
        {
            tempPath();
            Console.WriteLine();

            //Creating directory. My example will be C:\temp
            Console.Write("Specify the folder name and path you want to create: ");
            string userDirectory = Console.ReadLine();
            Directory.CreateDirectory(userDirectory);
            
            //creating file, examples is mytest.txt
            Console.Write("Specify the file name you would like to be created in the folder: ");
            string userFilePath = Console.ReadLine();

            //I combine the directory path with the file name in order to send my function the full location
            string fullPath = Path.Combine(userDirectory, userFilePath);
            createFile(fullPath);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("We are going to read whats in the file:");
            readFile(fullPath);

            Console.ReadLine();
            Console.WriteLine();

            Console.Write("Would you like to delete a file? (y/n)");
            string userchoice = Console.ReadLine();
            userchoice = userchoice.ToLower();
            if (userchoice == "y")
            {
                Console.Write("What is the filepath of the file you want deleted? ");
                string fileToBeDeleted = Console.ReadLine();
                deleteFile(fileToBeDeleted);
            }
            

            Console.ReadLine();

        }

        //Created a simple function that when called will give us the directory path to the temp folder
        static void tempPath()
        {
            Console.WriteLine("Here is the location of the temp folder.");
            string tempDirectoryPath = Path.GetTempPath();
            Console.WriteLine(tempDirectoryPath);
        }

        //Creating a file on the C drive
        static void createFile(string userFilePath)
        {
            //Checking to see if the file exists. If it does this will not do anything.
            //If it doesn't exit then we will create the file and add some text.
            if (!File.Exists(userFilePath))
            {
                using (StreamWriter sw = File.CreateText(userFilePath))
                {
                    Console.Write("What would you like to put in the file: ");
                    string userFileText = Console.ReadLine();
                    sw.WriteLine("This is what you wanted:");
                    sw.WriteLine();
                    sw.WriteLine(userFileText);
                    sw.WriteLine();
                    sw.WriteLine("C# is cool!");
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(userFilePath))
                {
                    Console.Write("What would you like to put in the file: ");
                    string userFileText = Console.ReadLine();
                    sw.WriteLine(userFileText);
                }
            }
        }

        //Read from the file just created
        static void readFile(string userFilePath)
        {
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(userFilePath))
            {
                string read = File.ReadAllText(userFilePath);
                Console.WriteLine(read);
            }
        }

        //Now we will remove the file created
        static void deleteFile(string userFilePath)
        {

            // If file found, delete it  
            if (File.Exists(userFilePath))
            {
                File.Delete(userFilePath);
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("file not found");
            }
        }
    }
}

//MODIFICATIONS: Created this myself

//ANALYSIS: Uses user input to create and call methods, create a directory, create/delete/read/write a file

/* Sample Output:

Here is the location of the temp folder.
C:\Users\brand\AppData\Local\Temp\

Specify the folder name and path you want to create: C:\temp
Specify the file name you would like to be created in the folder: test.txt
What would you like to put in the file: Hi I made this file.


We are going to read whats in the file:
This is what you wanted:

Hi I made this file.

C# is cool!



Would you like to delete a file? (y/n)y
What is the filepath of the file you want deleted? C:\temp\test.txt
File deleted.


 */
