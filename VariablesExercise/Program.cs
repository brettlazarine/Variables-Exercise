namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Brett";
            int age = 31;
            char letter = 'Z';
            bool truth = true;
            double timeToGetHired = 1.0;
            decimal earnings = 1000000000.9735m;
            //Practicing line breaks. May come back around and refactor down the line if I find a cleaner way of doing it.
            Console.WriteLine($"My name is {name}.\nI am {age} years old.\nI aim to learn coding, from A all the way to {letter}.\nAnd you can count on that being {truth.ToString().ToLower()}.\nHopefully I'll land a gig within {timeToGetHired} year of when I started out.\nSure would be cool if all this learning ended up earning me ${earnings}...");
        }
    }
}
