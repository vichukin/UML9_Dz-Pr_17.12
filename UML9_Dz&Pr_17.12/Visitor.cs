using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML9_Dz_Pr_17._12
{
    public abstract class Visitor
    {
        public abstract bool VisitHouse(House house);
        public abstract bool VisitFloor(Floor floor);
        public abstract bool VisitRoom(Room room);
    }
    public class Electrician : Visitor
    {
        public override bool VisitFloor(Floor floor)
        {
            Console.WriteLine($"Electrisian enter into level {floor.Level}");
            if (floor.Accept(this))
            {
                Console.WriteLine($"In level {floor.Level} problem");
            }
            else
            {
                Console.WriteLine($"Cant find in Level {floor.Level} a problem");
            }
            return floor.Accept(this);
        }

        public override bool VisitHouse(House house)
        {
            Console.WriteLine($"Electrisian enter in house {house.Number}");
            if (house.Accept(this))
            {
                Console.WriteLine($"In House {house.Number} problem");
            }
            else
            {
                Console.WriteLine($"Cant find in house {house.Number} a problem");
            }
            return house.Accept(this);
        }

        public override bool VisitRoom(Room room)
        {
            Console.WriteLine($"Electrisian enter in room with number {room.Number}");
            if (room.Accept(this))
            {
                Console.WriteLine($"In room {room.Number} problem");
                room.isError = false;
                Console.WriteLine($"problem in room {room.Number} was repair");
            }
            else
            {
                Console.WriteLine($"Cant find in room {room.Number} a problem");
            }
            return room.Accept(this);
        }
    }
}
