class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();
        while (true)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine(" 1. New Recipe Entry");
            Console.WriteLine(" 2. Display Recipes");
            Console.WriteLine(" 3. Reset ");
            Console.WriteLine("4. Clear");
            Console.WriteLine(" 5. Exit");
            Console.WriteLine("***********************************************");

            string set = Console.ReadLine();

            switch (set)
            {
                case "1":
                    recipe.UserInput();
                    break;
                case "2":
                    recipe.DisplayOption();
                    break;

                case "3":
                    recipe.ResetOption();
                    break;

                case "4":
                    recipe.ClearOption();
                    break;


                case "5":
                    Environment.Exit(1);
                    break;

            }
        }
    }
}

class Recipe
{

    private String[] ingredients;
    private double[] amount;
    private String[] units;
    private String[] steps;


    public void UserInput()
    {
        Console.WriteLine("Enter number of Ingredients:");
        int Add = Convert.ToInt32(Console.ReadLine());

        ingredients = new String[Add];
        amount = new double[Add];
        units = new String[Add];

        for (int m = 0; m < Add; m++)
        {
            Console.WriteLine($"Enter ingredient details#{m + 1}:");
            Console.Write("Name:");
            ingredients[m] = Console.ReadLine();
            Console.Write("Quantity:");
            amount[m] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unit of measurement:");
            units[m] = Console.ReadLine();
        }

        Console.WriteLine(" Number of Steps:");
        int nxtstep = Convert.ToInt32(Console.ReadLine());
        steps = new string[nxtstep];

        for (int a = 0; a < nxtstep; a++)
        {
            Console.Write($"Steps#{a + 1}:");
            steps[a] = Console.ReadLine();
        }
    }
    public void DisplayOption()
    {
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine($"- {amount[i]}{units[i]} of {ingredients[i]}");
        }
        Console.WriteLine("Steps:");
        for (int a = 0; a < steps.Length; a++)
        {
            Console.WriteLine($"-{steps[a]}");
        }
    }
    public void ScaleOption(double scale)
    {
        for (int s = 0; s < amount.Length; s++)
        {
            amount[s] *= scale;
        }
    }
    public void ResetOption()
    {
        for (int p = 0; p < amount.Length; p++)
        {
            amount[p] /= 2;
        }
    }
    public void ClearOption()
    {
        ingredients = new String[0];
        amount = new double[0];
        units = new String[0];
        steps = new String[0];
    }

}
