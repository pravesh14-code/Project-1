using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_1.CurriculumVitae;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Pravesh Gowreea, a second-year Software Engineering Student at the University Of Mauritius." +
                "\nI am also the new President of the UOM Oracle Club and recently winner of the UOM Hackathon 2022 organised " +
                "\nby the FOIDCT and winner of Fintech Ideathon 2022.");
            
            CurriculumVitae cv1 = new CurriculumVitae();
            cv1.printMenu();
            
            while (true)
            {
                Console.Write("\nMain Menu Choice => Select an appropriate choice to view more: ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                switch (choice)

                {
                    case 1: 
                        cv1 = new Experience();
                        cv1.printDetails();
                        break;

                    case 2:
                        cv1 = new Education();
                        cv1.printDetails();
                        break;

                    case 3:
                        cv1 = new PersonalSkills();
                        cv1.printDetails();
                        cv1.printMenu();
                        break;

                    case 4:
                        cv1 = new TechnologicalSkills();
                        cv1.printDetails();
                        cv1.printMenu();
                        break;
                    case 5:
                        cv1 = new ContactDetails();
                        cv1.printDetails();
                        cv1.printMenu();
                        break;
                    
                    default: 
                        Console.WriteLine("Error!! Please select appropraite choice!!");
                        cv1.printMenu();
                        break;
                }
            }
        }
    }
}
