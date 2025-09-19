using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"c:\temp\MyTest.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "Hello", "And", "Welcome" };
                File.WriteAllLines(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra tex\n\tthe more extra to the file";
            File.AppendAllText(path, appendText);


            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }





            //file stream
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                //Read and display lines from the file until the end of
                //the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine(sr.ReadToEnd());
            }






            //In this example, StreamWriter will write each member of the myArray array to the file in the foreach loop.



            //******************** using fileInfo and DirectoryInfo

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
            DirectoryInfo[] directories = dirInfo.GetDirectories();
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in directories)
                {
                    sw.WriteLine(dir.Name);
                }
                Console.WriteLine("writing completed");
            }





            var fi1 = new FileInfo(@"C:\blabla");

            // Create a file to write to.
            //using (StreamWriter sw = new StreamWriter("C:\\blabla"))
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }










            //******************* using stream reader

            var fi2 = new FileInfo("C:\\blabla");

            // Open the file to read from.
            using (StreamReader sr = fi2.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            //******************* using arrays
            string[] myArray = new string[4];
            //myArray[4] = "something";//out of index exception

            myArray[0] = "Will";
            myArray[1] = "fill";
            myArray[2] = "this";
            myArray[3] = "array";
            foreach (string s in myArray)
            {
                Console.WriteLine(s);
            }

            //####### dictionary in C#
            //   Create a dictionary where key = string, value = int

            Dictionary<string, int> ages = new Dictionary<string, int>();



            // Add items to the dictionary
            ages["Alice"] = 25;
            ages["Bob1"] = 30;
            ages["Charlie"] = 28;

            // Access by key
            Console.WriteLine("Alice's age: " + ages["Alice"]);

            // Check if key exists
            if (ages.ContainsKey("Bob"))
            {
                Console.WriteLine("Bob is in the dictionary.");
            }

            // Loop through dictionary
            foreach (var item in ages)
            {
                Console.WriteLine(item.Key + " → " + item.Value);
            }


            //**************file manipulation

            string path1_string = @"C:\blabla1.txt";
            string path2_string = @"C:\blabla_copy.txt";

            var file1 = new FileInfo(path1_string);
            using (StreamWriter sr = file1.CreateText())
            {
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

            var file2 = new FileInfo(path2_string);

            // Delete file2 if it exists
            if (file2.Exists)
            {
                fi2.Delete();
                Console.WriteLine("Deleted file2.");
            }

            // Copy file1 to file2
            file1.CopyTo(path2_string);
            Console.WriteLine("Copied file1 to file2.");

            // check if file2 exists
            if (file2.Exists)
            {
                Console.WriteLine("File2 exists.");
                file2.Delete();
            }
            else
            {
                Console.WriteLine("File2 does not exist.");
            }

            // Check if file1 exists
            if (fi1.Exists)
            {
                Console.WriteLine("File1 exists.");
                file1.Delete();
            }
            else
            {
                Console.WriteLine("File1 does not exist.");
            }

        }
    }
}
