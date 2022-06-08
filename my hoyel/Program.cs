using System;

namespace my_hoyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what do you whant to do?" +
                "chose number:");
            Console.WriteLine("1 - create new client" +
                "\n"+
                "2- delete client" +
                "\n" +
                "3- update client");
            int no = Convert.ToInt32(Console.ReadLine());
            
            switch (no)
            {
                case 1:
                    client c = new addClient();
                    addClient add = new addClient();
                    add.AddClient(add.id, add.name, add.phone, add.country);
                   add.Show();

                    break;
                case 2:
                    deleteClient del = new deleteClient();
                    del.DeleteClient(del.id);
                    break;
                case 3:
                    updateClient up = new updateClient();
                    up.UpdateClient(up.id, up.name, up.phone, up.country);
                    break;
                case 4:
                   
                    break;
                
            }
        }
    }
}
