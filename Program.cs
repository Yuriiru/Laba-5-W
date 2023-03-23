using Reader_Namespace;
using Student_Namespace;

namespace Student_Namespace
{
    public class Student
    {

        public string Fio;
        public string group;
        private int age;

        public Student(string Fio, string group, int age)
        {
            this.Fio = Fio;
            this.group = group;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine("фамилия" + Fio + "группа" + group + "возраст" + age);
        }
    }
}
namespace Reader_Namespace
{
    public class Reader
    {
        private string fio;
        public int numberReadTick;
        public string faculty;
        private string bd;
        public string telephone;

        public Reader(string fio, int numberReadTick, string faculty, string bd, string telephone)
        {
            this.fio = fio;
            this.numberReadTick = numberReadTick;
            this.faculty = faculty;
            this.bd = bd;
            this.telephone = telephone;
        }

        public void takeBook(int numberBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, numberBook);
        }

        public void takeBook(string namesBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, namesBook);
        }

        public void returnBook(int numberBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, numberBook);
        }

        public void returnBook(string namesBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, namesBook);
        }
    }
}
namespace laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Русинов Ю. А.","20ИТ17", 19),
                new Student("Жирнова Е. А.", "20ИТ17", 18),
                new Student("Марусик М. А.","20ИТ17", 19)
            };

            Reader[] libraryUsers =
            {
                new Reader("Русинов Ю. А.",8395883 , "Программирование", "22.02.04","89095638858"),
                new Reader("Жирнова Е. А.",63754845 , "Моделирование", "10.06.04","8994738836"),
                new Reader("Марусик М. А.", 23756347, "Экология", "17.01.04","89635683400")
            };

          
        }
    }
}
