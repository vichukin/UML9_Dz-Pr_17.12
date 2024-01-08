using UML9_Dz_Pr_17._12;

List<Room> rooms1 = new List<Room>() { new Room(1, false), new Room(2, false), new Room(3, false) };
List<Room> rooms2 = new List<Room>() { new Room(1, true), new Room(2, true), new Room(3, true), new Room(4, true) };
List<Room> rooms3 = new List<Room>() { new Room(1, false), new Room(2, true), new Room(3, false), new Room(4, true), new Room(5, false) };
List<Room> rooms4 = new List<Room>() { new Room(1, true) };
List<Room> rooms5 = new List<Room>() { new Room(1, false), new Room(2, false), new Room(3, true), new Room(4, true), new Room(5, false), new Room(6, false) };
List<Room> rooms6 = new List<Room>() { new Room(1, true), new Room(2, false), new Room(3, true), new Room(4, false) };
List<Room> rooms7 = new List<Room>() { new Room(1, false), new Room(2, false), new Room(3, false), new Room(4, false) };
List<Room> rooms8 = new List<Room>() { new Room(1, true), new Room(2, true), new Room(3, true), new Room(4, true), new Room(5, true), new Room(6, true), new Room(7, true) };
List<Room> rooms9 = new List<Room>() { new Room(1, false), new Room(2, false), new Room(3, false), new Room(4, false), new Room(5, false), new Room(6, false), new Room(7, false), new Room(8, false), new Room(9, false) };
List<Room> rooms10 = new List<Room>() { new Room(1, true), new Room(2, false), new Room(3, true), new Room(4, false), new Room(5, true), new Room(6, false), new Room(7, true), new Room(8, false), new Room(9, true), new Room(10, false) };

List<Floor> floors = new List<Floor>()
{
    new Floor(rooms1, 1),
    new Floor(rooms2, 2),
    new Floor(rooms3, 3),
    new Floor(rooms4, 4),
    new Floor(rooms5, 5),
    new Floor(rooms6, 6),
    new Floor(rooms7, 7),
    new Floor(rooms8, 8),
    new Floor(rooms9, 9),
    new Floor(rooms10, 10)
};
List<Floor> floors1 = floors.GetRange(0, 3);
List<Floor> floors2 = floors.GetRange(3, 3);
List<Floor> floors3 = floors.GetRange(6, 3);

House house1 = new House(floors1, 1);
House house2 = new House(floors2, 2);
House house3 = new House(floors3, 3);
List<House> houses = new List<House>();
houses.Add(house1);
houses.Add(house2);
houses.Add(house3);

Electrician electrician = new Electrician();
foreach (House house in houses)
{
    if(electrician.VisitHouse(house))
    {
        foreach(Floor floor in house.Floors)
        {
            if(electrician.VisitFloor(floor))
            {
                foreach (var room in floor.Rooms)
                {
                    electrician.VisitRoom(room);
                }
                
            }
            Console.WriteLine("-----Floor done");
        }
       
    }
    Console.WriteLine("-----House done");
}    