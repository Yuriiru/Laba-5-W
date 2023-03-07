using System;
using Student_Namespace;
using Reader_Namespace;

namespace Student_Namespace{
    class Student
    {
        public string FIO;
        public string Group_Number;
        private int Age;

        public Student(string fIO, string group_Number, int age)
        {
            this.FIO = fIO;
            this.Group_Number = group_Number;
            this.Age = age;
        }
    }

}

namespace Reader_Namespace
{
    class Reader
    {
        private string FIO;
        public int library_card_number;
        public string faculty;
        private int Age;
        public long Phone_Number;

        public Reader(string fIO, int library_card_number, string faculty, int age, long phone_Number)
        {
            this.FIO = fIO;
            this.library_card_number = library_card_number;
            this.faculty = faculty;
            this.Age = age;
            this.Phone_Number = phone_Number;
        }

        public void takeBook(int number_of_books)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), FIO, number_of_books);
        }

        public void takeBook(string[] names_books)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), FIO, names_books);
        }

        public void returnBook(int number_of_books)
        {
            Console.WriteLine(String.Format("{0} ввернул {1} книг(и)"), FIO, number_of_books);
        }
        public void returnBook(string[] names_books)
        {
            Console.WriteLine(String.Format("{0} вернул {1} книг(и)"), FIO, names_books);
        }

    }
}
namespace Laba5_W
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] students =
            {
                new Student("Васичкин А. И.", "21РТ31", 18),
                new Student("Галич З. В.", "21РТ31", 18),
                new Student("Зиманов И. Г.", "21РТ31", 18) 
            };

            Reader[] library_users =
            {
                new Reader("Васичкин А. И.", 1001230075, "Науки и техники", 18, 89278523561),
                new Reader("Галич З. В.", 1001220075, "Науки и техники", 18, 89278534546),
                new Reader("Зиманов И. Г.", 1001210075, "Науки и техники" , 18, 89278435561)
            };

        }
    }
}
