using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoomInventoryApp
{
    internal class Classroom
    {
        public int ClassroomId { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int NumberOfProjectors { get; set; }
        public bool IncludesSmartBoard { get; set;}
        public bool IsAccessible { get; set;}

        public Classroom() { }
        public Classroom(int classroomId, string roomNumber, int capacity, int numberOfProjectors, bool includesSmartBoard, bool isAccessible)
        {
            ClassroomId = classroomId;
            RoomNumber = roomNumber;
            Capacity = capacity;
            NumberOfProjectors = numberOfProjectors;
            IncludesSmartBoard = includesSmartBoard;
            IsAccessible = isAccessible;
        }

        public bool CheckRoomNumber(string  roomNumber)
        {
            bool result = false;
            string roomPath = @"^(N|M|Y)[a-zA-Z]{2}(\s|-)?[1-9][a-zA-Z][0-9]{2}$";
            roomNumber = roomNumber.Trim();
            if (Regex.IsMatch(roomNumber, roomPath))
            {
                result = true;
            }
            return result;
        }

        public string GetCampus(string roomNumber)
        {
            string initial = roomNumber.Substring(0,1).Trim();
            string campus="";
            if (initial == "N")
            {
                campus = "Newnham";
            }
            else if(initial == "M")
            {
                campus = "Markham";
            }
            else if (initial == "Y")
            {
                campus= "York";
            }

            return campus;
        }
    }
}
