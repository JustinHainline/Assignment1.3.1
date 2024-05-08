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
                        Console.WriteLine("Enter length of base of triangle")
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Enter length of side of square");
                        break;
                    case "R":
                    case "r":
                       // RectangleMethod();
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

            static void Menu();
            {

            }


        }
        static double TriagnleMethod(width, height)
        {
            Console.WriteLine("Please sides of triangle:");
            Console.WriteLine("Enter base of triangle:");
            double readResult1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of triangle:");
            double readResult2 = Convert.ToDouble(Console.ReadLine());
            double sum = readResult1 * readResult2 / 2;

        static double AreaOfSquare(double side)
            {
                return side * side;
            }
        static double AreaOfRectangle(double side)
            {
                return side * side;
            }
            
                }
    }
}
