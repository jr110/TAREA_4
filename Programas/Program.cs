using System;
using System.Collections.Generic;
using System.Globalization; 


    public interface IAfinar
    { 
        string Nombre();
      

    }

  class Bajista :IAfinar
  {
      public string nombre{get;set;}
      public string afinar{get;set;}
      public Bajista(string n,string a)
      {
          nombre=n;
          afinar=a;
      }
      public string Nombre()
      {
          return nombre;
      }
       public string Afina()
      {
          return afinar;
      }

 }

class Guitarrista :IAfinar
     {
         public string nombre{get;set;}
      public string afinar{get;set;}
      public Guitarrista(string n,string a)
      {
          nombre=n;
          afinar=a;
      }
      public string Nombre()
      {
          return nombre;
      }
       public string Afina()
      {
          return afinar;
      }
     }

class Program

 {

  public static void Main() {
 
  //Musico m = new Musico("Django");
  Bajista b = new Bajista("Flea","Si afina");

  Guitarrista g = new Guitarrista("Santana","No afina");

Console.WriteLine(b.Nombre());
Console.WriteLine(g.Nombre());

Console.WriteLine(b.Afina());
Console.WriteLine(g.Afina());

 
  

 Console.ReadKey();
  
 }

}