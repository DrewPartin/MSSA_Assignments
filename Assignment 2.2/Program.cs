using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 1. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the           details from same file and print on console

namespace Assignment2._2
{
    class Program
    {
        static string filename;
        static string filepath = @"C:\MSSA\PCAD5\10975\Assignments\Assignment2.2\";
        static string changelogpath = @"C:\MSSA\PCAD5\10975\Assignments\Assignment2.2\";

        static void Main(string[] args)
        {
            Console.WriteLine("      Personal Data File Creator      ");
            Console.WriteLine("--------------------------------------");
            Console.Write("\n" + "Enter a title for the data file: ");
            filename = Console.ReadLine();
            filepath = filepath + (filename + ".txt");
            changelogpath = changelogpath + filename + "_changlog.txt";
            StreamWriter cl = null;            
            StreamWriter df = null;
            try
            {
                if (!File.Exists(filepath) || !File.Exists(changelogpath))
                {
                    df = File.CreateText(filepath);
                    
                    df.Close();
                    cl = File.CreateText(changelogpath);
                    cl.WriteLine("               Changelog               ");
                    cl.WriteLine("---------------------------------------");
                    cl.WriteLine("File created on: " + DateTime.Now);
                    Console.WriteLine($"Your personal data file has been created at {filepath}...");
                    cl.Close();
                    goto start;
                }
                else
                {
                    goto start;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        start:            
            string name;
            string address;
            int age;                        
            try
            {
                Console.Write("\n" + "Enter your full name: ");
                name = Console.ReadLine();                
                Console.Write("Enter your age: ");
                age = Int32.Parse(Console.ReadLine());                
                Console.Write("Enter your address on one line: ");
                address = Console.ReadLine();
                string personaldata = ("Name: " + name + "\n" + "Age: " + age + "\n" + "Address: " + address);
                WritetoFiles(personaldata);
                Appendlines("\n" + "File updated: " + DateTime.Now);
            }
            catch (Exception ex)
            {
                if (File.Exists(changelogpath))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    cl.Close();
                }
            }
            finally
            {
                ReadFromLog();
                Console.WriteLine("Press Enter to close the program...");
                Console.ReadLine();
            }
        }
        static void Appendlines(string data)
        {
            
            File.AppendAllText(changelogpath, data);                        
        }
        static void WritetoFiles(string data)
        {
            StreamWriter df = new StreamWriter(filepath);
            df.WriteLine("           Personal Data");
            df.WriteLine("------------------------------------");
            df.WriteLine(data);
            df.Close();
            Console.WriteLine("File has been updated...");
        }
        static void ReadFromLog()
        {
            StreamReader stream = new StreamReader(filepath);
            string data = stream.ReadToEnd();
            Console.WriteLine(data);
            stream.Close();
        }
    }
}
