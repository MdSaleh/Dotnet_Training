using System.Collections;

namespace sample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] StudentNumbers = new int[50];
            //for (int i = 0; i < StudentNumbers.Length; i++) {
            //    StudentNumbers[i] = Console.Read();
            //}

            //array list
            //ArrayList studentsListwithMarks = new ArrayList();  
            //for(int i = 0; i< 5; i++)
            //{
            //    var studentdetails  = Console.ReadLine();
            //    studentsListwithMarks.Add(studentdetails);
            //}
            //for (int i = 0; i < studentsListwithMarks.Count; i++)
            //{
            //    Console.WriteLine(studentsListwithMarks[i]);
            //}


            List<studentDetails> studentDetails = new List<studentDetails>();
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);
            studentDetails.Add(new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10);

            foreach (var student in studentDetails) 
            {
               Console.WriteLine(student.name);
                Console.WriteLine(student.usn);
            }

            //select class;
            int selectedClass = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, studentDetails> StudentDictionayDetails = new Dictionary<int, studentDetails>();
            StudentDictionayDetails.Add(1, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(1, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(1, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(1, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(1, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(2, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(2, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(2, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(2, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(3, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(3, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(3, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(3, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });
            StudentDictionayDetails.Add(3, new studentDetails { marks = [10, 20, 30, 45, 50], name = "saleha", usn = 10 });

            foreach( var student in StudentDictionayDetails )
            {
                if(student.Key == selectedClass)
                {
                    Console.WriteLine(student.Value);
                }
            }

        }

        public class studentDetails
        {
            public int usn {  get; set; }
            public string name { get; set; }
            public int[] marks {  get; set; }
        }

    }
}
