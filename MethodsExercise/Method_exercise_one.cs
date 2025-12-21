
namespace MethodsExercise
{
    public class Method_exercise_one
    {
        public static void You()
        {
            Console.WriteLine("What is your name?");
            string YouName = Console.ReadLine();
            Console.WriteLine($"{YouName} what is your favorite color?");
            string YouColor = Console.ReadLine();
            Console.WriteLine($"{YouName} what is your significant others name");
            string YouOther = Console.ReadLine();
            Console.WriteLine($"{YouName} what is your favorite animal");
            string YouAnimal = Console.ReadLine();
            Console.WriteLine($"{YouName} what is your favorite food");
            string YouFood = Console.ReadLine();
            Console.WriteLine($"{YouName} Last question, what is your favorite type of music");
            string YouMusic = Console.ReadLine();
            Console.WriteLine(
                $"It was a comfortable spring day when {YouName} and {YouOther} were walking in the woods for a picnic of {YouFood}. They were relaxing to some {YouMusic} on {YouName}s" +
                $" favorite {YouColor} blanket, When {YouOther} screamed {YouName} I just saw a {YouAnimal} jump out of that tree.");
        }

 















        static void Main(string[] args)
        {

            You();




        }
    }
}    

