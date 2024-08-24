

using System;

namespace Mosjid.Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Mosjid mosjid = new Mosjid();
            mosjid.DisplayMenu();
            mosjid.TakeOptions();


        }
    }

}