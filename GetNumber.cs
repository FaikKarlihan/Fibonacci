class GetNumber
{
    public int GetTheNumber()
    {
        string STRnumber;
        Console.Clear();
        Console.WriteLine("How many elements of a Fibonacci sequence do you want?: ");

        while (true)
        {
            STRnumber = Console.ReadLine();
            if (int.TryParse(STRnumber, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("please enter a number: ");
            }
        }
    }
}