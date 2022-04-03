using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Messages_Manager
{
    public class Users
    {
        public string Name { get; set; }
        public int Messages { get; set; }

        public Users(string name, int message)
        {
            this.Name = name;
            this.Messages = message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string commands = Console.ReadLine();
            List<Users> users = new List<Users>();

            while (commands != "Statistics")
            {
                string[] cmdArgs = commands.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string userName = cmdArgs[1];
                Users sender = null;
                Users receiver = null;

                if (command == "Add")
                {
                    int sent = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);
                    int total = sent + received;

                    if (!IsUser(users, userName))
                    {
                        sender = new Users(userName, total);
                        users.Add(sender);
                    }
                }
                else if (command == "Message")
                {
                    string receiveUser = cmdArgs[2];
                    if (IsUser(users, userName) && IsUser(users, receiveUser))
                    {
                        sender = users.SingleOrDefault(x => x.Name == userName);
                        receiver = users.SingleOrDefault(x => x.Name == receiveUser);

                        sender.Messages++;
                        receiver.Messages++;
                        if (sender.Messages >= capacity)
                        {
                            Console.WriteLine($"{sender.Name} reached the capacity!");
                            users.Remove(sender);
                        }
                        if (receiver.Messages >= capacity)
                        {
                            Console.WriteLine($"{receiver.Name} reached the capacity!");
                            users.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")  // All
                {
                    if (userName == "All")
                    {
                        users = new List<Users>();
                        commands = Console.ReadLine();
                        continue;
                    }
                    if (IsUser(users, userName))
                    {
                        sender = users.SingleOrDefault(x => x.Name == userName);
                        users.Remove(sender);
                    }
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Name} - {item.Messages}");
            }
        }

        static bool IsUser(List<Users> users, string user)
        {
            foreach (var item in users)
            {
                if (item.Name == user)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
