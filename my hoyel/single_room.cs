using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public class single_room : IRoomType
    {
        private int id;
        private string name;
        private int room_state;
        public int state {
            get => room_state;
            set => room_state=value;
        }
        public string type_name
        { get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
        


        public void add_room()
        {
           
        }

        public void edit_room()
        {
           
        }
    }
}