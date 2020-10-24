using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace COMP1202_S20_Assg2_VickySuPao
{
    class StudentIO
    {
        public static void WriteStudent(Student s)
        {
            StreamWriter fileOutput;
            String studentData = s.StudentID + ":" + s.FirstName + ":" + s.LastName + ":" + s.Gpa +":" + s.Major + ":" + s.Phone + ":" + s.BirthDate;

            try
            {
                using(fileOutput = new StreamWriter(@"data.txt", true))
                {
                    fileOutput.WriteLine(studentData);
                }
            }

            catch(IOException exc)
            {
                WriteLine("Cannot write to file\n" + exc.Message);
            }
        } //Writing student data to a file


        public static Student[] GetStudents()
        {
            Student[] studentList;
            int studentCount = 0;
            StreamReader fileInput;
            String studentData;
            String[] studentDataArray = new string[7];
            if (File.Exists(@"data.txt"))
            {
                try
                {
                    using(fileInput = new StreamReader(@"data.txt"))
                    {
                        while((studentData = fileInput.ReadLine()) != null)
                        {
                            ++studentCount;
                        }
                    }

                    studentList = new Student[studentCount];

                    using(fileInput = new StreamReader(@"data.txt"))
                    {
                        for(int i = 0; i < studentCount; i++)
                        {
                            studentData = fileInput.ReadLine();
                            studentList[i] = new Student();
                            studentDataArray = studentData.Split(':');
                            studentList[i].Id = Convert.ToInt32(studentDataArray[0]);
                            studentList[i].FirstName = studentDataArray[1];
                            studentList[i].LastName = studentDataArray[2];
                            studentList[i].Gpa = Convert.ToDouble(studentDataArray[3]);
                            studentList[i].Major = studentDataArray[4];
                            studentList[i].Phone = studentDataArray[5];
                            studentList[i].BirthDate = studentDataArray[6];
                           
                                
                      }
                    }

                   
                    return studentList;
                }

                catch(IOException exc)
                {
                    WriteLine("Cannot write to file \n" + exc.Message);
                    return null;
                }
            }
            else
            {
                WriteLine("File not found.\nCreating a new file ... ");
                return null;
            }

            
          

            
        }  //Reading student data from a file
    }
}
