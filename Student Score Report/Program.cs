using System;
using System.IO;

namespace Student_Score_Report
{
    class Program
    {
        static void printStudent(string first, string last, string year, string major, double average)
        {
            Console.WriteLine($"{first} {last}: {year}({major})");
            Console.WriteLine($"Average Score: {average}%");
        }

        static double getAverage(double score1, double score2, double score3)
        {
            double sum = (score1 + score2 + score3);
            double average = sum/3;

            return average;
        }

        static string getYear(int credits)
        {
            if(credits <= 29)
            {
                return "Freshman";
            }
            else if(credits >= 30 && credits <= 59)
            {
                return "Sophomore";
            }
            else if(credits >= 60 && credits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        static void createLog(int numStudents, double avgScoreSum, double minScoreSum, double maxScoreSum)
        {
            double averageScore = avgScoreSum/numStudents;

            StreamWriter log = new StreamWriter("scoresLog.txt");

            log.WriteLine($"Number of Students: {numStudents}");
            log.WriteLine($"Average Score: {averageScore}%");
            log.WriteLine($"Maximum Average Score: {maxScoreSum}%");
            log.WriteLine($"Minimum Average Score: {minScoreSum}%");
        }

        static string checkFile(string fileName)
        {
            if(fileName.EndsWith(".csv"))
            {
                return fileName;
            }
            else
            {
                return fileName + ".csv";
            }
        }

        static void Main(string[] args)
        {
            int numStudents = 0;
            double avgScoreSum = 0;
            double maxScoreSum = 0;
            double minScoreSum = 100;

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your file name:");
            string file = Console.ReadLine();

            while(file == "")
            {
                Console.WriteLine("Error: You must enter a document name.\n");
                Console.WriteLine("Enter your file name:");
                file = Console.ReadLine();
            }

            file = checkFile(file);

            StreamReader fileReader = new StreamReader($"{file}");

            while(!fileReader.EndOfStream)
            {
                string lineOfData = fileReader.ReadLine();
                string[] data = lineOfData.Split(",");

                string first = data[0];
                string last = data[1];
                int credits = int.Parse(data[2]);
                string major = data[3];
                double exam1 = Convert.ToDouble(data[4]);
                double exam2 = Convert.ToDouble(data[5]);
                double exam3 = Convert.ToDouble(data[6]);

                double average = getAverage(exam1, exam2, exam3);
                string year = getYear(credits);

                printStudent(first, last, year, major, average);

                numStudents++;
                avgScoreSum += average;

                if(average > maxScoreSum)
                {
                    maxScoreSum = average
                }

                if(average < minScoreSum)
                {
                    minScoreSum = average
                }
            }           
            createLog(numStudents, avgScoreSum, minScoreSum, maxScoreSum);
            Console.WriteLine("The scoresLog.txt file has been successfully written");
        }
    }
}
