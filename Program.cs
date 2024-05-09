namespace Assignment13._1._1
{
    internal class Program
    {
        // area of triangle formula =  base × height/2
        // area of a square formula = L x W = ^2
        // area of a rectangle formula = L x W = ^2
        static void Main(string[] args)
        {
            string readResult;
            do
            {
                Console.WriteLine("Please enter your choice of formula.");
                Console.WriteLine("Enter T for Triangle.");
                Console.WriteLine("Enter S for Square.");
                Console.WriteLine("Enter R for Rectangle.");
                Console.WriteLine("Enter X to Exit.");

                readResult = Console.ReadLine();

                switch (readResult)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("Enter width of base of triangle");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height of triangle");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the triangle is " + TriagnleMethod(width, height));
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Enter side of square");
                        double side1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter other side of square");
                        double side2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the square is " + AreaOfSquare(side1, side2));
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("Enter side of rectangle");
                        double recside1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter other side of rectangle");
                        double recside2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the rectangle is " + AreaOfRectangle(recside1, recside2));
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("You want to exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            while (readResult != "x" && readResult != "X");
        }
        static double AreaOfRectangle(double recside1, double recside2)
        {
            double area = recside1 * recside2;
            return area;
        }
        static double AreaOfSquare(double side1, double side2)
        {
                double area = side1 * side2;
                return area;
        }
        static double TriagnleMethod(double width, double height)
        {
                double result = (width * height) / 2;
                return result;
        }
        ///This is a comment just to commit 
    }
}


        
        
