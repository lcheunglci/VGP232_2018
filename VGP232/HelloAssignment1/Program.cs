using System;
using System.Collections.Generic;
using System.IO;

// NAME:
// STUDENT NUMBER:

namespace HelloConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // variables and flags
            string inputFile = string.Empty;
            string outputFile = string.Empty;
            bool append = false;
            bool displayCount = false;
            bool sumEnabled = false;
            float sum = 0f;

            ItemCollection results = new ItemCollection();

            // TODO: check if there is more than 1 argument, if not perform a different flow

            // Interactive mode
            // TODO: prompt user for the input to populate the parameters
            if (args.Length == 0)
            {
                while (true)
                {
                    if (string.IsNullOrEmpty(inputFile))
                    {
                        Console.Write("Path to input: ");
                        inputFile = Console.ReadLine();
                        results.Parse(inputFile);
                    }

                    if (string.IsNullOrEmpty(outputFile))
                    {
                        Console.Write("Path to output: ");
                        outputFile = Console.ReadLine();
                    }

                    Console.Write("Sum? (yes|no) ");
                    string decision = Console.ReadLine();
                    if (decision == "yes")
                    {
                        sumEnabled = true;
                    }

                    Console.WriteLine("Are you done?");
                    string end = Console.ReadLine();
                    if (end == "yes")
                    {
                        break;
                    }
                }
            }

            // Scripted Mode
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-h" || args[i] == "--help")
                {
                    Console.WriteLine("-i OR --input <include path to input file> | takes the data and outputs it");
                    Console.WriteLine("-s OR --sum | sums the results");
                    Console.WriteLine("-o OR --output | <include path to output file> | output file with results");
                    Console.WriteLine("-a OR --append | appends result to file");
                    Console.WriteLine("-c OR --count  | number of lines in the file");
                    break;
                }
                else if (args[i] == "-i" || args[i] == "--input")
                {
                    if (args.Length > i + 1)
                    {
                        // validation to make sure we do have an argument after the flag
                        ++i;
                        inputFile = args[i];

                        if (string.IsNullOrEmpty(inputFile))
                        {
                            Console.WriteLine("input file path was not specified"); 
                        }
                        else if (!File.Exists(inputFile))
                        {
                            Console.WriteLine("file path does not exist");
                        }
                        else
                        {
                            results.Parse(inputFile);
                        }
                    }
                }
                else if (args[i] == "-s" || args[i] == "--sum")
                {
                    sumEnabled = true;
                }
                else if (args[i] == "-o" || args[i] == "--output")
                {
                    if (args.Length > i + 1)
                    {
                        // validation to make sure we do have an argument after the flag
                        ++i;
                        outputFile = args[i];

                        if (string.IsNullOrEmpty(outputFile))
                        {
                            Console.WriteLine("output file path was not specified");
                        }
                    }
                }
                else if (args[i] == "-a" || args[i] == "--append")
                {
                    append = true;
                }
                else if (args[i] == "-c" || args[i] == "--count")
                {
                    displayCount = true;
                }
                else
                {
                    Console.WriteLine("The argument Arg[{0}] = [{1}] is invalid", i, args[i]);
                }
            }

            List<string> names = new List<string>();
            names.Sort();

            if (sumEnabled)
            {
                sum = results.CompleteTotal;
            }

            if (results.Count > 0)
            {
                if (!string.IsNullOrEmpty(outputFile))
                {
                    results.Save(outputFile, append, displayCount, sumEnabled);
                }
                else
                {
                    if (displayCount)
                    {
                        Console.WriteLine("There are {0} entries", results.Count);
                    }

                    if (sumEnabled)
                    {
                        Console.WriteLine("Sum of all the values is {0}", sum);
                    }

                    for (int i = 0; i < results.Count; i++)
                    {
                        Console.WriteLine(results[i]);
                    }
                }
            }
            Console.WriteLine("Done!");
        }
        
    }
}
