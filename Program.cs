using System;
using System.IO;

namespace Ticketing
{
    class Program
    {
  
        
        
        static void Main(string[] args)
        {
            string file = "ticket.csv";
            string choice;
            string one = "TicketID,Summary,Status,Priority,Submitter,Assigned,Watching";
            string two = "1,This is a bug ticket,Open,High,Drew Kjell,Jane Doe,Drew Kjell|John Smith|Bill Jones";
            //string[] data1 = new string[] {"TicketID"}
            string[] dataOne = one.Split(",");
            string[] dataTwo = two.Split(",");

            Console.WriteLine("1) Read data from file.");
            Console.WriteLine("2) Create file from data.");
            Console.WriteLine("Enter any other key to exit.");

            choice = Console.ReadLine();
            string stream = "";
            
            
            // if (!File.Exists(file))
            // {
            //     StreamWriter sw = new StreamWriter(file);
            //     sw.WriteLine(one);
            //     sw.WriteLine(two);
            //     sw.Close();
            // }
            // else
            // {
            //     StreamReader sr = new StreamReader(file);
            //
            //     while (!sr.EndOfStream)
            //     {
            //         var line = sr.ReadLine();
            //         if (line != "")
            //         {
            //             stream += line;
            //             //stream += "\n";
            //         }
            //     }
            //
            //     sr.Close();
            // }

            if (choice == "2")
            {
                string record_str = "";
                string rec_str = "";
                string[] records = new string[7];

                Console.Write("Ticket ID");
                string id = Console.ReadLine();
                records[0] = id;

                Console.Write("Summary");
                string summary = Console.ReadLine();
                records[1] = summary;

                Console.Write("Status");
                string status = Console.ReadLine();
                records[2] = status;

                Console.Write("Priority");
                string priority = Console.ReadLine();
                records[3] = priority;

                Console.Write("Submitter");
                string submitter = Console.ReadLine();
                records[4] = submitter;

                Console.Write("Assigned");
                string assigned = Console.ReadLine();
                records[5] = assigned;

                Console.Write("Watching");
                string watching = Console.ReadLine();
                records[6] = watching;

                if (!File.Exists(file))
                {
                    StreamWriter sw = new StreamWriter(file);
                    sw.WriteLine(one);
                    sw.WriteLine(two);
                    
                    foreach (var index in records)
                    {
                        record_str += index;
                        record_str += ",";
                    }

                    if (record_str.Length > 1)
                    {
                        rec_str = record_str.Substring(0, record_str.Length - 1);
                    }
                    sw.WriteLine(rec_str);

                    sw.Close();
                }
                else
                {
                    // StreamWriter sw = new StreamWriter(file);
                    // sw.WriteLine(one);
                    // sw.WriteLine(two);
                    //
                    StreamReader sr = new StreamReader(file);
                    Console.WriteLine("");
                    Console.WriteLine(sr);
                    
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        stream += line;
                        Console.Write(stream);
                        //Console.WriteLine(line);
                    }
                    
                    foreach (var index in records)
                    {
                        record_str += index;
                        record_str += ",";
                    }

                    Console.WriteLine(record_str);
                    if (record_str.Length > 1)
                    {
                        rec_str = record_str.Substring(0, record_str.Length - 1);
                    }
                    
                    Console.WriteLine(rec_str);

                    
                    //sw.WriteLine(rec_str);
                   // sw.WriteLine();
                    //sw.WriteLine(two);

                    //sw.Close();
                }
            }
            // else
            // {
            //     if (!File.Exists(file))
            //     {
            //         StreamReader sr = new StreamReader(file);
            //
            //         while (!sr.EndOfStream)
            //         {
            //             string line = sr.ReadLine();
            //             Console.WriteLine(line);
            //         }
            //
            //     }
            // }



            return;
            do
            { 
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // read data from file
                    if (File.Exists(file))
                    {
                        // accumulators needed for GPA
                        int gradePoints = 0;
                        int count = 0;
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine("Course: {0}, Grade: {1}", arr[0], arr[1]);
                            // add to accumulators
                            gradePoints += arr[1] == "A" ? 4 : arr[1] == "B" ? 3 : arr[1] == "C" ? 2 : arr[1] == "D" ? 1 : 0;
                            count += 1;
                        }
                        // calculate GPA
                        double GPA = (double)gradePoints / count;
                        Console.WriteLine("GPA: {0:N2}", GPA);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                        // ask a question
                        Console.WriteLine("Enter a course (Y/N)?");
                        // input the response
                        string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        // prompt for course name
                        Console.WriteLine("Enter the course name.");
                        // save the course name
                        string name = Console.ReadLine();
                        // prompt for course grade
                        Console.WriteLine("Enter the course grade.");
                        // save the course grade
                        string grade = Console.ReadLine().ToUpper();
                        sw.WriteLine("{0}|{1}", name, grade);
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
