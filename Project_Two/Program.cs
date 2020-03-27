using System;

namespace Project_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations

            FileStream input;
            StreamReader read;
            string line;
            string[] data;
            int counter = 0;
            //Exception handling for pipeline
            try
            {
                Console.WriteLine("Please enter the file you want to read in.");
                string file = Console.ReadLine();
                //string PATH = Path.GetFullPath(file);
                string PATH = @$"C:\Users\gunkeec\Desktop\Project2-2\Project2\{file}";
                input = new FileStream(PATH, FileMode.Open, FileAccess.Read);
                read = new StreamReader(input);
                line = read.ReadLine(); //primer 
                List<WinningTeam> winningTeamList = new List<WinningTeam>();
                List<SuperBowls> superBowlsList = new List<SuperBowls>();
                //Looping structure to read every line in the file
                while (counter != 55) // reads lines until it can't read anything from a line aka NULL
                {

                    if (counter > 0)
                    {
                        line = read.ReadLine();
                        string[] col = line.Split(',');
                        string[] row = line.Split();
                        // Populating data array with each line
                        //data = read.ReadLine().Split(',');
                        // Adds Student objects per line in the file
                        winningTeamList.Add(new WinningTeam(col[5], col[0], col[3], col[4], col[11], Convert.ToInt32(col[6]) - Convert.ToInt32(col[10])));
                        // Writes out each object in the listSuper_Bowl_Project.csv

                    }
                    if (counter == 12)
                    {
                        string[] col = line.Split(',');
                        superBowlsList.Add(new SuperBowls(col[1], col[0], col[2], col[5], col[9], col[13], col[14], col[12]));
                    }
                    if (counter == 15)
                    {
                        string[] col = line.Split(',');
                        superBowlsList.Add(new SuperBowls(col[1], col[0], col[2], col[5], col[9], col[13], col[14], col[12]));
                    }
                    if (counter == 18)
                    {
                        string[] col = line.Split(',');
                        superBowlsList.Add(new SuperBowls(col[1], col[0], col[2], col[5], col[9], col[13], col[14], col[12]));
                    }
                    if (counter == 22)
                    {
                        string[] col = line.Split(',');
                        superBowlsList.Add(new SuperBowls(col[1], col[0], col[2], col[5], col[9], col[13], col[14], col[12]));
                    }
                    if (counter == 46)
                    {
                        string[] col = line.Split(',');
                        superBowlsList.Add(new SuperBowls(col[1], col[0], col[2], col[5], col[9], col[13], col[14], col[12]));
                    }


                    counter++;

                }
                Console.WriteLine("Please enter the file you want to write to");
                string outputFile = Console.ReadLine();
                string outputPath = @$"C:\Users\gunkeec\Desktop\{outputFile}";
                FileStream output = new FileStream(outputPath, FileMode.Open, FileAccess.Write);
                //StreamReader write = new StreamReader(output);
                using (StreamWriter outputFilePath = new StreamWriter(output))
                {
                    for (int i = 0; i < winningTeamList.Count; i++)
                    {
                        outputFilePath.WriteLine(winningTeamList[i]);
                    }
                    for (int j = 0; j < superBowlsList.Count; j++)
                    {
                        outputFilePath.Write(superBowlsList[j]);
                    }
                }

                read.Close();
                input.Close();
                output.Close();
                //write.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    class WinningTeam
    {
        string TeamName { get; set; }
        string Date { get; set; }
        string WinningQuarterback { get; set; }
        string WinningCoach { get; set; }
        string MVP { get; set; }
        int PointDifference { get; set; }


        public WinningTeam(string name, string date, string quarterback, string coach, string mvp, int points)
        {
            TeamName = name;
            Date = date;
            WinningQuarterback = quarterback;
            WinningCoach = coach;
            MVP = mvp;
            PointDifference = points;

        }
        public override string ToString()
        {
            return String.Format($"\nWinner: {TeamName}\nDate Won: {Date}\nQuarterback: {WinningQuarterback}\nCoach: {WinningCoach}\nMVP: {MVP}\nPoint Difference: {PointDifference}");
        }
    }

    class SuperBowls
    {
        string SuperBowl { get; set; }
        string Attendance { get; set; }
        string Date { get; set; }
        string WinningTeam { get; set; }
        string LosingTeam { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Stadium { get; set; }

        public SuperBowls(string superbowl, string date, string attendance, string winner, string loser, string city, string state, string stadium)
        {
            SuperBowl = superbowl;
            Attendance = attendance;
            Date = date;
            WinningTeam = winner;
            LosingTeam = loser;
            City = city;
            State = state;
            Stadium = stadium;
        }
        public override string ToString()
        {
            return String.Format($"\nSuper Bowl: {SuperBowl}\nAttendance: {Attendance}\nDate: {Date}\nWinning Team: {WinningTeam}\nLosing Team: {LosingTeam}\nCity: {City}\nState: {State}\nStadium: {Stadium}\n");
        }
    }
}
