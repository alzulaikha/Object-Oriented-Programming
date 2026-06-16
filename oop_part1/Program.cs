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
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Price Per Night" + pricePerNight);
            Console.WriteLine("Is Available? " + isAvailable);
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
            Console.WriteLine("Guest Id: " + guestId);
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Check In Date: " + checkInDate);

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

            }
                static void Main(string[] args)
                {
                    //System Lists 
                    List<Room> rooms = new List<Room>();
                    rooms.Add(new Room { roomNumber = 101, roomType = "Single", pricePerNight = 30,isAvailable= true});
                    rooms.Add(new Room { roomNumber = 102, roomType = "Double", pricePerNight = 20, isAvailable = true });
                    rooms.Add(new Room { roomNumber = 103, roomType = "Suite",  pricePerNight = 50, isAvailable = true });
                    rooms.Add(new Room { roomNumber = 104, roomType = "Double", pricePerNight = 20, isAvailable = true });
                    rooms.Add(new Room { roomNumber = 105, roomType = "Single", pricePerNight = 30, isAvailable = true });
                    rooms.Add(new Room { roomNumber = 106, roomType = "Suite",  pricePerNight = 50, isAvailable = true });

                    List<Guest> guests = new List<Guest>();
                  

                    bool exit = false;
                    while (exit == false)
                    {
                        mainMenu();
                        Console.WriteLine("Enter your choice: _");
                        int choice = int.Parse(Console.ReadLine());
                  
                        switch(choice) {

                            case 1:
                                Console.WriteLine("Enter Room Number:");
                                int RoomNumber= int.Parse(Console.ReadLine());

                                if (rooms.Any(r => r.roomNumber == RoomNumber))//check whether a room with the same room number already exists in the rooms list.
                            {
                                    Console.WriteLine("room number already exists");
                                }
                                else
                                {
                                    Console.WriteLine("Enter Room Type:");
                                    string RoomType = Console.ReadLine();

                                    Console.WriteLine("Enter Price:");
                                    double price = double.Parse(Console.ReadLine());

                                    Room room = new Room();// a new Room object
                                    room.roomNumber = RoomNumber;
                                    room.roomType = RoomType;
                                    room.pricePerNight = price;
                                    room .isAvailable = true;
                                    rooms.Add(room);
                                    Console.WriteLine();
                                    Console.WriteLine("New Room Details Added Successfully ");
                                    Console.WriteLine();
                                    Console.WriteLine("=== All Entered Details === ");
                                    room.displayRoom();

                                    Console.WriteLine("Updated Total Room: "+rooms.Count);

                                }
                               

                                break;
                            case 2:
                                
                                break;
                            case 3:
                                
                                break;
                            case 4:
                                
                                break;
                            case 5:
                                
                                break;
                            case 6:
                                
                                break;
                            case 7:
                                
                                break;
                            case 0:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("invalid option please try again");
                                break;

                        }
                        Console.WriteLine("press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    } 