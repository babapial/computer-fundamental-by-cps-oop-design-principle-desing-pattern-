using System;
using System.Collections.Generic;

//function overloading - same function name but different parameter
//complie time polymorphism

public class calcultaion{  //parent class
  public void sum(int a){
    Console.WriteLine("int a");
    Console.WriteLine("sum = "+a+"\n");
  }
  public void sum(int a,int b){
    Console.WriteLine("int a,int b");
    int ans = a+b;
    Console.WriteLine("sum = "+ans+"\n");
  }
  public void sum(int a,int b,int c){
    Console.WriteLine("int a,int b,int c");
    int ans = a+b+c;
    Console.WriteLine("sum = "+ans+"\n");
  }
  public void sum(int a,double b){
    Console.WriteLine("int a,double b");
    double ans = a+b;
    Console.WriteLine("sum = "+ans+"\n");
  }
  public void sum(double a,int b){
    Console.WriteLine("double a,int b");
    double ans = a+b;
    Console.WriteLine("sum = "+ans+"\n");
  }
  
  
}


class Program {
  public static void Main (string[] args) {
    calcultaion c = new calcultaion();
    c.sum(10,20,30);
    c.sum(10);
    c.sum(10,20);
    c.sum(10,20.5);
    c.sum(10.5,20);
   
  }
} 