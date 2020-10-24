using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;


namespace COMP1202_S20_Assg2_VickySuPao
{


    //COMP1202 Assignment 2
    //Group Assignment by Su, Vicky and Paolo

    //Student1 Name : Paolo Tous
    //Student1 ID : 101325245

    //Student2 Name : Su Su Aye Aung
    //Student2 ID : 101296632

    //Student3 Name : Ke (Vicky) Wang
    //Student3 ID : 101270848
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;
            String firstName;
            String lastName;
            
            double gpa;
            String major;
            String phone = "0";
            bool isFalse = false;
            String birthDate;
            String year;
            int intYear;
            String month;
            int intMonth;
            String day;
            int intDay;
            bool isBirth = false;
            int ans;

            WriteLine("How many students would you like to add? Press 0 to skip the step: ");
            counter = Convert.ToInt32(ReadLine());

            Student[] studentList = new Student[counter];
            Student[] studentList2 = StudentIO.GetStudents();

            try
            {
                if (studentList2.Length > 0)
                {
                    for (int i = 0; i < studentList2.Length; i++)
                    {
                        studentList2[i].GenerateID();
                    }
                }
            } catch(NullReferenceException ex)
            {

            }

            //Looping to start the process of adding data for each student
            for(int i = 0; i < studentList.Length; i++)
            {
                WriteLine("Please enter the data for Student " + (i + 1));
                WriteLine("Loading Info Page ... ");

                Write("First Name :       ");
                firstName = ReadLine();

                Write("Last Name :       ");
                lastName = ReadLine();

                Write("GPA :       ");
                gpa = Convert.ToDouble(ReadLine());

                Write("Area of study :       ");
                major = ReadLine();

                WriteLine("Please enter your date of birth after reading the next line");
                do
                {
                    //Validations in process
                    Write("Please enter the year : ");
                    year = ReadLine();
                    int.TryParse(year, out intYear);
                    if (!Regex.IsMatch(year, @"^[a-zA-Z]+$") && year.Length == 4 && intYear < 2021)
                    {
                        isBirth = true;
                    }

                    else
                    {
                        WriteLine("Invalid year");
                        isBirth = false;
                    }
                }
                while (isBirth == false);

                do
                {
                    Write("Please enter your 2 digit month (for example 08 for August) : ");
                    month = ReadLine();
                    int.TryParse(month, out intMonth);
                    if (!Regex.IsMatch(month, @"^[a-zA-Z]+$") && month.Length == 2 && intMonth < 13 && intMonth > 0)
                    {
                        isBirth = true;
                    }
                    else
                    {
                        WriteLine("Invalid. Please insert a valid month");
                        isBirth = false;
                    }
                }
                while (isBirth == false);

                do
                {
                    Write("Please enter the day : ");
                    day = ReadLine();
                    int.TryParse(day, out intDay);
                    if (!Regex.IsMatch(day, @"^[a-zA-Z]+$") && day.Length == 2 && intDay < 32)
                    {
                        isBirth = true;
                    }
                    else
                    {
                        WriteLine("Invalid. Please insert the correct day");
                        isBirth = false;
                    }
                } while (isBirth == false);

                birthDate = year + "-" + month + "-" + day; 

                while (isFalse == false)
                {
                    Write("Phone number :       ");
                    phone = ReadLine();
                    if (!Regex.IsMatch(phone, @"^[a-zA-Z]+$") && phone.Length == 10)
                    {
                        isFalse = true;
                    }
                    else
                    {
                        WriteLine("Invalid. Please insert your 10 digit phone number");
                    }
                }

                studentList[i] = new Student(firstName, lastName, gpa, major, phone, birthDate);
                studentList[i].GenerateID();  //This will generate a new ID for every student created
                isFalse = false;

                WriteLine("Writing student data ... ");
                StudentIO.WriteStudent(studentList[i]);   //Writing Student data
                WriteLine("Student saved!");
            }

            studentList2 = StudentIO.GetStudents();      //Getting student data
            WriteLine("Here is a list of our students : ");
            
            PrintList(studentList2);                    //Printing student data
            WriteLine("Press any key to continue");
            ReadKey();

            WriteLine("Would you like to modify? press 1 if yes \n Would you like to search? press 2 if yes \n Would you like to sort? press 3 if yes");
            ans = Convert.ToInt32(ReadLine());
            if(ans == 1)
            {
                
                WriteLine("Please enter the ID");
                int id = Convert.ToInt32(ReadLine());
                StudentUtil.ModifyBySID(studentList2, id);  //Call the method that can modify the student data based on ID
                if (studentList2[0] == null)
                {
                    PrintOne(studentList2[0]);
                }
                else
                {
                    PrintList(studentList2);
                }
                ReadKey();
            }

            else if(ans == 2)
            {
                WriteLine("Enter 1 to search by ID");
                WriteLine("Enter 2 to search by Major");
                WriteLine("Enter 3 to search by GPA");
                String number = ReadLine();
                if (number == "1")
                {
                    WriteLine("Please insert the ID to search for");
                    int num = Convert.ToInt32(ReadLine());
                    studentList2[0] = StudentUtil.SearchBySID(studentList2, num); //Call the method that can search for the student by ID
                    if(studentList2[0] == null)
                    {
                        WriteLine("\n Sorry. No students found with the ID number you are searching for.");
                    }
                    else
                    {
                        PrintOne(studentList2[0]);
                    }

                    ReadKey();
                }
                else if(number == "2")
                {
                    WriteLine("Please insert the Major");
                    String maj = ReadLine();
                    studentList2[0] = StudentUtil.SearchByMajor(studentList2, maj);  //Call the method that can search for the student by maj
                    if (studentList2[0] == null)
                    {
                        WriteLine("\n Sorry. No student found with the major you are searching for.");
                    }
                    else
                    {
                        PrintOne(studentList2[0]);
                    }
                    ReadKey();
                }

                else if(number == "3")
                {
                    WriteLine("Please insert the GPA");
                    double gpas = Convert.ToDouble(ReadLine());
                    studentList2[0] = StudentUtil.SearchByGPA(studentList2, gpas); //Call the method that can search for the student by GPA
                    if (studentList2[0] == null)
                    {
                        WriteLine("\n Sorry. No students found with the GPA you are searching for.");
                    }
                    else
                    {
                        PrintOne(studentList2[0]);
                    }
                    ReadKey();
                }
                else
                {
                    WriteLine("Please choose the valid option.");
                }
            }

            else if(ans == 3)
            {
                WriteLine("Press 1 to sort by First Name");
                WriteLine("Press 2 to sort by Last Name");
                WriteLine("Press 3 to sort by GPA");
                String choice = ReadLine();
                if(choice == "1")
                {
                    StudentSort.SortByFirstName(studentList2);       //Sort by first name
                    PrintList(studentList2);
                }
                //StudentSort.GetStudentsOrderBy(studentList2);
                //PrintList(studentList2);

                else if(choice == "2")
                {
                    StudentSort.SortByLastName(studentList2);         //Sort by last name
                    PrintList(studentList2);
                }

                else if(choice == "3")
                {
                    StudentSort.SortByGPA(studentList2);            //Sort by GPA
                    PrintList(studentList2);
                }
                else
                {
                    WriteLine("Invalid Choice. Please try again later");
                }
                
                ReadKey();
            }

            else
            {
                WriteLine("Thank you for choosing Toronto College!");
                ReadKey();
            }
        }

        public static void PrintList(Student[] students)
        {
            foreach(Student student in students)
            {
                WriteLine(student);
            }
        }   //Printing all students

        public static void PrintOne(Student student)
        {
            WriteLine(student);
        }     //Printing one student
    }
}
