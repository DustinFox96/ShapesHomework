using System;

namespace ShapesHomework {
    class Program {
        static void Main(string[] args) {
            var rect1 = new Rect(7, 2);

            Console.WriteLine($"the peremiter of rect1 is {rect1.Peremiter()}");

            var sqr1 = new Sqr(7);
            Console.WriteLine($"the Area of sqr1 is {sqr1.Area()}");
        }

    }
}
