internal class Program
{
    private static void Main(string[] args)
    {
        int genAmount = 0;
        while (true)
        {
            // Type your username and press enter
            Console.Write("Enter the number of weapon generations: ");
            
            var input = Console.ReadLine();

            // Create a string variable and get user input from the keyboard and store it in the variable
            var isValidInt = int.TryParse(input, out genAmount);

            if (isValidInt)
            {
                Console.WriteLine("");
                break; // breaks out of the while loop to the rest of the code (thnx Kieran)
            } 
            else 
            {
                Console.WriteLine($"\n{input} is of type: {input.GetType().Name}! Please try an integer instead!\n");
            }
        }

        // path to weapon.txt
        string filePath = "../../../weapons.txt";
        
        // create a list variable with all weapons
        List<string> weaponsList = new List<string>();

        // Read the file line by line and add each line to the list
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    weaponsList.Add(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }

        // counting elements in list
        int listCount = weaponsList.Count;
        
        // init random
        Random random = new Random();
        
        // print random weapon(s)
        for (int i = 0; i < genAmount; i++)
        {
            Console.WriteLine(weaponsList[random.Next(1, listCount)]);
        }
    }
}