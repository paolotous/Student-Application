using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1202_S20_Assg2_VickySuPao
{
    class Student
    {

        public static int studentID = 10000;
        //public String studentID;
        private String firstName;
        private String lastName;
        private double gpa;
        private String major;
        private String phone;
        private String birthDate;
        private int id;

        public int Id
        {
            get;
            set;
        }


        public String BirthDate
        {
            get;
            set;
        }

        public String Phone
        {
            get;
            set;
        }
        public String Major
        {
            get;
            set;
        }
        public int StudentID
        {

            set
            {
                studentID = value;
            }

            get
            {
                return studentID;
            }
        }

        public void GenerateID()
        {
            studentID += 1;
        }

        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        
        public double Gpa
        {
            get
            {
                return gpa;
            }

            set
            {
                if(value < 0 || value > 4.0)
                {
                    gpa = 0;
                }

                else
                {
                    gpa = value;
                }
            }
            
        }


        public Student()
        {

        }

        public Student(int SID, String fName, String lName)
        {
            StudentID = SID;
            FirstName = fName;
            LastName = lName;
        }

        public Student(String fName, String lName, double GPA, String maj, String tel, String birth)
        {
            //StudentID = SID;
            FirstName = fName;
            LastName = lName;
            Gpa = GPA;
            Major = maj;
            Phone = tel;
            BirthDate = birth;
            //GenerateID();
        }


        public override string ToString()
        {
            String data = "Student ID =======> " + Id + "\n";
            data += "First Name =======> " + FirstName + "\n";
            data += "Last Name =======> " + LastName + "\n";
            data += "GPA =======> " + Gpa + "\n";
            data += "Area of Study =======> " + Major + "\n";
            data += "Phone number =======> " + Phone + "\n";
            data += "Date of Birth =======> " + BirthDate + "\n";

            return data;
        }


    }
}
