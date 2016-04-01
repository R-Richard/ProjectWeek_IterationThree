using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;


namespace ProjectWeek_IterationThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Lots Of Programming Stuff", "9-987-9876-9", 123, "AVAILABLE", DateTime.Now);
            Book book2 = new Book("Even More on C#", "8-123-12345-8", 534, "AVAILABLE", DateTime.Now);
            Book book3 = new Book("Big Book of C#", "7-234-23456-7", 878, "AVAILABLE", DateTime.Now);

            Magazine magazine1 = new Magazine("Database Periodical", "5-234-45678-9", 50, "AVAILABLE", DateTime.Now);
            Magazine magazine2 = new Magazine("SQL Monthly", "4-234-12345-6", 23, "AVAILABLE", DateTime.Now);
            Magazine magazine3 = new Magazine("Big Magazine of Useless Facts", "8-987-87654-3", 14, "AVAILABLE", DateTime.Now);

            DVD dvd1 = new DVD("Beginner's Database Handbook: DVD Companion", "0-987-12345-6", 45, "AVAILABLE", DateTime.Now);
            DVD dvd2 = new DVD("C# Player's Guide On DVD", "3-123-29846-3", 90, "AVAILABLE", DateTime.Now);
            DVD dvd3 = new DVD("String Comparison Basics: DVD Companion", "1-234-74523-9", 120, "AVAILABLE", DateTime.Now);

            int userInput;
            
            bool restart = true;
            do
            {
                Header();
                {
                    List<string> AllResourceList = new List<string>();

                    DVD dvdInfo = new DVD();
                    Book bookInfo = new Book();
                    Magazine magazineInfo = new Magazine();

                    string menuItemTemp;
                    Student studentInfo = new Student();

                    string userNameInput;
                    string userNameInputUpper;

                    List<string> AllStatusList = new List<string>();
                    dvdInfo.ResourceStatus.Clear();
                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                    bookInfo.ResourceStatus.Clear();
                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                    magazineInfo.ResourceStatus.Clear();
                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);

                    studentInfo.StudentInfo.Add("U123", "JIMMY JONES");
                    studentInfo.StudentInfo.Add("U234", "JAMIE NOEL");
                    studentInfo.StudentInfo.Add("U345", "SCOTT BRIDGES");
                    studentInfo.StudentInfo.Add("U456", "ALEXANDER ZILL");
                    studentInfo.StudentInfo.Add("U567", "WILFORD WILLIAMS");

                    
                    int switchnbr;

                    Console.WriteLine("Enter Menu Item Number");
                    string menuItem = Console.ReadLine();
                    userInput = NumberCheck(menuItem);
                    int caseRestart = 0;
                    while (caseRestart == 0)
                    {
                        switch (userInput)
                        {
                            case 1:
                                do
                                {
                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);
                                    StreamWriter writer4 = new StreamWriter("BooksFile.txt");
                                    using (writer4)
                                    {
                                        writer4.WriteLine("Books File:\r\n");
                                        writer4.WriteLine(book1.returnResourceInfo());
                                        writer4.WriteLine(book2.returnResourceInfo());
                                        writer4.WriteLine(book3.returnResourceInfo());

                                    }

                                    StreamWriter writer5 = new StreamWriter("MagazineFile.txt");
                                    using (writer5)
                                    {

                                        writer5.WriteLine("Magazine File:\r\n");
                                        writer5.WriteLine(magazine1.returnResourceInfo());
                                        writer5.WriteLine(magazine2.returnResourceInfo());
                                        writer5.WriteLine(magazine3.returnResourceInfo());
                                    }
                                    StreamWriter writer6 = new StreamWriter("DVDFile.txt");
                                    using (writer6)
                                    {

                                        writer6.WriteLine("DVD File:\r\n");
                                        writer6.WriteLine(dvd1.returnResourceInfo());
                                        writer6.WriteLine(dvd2.returnResourceInfo());
                                        writer6.WriteLine(dvd3.returnResourceInfo());


                                    }

                                    StreamWriter writer = new StreamWriter("All Resources.txt");
                                    using (writer)
                                    {

                                        writer.WriteLine("Resource List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (DVD)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Book)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Magazine)");
                                        }
                                    }
                                    Console.Clear();
                                    Header();

                                    using (StreamReader sr = File.OpenText("All Resources.txt"))
                                    {
                                        string s = "";
                                        while ((s = sr.ReadLine()) != null)
                                        {
                                            Console.WriteLine(s);
                                        }
                                    }
                                    userInput = DoNext(menuItem);
                                    break;
                                }
                                while (userInput == 1);
                                break;

                            case 2:
                                do
                                {
                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);

                                    switchnbr = 1;

                                    bookInfo.AvailableStatus.Clear();

                                    StreamWriter writer4 = new StreamWriter("BooksFile.txt");
                                    using (writer4)
                                    {
                                        writer4.WriteLine("Books File:\r\n");
                                        writer4.WriteLine(book1.returnResourceInfo());
                                        writer4.WriteLine(book2.returnResourceInfo());
                                        writer4.WriteLine(book3.returnResourceInfo());

                                    }

                                    StreamWriter writer5 = new StreamWriter("MagazineFile.txt");
                                    using (writer5)
                                    {

                                        writer5.WriteLine("Magazine File:\r\n");
                                        writer5.WriteLine(magazine1.returnResourceInfo());
                                        writer5.WriteLine(magazine2.returnResourceInfo());
                                        writer5.WriteLine(magazine3.returnResourceInfo());
                                    }
                                    StreamWriter writer6 = new StreamWriter("DVDFile.txt");
                                    using (writer6)
                                    {

                                        writer6.WriteLine("DVD File:\r\n");
                                        writer6.WriteLine(dvd1.returnResourceInfo());
                                        writer6.WriteLine(dvd2.returnResourceInfo());
                                        writer6.WriteLine(dvd3.returnResourceInfo());


                                    }

              

                                    StreamWriter writer9 = new StreamWriter("CheckedOutResources.txt");
                                    using (writer9)
                                    {
                                        writer9.WriteLine("Checked Out Resources:\r\n");

                                        if (book1.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(book1.returnResourceInfo());
                                        }

                                        if (book2.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(book2.returnResourceInfo());
                                        }

                                        if (book3.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(book3.returnResourceInfo());
                                        }

                                        if (dvd1.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(dvd1.returnResourceInfo());
                                        }
                                        if (dvd2.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(dvd2.returnResourceInfo());
                                        }
                                        if (dvd3.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(dvd3.returnResourceInfo());
                                        }
                                        if (magazine1.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(magazine1.returnResourceInfo());
                                        }
                                        if (magazine2.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(magazine2.returnResourceInfo());
                                        }
                                        if (magazine3.Status != "AVAILABLE")
                                        {
                                            writer9.WriteLine(magazine3.returnResourceInfo());
                                        }

                                    }



                                    StreamWriter writer = new StreamWriter("All Resources.txt");
                                    using (writer)
                                    {

                                        writer.WriteLine("Resource List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (DVD)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Book)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Magazine)");
                                        }
                                    }
                                 //  /////////////////////////////////////////////





                                    Console.Clear();
                                    Header();

                                    Console.WriteLine("Available Resources:\n");
                                    foreach (KeyValuePair<string, string> pair in (dvdInfo.ResourceStatus))
                                    {
                                        if (pair.Value == "AVAILABLE")
                                        {
                                            Console.WriteLine(switchnbr + ": " + pair.Key);
                                            bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                            switchnbr++;
                                        }
                                    }
                                    foreach (KeyValuePair<string, string> pair in (magazineInfo.ResourceStatus))
                                    {
                                        if (pair.Value == "AVAILABLE")
                                        {
                                            Console.WriteLine(switchnbr + ": " + pair.Key);
                                            bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                            switchnbr++;
                                        }
                                    }
                                    foreach (KeyValuePair<string, string> pair in (bookInfo.ResourceStatus))
                                    {
                                        if (pair.Value == "AVAILABLE")
                                        {
                                            Console.WriteLine(switchnbr + ": " + pair.Key);
                                            bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                            switchnbr++;
                                        }
                                    }
                                    Console.WriteLine("\nA List Of Checked Out Resources Has Been Printed To Your Account Folder");
                                    Console.WriteLine("\nSelect The Item Number To View Resource Detail Or Press Or Press \"E\" To Exit");
                                    menuItemTemp = Console.ReadLine();

                                    if (menuItemTemp.Equals("e", StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        Console.Clear();
                                        Header();
                                        userInput = DoNext(menuItem);
                                        break;
                                    }
                                    else
                                    {

                                        int userIntInput = NumberCheck(menuItemTemp);

                                        {
                                            string tempResource = bookInfo.AvailableStatus[userIntInput];


                                            if (book1.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                book1.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }

                                            if (book2.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                book2.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }

                                            if (book3.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                book3.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }

                                            if (magazine1.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                magazine1.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;

                                            }
                                            if (magazine2.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                magazine2.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            if (magazine3.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                magazine3.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }

                                            if (dvd1.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                dvd1.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            if (dvd2.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                dvd2.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            if (dvd3.Title == (tempResource))
                                            {
                                                Console.Clear();
                                                Header();
                                                dvd3.getResourceInfo();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }

                                        }
                                        userInput = DoNext(menuItem);
                                        break;

                                    }
                                }
                                while (userInput == 2);
                                break;




                            case 3:
                                do
                                {
                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);

                                    bookInfo.AvailableStatus.Clear();

                                    StreamWriter writer4 = new StreamWriter("BooksFile.txt");
                                    using (writer4)
                                    {
                                        writer4.WriteLine("Books File:\r\n");
                                        writer4.WriteLine(book1.returnResourceInfo());
                                        writer4.WriteLine(book2.returnResourceInfo());
                                        writer4.WriteLine(book3.returnResourceInfo());

                                    }

                                    StreamWriter writer5 = new StreamWriter("MagazineFile.txt");
                                    using (writer5)
                                    {

                                        writer5.WriteLine("Magazine File:\r\n");
                                        writer5.WriteLine(magazine1.returnResourceInfo());
                                        writer5.WriteLine(magazine2.returnResourceInfo());
                                        writer5.WriteLine(magazine3.returnResourceInfo());
                                    }
                                    StreamWriter writer6 = new StreamWriter("DVDFile.txt");
                                    using (writer6)
                                    {

                                        writer6.WriteLine("DVD File:\r\n");
                                        writer6.WriteLine(dvd1.returnResourceInfo());
                                        writer6.WriteLine(dvd2.returnResourceInfo());
                                        writer6.WriteLine(dvd3.returnResourceInfo());


                                    }

                                    StreamWriter writer = new StreamWriter("All Resources.txt");
                                    using (writer)
                                    {

                                        writer.WriteLine("Resource List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (DVD)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Book)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Magazine)");
                                        }
                                    }
                                   
                                    switchnbr = 1;
                                    Console.Clear();
                                    Header();
                                    Console.WriteLine("Choose a Resource To Edit:\n");


                                    {
                                        foreach (KeyValuePair<string, string> pair in (dvdInfo.ResourceStatus))
                                        {
                                            Console.WriteLine(switchnbr + ": " + pair.Key);
                                            bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                            switchnbr++;
                                        }

                                        foreach (KeyValuePair<string, string> pair in (magazineInfo.ResourceStatus))
                                        {
                                            Console.WriteLine(switchnbr + ": " + pair.Key);
                                            bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                            switchnbr++;
                                        }

                                        foreach (KeyValuePair<string, string> pair in (bookInfo.ResourceStatus))
                                        {
                                            Console.WriteLine(switchnbr + ": " + pair.Key);
                                            bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                            switchnbr++;
                                        }
                                    }

                                    menuItemTemp = Console.ReadLine();
                                    Console.Clear();
                                    Header();
                                    int userIntInput = NumberCheck(menuItemTemp);

                                    if (bookInfo.AvailableStatus.ContainsKey(userIntInput))
                                    {
                                        string tempResource = bookInfo.AvailableStatus[userIntInput];
                                        if (book1.Title == (tempResource))
                                        {
                                            book1.EditTitle(tempResource);
                                            restart = false;
                                            userInput = DoNext(menuItem);
                                            break;
                                        }

                                        if (book2.Title == (tempResource))
                                        {
                                            book2.EditTitle(tempResource);
                                            restart = false;
                                            userInput = DoNext(menuItem);
                                            break;
                                        }

                                        if (book3.Title == (tempResource))
                                        {
                                            book3.EditTitle(tempResource);
                                            restart = false;
                                            userInput = DoNext(menuItem);                                        
                                            break;
                                        }

                                        if (magazine1.Title == (tempResource))
                                        {
                                            magazine1.EditTitle(tempResource);
                                            userInput = DoNext(menuItem);                                         
                                            break;
                                        }
                                        if (magazine2.Title == (tempResource))
                                        {
                                            magazine2.EditTitle(tempResource);

                                            userInput = DoNext(menuItem);                                        
                                            break;
                                        }
                                        if (magazine3.Title == (tempResource))
                                        {
                                            magazine3.EditTitle(tempResource);
                                            userInput = DoNext(menuItem);
                                            break;
                                        }

                                        if (dvd1.Title == (tempResource))
                                        {
                                            dvd1.EditTitle(tempResource);

                                            userInput = DoNext(menuItem);                                           
                                            break;
                                        }
                                        if (dvd2.Title == (tempResource))
                                        {
                                            dvd2.EditTitle(tempResource);

                                            userInput = DoNext(menuItem);                                        
                                            break;
                                        }
                                        if (dvd3.Title == (tempResource))
                                        {
                                            dvd3.EditTitle(tempResource);

                                            userInput = DoNext(menuItem);                                          
                                            break;
                                        }

                                        Console.Clear();
                                        Header();
                                        userInput = DoNext(menuItem);
                                        Console.Clear();
                                        Header();
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Header();
                                        Console.WriteLine("\nThat Is Not A Valid Entry");
                                        userInput = DoNext(menuItem);
                                        Console.Clear();
                                        Header();
                                        break;
                                    }

                                }
                                while (userInput == 3);
                                break;

                            case 4:
                                do
                                {
                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);
                                    StreamWriter writer7 = new StreamWriter("Students.txt");
                                    using (writer7)
                                    {

                                        writer7.WriteLine("Student List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in studentInfo.StudentInfo.OrderBy(value => value.Value))
                                        {
                                            Console.WriteLine(pair.Value);

                                        }

                                    }
                                    using (StreamReader sr = File.OpenText("Students.txt"))
                                    {
                                        string s = "";
                                        while ((s = sr.ReadLine()) != null)
                                        {
                                            Console.WriteLine(s);
                                        }
                                    }
                                    Console.Clear();
                                    Header();

                                    {
                                        Console.WriteLine("Students:\n");

                                        foreach (KeyValuePair<string, string> pair in studentInfo.StudentInfo.OrderBy(value => value.Value))
                                        {

                                            Console.WriteLine(pair.Value);
                                        }

                                    }
                                    userInput = DoNext(menuItem);
                                    break;

                                }
                                while (userInput == 4);
                                break;

                            case 5:
                                do
                                {

                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);
 
                                    StreamWriter writer4 = new StreamWriter("BooksFile.txt");
                                    using (writer4)
                                    {
                                        writer4.WriteLine("Books File:\r\n");
                                        writer4.WriteLine(book1.returnResourceInfo());
                                        writer4.WriteLine(book2.returnResourceInfo());
                                        writer4.WriteLine(book3.returnResourceInfo());
                                    }

                                    StreamWriter writer5 = new StreamWriter("MagazineFile.txt");
                                    using (writer5)
                                    {
                                        writer5.WriteLine("Magazine File:\r\n");
                                        writer5.WriteLine(magazine1.returnResourceInfo());
                                        writer5.WriteLine(magazine2.returnResourceInfo());
                                        writer5.WriteLine(magazine3.returnResourceInfo());
                                    }
                                    StreamWriter writer6 = new StreamWriter("DVDFile.txt");
                                    using (writer6)
                                    {
                                        writer6.WriteLine("DVD File:\r\n");
                                        writer6.WriteLine(dvd1.returnResourceInfo());
                                        writer6.WriteLine(dvd2.returnResourceInfo());
                                        writer6.WriteLine(dvd3.returnResourceInfo());
                                    }

                                    StreamWriter writer = new StreamWriter("All Resources.txt");
                                    using (writer)
                                    {

                                        writer.WriteLine("Resource List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (DVD)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Book)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Magazine)");
                                        }
                                    }

                                    Console.Clear();
                                    Header();
                                    Console.WriteLine("\nType In A Four Digit User Account Number From The List Below To Print Account Information\n\n");


                                    StringBuilder account = new StringBuilder();
                                    foreach (KeyValuePair<string, string> pair in studentInfo.StudentInfo.OrderBy(value => value.Value))

                                    {
                                        account.AppendLine("User ID: " + pair.Key + " ** Name: " + pair.Value);
                                    }
                                    Console.WriteLine(account.ToString());

                                    userNameInput = Console.ReadLine();
                                    NullOrWhiteSpace(userNameInput);
                                    userInput = NumberCheck(menuItem);
                                    userNameInputUpper = userNameInput.ToUpper();

                                    if (studentInfo.StudentInfo.ContainsKey(userNameInputUpper))
                                    {
                                        if ((magazineInfo.ResourceStatus.ContainsValue(userNameInputUpper)) || (bookInfo.ResourceStatus.ContainsValue(userNameInputUpper)) || (dvdInfo.ResourceStatus.ContainsValue(userNameInputUpper)))
                                        {
                                            Console.Clear();
                                            Header();
                                            Console.WriteLine("\nThe Following Items Are Checked Out:");

                                            foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                    Console.WriteLine(pair.Key);
                                            }
                                            foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                    Console.WriteLine(pair.Key);
                                            }
                                            foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                    Console.WriteLine(pair.Key);
                                            }

                                            StreamWriter writer3 = new StreamWriter("UserID" + userNameInputUpper + "_StudentAccount.txt");
                                            using (writer3)
                                            {
                                                writer3.WriteLine("Resource Checkout System");
                                                writer3.WriteLine("Student Account For User ID: " + userNameInputUpper + ", " + studentInfo.StudentInfo[userNameInputUpper]);
                                                writer3.WriteLine("\r\nChecked Out Resources: \r\n");

                                                foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                                {
                                                    if (pair.Value == userNameInputUpper)
                                                        writer3.WriteLine(pair.Key);
                                                }
                                                foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                                {
                                                    if (pair.Value == userNameInputUpper)
                                                        writer3.WriteLine(pair.Key);
                                                }
                                                foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                                {
                                                    if (pair.Value == userNameInputUpper)
                                                        writer3.WriteLine(pair.Key);
                                                }
                                            }
                                            Console.Clear();
                                            Console.WriteLine("\nFile Export Preview\n");
                                            using (StreamReader sr = File.OpenText("UserID" + userNameInputUpper + "_StudentAccount.txt"))
                                            {
                                                string s = "";
                                                while ((s = sr.ReadLine()) != null)
                                                {

                                                    Console.WriteLine(s);
                                                }

                                                Console.WriteLine("\nYour Student Account Was Successfully Exported.\nPress \"Y\" To Preview And Print A Summary Of All Library Resources.\nPress Any Other Key For The Main Menu\n");
                                                {
                                                    string restartAsString = Console.ReadLine();
                                                    userInput = NumberCheck(menuItem);
                                                    if (restartAsString.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                                                    {

                                                        StreamWriter writer2 = new StreamWriter("UserID" + userNameInputUpper + "_AvailableResources.txt");
                                                        using (writer2)
                                                        {
                                                            writer2.WriteLine("Resource Checkout System");
                                                            writer2.WriteLine("Resource List For User ID: " + userNameInputUpper + ", " + studentInfo.StudentInfo[userNameInputUpper]);
                                                            writer2.WriteLine("\r\n\r\nUnavailable Resources:\r\n");

                                                            foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                                            {
                                                                if (pair.Value != "AVAILABLE")
                                                                    writer2.WriteLine(pair.Key);
                                                            }
                                                            foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                                            {
                                                                if (pair.Value != "AVAILABLE")
                                                                    writer2.WriteLine(pair.Key);
                                                            }
                                                            foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                                            {
                                                                if (pair.Value != "AVAILABLE")
                                                                    writer2.WriteLine(pair.Key);
                                                            }
                                                            writer2.WriteLine("\r\n\r\nAvailable Resources:\r\n");


                                                            foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                                            {
                                                                if (pair.Value == "AVAILABLE")
                                                                    writer2.WriteLine(pair.Key);
                                                            }
                                                            foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                                            {
                                                                if (pair.Value == "AVAILABLE")
                                                                    writer2.WriteLine(pair.Key);
                                                            }
                                                            foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                                            {
                                                                if (pair.Value == "AVAILABLE")
                                                                    writer2.WriteLine(pair.Key);
                                                            }
                                                        }

                                                        Console.Clear();
                                                        Console.WriteLine("\nResource Book Summary\n");
                                                        using (StreamReader sr2 = File.OpenText("UserID" + userNameInputUpper + "_AvailableResources.txt"))
                                                        {
                                                            string s2 = "";
                                                            while ((s2 = sr2.ReadLine()) != null)
                                                            {
                                                                Console.WriteLine(s2);
                                                            }

                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Header();

                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }
                                                }

                                            }
                                            {
                                                Console.WriteLine();
                                                StringBldrLine();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Header();
                                                userInput = DoNext(menuItem);

                                                break;
                                            }
                                        }
                                        else
                                        {

                                            Console.Clear();
                                            Header();
                                            Console.WriteLine("\nYou Have No Books Checked Out");
                                            userInput = DoNext(menuItem);
                                            Console.Clear();
                                            Header();
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThat Is Not A Valid Entry");
                                        userInput = DoNext(menuItem);
                                        Console.Clear();
                                        Header();
                                        break;
                                    }
                                }
                                while (userInput == 5);
                                break;

                            case 7:
                                do
                                {
                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);

                                     StreamWriter writer4 = new StreamWriter("BooksFile.txt");
                                    using (writer4)
                                    {
                                        writer4.WriteLine("Books File:\r\n");
                                        writer4.WriteLine(book1.returnResourceInfo());
                                        writer4.WriteLine(book2.returnResourceInfo());
                                        writer4.WriteLine(book3.returnResourceInfo());

                                    }

                                    StreamWriter writer5 = new StreamWriter("MagazineFile.txt");
                                    using (writer5)
                                    {

                                        writer5.WriteLine("Magazine File:\r\n");
                                        writer5.WriteLine(magazine1.returnResourceInfo());
                                        writer5.WriteLine(magazine2.returnResourceInfo());
                                        writer5.WriteLine(magazine3.returnResourceInfo());
                                    }
                                    StreamWriter writer6 = new StreamWriter("DVDFile.txt");
                                    using (writer6)
                                    {

                                        writer6.WriteLine("DVD File:\r\n");
                                        writer6.WriteLine(dvd1.returnResourceInfo());
                                        writer6.WriteLine(dvd2.returnResourceInfo());
                                        writer6.WriteLine(dvd3.returnResourceInfo());


                                    }

                                    StreamWriter writer = new StreamWriter("All Resources.txt");
                                    using (writer)
                                    {

                                        writer.WriteLine("Resource List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (DVD)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Book)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Magazine)");
                                        }
                                    }
                                    Console.Clear();
                                    Header();
                                    int booksOut = 1;


                                    if ((magazineInfo.ResourceStatus.ContainsValue("AVAILABLE")) || (bookInfo.ResourceStatus.ContainsValue("AVAILABLE")) || (dvdInfo.ResourceStatus.ContainsValue("AVAILABLE")))
                                    {
                                        foreach (KeyValuePair<string, string> pair in studentInfo.StudentInfo)
                                        {
                                            Console.WriteLine(pair.Key + " " + pair.Value);
                                        }
                                        Console.WriteLine("\nEnter User Account Nbr To Begin Checkout\n\n");

                                        userNameInput = Console.ReadLine();
                                        NullOrWhiteSpace(userNameInput);
                                        userInput = NumberCheck(menuItem);
                                        userNameInputUpper = userNameInput.ToUpper();


                                        if (studentInfo.StudentInfo.ContainsKey(userNameInputUpper))
                                        {
                                            foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                {
                                                    booksOut = booksOut + 1;
                                                }
                                            }
                                            foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                {
                                                    booksOut = booksOut + 1;
                                                }
                                            }
                                            foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                {
                                                    booksOut = booksOut + 1;
                                                }
                                            }

                                            Console.Clear();
                                            Header();
                                            if (booksOut <= 3)

                                            {
                                                Console.Clear();
                                                Header();

                                                Console.WriteLine("Type The Number Of An Item To Check Out:");
                                                bookInfo.AvailableStatus.Clear();
                                                switchnbr = 1;

                                                Console.WriteLine("\nAvailable Resources:");
                                                foreach (KeyValuePair<string, string> pair in (dvdInfo.ResourceStatus))
                                                {
                                                    if (pair.Value == "AVAILABLE")
                                                    {
                                                        Console.WriteLine(switchnbr + ": " + pair.Key);
                                                        bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                                        switchnbr++;

                                                    }
                                                }

                                                foreach (KeyValuePair<string, string> pair in (magazineInfo.ResourceStatus))
                                                {
                                                    if (pair.Value == "AVAILABLE")
                                                    {
                                                        Console.WriteLine(switchnbr + ": " + pair.Key);
                                                        bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                                        switchnbr++;

                                                    }

                                                }

                                                foreach (KeyValuePair<string, string> pair in (bookInfo.ResourceStatus))
                                                {
                                                    if (pair.Value == "AVAILABLE")
                                                    {
                                                        Console.WriteLine(switchnbr + ": " + pair.Key);
                                                        bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                                        switchnbr++;

                                                    }

                                                }

                                                menuItemTemp = Console.ReadLine();
                                                int userIntInput = NumberCheck(menuItemTemp);
                                                if (bookInfo.AvailableStatus.ContainsKey(userIntInput))
                                                {
                                                    string tempResource = bookInfo.AvailableStatus[userIntInput];
                                                    if (book1.Title == (tempResource))
                                                    {
                                                        book1.Status = userNameInputUpper;
                                                        book1.DateDue = book1.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);

                                                        book1.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }

                                                    if (book2.Title == (tempResource))
                                                    {
                                                        book2.Status = userNameInputUpper;
                                                        book2.DateDue = book2.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);

                                                        book2.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }

                                                    if (book3.Title == (tempResource))
                                                    {
                                                        book3.Status = userNameInputUpper;
                                                        book3.DateDue = book3.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        book3.DueDate();

                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }

                                                    if (magazine1.Title == (tempResource))
                                                    {
                                                        magazine1.Status = userNameInputUpper;
                                                        magazine1.DateDue = magazine1.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        magazine1.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }
                                                    if (magazine2.Title == (tempResource))
                                                    {
                                                        magazine2.Status = userNameInputUpper;
                                                        magazine2.DateDue = magazine2.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        magazine2.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }
                                                    if (magazine3.Title == (tempResource))
                                                    {
                                                        magazine3.Status = userNameInputUpper;
                                                        magazine3.DateDue = magazine3.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        magazine3.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }

                                                    if (dvd1.Title == (tempResource))
                                                    {
                                                        dvd1.Status = userNameInputUpper;
                                                        dvd1.DateDue = dvd1.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        dvd1.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }
                                                    if (dvd2.Title == (tempResource))
                                                    {
                                                        dvd2.Status = userNameInputUpper;
                                                        dvd2.DateDue = dvd2.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        dvd2.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }
                                                    if (dvd3.Title == (tempResource))
                                                    {
                                                        dvd3.Status = userNameInputUpper;
                                                        dvd3.DateDue = dvd3.addDays();
                                                        Console.Clear();
                                                        Header();
                                                        Console.WriteLine(userNameInputUpper + " has checked out " + tempResource);
                                                        dvd3.DueDate();
                                                        userInput = DoNext(menuItem);
                                                        Console.Clear();
                                                        Header();
                                                        break;
                                                    }

                                                    Console.Clear();
                                                    Header();
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine("\nThat Is Not A Valid Entry");
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nUser ID: " + userNameInputUpper + " has checked out the maximum number of resources.");
                                                userInput = DoNext(menuItem);
                                                Console.Clear();
                                                Header();
                                                break;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\nThat Is Not A Valid Entry");
                                            userInput = DoNext(menuItem);
                                            Console.Clear();
                                            Header();
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nAll Resources Are Currently Unavailable");
                                        userInput = DoNext(menuItem);
                                        Console.Clear();
                                        Header();
                                        break;
                                    }
                                }
                                while (userInput == 7);
                                break;
                            case 6:
                                do
                                {
                                    dvdInfo.ResourceStatus.Clear();
                                    dvdInfo.ResourceStatus.Add(dvd1.Title, dvd1.Status);
                                    dvdInfo.ResourceStatus.Add(dvd2.Title, dvd2.Status);
                                    dvdInfo.ResourceStatus.Add(dvd3.Title, dvd3.Status);

                                    bookInfo.ResourceStatus.Clear();
                                    bookInfo.ResourceStatus.Add(book1.Title, book1.Status);
                                    bookInfo.ResourceStatus.Add(book2.Title, book2.Status);
                                    bookInfo.ResourceStatus.Add(book3.Title, book3.Status);

                                    magazineInfo.ResourceStatus.Clear();
                                    magazineInfo.ResourceStatus.Add(magazine1.Title, magazine1.Status);
                                    magazineInfo.ResourceStatus.Add(magazine2.Title, magazine2.Status);
                                    magazineInfo.ResourceStatus.Add(magazine3.Title, magazine3.Status);

                                    bookInfo.AvailableStatus.Clear();
                                   StreamWriter writer4 = new StreamWriter("BooksFile.txt");
                                    using (writer4)
                                    {
                                        writer4.WriteLine("Books File:\r\n");
                                        writer4.WriteLine(book1.returnResourceInfo());
                                        writer4.WriteLine(book2.returnResourceInfo());
                                        writer4.WriteLine(book3.returnResourceInfo());

                                    }

                                    StreamWriter writer5 = new StreamWriter("MagazineFile.txt");
                                    using (writer5)
                                    {

                                        writer5.WriteLine("Magazine File:\r\n");
                                        writer5.WriteLine(magazine1.returnResourceInfo());
                                        writer5.WriteLine(magazine2.returnResourceInfo());
                                        writer5.WriteLine(magazine3.returnResourceInfo());
                                    }
                                    StreamWriter writer6 = new StreamWriter("DVDFile.txt");
                                    using (writer6)
                                    {

                                        writer6.WriteLine("DVD File:\r\n");
                                        writer6.WriteLine(dvd1.returnResourceInfo());
                                        writer6.WriteLine(dvd2.returnResourceInfo());
                                        writer6.WriteLine(dvd3.returnResourceInfo());


                                    }

                                    StreamWriter writer = new StreamWriter("All Resources.txt");
                                    using (writer)
                                    {

                                        writer.WriteLine("Resource List:\r\n");

                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (DVD)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Book)");
                                        }

                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            writer.WriteLine(pair.Key + " (Magazine)");
                                        }
                                    }
                                    Console.Clear();
                                    Header();
                                    int booksOut = 0;
                                    int totalbookStatus = 0;

                                    //
                                    foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                    {
                                        if (pair.Value == "AVAILABLE")
                                        {
                                            totalbookStatus = totalbookStatus + 1;

                                        }
                                    }

                                    foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                    {
                                        if (pair.Value == "AVAILABLE")
                                        {
                                            totalbookStatus = totalbookStatus + 1;

                                        }
                                    }

                                    foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                    {
                                        if (pair.Value == "AVAILABLE")
                                        {
                                            totalbookStatus = totalbookStatus + 1;

                                        }
                                    }



                                    if (totalbookStatus < 9)
                                    {

                                        Console.WriteLine("\nEnter User Account Number To Begin Check In\n\n");

                                        foreach (KeyValuePair<string, string> pair in studentInfo.StudentInfo)
                                        {
                                            Console.WriteLine(pair.Key + " " + pair.Value);
                                        }

                                        userNameInput = Console.ReadLine();
                                        NullOrWhiteSpace(userNameInput);
                                        userInput = NumberCheck(menuItem);
                                        userNameInputUpper = userNameInput.ToUpper();

                                        foreach (KeyValuePair<string, string> pair in bookInfo.ResourceStatus)
                                        {
                                            if (pair.Value == userNameInputUpper)
                                            {
                                                booksOut = booksOut + 1;
                                            }
                                        }
                                        foreach (KeyValuePair<string, string> pair in magazineInfo.ResourceStatus)
                                        {
                                            if (pair.Value == userNameInputUpper)
                                            {
                                                booksOut = booksOut + 1;
                                            }
                                        }
                                        foreach (KeyValuePair<string, string> pair in dvdInfo.ResourceStatus)
                                        {
                                            if (pair.Value == userNameInputUpper)
                                            {
                                                booksOut = booksOut + 1;
                                            }
                                        }

                                        Console.Clear();
                                        Header();
                                        if (booksOut >= 1)

                                        {
                                            Console.Clear();
                                            Header();

                                            Console.WriteLine("Type The Number Of An Item To Check In:");
                                            bookInfo.AvailableStatus.Clear();
                                            switchnbr = 1;

                                            Console.WriteLine("\nChecked Out Resources:");
                                            foreach (KeyValuePair<string, string> pair in (dvdInfo.ResourceStatus))
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                {
                                                    Console.WriteLine(switchnbr + ": " + pair.Key);
                                                    bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                                    switchnbr++;

                                                }
                                            }

                                            foreach (KeyValuePair<string, string> pair in (magazineInfo.ResourceStatus))
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                {
                                                    Console.WriteLine(switchnbr + ": " + pair.Key);
                                                    bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                                    switchnbr++;

                                                }

                                            }

                                            foreach (KeyValuePair<string, string> pair in (bookInfo.ResourceStatus))
                                            {
                                                if (pair.Value == userNameInputUpper)
                                                {
                                                    Console.WriteLine(switchnbr + ": " + pair.Key);
                                                    bookInfo.AvailableStatus.Add(switchnbr, pair.Key);
                                                    switchnbr++;

                                                }

                                            }
                                            // /////////////////////////////////////////////////////////////////////////////////////////////
                                            menuItemTemp = Console.ReadLine();
                                            int userIntInput = NumberCheck(menuItemTemp);


                                            if (bookInfo.AvailableStatus.ContainsKey(userIntInput))
                                            {
                                                string tempResource = bookInfo.AvailableStatus[userIntInput];
                                                if (book1.Title == (tempResource))
                                                {
                                                    book1.Status = "AVAILABLE";

                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }

                                                if (book2.Title == (tempResource))
                                                {
                                                    book2.Status = "AVAILABLE";

                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }

                                                if (book3.Title == (tempResource))
                                                {
                                                    book3.Status = "AVAILABLE";
                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }

                                                if (magazine1.Title == (tempResource))
                                                {
                                                    magazine1.Status = "AVAILABLE";
                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }
                                                if (magazine2.Title == (tempResource))
                                                {
                                                    magazine2.Status = "AVAILABLE";
                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }
                                                if (magazine3.Title == (tempResource))
                                                {
                                                    magazine3.Status = "AVAILABLE";
                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }

                                                if (dvd1.Title == (tempResource))
                                                {
                                                    dvd1.Status = "AVAILABLE";

                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }
                                                if (dvd2.Title == (tempResource))
                                                {
                                                    dvd2.Status = "AVAILABLE";

                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }
                                                if (dvd3.Title == (tempResource))
                                                {
                                                    dvd3.Status = "AVAILABLE";

                                                    Console.Clear();
                                                    Header();
                                                    Console.WriteLine(userNameInputUpper + " has checked in " + tempResource);
                                                    userInput = DoNext(menuItem);
                                                    Console.Clear();
                                                    Header();
                                                    break;
                                                }

                                                Console.Clear();
                                                Header();
                                                userInput = DoNext(menuItem);
                                                Console.Clear();
                                                Header();
                                                break;

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Header();
                                                Console.WriteLine("\nThat Is Not A Valid Entry");
                                                userInput = DoNext(menuItem);
                                                Console.Clear();
                                                Header();
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nUser ID: " + userNameInputUpper + " has no resources checked out.");
                                            userInput = DoNext(menuItem);
                                            Console.Clear();
                                            Header();
                                            break;
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine("\nNo Resources Are Currently Checked Out");
                                        userInput = DoNext(menuItem);
                                        Console.Clear();
                                        Header();
                                        break;
                                    }
                                }
                                while (userInput == 6);
                                break;

                            case 8://Exit
                                {
                                    Console.WriteLine("\nAre you sure you want to exit? \nPress \"N\" to restart program\nPress any other key to exit");
                                    string restartAsString = Console.ReadLine();

                                    if (restartAsString.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        caseRestart++;
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        restart = false;
                                        Console.Clear();
                                        Console.WriteLine("GoodBye");
                                        Thread.Sleep(1000);
                                        Environment.Exit(0);
                                    }
                                    break;

                                }

                            default:
                                {
                                    Console.WriteLine("\nThat is not a Valid Entry");
                                    userInput = DoNext(menuItem);
                                    Console.Clear();
                                    Header();
                                    break;
                                }

                        }
                    }

                }
            } while (restart == true);
        }
        // //////////////////////////////////////////////////////////////////////////////////////////////


        static void Header()
        {
         
            string title = "RESOURCES MENU";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title + "\n\n", Console.Title);


            Console.WriteLine("Main Menu\n1: View All Resources\n2: View Available Resources\n3: Edit Resources\n4: View All Students\n5: View Student Accounts\n6: Check In Resource\n7: Check Out Resource\n8: Exit");
            
            StringBldrLine();
        }
                //////////////////////////////////////////StringBldrLine METHOD/////////////////////////////////////////////////////////////////
                static void StringBldrLine()
        {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("*");
                    for (int i = 1; i <= 79; i++)
                    {
                        sb.Append("*");
                    }
                    Console.WriteLine(sb);
                }
        ///////////////////////////////////////////////////////////////////Number Check Method///////////////////////////////////////////

        static int NumberCheck(string input)
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
        static int DoNext(string menuItem)

        {
            int userInput;
            Console.WriteLine("\nWhat would you like to do next? Choose From the Main Menu:");
            menuItem = Console.ReadLine();

            userInput = NumberCheck(menuItem);

            return userInput;



        }
                                           // /////////////////////////////////////////////////NullOrWhiteSpace Method /////////////////////////

        static void NullOrWhiteSpace(string stringInput)
        {
            bool a;

            a = string.IsNullOrWhiteSpace(stringInput);

            if (a == true)
            {
                Console.WriteLine("Error: Request Unavailable");

            }

        }
    

    }
}

