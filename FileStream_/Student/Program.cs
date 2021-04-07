using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Student_
{
    class Student
    {
        private string name;
        private int course;
        private List<int> marks;
        public override string ToString()
        {
            return $"Name : {Name}, Course : {Course}, Marks : {Marks}";
        }
        public Student(int course, string name, List<int> marks)
        {
            Name = name;
            Course = course;
            Marks = marks;
        }
        public Student() : this(1, "Noname", null) { }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Course
        {
            get => course;
            set
            {
                //if (course > 0 && course < 6)
                //{
                //    course = value;
                //}
                //else
                //{
                //    throw new IndexOutOfRangeException("Out of course range exception (from 1 to 5 course).");
                //}
                course = value;
            }
        }
        public List<int> Marks
        {
            get => marks;
            set
            {
                marks = value;
            }
        }
    }
    static class StudentFS
    {
        public static void StudentWrite(Student student, string fname)
        {
            {
                byte[] bytes = BitConverter.GetBytes(student.Course);
                using (FileStream fs = new FileStream(fname, FileMode.Create))
                {
                    fs.Write(bytes);
                }
            }
            {
                byte[] bytes = Encoding.UTF8.GetBytes(student.Name);
                byte len = (byte)bytes.Length;
                using (FileStream fs = new FileStream(fname, FileMode.Append))
                {
                    fs.WriteByte(len);
                    fs.Write(bytes);
                }
            }
            {
                byte[] bytes = null;
                using (FileStream fs = new FileStream(fname, FileMode.Append))
                {
                    for (int i = 0; i < student.Marks.Count; i++)
                    {
                        bytes = BitConverter.GetBytes(student.Marks[i]);
                        fs.Write(bytes);
                    }
                }
            }
        }
        public static Student StudentRead(Student student, string fname)
        {
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                byte count = (byte)fs.ReadByte();
                byte[] bytes = new byte[count];
                fs.Read(bytes);
                student.Name = Encoding.UTF8.GetString(bytes);

                byte[] course = new byte[sizeof(int)];
                fs.Read(course);
                student.Course = BitConverter.ToInt32(course);

                byte len = (byte)fs.ReadByte();
                List<int> list = new List<int>();
                for (int i = 0; i < len; i++)
                {
                    byte[] tmp = new byte[sizeof(int)];
                    fs.Read(tmp);
                    list.Add(BitConverter.ToInt32(tmp));
                }
                student.Marks = list;
                return student;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<int> list = new List<int>() { 6, 5, 10 };
                Student student = new Student(2, "Student 1", list);
                StudentFS.StudentWrite(student, "note.dat");
                Console.WriteLine(StudentFS.StudentRead(student, "note.dat"));
            }
        }
    }
}
