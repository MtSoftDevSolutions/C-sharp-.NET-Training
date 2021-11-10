using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructSub
{
    public class HouseNames
    {
        public string nameOfHouses;
        public HouseNames() : this("Slytherin")
        {

        }

        public HouseNames (string houseName)
        {
            nameOfHouses = houseName;
        }
    }
}
