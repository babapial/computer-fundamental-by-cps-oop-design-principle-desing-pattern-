using System;
using System.Collections.Generic;


public interface Isend{
  public void Send();
}
public interface Ilog{
  public void Log();
}
public interface Isave{
  public void Save();
}

public class EmailNotify : Isend,Ilog,Isave{
  public string Email {get; set;}
  public void Send(){
     Console.WriteLine("Email Sent "+Email);
  }
  public void Log(){
    Console.WriteLine("Email Logged "+Email);
  }
  public void Save(){
    Console.WriteLine("Email Saved "+Email);
  }
}
public class SmsNotify : Isend,Ilog{
  public string phoneNumber {get;set;}
  public void Send(){
     Console.WriteLine("SMS Sent "+phoneNumber);
  }
  public void Log(){
    Console.WriteLine("sms are looged "+phoneNumber);
  }
  // public void Save(){}  //interface segregation
}

public class facebookNotify : Isend{
  public string facebookId {get;set;}
  public void Send(){
     Console.WriteLine("facebook SMS  send "+facebookId);
  }
  // public void Log(){} //interface segregation
  // public void Save(){} //interface segregation

}

public class notifyContext{
  public Isend send{get;set;}
  public Ilog log {get;set;}
  public Isave save {get;set;}
  public notifyContext(Isend send,Ilog log,Isave save){
    this.send = send;
    this.log = log;
    this.save = save;
  }
  public void process(){
    if(send != null){
      send.Send();
    }
    if(log != null){
      log.Log();
    }
    if(save != null){
      save.Save();
    }
  }
}


class Program {
  public static void Main (string[] args) {
    /*
    INotify email_notify = new EmailNotify{Email = "test@gmail.com"};
    email_notify.Send();
    email_notify.Log();
    email_notify.Save();


    INotify sms_notify = new SmsNotify{phoneNumber = "9876543210"};
    sms_notify.Send();
    sms_notify.Log();
    sms_notify.Save();
    */

    /*
    List<INotify> notifies = new List<INotify>{
      new EmailNotify {Email = "test@gmail.com"},
      new SmsNotify {phoneNumber = "9876543210"}
    };

    foreach(var notify in notifies){
      notify.Send();
      notify.Log();
      notify.Save();
    }
    */
    notifyContext notifyContext = new notifyContext(
      new EmailNotify{Email = "test@gmail.com"},
      new EmailNotify{Email = "test@gmail.com"},
      new EmailNotify{Email = "test@gmail.com"}
    );
    notifyContext.process();

    
    notifyContext notifyContext1 = new notifyContext(
      new SmsNotify{phoneNumber = "9876543210"},
      new SmsNotify{phoneNumber = "9876543210"},
      null
    );
    notifyContext1.process();

    notifyContext notifyContext2 = new notifyContext(
      new facebookNotify{facebookId = "9876543210"},
      null,
      null
    );
    notifyContext2.process();
    
  }
} 