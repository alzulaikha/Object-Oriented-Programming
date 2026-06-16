using System.Xml.Linq;

namespace oop_part1
{
    public class Room
    {

        public int roomNumber;
        public string roomType {  get; set; }
        public double pricePerNight {get;set;}
        public bool isAvailable { get;set;}
    }
    public class Guest
    {

        public int guestId;
        public string guestName { get;set;}
        public string roomNumber {  get;set;}
        public string checkInDate { get;set;}
        public string totalNights { get;set;}
 }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
