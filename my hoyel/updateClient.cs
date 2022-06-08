using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public class updateClient:client
    {
        public void UpdateClient(int id, string name, string phone, string country)
        {
            Console.WriteLine("enter client id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter changes");
            Console.WriteLine("client id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("client name");
            name = Console.ReadLine();
            Console.WriteLine("enter client info");
            phone = Console.ReadLine();
            Console.WriteLine("client country");
            country = Console.ReadLine();
            Console.WriteLine(" client updated succesfuly");
        }
    }
}