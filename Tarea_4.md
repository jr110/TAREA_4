# TAREA 4

## 1. Considera el siguiente fragmento de programa:


using System;

class A

    {

    public int a;

    public A()

        {

        a = 10;

        }

    public _______ string Display()

      {

      return a.ToString();

      }

    }

class B:A

   {

   public int b;

   public B():base()

   {

    b = 15;

   }

 

  // #########################################

  //  #  Después de contestar la pregunta 1                  

 //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.

 //  #########################################

 

}

 class Program

  {

   public static void Main()

   {

  A objA = new A();

  B objB = new B();

  Console.WriteLine(objA.Display()); ////  (1 )

  Console. WriteLine(objB.Display()); ////  ( 2)

  }

  }

### 1.1. ¿Qué valores imprimen las lineas (1) y (2) ?
Un string que imprime "10" en ambas lineas, ya que no se hace override a la clase A(verificar)

### 1.2.  Redefine el método Display en el espacio indicado,

  ###   una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?.
Nos regresa los valores de 10 y 15

### 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?

La palabra virtual. Para hacer override en la clase B y que despliegue valores correctamente.

# 2. Considera el siguiente fragmento de programa:
using System;

using System.Collections.Generic;

 ________ class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

   public abstract (A) void Afina();  (B)

   public (C) string Display()

      { 

       return nombre;

      }

   }

class Bajista; Musico

  {

    public string instrumento;

    public Bajista (string n, string i ) ......

    .........

    public _________ Afina()

      {

      ________________

      }

 }

class Guitarrista ____________

     {

     public instrumento;

      // Falta el constructor y otras cosas??

 

     }

 

class Program

 {

  public static Main()

   {

  Musico m = new Musico("Django"); (D)

  Bajista b = new Bajista("Flea");

  Guitarrista g = new Guitarrista("Santana");

   List<Musico> musicos = ____________________

 musicos.Add( b);

  musicos.Add(g);

 

  foreach ( ___________)

       _____________________

 

 Console.ReadKey();

  

 }

}

## 2.1. Completa el programa.

## 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
A: No lleva void en la declaracion del metodo, en vez de eso lleva string.
B: Se quita el (B) que esta de mas en el codigo.
C: Profe, no encontre errores en (B) y (D) mas que el propio error de que estuvieran escritos en el programa, solo los elimine
y en base a otros procedimientos logre correrlo.
D: Al ser una clase abstracta no se puede crear un musico de manera "convencional".
## 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
Se debe implementar un override a afina para que este funcione apropiadamente.
## 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
Al ser una clase abstracta no se perimite agregar corchetes. Se podria agregar cuando sea virtual, por ejemplo.
## 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
Se cambia el metodo string a void y se cambian los return por console.writeline, y a la hora de imprimir al final del programa  de pone la linea de codigo mus.afina(); en vez de console.writeline(mus.afina); por que si no seria rebundante y arrojaria error.
# 3. Implementa el programa utilizando interfaces en lugar de herencia.











