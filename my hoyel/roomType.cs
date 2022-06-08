using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public interface IRoomType :Iadd_Room ,Iupdate_room

    {
        string type_name { get; set; }
        int state { get; set; }
    }
}