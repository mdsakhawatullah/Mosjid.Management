using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
            Console.WriteLine("3. Mange Events");
            Console.WriteLine();
            
        }

        public void TakeOptions()
        {
            while (true)
            {
                Console.WriteLine("Choose your option (0 to Exite)");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                    ExteSystem();
                if(number == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Managing Member ");
                    Console.WriteLine();

                    Console.WriteLine("1. Add new Member");
                    Console.WriteLine("2. Show Member List");

                    Console.WriteLine("Choose Option (0 to Exit)");
                    int choose = int.Parse(Console.ReadLine());

                    if(choose == 1)
                    {
                        Console.WriteLine("Write member ID and Name with a SPACE");
                        string[] input = Console.ReadLine().Split();
                        int id = int.Parse(input[0]);
                        string name = input[1];

                        Members.Add(new MemberInfo(id, name));
                        Console.WriteLine("Members added successfully");

                    }
                    int newChoose = int.Parse(Console.ReadLine());
                    if (newChoose == 2)
                    {
                        Console.WriteLine("Members List");
                        foreach(MemberInfo member in Members)
                        {
                            Console.WriteLine($"Name: {member.Name}, Id: {member.Id}");
                           
                        }
                    }
                    if (choose == 0)
                        ExteSystem();
                }

                if(number == 2)
                {
                   
                }

                if(number == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Managing Events ");
                    Console.WriteLine();

                    Console.WriteLine("1. Add new Events");
                    Console.WriteLine("2. Show Upcoming List");

                    Console.WriteLine("Choose Option (0 to Exit)");
                    int choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        Console.WriteLine("Write event ID , Name, Topic and Time with a SPACE");
                        string[] input = Console.ReadLine().Split();
                        int id = int.Parse(input[0]);
                        string name = input[1];
                        string topic = input[2];
                        double time = double.Parse(input[3]);

                        Events.Add(new EventInfo(id, name, topic, time));
                        Console.WriteLine("Events added successfully");

                    }
                    int newChoose = int.Parse(Console.ReadLine());
                    if (newChoose == 2)
                    {
                        Console.WriteLine("Upcoming List");
                        foreach (EventInfo eve in Events)
                        {
                            Console.WriteLine($"Name: {eve.Name}, Id: {eve.Id}, Topic: {eve.TopicInfo}");

                        }
                    }

                }

            }
        }

        public void ExteSystem()
        {
            Console.WriteLine("Existing the system");
            Environment.Exit(0);
        }
    }
}
