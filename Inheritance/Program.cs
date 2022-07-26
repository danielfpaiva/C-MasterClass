using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false,"Samsung");
            myTV.SwitchOn();
            myTV.WatchTV();
        }
    }
}
