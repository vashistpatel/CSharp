

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! This is VP ;) ");
            //OperatorExamples();
            testMethod(5);
        }

        public static void testMethod(int x)
        {
            Console.WriteLine("Hello There! " + x);
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;

            int height = 2+4;
            int area = width * height;
            Console.WriteLine(area);

            while (area < 50)
            {
                height++;
                area = width * height;
            }
            do
            {
                width--;
                area = width * height;
            } while (area>25);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}
