using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RoomInventoryApp
{
    /*
    * Final Exam
    * April 18, 2023
    * Programming Concepts 2
    * Bryan Ayala
    */


    internal class IClassroomManager
    {
        List<Classroom> myBooks = new List<Classroom>();
        public IClassroomManager() { }


        public int GetRecordID(string dirPath)
        {
            int fileCount = 0;
            fileCount = Directory.GetFiles(dirPath).Length;

            fileCount += 1;

            return fileCount;
        }

        public bool IsBookLoan(int loanRecordId)
        {
            bool result = false;
            var selectedItem = myBooks.Where(x => x.ClassroomId == loanRecordId).FirstOrDefault();

            if (selectedItem != null)
            {
                result = true;
            }

            return result;

        }

        public void CreateNewFile(Classroom classroom, string newPath)
        {
            string campus= classroom.GetCampus(classroom.RoomNumber);
            string smartBoard;
            string accessible;
            string filePath = Path.Combine(newPath, $"{classroom.RoomNumber}.txt");

            if (!File.Exists(filePath))
            {
                if (classroom.IncludesSmartBoard)
                {
                    smartBoard = "yes";
                }
                else
                {
                    smartBoard = "no";
                }

                if (classroom.IsAccessible)
                {
                    accessible= "yes";
                }
                else
                {
                    accessible= "no";
                }

                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine($"{classroom.ClassroomId}|{classroom.RoomNumber}|{classroom.Capacity}|{classroom.NumberOfProjectors}|{smartBoard}|{accessible}|{campus}");

                }
            }
        }

        public string AddClassroom(Classroom book)
        {
            myBooks.Add(book);

            int countBooks = 0;

            countBooks = myBooks.Count;

            return $"{countBooks} classroom were loaded succesfully";
        }

        public List<string> GetFiles(string dirPath, bool btnM, bool btnN, bool btnY, int capacity)
        {
            List<string> items = new List<string>();
            string[] fields = null;
            string item = "";
            string filePath;

            SearchOption subs = SearchOption.AllDirectories;
            var directories = Directory.GetFiles(dirPath, "*.txt", subs);
            foreach (var directory in directories)
            {
                filePath = Path.Combine(directory);
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        fields = line.Split('|');
                    }
                }

                if(btnM)
                {
                    if (fields[6] == "Markham" && capacity <= int.Parse(fields[2]))
                    {
                        item = $"{fields[1]}: Campus: {fields[6]}; Capacity: {fields[2]}; projectors: {fields[3]}; includes smart board: {fields[4]}; is accessible: {fields[5]}";
                    }
                }
                else if (btnN)
                {
                    if (fields[6] == "Newnham" && capacity <= int.Parse(fields[2]))
                    {
                        item = $"{fields[1]}: Campus: {fields[6]}; Capacity: {fields[2]}; projectors: {fields[3]}; includes smart board: {fields[4]}; is accessible: {fields[5]}";
                    }
                }
                else if (btnY)
                {
                    if (fields[6] == "York" && capacity <= int.Parse(fields[2]))
                    {
                        item = $"{fields[1]}: Campus: {fields[6]}; Capacity: {fields[2]}; projectors: {fields[3]}; includes smart board: {fields[4]}; is accessible: {fields[5]}";
                    }
                }
                else
                {
                    if (capacity <= int.Parse(fields[2]))
                    {
                        item = $"{fields[1]}: Campus: {fields[6]}; Capacity: {fields[2]}; projectors: {fields[3]}; includes smart board: {fields[4]}; is accessible: {fields[5]}";
                    }
                }

                items.Add(item);
            }
            return items;
        }

        public string[] GetRoomInfo(string text, string newPath)
        {
            string[] fields = null;
            string title = text.Substring(0, text.IndexOf(": Campus"));
       //     string isbn = text.Substring(text.IndexOf("ISBN-13: ") + 9, 14);

            string dirPath = Path.Combine(newPath, $"{title}.txt");

            using (StreamReader reader = new StreamReader(dirPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fields = line.Split('|');
                }
            }

            return fields;
        }

        public string EditClassroom(string newPath, Classroom classroom)
        {


            string dirPath = Path.Combine(newPath, $"{classroom.RoomNumber}.txt");

            if (File.Exists(dirPath))
            {
                string campus = classroom.GetCampus(classroom.RoomNumber);
                string smartBoard;
                string accessible;
                if (classroom.IncludesSmartBoard)
                {
                    smartBoard = "yes";
                }
                else
                {
                    smartBoard = "no";
                }

                if (classroom.IsAccessible)
                {
                    accessible = "yes";
                }
                else
                {
                    accessible = "no";
                }
                using (StreamWriter sw = File.CreateText(dirPath))
                {
                    sw.WriteLine($"{classroom.ClassroomId}|{classroom.RoomNumber}|{classroom.Capacity}|{classroom.NumberOfProjectors}|{smartBoard}|{accessible}|{campus}");

                }

                return "The Record was updated";
            }
            else
            {
                return "The Record was not found";
            }

        }

    }
}
