using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public interface Iroom_reserv
    {
        int room_id { get; set; }

        void getEmptyRoom(int id);
    }
}