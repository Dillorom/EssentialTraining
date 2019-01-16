using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The program has started.");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Yogurt");

            CrazyMathProblems();
            ReadTextFile();
        }

        private static void ReadTextFile()
        {
            try
            {
                using(var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the file." + ex.Message);
                logger.Error("Could not find the file" + ex.Message);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error occured" + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time");
                Console.ReadKey();
            }
        }

        private static int CrazyMathProblems()
            {
                var income = 10000;
                for(var i = 10; i < 0; i--)
                {
                    income = income = (income / i);
                }
            return income;
            }
    }
}
