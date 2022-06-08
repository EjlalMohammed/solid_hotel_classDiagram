using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public class manager: Istaff
    {
        private int man_id;
        private string man_name;
        private string man_gender;
        private string man_phone;
        private int man_sal;

        public string name {
            get => man_name;
            set => man_name =value;
        }
        public int id {
            get => man_id;
            set => man_id = value;
        }
        public string phone {
            get => man_phone;
            set => man_phone=value;
        }
        public String gender {
            get => man_gender;
            set => man_gender = value;
        }
        public int salary
        {
            get => man_sal;

            set => man_sal = value;
        }
        
        public void readTask()
        {
           
        }

        public void show()
        {
            
        }
    }
}