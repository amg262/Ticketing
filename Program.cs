using System;
using System.Collections.Generic;
using System.IO;

namespace Ticketing
{
    class Program
    {

        
        
        public void BuildFile() {

            Console.WriteLine("1. Build Data File  2. Add Records");

            //Console.WriteLine("New Record? (y/n");
            string local = "Data.csv";
            string option = Console.ReadLine();
            double optionNum = Convert.ToDouble(option);
            string[] arr = new string[7];


            if (optionNum == 1 ) {
                StreamReader sr = new StreamReader(local);

                while (!sr.EndOfStream) {
                    
                    string data = sr.ReadLine();
                    Console.WriteLine(data);

                }

            } else if (optionNum == 2) {
                Console.WriteLine("1. Build Data File  2. Add Records");
                string summary = Console.ReadLine();
                arr[1] = summary;




                
            }


            
            // string file = "Tickets.csv";
            // var reader = new StreamReader(file);

            // if (File.Exists(file) ) {


            //     List<string> listA = new List<string>();
            //     List<string> listB = new List<string>();
            //     while (!reader.EndOfStream)
            //     {

            //         listA.Add(values[0]);

                    // var line = reader.ReadLine();
                    // var values = line.Split(',');
                    // var n = "/n";

                    // listA.Add(values[0]);
                    // listB.Add(values[1]);
               // }
                // accumulators needed for GPA~
                        // int gradePoints = 0;
                        // int count = 0;
                        // // read data from file
                        // StreamReader sr = new StreamReader(file);
                        // while (!sr.EndOfStream)
                        // {
                        //     string line = sr.ReadLine();
                        //     // convert string to array
                        //     string[] arr = line.Split('|');
                        //     // display array data
                        //     Console.WriteLine("Course: {0}, Grade: {1}", arr[0], arr[1]);
                        //     // add to accumulators
                        //     gradePoints += arr[1] == "A" ? 4 : arr[1] == "B" ? 3 : arr[1] == "C" ? 2 : arr[1] == "D" ? 1 : 0;
                        //     count += 1;
                        // }
                        // sr.Close();
                        // // calculate GPA
                        // double GPA = (double)gradePoints / count;
                        // Console.WriteLine("GPA: {0:n2}", GPA);

            }



        



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.BuildFile();
        }
    }
}
