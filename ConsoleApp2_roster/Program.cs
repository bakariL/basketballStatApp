using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_roster
{
    class Program
    {
        public static object ToLower { get; private set; }

        static void Main(string[] args)
        {


            //Console.WriteLine("Type a number ");
            //int input = int.Parse(Console.ReadLine());
            //int[] numbers = new int[input];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum = (sum + (i + 1));
            //}
            //Console.WriteLine(sum);


            double[] percentage = new double[5];
            double[] attempts = new double[5];
            int[] makes = new int[5];
            string choice = " ";
            // Are you the coach? 
            Console.WriteLine("Are you the coach?");
            string coach = Console.ReadLine();
            if (coach == "yes")
            {
                //What is the Name of your team
                Console.WriteLine("What is the name of your team/school? this Tree is not looking like it should be looking");
                string schoolName = Console.ReadLine();

                //how many players on the team
                try
                {


                    Console.WriteLine("How many players are on the " + schoolName + "?");
                    int amountPlayers = int.Parse(Console.ReadLine());
                    string[] rosterTotal = new string[amountPlayers]; //creates the amount of rosters spots
                int i;
                string playerName = "";
            }catch
            {
                throw new ExecutionEngineException();
            }

                while (playerName != "quit")
                {
                    //Player 1, enter  name
                    Console.WriteLine("Enter first and last name of roster spot # but enter the whole file");
                    //rosterTotal[] = Console.ReadLine();

                    
                    Console.WriteLine("Enter " +  " Shot attempts.");
                    //attempts = double.Parse(Console.ReadLine());

                    Console.WriteLine("How many shots"  + "make?");
                    //makes[i] = int.Parse(Console.ReadLine());

                    //percentage[i] = makes[i] / attempts[1];
                }
            }
            //else if (coach == "no")
            //{
            //    Console.WriteLine("Welcome Player!, Pleae type your first and last name");
            //    string playerName = Console.ReadLine();

            //}
            //else
            //{
            //    Console.WriteLine("Sorry, Coaches and Players only, type 'ok' to try again..");
            //} }
            
           

       







    }
    }

