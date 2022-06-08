using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public  class client
    {
        private int Client_id= 55;
        private string Client_name="ejlal";
        private string client_phone="777777";
        private string client_country="yemen";

        public int id
        {
            get
            {
                return Client_id;
            }
            set
            {
                id = Client_id;
            }
        }

        public string name
        {
            get
            {
                return Client_name;
            }
            set
            {
                name = Client_name;
            }
        }

        public string phone
        {
            get
            {
                return client_phone;
            }
            set
            {
                phone = client_phone;
            }
        }

        public string country
        {
            get
            {
                return client_country;
            }
            set
            {
                country = client_country;
            }
        }

        public void Show()
        {
            Console.WriteLine(id + ' ' + name + ' ' + phone + ' ' + country);
        }
        


    }
}