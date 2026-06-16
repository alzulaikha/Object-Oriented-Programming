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
        //Methods
        public void displayRoom()
        {
            Console.WriteLine(roomNumber);
            Console.WriteLine(roomType);
            Console.WriteLine(pricePerNight);
            Console.WriteLine(isAvailable);
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
            Console.WriteLine(guestId);
            Console.WriteLine(guestName);
            Console.WriteLine(roomNumber);
            Console.WriteLine(checkInDate);
         
        }
        public void calculateTotalCost()
        {

        }


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

                mainMenu();
            }
        }
    }
}