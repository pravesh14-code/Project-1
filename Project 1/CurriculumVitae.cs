using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_1
{
    public class CurriculumVitae
    {
        public CurriculumVitae()
        {

        }
        public void printMenu()
        {
            Console.WriteLine("     \n\n************* Curriculum Vitae Main Menu *************\n");

            Console.WriteLine("1. Experience / Job History");
            Console.WriteLine("2. Education / Training");
            Console.WriteLine("3. Skills");
            Console.WriteLine("4. Technological Skills");
            Console.WriteLine("5. Contact Details");
        }
        public virtual void printDetails()
        {

        }
    }

    public class Experience : CurriculumVitae
    {
        public override void printDetails()
        {
            while (true)
            {
                Console.WriteLine("********* Experience/Job History *********\n");
                Console.WriteLine("1. Ceridian Mauritius (2022 - Current) ");
                Console.WriteLine("2. UOM Oracle Club (2020 - Current) ");

                Console.Write("\nOveriew Choice => Enter a choice to overiew or press 0 to go back: ");
                int overview = int.Parse(Console.ReadLine());
                
                if (overview == 0)
                {
                    printMenu();
                    break;
                }
                else
                {
                    experienceOverview(overview);
                }
            }
        }
        public void  experienceOverview (int overview)
        {
           switch(overview)
            {
                case 1:
                    Console.WriteLine("\n-------- Ceridian Mauritius --------");
                    Console.WriteLine("Technology Training: Ramp up on the following technology stack training [C#, FrontEnd, SQL, Automation]" +
                        "\nDomain Knowledge: Ramp up on Dayforce Product." +
                        "\nGet acquainted with scrum practices and participate in scrum events.");
                    Console.WriteLine("------------------------------------\n");
                    break;
                case 2:
                    Console.WriteLine("\n--------- UOM Oracle Club ---------");
                    Console.WriteLine("Develope my technical skills alongside my personal skills. Got the opportunity to learn about Oracle Cloub Platfrom." +
                        "\nImprove my leadership skills and communication skills by delegating works and communicate with teams.");
                    Console.WriteLine("------------------------------------\n");
                    break;
                default: Console.WriteLine("Error!! Please select appropriate choice!!");
                    break;
            }
        }
    }
    public class Education : CurriculumVitae
    {
        public override void printDetails()
        {
            while (true)
            {
                Console.WriteLine("********* Education/Training *********\n");
                Console.WriteLine("1. Software Engineering (Year 2)");
                Console.WriteLine("2. Software Engineering (Year 1)");
                Console.WriteLine("3. Training");

                Console.Write("\nOveriew Choice => Enter a choice to overiew or press 0 to go back: ");
                int overview = int.Parse(Console.ReadLine());

                if (overview == 0)
                {
                    printMenu();
                    break;
                }
                else
                {
                    educationOverview(overview);
                }
            }    
        }

        public void educationOverview(int overview)
        {
            switch (overview)
            {
                case 1:
                    Console.WriteLine("\n-------- Software Engineering (Year 2) --------");
                    Console.WriteLine("Modules covered: Web Application Development, Object Oriented Software Development, " +
                        "Interactive System Design,\nData Structure Algorithm, Software Verification & Validation" +
                        "Software Project Management. \n\nProject done: Kidemy Mobile Application, JRA ART Website, MyFitness GUI, Flood Radar.");
                    Console.WriteLine("------------------------------------\n");
                    break;
                case 2:
                    Console.WriteLine("\n--------- Software Engineering (Year 2) ---------");
                    Console.WriteLine("Modules covered: Discrete Structure, Database Systems, Software Design Programming, Comumunication Skills," +
                        "\nSoftware Engineering Principles, Software Analysis & Modelling. \nProject done: Code Lyoko 3D World Game, MauPlant Mobile Application ");
                    Console.WriteLine("------------------------------------\n");
                    break;
                case 3:
                    Console.WriteLine("\n--------- Training ---------");
                    Console.WriteLine("Training attended: Time Management, Flutter Festivals, Design Thinking, AI Training, IOT Training and so on...");
                    Console.WriteLine("------------------------------------\n");
                    break;

                default:
                    Console.WriteLine("Error!! Please select appropriate choice!!");
                    break;
            }
        }
    }

    public class PersonalSkills : CurriculumVitae
    {
        public override void printDetails()
        {
            Console.WriteLine("********* Personal Skills *********\n");
            Console.WriteLine("Leadership Skills, Good in teamwork, Can work independently, Fast Learner, " +
                "\nCriticical Thinking, Inquistive, Interactive.");
        }
    }

    public class TechnologicalSkills : CurriculumVitae
    {
        public override void printDetails()
        {
            Console.WriteLine("********* Technological Skills *********\n");
            Console.WriteLine("Microsoft Office Tools, Adobe Photoshop, Adobe After Effects, Dart, " +
                "\nHTML, CSS, JavaScript, PHP, SQL, Java, C++, C#.");
        }
    }

    public class ContactDetails : CurriculumVitae
    {
        public override void  printDetails()
        {
            Console.WriteLine("********* Contact Details *********\n");
            Console.WriteLine("Phone Number : 5783 3020 \nAddress : Royal Road Carreau Accacia.");
        }
    }
}