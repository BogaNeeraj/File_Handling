using System;
using System.IO;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Handling...");


            FileStream fs = new FileStream("C:\\Users\\Neeraj.Boga\\OneDrive - Trianz\\Desktop\\c# programs\\BioData.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("we can read and display file");
            //string Mystring = sr.ReadLine();
            //Console.WriteLine("content of my file is {0}", Mystring);

            string str = sr.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }

            //closing the file
            fs.Flush();
            fs.Close();

         
            FileStream fWrite = new FileStream("C:\\Users\\Neeraj.Boga\\OneDrive - Trianz\\Desktop\\c# programs\\BioData.txt", FileMode.Append);
            StreamWriter Swrite = new StreamWriter(fWrite);
            Console.WriteLine("writing content to file........\n");
        
            string content = Console.ReadLine();
            Swrite.Write(content);
            // while(content != null)
            //{
            //  Console.WriteLine(content);


            //}
            Swrite.Flush();
            fWrite.Flush();


            fWrite.Close();
        }
    }
}