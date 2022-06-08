using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public class Reserv :Iroom_reserv
    {
        private int reserve_id;
        private int reserve_dateIn;
        private int reserve_dateOut;

        public int id
        {
            get => default;
            set
            {
            }
        }

        public int dateIn
        {
            get => default;
            set
            {
            }
        }

        public int dateOut
        {
            get => default;
            set
            {
            }
        }

        public int room_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void getEmptyRoom()
        {
            Console.WriteLine("will get if the room is empty");
        }

        public void getEmptyRoom(int id)
        {
            Console.WriteLine("will get the type of room");
        }
    }
}