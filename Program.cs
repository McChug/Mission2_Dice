using Mission2_Dice;

internal class Program
{
    private static void Main()
    {
        RollDice rd = new RollDice();

        // Run opening statements and collect user input
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        int number_of_rolls = System.Console.ReadLine() ? int.Parse(System.Console.ReadLine()) : 10;

        // Run the Roll() method using the user's number of rolls
        int[] roll_results = rd.Roll(number_of_rolls);

        // Display results by looping through array
        for (int i = 0; i < roll_results.Length; i++)
        {
            // get rounded number to represent percent
            double percent_of_total = Math.Round(
                (roll_results[i] / (double)number_of_rolls) * 100,
                2
            );
            // build the histogram bars
            string hist_bar = "";
            for (int j = 0; j < Math.Floor(percent_of_total); j++)
            {
                hist_bar += "*";
            }
            // Print the number and bar
            Console.WriteLine((i + 2) + ": " + hist_bar);
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
