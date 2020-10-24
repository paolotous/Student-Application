using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace COMP1202_S20_Assg2_VickySuPao
{
    class StudentUtil
    {
       public static Student ModifyBySID(Student[] students, int id)
        {
             String sid = Convert.ToString(id);
            Student[] studentList2 = students;
            studentList2[0] = SearchBySID(studentList2, id);
            if (studentList2[0] == null)
            {
                WriteLine("\n You are entered invalid Student ID.");
                return null;
            }
            else
            {
                WriteLine("Please enter the number you want to modify.");
                WriteLine("1. Student ID");
                WriteLine("2. First Name");
                WriteLine("3. Last Name");
                WriteLine("4. Major");
                WriteLine("5. Phone");
                WriteLine("6. GPA");
                WriteLine("7. Date of Birth");

                String num = ReadLine();

                if (num == "1")
                {
                    WriteLine("Please enter the updated Student ID");
                    String updateID = ReadLine();
                    studentList2[0].Id = Convert.ToInt32(updateID);
                    students[0] = studentList2[0];
                }

                else if (num == "2")
                {
                    WriteLine("Please enter the updated First Name");
                    String updatefname = ReadLine();
                    studentList2[0].FirstName = updatefname;
                    students[0] = studentList2[0];
                }

                else if (num == "3")
                {
                    WriteLine("Please enter the updated Last Name");
                    String updatelname = ReadLine();
                    studentList2[0].LastName = updatelname;
                    students[0] = studentList2[0];
                }

                else if (num == "4")
                {
                    WriteLine("Please enter the updated Major");
                    String updatemajor = ReadLine();
                    studentList2[0].Major = updatemajor;
                    students[0] = studentList2[0];
                }

                else if (num == "5")
                {
                    WriteLine("Please enter the updated phone number");
                    String updatephone = ReadLine();
                    studentList2[0].Phone = updatephone;
                    students[0] = studentList2[0];

                }

                else if (num == "6")
                {
                    WriteLine("Please enter the updated GPA");
                    double updategpa = Convert.ToDouble(ReadLine());
                    studentList2[0].Gpa = updategpa;
                    students[0] = studentList2[0];
                }

                else if (num == "7")
                {
                    WriteLine("Please enter the updated date of birth");
                    String updatebirth = ReadLine();
                    studentList2[0].BirthDate = updatebirth;
                    students[0] = studentList2[0];
                }

                else
                {
                    WriteLine("You have entered an invalid option");
                }

                return students[0];
            }         
        }   //Method to modify info by using ID to grant access

       public static Student SearchBySID(Student[] students, int id)
        {
            String sid = Convert.ToString(id);
            bool found = false;
            int index = -1;

            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].Id.Equals(id))
                {
                    found = true;
                    index = i;
                }
            }

            if (found)
            {
                return students[index];
            }
            else
            {
                return null;
            }

        }   //Search for a specific student by ID

       public static Student SearchByMajor(Student[] students, String major)
        {
            bool found = false;
            int index = -1;

            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].Major.Equals(major))
                {
                    found = true;
                    index = i;
                }
            }
            if (found)
            {
                return students[index];
            }
            else
            {
                return null;
            }
        }  //Search for a specific student by major

       public static Student SearchByGPA(Student[] students, double gpas)
        {
            bool found = false;
            int index = -1;

            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].Gpa.Equals(gpas))
                {
                    found = true;
                    index = i;
                }
            }
            if (found)
            {
                return students[index];
            }
            else
            {
                return null;
            }
        }  //Search for a specific student by GPA


    }
}
