using System;

namespace Arrays__Books_
{
    class Book
    {
        private string author;
        private string code;
        private string name;
        private int year;
        public Book(string author, string code, string name, int year)
        {
            Author = author;
            Code = code;
            Name = name;
            Year = year;
        }
        public Book() : this("No author", "No code", "Noname", 0) { }
        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public void setValues(string author, string code, string name, int year)
        {
            this.author = author;
            this.code = code;
            this.name = name;
            this.year = year;
        }

        public override string ToString()
        {
            return ($"Author : {author}, Code : {code}, Name : {name}, Year : {year}");
        }
    }
    class Library
    {
        private Book[] books = null;

        public void Add(int index, string author, string code, string name, int year)
        {
            if (books.Length <= index)
            {
                books[index] = new Book(author, code, name, year);
            }
            else {
                Array.Resize(ref books, index);
                books[index] = new Book(author, code, name, year);
            }   
        }

        public void Print()
        {
            foreach (var elem in books)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public void Sort()
        {
            Array.Sort(books);
        }

        public int findIndex(/*this T[] array,*/ string item)
        {
            return Array.FindIndex(books, val => val.Equals(item));
        }
    }
    class Program
    {
        static void Main()
        {
            Library lib = new Library();
            lib.Add(0, "lO", "12", "nAME", 2000);
            lib.Print();
            
        }
    }
}
