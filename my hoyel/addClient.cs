using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{

    public class addClient:client
    {
        public void AddClient(int id,string name,string phone,string country)
        {
            try
            {
                Console.WriteLine("enter client info");
                Console.WriteLine("client id:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("client name");
                name = Console.ReadLine();
                Console.WriteLine("enter client phone");
                phone = Console.ReadLine();
                Console.WriteLine("client country");
                country = Console.ReadLine();
                Console.WriteLine("add new client succesfuly" +
                "\n id: " + id +
               "\n name: " + name +
               "\n phone: " + phone +
               "\n country:  " + country );
            }
            catch (Exception)
            {

                Console.WriteLine("MAKE SURE OF DATA TYPE");
            }
           
           
        }
        
       
        
    }

    
}