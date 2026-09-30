using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_
{
    internal class Room
   
    {
        public string RoomNumber {  get; set; }
        public string RoomType { get; set; }
        public decimal NightlyRate { get; set; }
        public string Status { get; set; }

        public Room(string number, string type, decimal rate)
        {
            RoomNumber = number;
            RoomType = type;
            NightlyRate = rate;
            Status = "Available";
        }
    }
}
