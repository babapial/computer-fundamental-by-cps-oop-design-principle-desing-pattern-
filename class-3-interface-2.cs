using System;
using System.Collections.Generic;

public interface INotify{
  public void Send();
  public void Log();
  public void Save();
}

public class EmailNotify : INotify{
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
public class SmsNotify : INotify{
  public string phoneNumber {get;set;}
  public void Send(){
     Console.WriteLine("SMS Sent "+phoneNumber);
  }
  public void Log(){
    Console.WriteLine("sms are looged "+phoneNumber);
  }
  public void Save(){
    Console.WriteLine("sms are saved "+phoneNumber);
  }
}

public class facebookNotify : INotify{
  public string facebookId {get;set;}
  public void Send(){
     Console.WriteLine("facebook SMS  send "+facebookId);
  }
  public void Log(){
    Console.WriteLine("facebook notification are looged "+facebookId);
  }
  public void Save(){
    Console.WriteLine("facebook notification are saved "+facebookId);
  }
  
}

public class notifyContext{
  public INotify notify{get;set;}
  public notifyContext(INotify notify){
    this.notify = notify;
  }
  public void process(){
    notify.Send();
    notify.Log();
    notify.Save();
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
    IList<notifyContext>notifyContexts = new List<notifyContext>();
    
    EmailNotify emailNotify1 = new EmailNotify { Email = "test@gmail.com" };
    SmsNotify smsNotify1 = new SmsNotify { phoneNumber = "9876543210" };
    facebookNotify facebookNotify1 = new facebookNotify { facebookId = "pial hasan" };

    notifyContexts.Add(new notifyContext(emailNotify1));
    notifyContexts.Add(new notifyContext(smsNotify1));
    notifyContexts.Add(new notifyContext(facebookNotify1));

    foreach(var context in notifyContexts)
    {
        context.process();
        Console.WriteLine("--------------------------------------");
    }
  }
} 