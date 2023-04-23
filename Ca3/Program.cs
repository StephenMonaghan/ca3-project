using System;
using System.Linq;
using System.Security;
using System.Xml;
using System.Text.RegularExpressions;
using static Ca3.PassengersData;

namespace Ca3
//stephen Monaghan
//Ca 3


{
    internal class Program
    {



      static  string path = @"../../../faminefile.csv";
        static void Main(string[] args)
        {
          
        


















            int MenuChoice = 0;

            while (MenuChoice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu"); /// main menu 
                Console.WriteLine("1.Ship Reports");
                Console.WriteLine("2.Occupation Report");
                Console.WriteLine("3.Age Report");
                Console.WriteLine("4.Exit");
                Console.WriteLine();

                Console.WriteLine("Enter Choice:");
                MenuChoice = int.Parse(Console.ReadLine());

                if (MenuChoice == 1)
                  {
                     ShipReportsData(path);
                 }
                else if(MenuChoice == 2)
                  {
                    OccupationReport(path);
                  }
                else if (MenuChoice == 3)
                {
                    AgeReport(path);
                }


            }
        }

        static List<PassengersData> GettingObjects(string path) //method so i can use  the objects through out the program
        {
           
            List<PassengersData> passengers = new List<PassengersData>();
            using (StreamReader sr = File.OpenText(path))

            {
                string? lineIn = sr.ReadLine();
                while (lineIn != null)
                {


                    string[] splitString = lineIn.Split(',');



                    PassengersData passenger = new PassengersData(splitString[1], splitString[0], splitString[3], splitString[2], splitString[4], splitString[5], splitString[6],
                       splitString[7], splitString[8], splitString[9]);//adding the data to the objects in a list

                    passengers.Add(passenger);
              






                    lineIn = sr.ReadLine();

                }
                return passengers;



            }
        }
        static void AgeReport(string path)
        {
            //List<PassengersData> passengers = GettingObjects(path);
            //int i= 0;
           
            // Regex re = new Regex(@"\d");
         


          //  while (i < passengers.Count)
          //  {
            //    if (passengers[i].Age.getLength() > 19) 
           //     { 
                //these are the infants
             //   }
            //    else
            //    {
                    //only passengers with a numeric age will pass this 

           //       int  passengerAge= re.match(passengers[i].Age);
            //    }
          
           //}

        }

        static void OccupationReport(string path )
        {
            
            int counterSpinster = 0;
            int counterCultivatorAndFarmer = 0;
            int matronCount=0;
            int dressMaker=0;
            int labourerCount = 0;
            int childCount = 0;
            int fishermanCount = 0;
            int nonecount = 0;
            int chaimberMaidCount=0;
            int smithCount =0;
            int masonCount = 0;
            int bakerCount = 0;
            int tannerCount = 0;
            int infantCount = 0;
            int carpenterCount = 0;
            int studentCount = 0;
            int clerkCount = 0;
            int coachmanCount = 0;
            int immigrantCount = 0;









            using (StreamReader sr = File.OpenText(path))
            {

                string lineIn = sr.ReadLine();

                while (lineIn != null)
                {
                    // if the line in is equal to any of the jobs the couter of that job is givin a +1 on its counter

                    string[] splitString = lineIn.Split(',');
                    if (lineIn.Contains("Spinster"))
                    {
                        counterSpinster++;
                        

                    }
                    else if (lineIn.Contains("Cultivator or Farmer"))
                    {
                        counterCultivatorAndFarmer++;

                    }
                    else if (lineIn.Contains("Matron"))
                    {
                        matronCount++;
                    }
                    else if (lineIn.Contains("Dressmaker"))
                    {
                        dressMaker++;
                    }
                    else if (lineIn.Contains("Child"))
                    {
                        childCount++;
                    }
                    else if (lineIn.Contains("Laborer (Ital. 'operaia') or Workman/Woman"))
                    {
                        labourerCount++;
                    }
                    else if (lineIn.Contains("Fisher Man"))
                    {
                        fishermanCount++;
                    }
                    else if (lineIn.Contains("None"))
                    {
                        nonecount++;
                    }
                    else if (lineIn.Contains("Chamber Maid or Maid or Servant"))
                    {
                        chaimberMaidCount++;
                    }
                    else if (lineIn.Contains("Smith"))
                    {
                        smithCount++;
                    }
                    else if (lineIn.Contains("Mason"))
                    {
                        masonCount++;
                    }
                    else if (lineIn.Contains("Baker or Macaroni Maker"))
                    {
                        bakerCount++;
                    }
                    else if (lineIn.Contains("Tanner or Gerber"))
                    {
                        tannerCount++;
                    }
                    else if (lineIn.Contains("Infant"))
                    {
                        infantCount++;
                    }
                    else if (lineIn.Contains("Carpenter"))
                    {
                        carpenterCount++;
                    }
                    else if (lineIn.Contains("Student"))
                    {
                        studentCount++;
                    }
                    else if (lineIn.Contains("Clerk"))
                    {
                        clerkCount++;
                    }
                    else if (lineIn.Contains("Coachman/Coach Driver or Driver"))
                    {
                        coachmanCount++;
                    }
                    else if (lineIn.Contains("Immigrant"))
                    {
                        immigrantCount++;
                    }




                    lineIn = sr.ReadLine();
                    
                }

                Console.WriteLine($"this is how many spinsters {counterSpinster}");
                Console.WriteLine($"this is how many Cultivator and farmers {counterCultivatorAndFarmer}");
                Console.WriteLine($"this is how many matrons {matronCount}");
                Console.WriteLine($"this is how many dressmakers {dressMaker}");
                Console.WriteLine($"this is how many children {childCount}");
                Console.WriteLine($"this is how many labourers {labourerCount}");
                Console.WriteLine($"this is how many fishermen {fishermanCount}");
                Console.WriteLine($"this is how many people withought a profession {nonecount}");
                Console.WriteLine($"this is how many caimbermaids  {chaimberMaidCount}");
                Console.WriteLine($"this is how many smiths  {smithCount}");
                Console.WriteLine($"this is how many masons   {masonCount}");
                Console.WriteLine($"this is how many bakers  {bakerCount}");
                Console.WriteLine($"this is how many tanners  {tannerCount}");
                Console.WriteLine($"this is how many infants there are  {infantCount}");
                Console.WriteLine($"this is how many carpenters {carpenterCount}");
                Console.WriteLine($"this is how many students  {studentCount}");
                Console.WriteLine($"this is how many clerks {clerkCount}");
                Console.WriteLine($"this is how many coachmen  {coachmanCount}");
                Console.WriteLine($"this is how many imigrants  {immigrantCount}");




            }
        }

        static void ShipReportsData(string path)
        {
            List<PassengersData> passengers = GettingObjects(path);




            string menuChoice2 = "0";
            int menuInt;
            Console.WriteLine("ship report");//menu  for the ship report
            Console.WriteLine("1.The Mary Harrington");
            Console.WriteLine("2.The Lincoln");
            Console.WriteLine("3.Clare");
            Console.WriteLine("4.The Disbatch");
            menuChoice2 = Console.ReadLine();
            while (!int.TryParse(menuChoice2, out menuInt))
            {
                Console.WriteLine("invalid choice please try again");
                Console.ReadLine();
            }

            int counter = 0;
            int i = 0;

            if (menuInt == 1)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {


                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("MARY HARRINGTON  187  07-06-1848  102"))
                        {
                            i++;
                            counter++;
                            Console.WriteLine($"FirstName  {passengers[i].FirstNamee}    \t LastName {passengers[i].LastName}   ");//printing out the object if it is on the same line ass the ship

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"This is the total number of passengers {counter}");
                }


            }


            if (menuInt == 2)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {

                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("LINCOLN 187 02-05-1849 071"))
                        {
                            i++;
                            counter++;
                            Console.WriteLine($"FirstName  {passengers[i].FirstNamee}    \t LastName {passengers[i].LastName}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"This is the total number of passengers {counter}");
                }


            }

            if (menuInt == 3)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {

                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("CLARE 187 06-06-1849 123"))
                        {
                            i++;
                            counter++;
                            Console.WriteLine($"FirstName  {passengers[i].FirstNamee}    \t LastName {passengers[i].LastName}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"This is the total number of passengers {counter}");
                }

            }

            if (menuInt == 4)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {

                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("DISPATCH 187 06-26-1851 049"))
                        {
                            i++;
                            counter++;
                            Console.WriteLine($"FirstName  {passengers[i].FirstNamee}    \t LastName {passengers[i].LastName}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"This is the total number of passengers {counter}");
                }
            }
        }



    }






       


    
}