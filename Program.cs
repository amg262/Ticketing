using System;
using System.IO;

/*
 * Namespace designated for Ticketing project.
 *
 * GITHUB ACCOUNT:      https://github.com/amg262/
 * GITHUB REPO:         https://github.com/amg262/Ticketing
 *
 * THERE IS SOME NOTES IN README.MD ON REPO 
 * 
 */
namespace Ticketing
{
    /*
     *
     * 
     * Program class: contains main method program runs. Had set csv file that is
     * read and written to based on user choice of 1. output CSV data file - or -
     * 2. input data to CSV file based on console prompts for each field.
     * Input is stored in array, and file is created and pre-populated if not exists
     * or data formatted into current data to append it on to previous entries
     *
     *
     * GITHUB ACCOUNT:      https://github.com/amg262/
     * GITHUB REPO:         https://github.com/amg262/Ticketing
     *
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            
            /*
             * Variables for CSV file name, input choice, pre-data
             */
            string file = "ticket.csv";
            string choice;
            string one = "TicketID,Summary,Status,Priority,Submitter,Assigned,Watching";
            string two = "1,This is a bug ticket,Open,High,Drew Kjell,Jane Doe,Drew Kjell|John Smith|Bill Jones";

            /*
             * Prompt user to decide whether output data or input
             */
            Console.WriteLine("1) Output CSV records.");
            Console.WriteLine("2) Add CSV record.");

            choice = Console.ReadLine();
            string stream = "";
            
            /*
             * Option of adding data
             */
            if (choice == "2")
            {
                /*
                 * string vars used for string field collection, formatted for input later
                 */
                string record_str = "";
                string rec_str = "";
                string[] records = new string[7];

                /*
                 * Getting ticket id field, add data to record array
                 */
                Console.Write("Ticket ID>");
                string id = Console.ReadLine();
                records[0] = id;

                /*
                 * Getting summary field, add data to record array
                 */
                Console.Write("Summary>");
                string summary = Console.ReadLine();
                records[1] = summary;

                /*
                 * Getting status field, add data to record array
                 */
                Console.Write("Status>");
                string status = Console.ReadLine();
                records[2] = status;

                /*
                 * Getting priority field, add data to record array
                 */
                Console.Write("Priority>");
                string priority = Console.ReadLine();
                records[3] = priority;

                /*
                 * Getting submitter field, add data to record array
                 */
                Console.Write("Submitter>");
                string submitter = Console.ReadLine();
                records[4] = submitter;

                /*
                 * Getting assigned field, add data to record array
                 */
                Console.Write("Assigned>");
                string assigned = Console.ReadLine();
                records[5] = assigned;

                /*
                 * Getting watching field, add data to record array
                 */
                Console.Write("Watching>");
                string watching = Console.ReadLine();
                records[6] = watching;

                /*
                 * if file doesnt exist, add pre-data first, then format and add input data
                 */
                if (!File.Exists(file))
                {
                    StreamWriter sw = new StreamWriter(file);
                    sw.WriteLine(one);
                    sw.WriteLine(two);
                    
                    /*
                     * loop thru input data array and format to CSV
                     */
                    foreach (var index in records)
                    {
                        record_str += index;
                        record_str += ",";
                    }

                    /*
                     * Check for null, Remove trailing comma to prevent record run-on
                     */
                    if (record_str.Length > 1)
                    {
                        rec_str = record_str.Substring(0, record_str.Length - 1);
                    }
                    sw.Write(rec_str);

                    sw.Close();
                }
                else
                {
                    /*
                     * if file exists, loop thru file lines and build a string built from
                     * each line formatted with line break.
                     */
                    StreamReader sr = new StreamReader(file);

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        stream += line;
                        stream += "\n";
                    }
                    sr.Close();
           
                    StreamWriter sw = new StreamWriter(file);
                    sw.Write(stream);
                    
                    /*
                     * loop thru input data array and format into csv
                     */
                    foreach (var index in records)
                    {
                        record_str += index;
                        record_str += ",";
                    }

                    /*
                     * Check for null, Remove trailing comma to prevent record run-on
                     */
                    if (record_str.Length > 1)
                    {
                        rec_str = record_str.Substring(0, record_str.Length - 1);
                    }
                    sw.Write(rec_str);
                    sw.Close();
                }
            }
            else
            {
                /*
                 * if user chooses output data, open CSV file and loop thru each line
                 * and write to console.
                 */
                StreamReader sr = new StreamReader(file);
        
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                sr.Close();
            }
        }
    }
}
