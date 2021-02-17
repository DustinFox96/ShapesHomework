using System;

namespace ShapesHomework {
    class Program {
        static void Main(string[] args) {

            Quad X = new Sqr(3);// have becca explain what this is and what's happening here.

            var rect1 = new Rect(7, 2);
            Console.WriteLine($"RECT:The peremiter of rect1 is {rect1.Peremiter()}");

            var sqr1 = new Sqr(7);
            Console.WriteLine($"SQR:The Area of sqr1 is {sqr1.Area()}");
            Console.WriteLine($"SQR:Print is {sqr1.Print()}");

            var sqr2 = new Sqr(5);
            Console.WriteLine($"SQR:The perimeter of sqr2 is {sqr2.Peremiter()}");

            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"QUAD:The perimeter of quad1 is {quad1.Peremiter()}");

            // under here are all polymorphism changes update
            var Shapes = new Quad[] { sqr1, rect1, quad1 };
            foreach(var shape in Shapes) {
                Console.WriteLine($"shape is a {shape.Print()}");
                //Console.WriteLine($"shape's area is {shape.Area()}");
                var rect = shape as Rect;
                if(rect != null) {
                    Console.WriteLine($"shape's area is {rect.Area()}");
                } else {
                    Console.WriteLine($"The shape is a quad");
                }
            }


        }

    }
}
