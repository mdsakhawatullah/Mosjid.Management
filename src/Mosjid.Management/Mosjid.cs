using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace Mosjid.Management
{
    public class Mosjid
    {
        public List<MemberInfo> Members = new List<MemberInfo>();
        public List<EventInfo> Events = new List<EventInfo>();

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome To Our Mosjid");
            Console.WriteLine();
            Console.WriteLine("1. Member Information");
            Console.WriteLine("2. Donation");
            Console.WriteLine("3. Manage Events");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
        }

        public void TakeOptions()
        {
            while (true)
            {
               
                Console.WriteLine("Choose your option:");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        ExitSystem();
                        break;
                    case 1:
                        ManageMembers();
                        break;
                    case 2:
                        Console.WriteLine("Donation management is not implemented yet.");
                        break;
                    case 3:
                        ManageEvents();
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        private void ManageMembers()
        {
            Console.WriteLine();
            Console.WriteLine("Managing Members");
            Console.WriteLine("1. Add New Member");
            Console.WriteLine("2. Show Member List");
            Console.WriteLine("0. Back to Main Menu");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    return;
                case 1:
                    AddMember();
                    break;
                case 2:
                    ShowMembers();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

        private void AddMember()
        {
            Console.WriteLine("Enter member ID and Name separated by a SPACE:");
            string[] input = Console.ReadLine().Split();
            int id = int.Parse(input[0]);
            string name = input[1];

            Members.Add(new MemberInfo(id, name));
            Console.WriteLine("Member added successfully.");
        }

        private void ShowMembers()
        {
            Console.WriteLine("Members List:");
            foreach (MemberInfo member in Members)
            {
                Console.WriteLine($"Name: {member.Name}, Id: {member.Id}");
            }
        }

        private void ManageEvents()
        {
            Console.WriteLine();
            Console.WriteLine("Managing Events");
            Console.WriteLine("1. Add New Event");
            Console.WriteLine("2. Show Upcoming Events");
            Console.WriteLine("0. Back to Main Menu");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    return;
                case 1:
                    AddEvent();
                    break;
                case 2:
                    ShowEvents();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

        private void AddEvent()
        {
            Console.WriteLine("Enter event ID, Name, Topic, and Time separated by a SPACE:");
            string[] input = Console.ReadLine().Split();
            int id = int.Parse(input[0]);
            string name = input[1];
            string topic = input[2];
            double time = double.Parse(input[3]);

            Events.Add(new EventInfo(id, name, topic, time));
            Console.WriteLine("Event added successfully.");
        }

        private void ShowEvents()
        {
            Console.WriteLine("Upcoming Events:");
            foreach (EventInfo eve in Events)
            {
                Console.WriteLine($"Name: {eve.Name}, Id: {eve.Id}, Topic: {eve.TopicInfo}, Time: {eve.Time}");
            }
        }

        public void ExitSystem()
        {
            Console.WriteLine("Exiting the system.");
            Environment.Exit(0);
        }
    }

    
}
