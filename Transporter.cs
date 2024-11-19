public class Transporter
{
    public int ChosedNumber{get;set;}

    public void TakeAndBring()
    {
        GetNumber obj = new GetNumber();
        ChosedNumber = obj.GetTheNumber();
    }
}

