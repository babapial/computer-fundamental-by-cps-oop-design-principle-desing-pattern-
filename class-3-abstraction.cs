using System;
using System.Collections.Generic;

public abstract class payment{
  public int amount {get;set;}
  public string TransactionId {get;set;}

  public abstract void validpayment();
  public abstract void processpayment(); // ek ek somoy ek ek vabe use kora proyojon
  
  
  public void showinfo(){
     Console.WriteLine("TransactionId: {0}", TransactionId);
     Console.WriteLine("Amount: {0}", amount);
  }
}
public class CreditCardPayment : payment{
  public string CardNumber {get;set;}
  
  public override void validpayment(){
     Console.WriteLine("Validating credit card payment");
  }
  public override void processpayment(){
     Console.WriteLine("Processing credit card payment");
  }
}

public class bkashpayment : payment{
  public string bkashnumber{get;set;}
  public override void validpayment(){
    Console.WriteLine("Validating bkash payment");
  }
  public override void processpayment(){
    Console.WriteLine("process bkash payment");
  }
}

class Program {
  public static void Main (string[] args) {
    payment p1 = new CreditCardPayment{
       amount = 100,
       TransactionId = "12345",
       CardNumber = "1234567890"
    };
    p1.validpayment();
    p1.processpayment();
    p1.showinfo();

    Console.WriteLine("----------------------------");
    
    payment p2 = new bkashpayment{
       amount = 200,
       TransactionId = "67890",
       bkashnumber = "01712345678"
    };
    p2.validpayment();
    p2.processpayment();
    p2.showinfo();
    
  }
} 