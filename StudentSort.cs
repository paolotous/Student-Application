using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace COMP1202_S20_Assg2_VickySuPao
{
    class StudentSort
    {
        public static Student[] GetStudentsOrderBy(Student[] students)
        {
            int sortTypeNumber;
            Student temp;
            bool isValid = false;
            bool isValid2 = false;
            bool isValid3 = false;

            String sortType;

            
                WriteLine("Please enter the number you want to sort？\n 1. First Name \n 2. Last Name \n 3. GPA ");
                sortTypeNumber = Convert.ToInt32(ReadLine());

                if (sortTypeNumber == 1)
                {
                    WriteLine("Please choose the number you want to sort: \n 1. ascending \n 2. decending ");
                    sortType = ReadLine();
                    if (sortType == "1")
                    {
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = i + 1; j < students.Length; j++)
                            {
                                if (students[i].FirstName.CompareTo(students[j].FirstName) > 0)
                                {
                                    students[i] = students[i];
                                    temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                    

                                }
                            }
                        }
                    }
                    else if (sortType == "2")
                    {
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = i + 1; j < students.Length; j++)
                            {
                                if (students[i].FirstName.CompareTo(students[j].FirstName) < 0)
                                {
                                    temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                    

                                }
                            }
                        }
                    }
                    else
                    {
                        WriteLine("Please choose the valid option.");
                        
                        return null;
                    }
                    return students;
                }
                else if (sortTypeNumber == 2)
                {
                    WriteLine("Please choose the number you want to sort: \n 1. ascending \n 2. descending ");
                    sortType = ReadLine();
                    if (sortType == "1")
                    {
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = i + 1; j < students.Length; j++)
                            {
                                if (students[i].LastName.CompareTo(students[j].LastName) > 0)
                                {
                                    temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                    

                                }
                            }
                        }
                    }
                    else if (sortType == "2")
                    {
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = i + 1; j < students.Length; j++)
                            {
                                if (students[i].LastName.CompareTo(students[j].LastName) < 0)
                                {
                                    temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                    

                                }
                            }
                        }
                    }
                    else
                    {
                        WriteLine("Please choose the valid option");
                        


                    }
                    return students;
                }
                else if (sortTypeNumber == 3)
                {
                    WriteLine("Please choose the number you want to sort: \n 1. higher \n 2. lower ");
                    sortType = ReadLine();
                    if (sortType == "1")
                    {
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = i + 1; j < students.Length; j++)
                            {
                                if (students[i].Gpa < students[j].Gpa)
                                {
                                    temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                    


                                }
                            }
                        }
                    }
                    else if (sortType == "2")
                    {
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = i + 1; j < students.Length; j++)
                            {
                                if (students[i].Gpa > students[j].Gpa)
                                {
                                    temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                    


                                }
                            }
                        }
                    }
                    else
                    {
                        WriteLine("Please choose the valid option.");
                        

                    }
                    return students;
                }
                else
                {
                    WriteLine("Please choose the valid option.");
                    
                    return null;
                }

            
            }  //Prototype method --- No Longer needed.

        public static Student[] SortByFirstName(Student[] students)
        {
            Student temp;
            String sortType;
            bool isValid = false;

            do
            {
                WriteLine("Press 1 to sort in Ascending order");
                WriteLine("Press 2 to sort in Descending order");
                sortType = ReadLine();

                if (sortType == "1")
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        for (int j = i + 1; j < students.Length; j++)
                        {
                            if (students[i].FirstName.CompareTo(students[j].FirstName) > 0)
                            {
                                students[i] = students[i];
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    isValid = true;
                }

                else if (sortType == "2")
                {
                    for (int i = 0; i < students.Length - 1; i++)
                    {
                        for (int j = i + 1; j < students.Length; j++)
                        {
                            if (students[i].FirstName.CompareTo(students[j].FirstName) < 0)
                            {
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                                
                            }
                        }
                    }
                    isValid = true;
                }

                else
                {
                    WriteLine("Please insert a valid option");
                    isValid = false;
                }
            } while (isValid == false);

            return students;
        }   //Method to sort by first names

        public static Student[] SortByLastName(Student[] students)
        {
            Student temp;
            String sortType;
            bool isValid = false;

            do
            {
                WriteLine("Press 1 to sort in Ascending order");
                WriteLine("Press 2 to sort in Descending order");
                sortType = ReadLine();

                if (sortType == "1")
                {
                    for (int i = 0; i < students.Length - 1; i++)
                    {
                        for (int j = i + 1; j < students.Length; j++)
                        {
                            if (students[i].LastName.CompareTo(students[j].LastName) > 0)
                            {
                                
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    isValid = true;
                }

                else if (sortType == "2")
                {
                    for (int i = 0; i < students.Length - 1; i++)
                    {
                        for (int j = i + 1; j < students.Length; j++)
                        {
                            if (students[i].LastName.CompareTo(students[j].LastName) < 0)
                            {
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    isValid = true;
                }

                else
                {
                    WriteLine("Please insert a valid option");
                    isValid = false;
                }
            } while (isValid == false);

            return students;


        }  //Method to sort by last names

        public static Student[] SortByGPA(Student[] students)
        {
            Student temp;
            String sortType;
            bool isValid = false;

            do
            {
                WriteLine("Press 1 to sort by Lower");
                WriteLine("Press 2 to sort by Higher");
                sortType = ReadLine();

                if (sortType == "2")
                {
                    for (int i = 0; i < students.Length - 1; i++)
                    {
                        for (int j = i + 1; j < students.Length; j++)
                        {
                            if (students[i].Gpa < students[j].Gpa)
                            {
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }

                    isValid = true;
                }

                else if (sortType == "1")
                {
                    for (int i = 0; i < students.Length - 1; i++)
                    {
                        for (int j = i + 1; j < students.Length; j++)
                        {
                            if (students[i].Gpa > students[j].Gpa)
                            {
                                temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }
                    isValid = true;
                }

                else
                {
                    WriteLine("Please insert a valid option");
                    isValid = false;
                }
            } while (isValid == false);

            return students;
        }   //Method to sort by GPAs
        
    }
}
