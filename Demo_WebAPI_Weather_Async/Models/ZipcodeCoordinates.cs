using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WebAPI_Weather
{
    public struct ZipcodeCoordinates
    {
        public int Zipcode { get; set; }

        public ZipcodeCoordinates(int zipcode)
        {
            this.Zipcode = zipcode;
        }

    }
}
