using Lab_2;
using System.Security.Principal;
public enum Season
{
    Spring = 2,
    Summer = 4,
    Autumn = 1,
    Winter = 3
}
public enum Discount
{
    None,
    SecondVisit = 10,
    VIP = 20
}

internal class Program
{
    enum Day { Monday, Tuesday =10, Wednesday, Thursday=20, Friday, Saturday, Sunday };
    public static void Main(string[] args)
    {
        Problem1();
/*        Pr2();
        Pr3();
        Pr4();*/
    }

    static void Problem1()
    {
        Console.WriteLine("Enter number: ");
        int size = int.Parse(Console.ReadLine());
        for (int stCount = 1; stCount <= size; stCount++)
            PrintRow(size, stCount);
        for (int stCount = size - 1; stCount >= 1; stCount--)
            PrintRow(size, stCount);
    }
    static void PrintRow(int figureSize, int starCount)
    {
        for (int i = 0; i < figureSize - starCount; i++)
            Console.Write(" ");
        for (int col = 1; col < starCount; col++)
            Console.Write("* ");
        Console.WriteLine("*");
    }
    static void Pr2()
    {
        //Read coordinate of the rectangle
        string inputLine = Console.ReadLine();
        string[] rectCoordinatesAsText = inputLine.Split();
        
        //Create Rectangle rect
        Rectangle newRect = new Rectangle(int.Parse(rectCoordinatesAsText[0]),
            int.Parse(rectCoordinatesAsText[1]),
            int.Parse(rectCoordinatesAsText[2]),
            int.Parse(rectCoordinatesAsText[3]));
        // Read the number N of Points
        int N = int.Parse(Console.ReadLine());
        Point[] myPointArray = new Point[N];
        //Read and create N points
        for (int i = 0; i < N; i++)
        {
            inputLine = Console.ReadLine();
            string[] pointCoordinates = inputLine.Split();
            myPointArray[i] = new Point(int.Parse(pointCoordinates[0]),
                int.Parse(pointCoordinates[1]));
        }
        //Call the method rect.Contains(point) for the N points and
        //print the result to the screen
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(newRect.Contains(myPointArray[i]));
        }
    }

    static void Pr3()
    {
        StudentManagement studentManagement = new StudentManagement();
        studentManagement.Run();
    }

    static void Pr4()
    {
        do
        {
            string command = Console.ReadLine();
            var cmdArgs = command.Split();
            if (cmdArgs[0] == "Exit")
            {
                break;
            }
            Season season = (Season)Enum.Parse(typeof(Season), cmdArgs[2]);
            Discount discount;
            if (cmdArgs.Length > 3)
            {
                discount = (Discount)Enum.Parse(typeof(Discount), cmdArgs[3]);

            }
            else
            {
                discount = Discount.None;
            }
            Console.WriteLine(PriceCalculator.CalculatePrice(decimal.Parse(cmdArgs[0]), int.Parse(cmdArgs[1])
                , season, discount));

        } while (true);
    }

}