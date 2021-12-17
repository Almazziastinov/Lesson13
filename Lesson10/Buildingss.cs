using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Buildingss
    {
        private Building[] array;

        public Buildingss(int capacity)
        {
            array = new Building[capacity];
            for (int i = 0; i < capacity; i++)
            {
                array[i] = new Building();
            }
        }
        public Building this[int index]
        {
            get
            {
                if (array.Any(x => x.Id == index))
                {
                    return array.First(x => x.Id == index);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
