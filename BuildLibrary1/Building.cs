using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Building
    {
        static public int housnum = 1;
        public Building(int flrhight, int floor, int appart, int entrance)
        {
            floorHight = flrhight;
            this.floor = floor;
            appartNum = appart;
            this.entrance = entrance;
            housnum++;
        }
        public Building()
        {
            housnum++;
        }
        private int floorHight;

        public int FloorHight
        {
            get { return floorHight; }
            set { floorHight = value; }
        }

        private int floor;

        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        private int appartNum;

        public int Appart
        {
            get { return appartNum; }
            set { appartNum = value; }
        }

        private int entrance;

        public int Entrance
        {
            get { return entrance; }
            set { entrance = value; }
        }
        public void Hight(int hight)
        {
            hight = FloorHight * Floor;
            Console.WriteLine($"Высота дома - {hight}");
        }

        public void AppartinEnt(int apent)
        {
            apent = Appart / Entrance;
            Console.WriteLine($"Количество квартир в подъезде - {apent}");
            AppartinFloor(apent);
        }

        public void AppartinFloor(int apoor)
        {
            apoor /= Floor;
            Console.WriteLine($"Количество квартир н этаже - {apoor}");
        }


    }
}
