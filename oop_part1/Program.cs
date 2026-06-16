using System.Xml.Linq;

namespace oop_part1
{
    public class Room
    {
        //Attributes
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int RoomNumber,string Roomtype,double PricePerNight,bool IsAvailable)
        {
            roomNumber = RoomNumber;
            roomType = Roomtype;
            pricePerNight = PricePerNight;
            isAvailable = IsAvailable;
        }
        //Methods
        public void displayRoom()
        {
            Console.WriteLine("Room Number: "+roomNumber);
            Console.WriteLine("Room Type: "+ roomType);
            Console.WriteLine("Price Per Night"+ pricePerNight);
            Console.WriteLine("Is Available? "+isAvailable);
        }
    }
    public class Guest
    {
        //Attributes
        private int guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public string totalNights;

        //Methods
        public void displayGuest()
        {
            Console.WriteLine("Guest Id: "+guestId);
            Console.WriteLine("Guest Name: "+ guestName);
            Console.WriteLine("Room Number: "+roomNumber);
            Console.WriteLine("Check In Date: "+checkInDate);

        }

        public void calculateTotalCost()
        {

        }
        internal class Program
        {
            public static void mainMenu()//main menu function
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. Search & Filter Rooms");
                Console.WriteLine("5. Guest & Booking Statistics");
                Console.WriteLine("6. Check Out a Guest");
                Console.WriteLine("7. Remove Unavailable Rooms");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.WriteLine("Enter your choice: _");

                static void Main(string[] args)
                {
                    List<Room> rooms = new List<Room>();
                    List<Guest> guests = new List<Guest>();
                    rooms.Add(new Room(1, "Single", 30,true));
                    rooms.Add(new Room(2, "Double", 20, true));
                    rooms.Add(new Room(3, "Single", 30, true));
                    rooms.Add(new Room(4, "Suite", 50, true));
                    rooms.Add(new Room(5, "Double", 20, true));
                    rooms.Add(new Room(6, "Suite", 50, true));


                    mainMenu();
                }
            }
        }
    }
}