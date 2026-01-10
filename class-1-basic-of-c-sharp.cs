using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("pial is writing code");
    Console.WriteLine ("-------------------------------------------");
    //variable , condition , loop all are same like c++
    int a = 10;
    int b = 20;
    Console.WriteLine("the value of a = "+a+" and b = "+b);
    Console.WriteLine($"the value of a = {a} and b = {b}");
    
    if(a%2==0){
      Console.WriteLine("a is even");
    }
    else{
      Console.WriteLine("a is odd");
    }
    
    Console.WriteLine ("-------------------------------------------");
    
    int [] arr = new int[5];
    for(int i=0;i<5;i++){
      arr[i] = i+10;
    }
    for(int i=0;i<5;i++){
       Console.WriteLine ("arr["+i+"] = "+arr[i]);
    }
    int len = arr.Length;
    Console.WriteLine ("length of arr = "+len);
    Array.Sort(arr);
    Array.Reverse(arr);
    
    Console.WriteLine ("-------------------------------------------"); 

    int [,] arr2 = new int[5,3]; //[row,col]
    for(int i=0;i<5;i++){
      for(int j=0;j<3;j++){
          arr2[i,j] = i+2+j;
      }
    }

    for(int i=0;i<5;i++){
      for(int j=0;j<3;j++){
           Console.Write(arr2[i,j]+" ");
      }
       Console.WriteLine();
    }
    Console.WriteLine ("-------------------------------------------");
    String s = "pial hasan";
    char [] arr3 = s.ToCharArray();  //convert character array
    Array.Reverse(arr3);
    String s2 = new String(arr3); //convert string
    Console.WriteLine(s2);
    Console.WriteLine ("-------------------------------------------");

    IList<int> d = new List<int>();
    d.Add(10);
    d.Add(20);
    d.Add(30);
    d.Add(40);
    d.Add(1);
    d.Add(40);
    d.Remove(1);
    foreach(int i in d){
      Console.WriteLine(i);
    }

    Console.WriteLine ("-------------------------------------------");

    Dictionary<String,int> d2 = new Dictionary<String,int>();
    d2["one"] = 1;
    d2["two"] = 2;
    d2["three"] = 3;
    foreach(var kv in d2){
      Console.WriteLine($"key = {kv.Key} and value = {kv.Value}");
    }

    Console.WriteLine ("-------------------------------------------");

    Dictionary<String,int> d3 = new Dictionary<String,int>();
    string[] key = new string[] { "one", "two", "three", "four", "three" };
    int[] value = new int[] { 1, 2, 3, 4, 5 };
    for(int i=0;i<key.Length;i++){
      if(d3.ContainsKey(key[i])){
        d3[key[i]] = value[i];
      }
      else{
         d3.Add(key[i],value[i]);
      }
    }
    foreach(var kv in d3){
      Console.WriteLine($"key = {kv.Key} and value = {kv.Value}");
    }
    
    
  }
}