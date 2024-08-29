using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirements
{
    internal class Program
    {
        static double money;
        static char choose;
        static void Main(string[] args)
        {
            //directory
            string directorPath = @"C:\Users\Harvey Mellomida\Documents\Requirements";

            //names/files to check
            string[] filesToCheck = {
                "GoodMoral.pdf",
                "form137.pdf","grades.xlsx"
            };

            
            bool isRunning = false;

            //if false keep on running
            while (!isRunning)
            {        
                //enroll choice
                Console.Write("Do you want to enroll (y/n)? ");
                choose = Convert.ToChar(Console.ReadLine());
                //clear para mawala ung texts, thank you for this useful tip sir
                Console.Clear();
                if (choose == 'y' || choose == 'Y')
                {
                    //budget 
                    Console.WriteLine("The tuition for this enrollment is P 32,000 ");
                    Console.Write("Budget: ");

                    money = Convert.ToDouble(Console.ReadLine());

                    //if enough ang money then pwede na sha mag move on to the next algo, yung checking ng requirements
                    if (money >= 32000)
                    {
                        Console.Clear();
                        Console.WriteLine("You have enough money!");
                        Console.WriteLine();
                        Console.WriteLine("Requirements: \n1. Form 137\n2. Good Moral\n3. PSA\n4. Medical Certification");
                        Console.WriteLine();

                        //permission
                        Console.Write("Permission to check your files (y/n): ");
                        char reqchoice = Convert.ToChar(Console.ReadLine());
                        Console.Clear();

                        //choice
                        if (reqchoice == 'y')
                        {

                            //if nag exist, makaka enroll ka, if isa dun nawala, di ka makakaenroll
                            foreach (string fileName in filesToCheck)
                            {
                                string filePath = Path.Combine(directorPath, fileName);
                                if (File.Exists(filePath))
                                {
                                    Console.WriteLine($"File {fileName} exists");
                                }
                                else
                                {
                                    Console.WriteLine($"File {fileName} does not exist");
                                }
                                {

                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine("You can enroll now!");

                        }
                        else
                        {
                            Console.WriteLine("We can't enroll you with no requirements.");
                            continue;
                        }



                    }
                    //pag di enough ang budget balik sa isRunning
                    else if (money < 32000)
                    {
                        Console.WriteLine("Try again with enough budget.");

                        continue;

                    }
                }
                //yung so do u want to enroll y/n, break pag no
                else if (choose == 'n' || choose == 'N')
                {
                    Console.WriteLine("Thank you for trying!");

                    break;
                }
                //pag iba yung input babalik sha
                else {
                    Console.WriteLine("Invalid input. Please try again");
                    Console.WriteLine();
                    continue;
                }


                bool isValid = false;
                //course picking, if tama ung input go na, pag indi, mag loloop back sha
                while (!isValid)
                {
                    try
                    {
                        Console.Write("\nPick the course you desire\n1. Computer Science\n2. Information Technology\n3. Tourism\n4. Mechanical Engineering\n");

                        Console.Write("Course (number only): ");
                        int mycourse = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        //nabawasan na yung money once nag enroll ka na
                        if (mycourse == 1)
                        {
                            Console.WriteLine("You are now enrolled for Bachelor of Science in Computer Science!");

                            Console.WriteLine($"Your remaining budget is P{money - 32000}\n");
                            break;
                        }
                        else if (mycourse == 2)
                        {
                            Console.WriteLine("You are now enrolled for Bachelor of Science in Information Technology!");
                            Console.WriteLine($"Your remaining budget is P{money - 32000}\n");
                            break;
                        }
                        else if (mycourse == 3)
                        {
                            Console.WriteLine("You are now enrolled for Bachelor of Science in Tourism!");
                            Console.WriteLine($"Your remaining budget is P{money - 32000}\n");
                            break;
                        }
                        else if (mycourse == 4)
                        {
                            Console.WriteLine("You are now enrolled for Bachelor of Science in Mechanical Engineering!");
                            Console.WriteLine($"Your remaining budget is P{money - 32000}\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input, Please try again");
                            continue;
                        }
                    }                    
                    catch (Exception)
                    {
                        Console.WriteLine();
                        Console.WriteLine("No Input. Please try again");
                        continue;
                    }
                }
            }
        }
    }
}