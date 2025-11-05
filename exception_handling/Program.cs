using CustomExcExample;
using System;
using System.Diagnostics;
using System.IO;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                FileStream f = File.Open(@"myfile.txt", FileMode.Open);
            }
            catch (FileNotFoundException ex) // Specific
            {

                Console.WriteLine("Your file couldn't be opened!" + ex.Message);
            }
            catch (Exception ex) // Less specific
            {


                Console.WriteLine("A general exception occurred: " + ex.Message);
            }
            finally
            {
                // Close the file here, no matter what happened above.
            }

            ///**
            // * Uncomment to test custom Event Log exception logging
            // * 
            // * 
            // * 
            // * 
            try
            {
                // Something that may fail
                int x = Int16.Parse("abc");
            }
            catch (Exception ex)
            {
                string source = "N33-LA";              // Name of your app
                string logName = "Application";       // Windows log section

                // Check if the event source exists; if not, create it
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, logName);
                    Console.WriteLine("Event source created. Please restart the app.");
                    return; // Source needs to be registered before first use
                }

                // Write to Windows Event Log
                EventLog.WriteEntry(source, $"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);

                Console.WriteLine("Exception logged to Event Viewer.");

            }
             //*/
           
        }
    }
}
