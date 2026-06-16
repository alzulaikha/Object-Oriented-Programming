using System.Xml.Linq;

namespace oop_part1
{
    public class Room
    {
        //Attributes
        public string roomNumber;
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
        private string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;
         public double pricePerNight;

        //Methods
        public void displayGuest()
        {
            Console.WriteLine("Guest Id: " + guestId);
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Check In Date: " + checkInDate);
            Console.WriteLine("Total Of Nights: "+totalNights);
            Console.WriteLine("Price Per Night"+pricePerNight);

        }

        public double calculateTotalCost()
        {
           return totalNights * pricePerNight;
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
                    rooms.Add(new Room { roomNumber = "101", roomType = "Single", pricePerNight = 30,isAvailable= true});
                    rooms.Add(new Room { roomNumber = "102", roomType = "Double", pricePerNight = 20, isAvailable = true });
                    rooms.Add(new Room { roomNumber = "103", roomType = "Suite",  pricePerNight = 50, isAvailable = true });
                    rooms.Add(new Room { roomNumber = "104", roomType = "Double", pricePerNight = 20, isAvailable = true });
                    rooms.Add(new Room { roomNumber = "105", roomType = "Single", pricePerNight = 30, isAvailable = true });
                    rooms.Add(new Room { roomNumber = "106", roomType = "Suite",  pricePerNight = 50, isAvailable = true });

                    List<Guest> guests = new List<Guest>();
                  

                    bool exit = false;
                    while (exit == false)
                    {
                        mainMenu();
                        Console.WriteLine("Enter your choice: _");
                        int choice = int.Parse(Console.ReadLine());

                    switch (choice) {

                        case 1: //Case 01: Add New Room 
                            Console.WriteLine("Enter Room Number:");
                            string RoomNumber = Console.ReadLine();

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
                                room.isAvailable = true;
                                rooms.Add(room);
                                Console.WriteLine();
                                Console.WriteLine("New Room Details Added Successfully ");
                                Console.WriteLine();
                                Console.WriteLine("=== All Entered Details === ");
                                room.displayRoom();

                                Console.WriteLine("Updated Total Room: " + rooms.Count);

                            }


                            break;
                        case 2://Case 02: Register New Guest 


                            Console.WriteLine("Enter guest name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter check-in date");
                            string date = Console.ReadLine();
                            Console.WriteLine("Enter number of nights ");
                            int numberOfNight = int.Parse(Console.ReadLine());
                            if (numberOfNight <0)
                            {
                                Console.WriteLine("Please enter possitive number");
                                return;
                            }


                            Guest guest = new Guest();// a new Room object
                            //guest.roomNumber = "Not Assigned";
                            string guestID = "G00"+(guests.Count + 1);
                            guest.guestId = guestID;
                            guest.guestName= name;
                            guest.checkInDate = date;
                            guest.totalNights = numberOfNight;
                            guest.roomNumber = "Not Assigned";


                            guests.Add(guest);
                            Console.WriteLine();
                            Console.WriteLine("New Guest Details Added Successfully ");
                            Console.WriteLine();
                            Console.WriteLine("=== All Entered Details === ");
                            guest.displayGuest();

                            break;



                            case 3://Case 03: Book a Room for a Guest
                            Console.WriteLine("Enter guest ID:");
                            string guestid= Console.ReadLine();

                            Guest selectedGuest = guests.FirstOrDefault(g => g.guestId == guestid);//linq firstordefualt 
                            if (selectedGuest == null)
                            {
                                Console.WriteLine("Guest not found");
                            }


                            Console.WriteLine("Enter room number: ");
                            string number= Console.ReadLine();

                          

                            Room selectedRoom = rooms.FirstOrDefault(r => r.roomNumber == number);//linq firstordefualt 
                            if (selectedRoom == null)
                            {
                                Console.WriteLine("Room not found");
                            }

                            if (!selectedRoom.isAvailable)
                            {
                                Console.WriteLine("'Room is already booked");
                            }
                            selectedRoom.roomNumber = selectedGuest.roomNumber;
                            selectedRoom.isAvailable = false;

                            Console.WriteLine("Guest Name: "+selectedGuest.guestName);
                            Console.WriteLine("Room Number: "+selectedRoom.roomNumber);
                            Console.WriteLine("Room Type: "+selectedRoom.roomType);
                            Console.WriteLine("Price:"+selectedRoom.pricePerNight);
                            Console.WriteLine("Total Nights:"+selectedGuest.totalNights);
                            Console.WriteLine("Total Cost: "+selectedGuest.calculateTotalCost());



                            break;
                            case 4:
                            Console.WriteLine("(1) Show all available rooms");
                            Console.WriteLine("(2) Filter by room type");
                            Console.WriteLine("(3) Filter by max price");
                            Console.WriteLine("(4) Room price statistics");
                            Console.WriteLine("(0) Back");
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