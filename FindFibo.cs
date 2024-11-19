class FindFibo:Transporter
{
    public List<int> FiboNumbers {get;set;} = new List<int>();
    public void FindFibonacciNumbers()
    {
        TakeAndBring(); //ChosedNumber from GetNumber
        int first = 0 , second = 1, next;

        for (int i = 0; i < ChosedNumber; i++)
        {
            FiboNumbers.Add(first);
            next = first + second;
            first = second;
            second = next;
        }
    }
}