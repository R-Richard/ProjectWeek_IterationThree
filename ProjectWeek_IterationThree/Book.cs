using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectWeek_IterationThree
{
    class Book : Resources
    {
       public Book(string title, string isbn, int length, string status, DateTime dateDue)
{
            Title = title;
            ISBN = isbn;
            Length = length;
            Status = status;
            DateDue = dateDue;
        }

        public static List<Book> books = new List<Book>
{

};



        public override void EditTitle(string userStringInput)
        {
            Console.WriteLine("Choose The Item You Would Like To Edit:\n1: Title\n2: ISBN\n3: Resource Length");
            string x = Console.ReadLine();
            int userInputInt = NumberCheck(x);
       
            switch (userInputInt)
            {
                case 1:
                    do
                    {
                        Console.Clear();
                        Header();
                        Console.WriteLine("\nCurrent Title: " + Title + "\nEnter New Title:");
                        Title = Console.ReadLine();
                        Console.Clear();
                        Header();
                        Console.WriteLine("\nThe New Title is " + Title);
                        break;
                    }
                    while (userInputInt == 1);
                    break;

                case 2:

                    do
                    {
                        Console.Clear();
                        Header();
                        Console.WriteLine("\nCurrent ISBN: " + ISBN + "\nEnter New ISBN:");
                        ISBN = Console.ReadLine();
                        Console.Clear();
                        Header();
                        Console.WriteLine("\nThe New ISBN is " + ISBN);
                        break;

                    }
                    while (userInputInt == 2);
                    break;

                case 3:
                    do
                    {
                        Console.Clear();
                        Header();
                        Console.WriteLine("\nCurrent Length: " + Length + "\nEnter New Length:");
                        string inputString = Console.ReadLine();
                        Length = NumberCheck(inputString);
                        Console.Clear();
                        Header();
                        Console.WriteLine("\nThe New Length is " + Length + " pages");
                        break;
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

        public Book()
        {
           AvailableStatus = new Dictionary<int, string>();

            ResourceStatus = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);


            ResourceISBN = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);


            ResourceLength = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        }

        public override void getResourceInfo()
        {
            Console.WriteLine("Title: " + Title + "\nISBN: " + ISBN + "\nLength: " + Length + " pages\nStatus: " + Status +"\n");
            if (Status != "AVAILABLE")
            {
                Console.WriteLine(DateDue);
            }
        }

        public override string returnResourceInfo()
        {
            if (Status == "AVAILABLE")
            {
                string returnx = ("\r\nTitle: " + Title + "\r\nISBN: " + ISBN + "\r\nLength: " + Length + " pages\r\nStatus: " + Status);
                return returnx;
            }
            else
            {
                string returnx = ("\r\nTitle: " + Title + "\r\nISBN: " + ISBN + "\r\nLength: " + Length + " pages\r\nStatus: Checked Out" + "\r\nDue Date: " + DateDue);
                return returnx;
            }

        }

        public override DateTime addDays()
        {
            int DaysDue = 14;
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(DaysDue);
            return answer;
        }

        public override void DueDate()
        {

            DateTime x = addDays();

            Console.WriteLine("\n" + Title + " is due back on " + addDays());
        }


    }


}
