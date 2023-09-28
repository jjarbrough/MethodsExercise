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
        }
    }
}
