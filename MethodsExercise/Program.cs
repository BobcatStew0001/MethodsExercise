
namespace MethodsExercise
{
    public class Program
    {
        public static void You()
        {
            Console.WriteLine("What is your name?");
            string youName = Console.ReadLine();
            Console.WriteLine($"{youName} what is your favorite color?");
            string youColor = Console.ReadLine();
            Console.WriteLine($"{youName} what is your significant others name");
            string youOther = Console.ReadLine();
            Console.WriteLine($"{youName} what is your favorite animal");
            string youAnimal = Console.ReadLine();
            Console.WriteLine($"{youName} what is your favorite food");
            string youFood = Console.ReadLine();
            Console.WriteLine($"{youName} Last question, what is your favorite type of music");
            string youMusic = Console.ReadLine();
            Console.WriteLine(
                $"It was a comfortable spring day when {youName} and {youOther} were walking in the woods for a picnic of {youFood}. They were relaxing to some {youMusic} on {youName}s" +
                $" favorite {youColor} blanket, When {youOther} screamed {youName} I just saw a {youAnimal} jump out of that tree.");
        }

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int MultiTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int DivTwoNumbers(int num1, int num2) {
            return num1 / num2; }


        static void Main(string[] args)
        {
            You();
            //Console.WriteLine(AddTwoNumbers(10, 20));
            //Console.WriteLine(SubTwoNumbers(10025, 2520));
            //Console.WriteLine(MultiTwoNumbers(3, 9));
            //Console.WriteLine(DivTwoNumbers(2020, 200));




        }
    }
}    

