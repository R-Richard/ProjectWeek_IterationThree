using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeek_IterationThree
{
    abstract class Resources
    {
        string title;
        string isbn;
        int length;
        string status;
        string studentNbr;
        string studentName;
        int daysDue;
        DateTime dateDue;
        protected Dictionary<string, string> resourceStatus;
        protected Dictionary<int, string> availableStatus;
        protected Dictionary<string, string> resourceISBN;
        protected Dictionary<string, int> resourceLength;
        protected Dictionary<string, Resources> resourceTest;
        protected Dictionary<string, string> studentInfo;

     

        // properties
        public virtual Dictionary<string, Resources> ResourceTest
        {
            get { return this.resourceTest; }
            set { this.resourceTest = value; }
        }
        public Dictionary<string, string> ResourceStatus
        {
            get { return this.resourceStatus; }
            set { this.resourceStatus = value; }
        }

        public Dictionary<int, string> AvailableStatus
        {
            get { return this.availableStatus; }
            set { this.availableStatus = value; }
        }
        public Dictionary<string, int> ResourceLength
        {
            get { return this.resourceLength; }
            set { this.resourceLength = value; }
        }
        public Dictionary<string, string> ResourceISBN
        {
            get { return this.resourceISBN; }
            set { this.resourceISBN = value; }
        }

        public Dictionary<string, string> StudentInfo
        {
            get { return this.studentInfo; }
            set { this.studentInfo = value; }
        }

        public virtual string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public virtual int DaysDue
        {
            get { return this.daysDue; }
            set { this.daysDue = value; }
        }

        public virtual string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
        public virtual DateTime DateDue
        {
            get { return this.dateDue; }
            set { this.dateDue = value; }
        }


        public virtual int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public virtual string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public virtual string StudentNbr
        {
            get { return this.studentNbr; }
            set { this.studentNbr = value; }
        }

        public virtual string StudentName
        {
            get { return this.studentName; }
            set { this.studentName = value; }
        }

        //methods
   
        public virtual void getResourceInfo()
        {
            Console.WriteLine("\nTitle: " + Title + "\nISBN: " + ISBN + "\nLength: " + Length + "\nStatus: " + Status);
            if (Status != "AVAILABLE")
            {
                Console.WriteLine(DateDue);
            }
        }

        public virtual string returnResourceInfo()
        {
          

            if (Status == "AVAILABLE")
            {
               string returnx = ("\r\nTitle: " + Title + "\r\nISBN: " + ISBN + "\r\nLength: " + Length + "\r\nStatus: " + Status);
                return returnx;
            }
            else // (Status != "AVAILABLE")
            {
               string returnx = ("\r\nTitle: " + Title + "\r\nISBN: " + ISBN + "\r\nLength: " + Length + "\r\nStatus: " + Status + "\r\nDue Date: " + DateDue);
                return returnx;
            }
           
        }

        public virtual void EditTitle(string userStringInput)
        {
            Console.WriteLine("Choose The Number Of The Item To Edit:\n1: Title\n2: ISBN\n3: Resource Length");
            string x = Console.ReadLine();
            int userInputInt = NumberCheck(x);
            switch (userInputInt)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Current Title: " + Title + "\nEnter New Title:");
                        Title = Console.ReadLine();
                    }
                    while (userInputInt == 1);
                    break;

                case 2:

                    do
                    {

                        Console.WriteLine("Current ISBN: " + ISBN + "\nEnter New ISBN:");
                        ISBN = Console.ReadLine();

                    }
                    while (userInputInt == 2);
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Current Length: " + Length + "\nEnter New Length:");
                        string inputString = Console.ReadLine();
                        Length = NumberCheck(inputString);
                    }
                    while (userInputInt == 3);
                    break;
                default:
                    {
                        Console.WriteLine("\nThat is not a Valid Entry");
                        string inputString = Console.ReadLine();
                        break;
                    }
            }
        }
         public virtual DateTime addDays()
        {
            int DaysDue = 3;
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(DaysDue);
            return answer;
        }

        public virtual void DueDate()
        {


            DateTime x = addDays();

            Console.WriteLine("\n" + Title + " is due back on " + addDays());
        
        }
        public virtual int NumberCheck(string input)
        {
            int menuItem;

            do
            {

                bool numVer = int.TryParse(input, out menuItem);
                if ((menuItem != 0))
                {
                    return menuItem;
                }
                else if (menuItem == 0)
                {
                    Console.WriteLine("That is not a valid entry, please enter a number");
                    input = Console.ReadLine();
                }
            }
            while (menuItem == 0);
            return menuItem;
        }
        //////////////////////////////////////////Do Next METHOD/////////////////////////////////////////////////////////////////
        public virtual int DoNext(string menuItem)

        {
            int userInput;
            Console.WriteLine("\nWhat would you like to do next? Choose From the Main Menu:");
            menuItem = Console.ReadLine();

            userInput = NumberCheck(menuItem);

            return userInput;



        }

        // /////////////////////////////////////////////////NullOrWhiteSpace Method /////////////////////////

        public virtual void NullOrWhiteSpace(string stringInput)
        {
            bool a;

            a = string.IsNullOrWhiteSpace(stringInput);

            if (a == true)
            {
                Console.WriteLine("Error: Request Unavailable");

            }

        }
        public virtual void Header()
        {

            string title = "RESOURCES MENU";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title + "\n\n", Console.Title);


            Console.WriteLine("Main Menu\n1: View All Resources\n2: View Available Resources\n3: Edit Resources\n4: View All Students\n5: View Student Accounts\n6: Check In Resource\n7: Check Out Resource");

            StringBldrLine();
        }
        //////////////////////////////////////////StringBldrLine METHOD/////////////////////////////////////////////////////////////////
        public virtual void StringBldrLine()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*");
            for (int i = 1; i <= 79; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb);
        }

    }
}
