using System;

namespace Additional_Features
{
    public class MyClass
    {
        public string filmName;
        public const string film = "Tenet";
        public MyClass() : this(film) { }

        public MyClass(string newFlimName)
        {
            var newName = newFlimName;
            filmName = newName;
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.filmName);
        }
    }
}
