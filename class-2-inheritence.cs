using System;
using System.Collections.Generic;

public class university{  //parent class
  private string name ;
  private int age;
  private int id;
  public university(string name , int age , int id){  // constructor
    this.name = name;
    this.age = age;
    this.id = id;
  }
  public void show_info(){
    Console.WriteLine($"\n-----------information-------------");
    Console.WriteLine("name : "+this.name);
    Console.WriteLine("age : "+this.age);
    Console.WriteLine("id : "+this.id);
  }
}
public class student : university{ //child class
  public student(string name , int age , int id) : base(name,age,id){} //parent class er constructor call kora hoise
  public void student_present(){
    Console.WriteLine("the student is present");
  }
}

public class teacher : university{ //child class
  public teacher(string name , int age , int id) : base(name,age,id){} //parent class er constructor call kora hoise
  public void teacher_present(){
    Console.WriteLine("the teacher is present");
  }
}


public class staff : university{ //child class
  public staff(string name , int age , int id) : base(name,age,id){} //parent class er constructor call kora hoise
  public void staff_present(){
    Console.WriteLine("the staff is present");
  }
}

class Program {
  public static void Main (string[] args) {
    student s1 = new student("pial",20,123);
    s1.show_info();
    s1.student_present();

    teacher t1 = new teacher("mim",18,003);
    t1.show_info();
    t1.teacher_present();

    student s2 = new student("siam",21,124);
    s2.show_info();
    s2.student_present();

    staff st1 = new staff("alif",24,4);
    st1.show_info();
    st1.staff_present();
  }
} 