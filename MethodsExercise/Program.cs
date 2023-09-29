namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{name}'s {age} birthday.");
            Console.WriteLine($"On {name}'s Birhtday they went to the zoo.");
            Console.WriteLine($"They really wanted to see the {animal}.");
            Console.WriteLine($"To {name}'s surprise there were baby {animal}s.");
            Console.WriteLine($"{name} made sure they wore their favorite {color} shirt.");
            Console.WriteLine($"{band} was playing on the ride home.");

            Console.WriteLine(add(2, 2));
            Console.WriteLine(multiply(2, 2));
            Console.WriteLine(divide(2,2));
            Console.WriteLine(subtract(2,2));
            Console.WriteLine(Sum(2,2,2,3,4));
        }

        public static int add(int num1, int num2)
        {   
            return num1 + num2; 
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int divide(int num1, int num2) 
        {
            return num1 / num2;
        }

        public static int subtract(int num1, int num2) 
        {
            return num1 - num2;
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;

            for(int i =0; i < list.Length; i++)
            {
                int placeholder = list[i];
                sum = sum + placeholder;
            }
            return sum;
        }
    }
}
