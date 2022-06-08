using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public class vip_room : IRoomType
    {
        private int id;
        private int name;
        private int room_state;

        public int type_name {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int state {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        string IRoomType.type_name {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public void add_room()
        {
            throw new NotImplementedException();
        }

        public void edit_room()
        {
            throw new NotImplementedException();
        }
    }
}