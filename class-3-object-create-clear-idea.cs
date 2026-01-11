

using System;

public abstract class Payment
{
    public void ShowInfo()
    {
        Console.WriteLine("Payment info shown");
    }

    public abstract void ProcessPayment();
}


class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine("Credit card payment processed");
    }

    public void ShowCardNumber()
    {
        Console.WriteLine("Card Number: " + CardNumber);
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Payment p2 = new CreditCardPayment(); // p2 referance , creditcardpapayment object
        p2.ShowInfo();        
        p2.ProcessPayment();
        //p2.ShowCardNumber();  //show error 
        //p2.CardNumber = "123";  show error
        
        
        CreditCardPayment p1 = new CreditCardPayment();
        p1.CardNumber = "1234-5678";
        p1.ShowInfo();        
        p1.ProcessPayment(); 
        p1.ShowCardNumber(); 
        
    }
}