namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catName = "Mia";
            int catAge = 1;
            char lastInitial = 'T';
            bool isHappy = true;
            double weight = 4.3;
            decimal lenght = 3.53m;

            Console.WriteLine($"The cats name is {catName} {lastInitial}.\n" +
                $"she is {catAge} year old and weighs {weight} with a lenght of {lenght}\n" +
                $"and its {isHappy} she is happy");
        }
    }
}
 