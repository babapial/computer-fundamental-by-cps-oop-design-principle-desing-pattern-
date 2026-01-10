using System;
using System.Collections.Generic;

public class university{  //parent class
  public string name ;
  public int id;
  public virtual void present(){
    Console.WriteLine("the person is present");
  }
  public void show_info(){
    Console.WriteLine($"\n-----------information-------------");
    Console.WriteLine("name : "+this.name);
    Console.WriteLine("id : "+this.id);
  }
}

public class student : university{ //child class
 
  public override void present(){
    Console.WriteLine("the student is present");
  }
}

public class teacher : university{ //child class
  public override void present(){
    Console.WriteLine("the teacher is present");
  }
}


public class staff : university{ //child class
  public override void present(){
    Console.WriteLine("the staff is present");
  }
}

class Program {
  public static void Main (string[] args) {
    
    student s1 = new student();
    s1.name = "siam";
    s1.id = 123;
    s1.show_info();
    s1.present();

    
    teacher t1 = new teacher();
    t1.name = "lamia";
    t1.id = 18;
    t1.show_info();
    t1.present();

    
    student s2 = new student();
    s2.name = "sabbir";
    s2.id = 23;
    s2.show_info();
    s2.present();
    

    staff st1 = new staff();
    st1.name = "siam";
    st1.id = 124;
    st1.show_info();
    st1.present();
  }
} 