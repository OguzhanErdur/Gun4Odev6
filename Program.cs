using System;

namespace Gun4Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> student = new MyDictionary<string, int>();

            student.Add("Ahmet",123);
            student.Add("Mehmet",321);
            student.Add("Kamil", 789);

         
        }
    }
}
