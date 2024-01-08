using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML9_Dz_Pr_17._12
{
    public abstract class Element
    {
        public bool isError {  get; set; }

        public abstract bool Accept(Visitor visitor);

    }
    public class Room : Element
    {
        public int Number;
        public Room(int number, bool isError)
        {
            Number = number;
            this.isError = isError;
        }
        public override bool Accept(Visitor visitor)
        {
            return isError;
        }
    }
    public class Floor : Element
    {
        public int Level;
        public List<Room> Rooms = new List<Room>();
        public Floor(List<Room> rooms,int level)
        {
            this.Rooms = rooms;
            if(Rooms.Any(t => t.isError == true))
                isError = true;
            Level = level;
        }
        public void AddRoom(Room room)
        {
            if (room.isError)
                isError = true;
            Rooms.Add(room);
        }
        public override bool Accept(Visitor visitor)
        {
            return isError;
        }
    }
    public class House: Element
    {
        public int Number;
        public List<Floor> Floors = new List<Floor>();
        public House(List<Floor> floors, int number)
        {
            Floors= floors;
            if(Floors.Any(t => t.isError == true))
            {
                isError = true;
            }
            Number= number;
        }
        public override bool Accept(Visitor visitor)
        {
            return isError;
        }
    }
}
