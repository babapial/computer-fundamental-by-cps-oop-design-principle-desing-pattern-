using System;
using System.Collections.Generic;

public interface payment{   //interface every method is abstract
  public abstract void validpayment();
  public abstract void processpayment(); 
  public void showinfo();
}

public class CreditCardPayment : payment{ //every method must be implemented
  public string CardNumber {get;set;}
  
  public void validpayment(){
     Console.WriteLine("Validating credit card payment");
  }
  public void processpayment(){
     Console.WriteLine("Processing credit card payment");
  }
  public void showinfo(){
    Console.WriteLine("Card Number: " + CardNumber);
  }
}

public class bkashpayment : payment{
  public string bkashnumber{get;set;}
  
  public  void validpayment(){
    Console.WriteLine("Validating bkash payment");
  }
  public void processpayment(){
    Console.WriteLine("process bkash payment");
  }
  public void showinfo(){
    Console.WriteLine("bikas number " + bkashnumber);
  }
}

class Program {
  public static void Main (string[] args) {
    payment p1 = new CreditCardPayment{
       CardNumber = "1234567890"
    };
    p1.validpayment();
    p1.processpayment();
    p1.showinfo();

    Console.WriteLine("----------------------------");
    
    payment p2 = new bkashpayment{
       bkashnumber = "01712345678"
    };
    p2.validpayment();
    p2.processpayment();
    p2.showinfo();
    
  }
} 