using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp01
{
    class Program47
    {
        static void Main(string[] args)
        {
            //Editing the existing file
            string fpath = @"c:\myfile1.txt";
            FileStream fname = new FileStream(fpath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine("Added at EOF at " + DateTime.Now);
            sw.Close();

        }
    }
}

/*CREATE A FILE THROUGH FILE HANDLING
 * static void Main(string[] args)
        {
            string fpath = @"c:\myfile1.txt";
            StreamWriter fname = new StreamWriter(fpath);

            fname.WriteLine("Welcome to File handling");
            fname.WriteLine("File create from c#");
            fname.WriteLine("Created by kiran at " + DateTime.Now);

                Console.WriteLine("File created successfully..");

            fname.Close();
/

/*
 IO stands for Input and Output
.NET provided an API containing built in classes to handle a files,  namespace is System.IO
File Handling:    This is the feature used to handle files like
    Write data, read data, delete file, etc.,
To create Object:
StreamWriter obj = new StreamWrite("filename");
Note: The above system will create a new file, overwrite if file already exist
StreamWriter obj = new StreamWrite("filename",true);
By providing true as second parameter, the data will into the content
 */

/*
 * READ FILE
 * string fpath = @"c:\myfile1.txt";
            StreamReader sr = new StreamReader(fpath);

            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);

            sr.Close();
*/