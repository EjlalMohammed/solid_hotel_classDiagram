using System;
using System.Collections.Generic;
using System.Text;

namespace my_hoyel
{
    public interface Istaff
    {
        string name {
            get;
            set;
        }
        int id {
            get;
            set; }
        string phone {
            get;
            set; }
        string gender {
            get;
            set; }
        int salary {
            get;
            set; }

        void show();
    }
}