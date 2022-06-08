using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public class deleteClient:client
    {
        public void DeleteClient(int id)
        {
            Console.WriteLine("enter client id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" client deleted succesfuly");
        }
    }
}