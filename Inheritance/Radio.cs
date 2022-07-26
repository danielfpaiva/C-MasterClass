using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn,brand)
        {
        }
    }
}
