using System.Xml.Linq;

namespace oop_part1
{
    public class Room
    {

        public int roomNumber;
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; }
    }
    public class Guest
    {

        public int guestId;
        public string guestName { get; set; }
        public string roomNumber { get; set; }
        public string checkInDate { get; set; }
        public string totalNights { get; set; }
    }
    internal class Program
    {
        public static void mainMenu()
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