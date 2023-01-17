using System;
//Robert Kajanti
namespace AbstractiTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija a;
            Henkilö b;
            Opiskelija Opiskelija1 = new Opiskelija();
            Henkilö opiskelijahenkilö = new Opiskelija();
            a = Opiskelija1;
            b = Opiskelija1;
            b = opiskelijahenkilö;

            Console.WriteLine(Opiskelija1.GetType());
            Console.WriteLine(opiskelijahenkilö.GetType());

        }
    }
}
