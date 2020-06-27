using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Mesas
    {

        public string estado { get; set; }

        public int numPersonas { get; set; }

        public string Estado()
        {
            return estado;
        }

        public int NumPersonas()
        {
            return numPersonas;
        }

    }
}
