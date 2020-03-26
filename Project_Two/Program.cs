using System;

namespace Project_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Your application should allow the end user to pass end a file path for output 
            * or guide them through generating the file.
            **/
            // USE GET FULL PATH FOR THE READ FILE FOR EXTRA CREDIT POINT 
            Console.WriteLine("Please enter the file you want to read in.");
            string file = Console.ReadLine();
            //string PATH = Path.GetFullPath(file);
            string PATH = @$"C:\Users\gunkeec\Desktop\Project2-2\Project2\{file}";


        }
    }
}
