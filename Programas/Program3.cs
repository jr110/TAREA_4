using System;

using System.Collections.Generic;

 abstract class Musico

    {

    protected string nombre;

    public Musico (string n)

        {

         this.nombre = n;

        }
    

   public abstract void Afina();
   
  

   public string Display()

      { 

       return nombre;

      }
      
   }

 class Bajista :Musico
  {

    public string instrumento;

    public Bajista (string n, string Bajo ):base(n)
    {
        this.nombre=n;
        this.instrumento=Bajo;
    }

public override void Afina()
{
Console.WriteLine("El bajista afina");
}
    
 }

class Guitarrista :Musico
    {

     public string instrumento;
     public Guitarrista (string n, string Guitarra ):base(n)
    {
        this.nombre=n;
        this.instrumento=Guitarra;
    }
    public override void Afina()
{
    Console.WriteLine("El guitarrista afina");
}

     }
class Program

 {

  public static void Main() {
 
  //Musico m = new Musico("Django");
  Bajista b = new Bajista("Flea","Bajo");

  Guitarrista g = new Guitarrista("Santana","Guitarra");

  List<Musico> musicos = new List<Musico>();

  musicos.Add(b);

  musicos.Add(g);

 
  foreach (Musico Mus in musicos)
 {
    Console.WriteLine(Mus.Display());
    Mus.Afina();
 }

 Console.ReadKey();
  
  }

}