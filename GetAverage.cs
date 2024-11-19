class GetAverage:FindFibo
{
    public void GetTheAverage()
    {
        Console.Clear();
        foreach (int number in FiboNumbers)
        {
            Console.Write(number+", ");
        }
        int total = 0;
        double average;
        int length = FiboNumbers.Count;
        foreach (int number in FiboNumbers)
        {
            total += number;
        }
        average = total/length;
        Console.WriteLine($"\nThe average of the {length} element fibonacci sequence is: "+ average);
    }
}