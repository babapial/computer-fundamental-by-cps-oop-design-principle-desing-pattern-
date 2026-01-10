using System;
using System.Collections.Generic;

public class student{
  private string name ;
  private int age;
  private int id;
  public student(string name , int age , int id){  // constructor
    this.name = name;
    this.age = age;
    this.id = id;
  }
  public void show_info(){
    Console.WriteLine($"{id} student information");
    Console.WriteLine("name : "+this.name);
    Console.WriteLine("age : "+this.age);
    Console.WriteLine("id : "+this.id);
    Console.WriteLine("------------------------------------\n");
  }
}


class Program {
  public static void Main (string[] args) {
    student s1 = new student("pial",20,123);
    s1.show_info();

    student s2 = new student("siam",21,124);
    s2.show_info();
  }
} 