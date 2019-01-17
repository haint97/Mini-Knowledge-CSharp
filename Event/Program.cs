using System;

namespace Event
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.ChangePerimeterEvent += Circle_ChangePerimeterEvent;
            circle.Radius = 5;
            Console.ReadKey();
        }

        private static void Circle_ChangePerimeterEvent(object sender, EventArgs e)
        {
            Console.WriteLine("asd");
            Circle cir = sender as Circle;
            cir.P = "vale changed after radius to " + cir.Radius.ToString();
            Console.WriteLine(cir.P);
        }
    }
}