using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson10
{
    class Builder 
    {
        private static Hashtable hashtable = new Hashtable();
        public static void CreateBuild()
        {
            Building building = new Building();
            hashtable[Building.housnum] = building;
        }

        public static void CreateBuild(int flrhight, int floor, int appart, int entrance)
        {
            Building building = new Building(flrhight, floor, appart, entrance);
            hashtable[Building.housnum] = building;
        }

        public static void DeleteBuilding(int id)
        {
            hashtable.Remove(id);
        }



    }
}
