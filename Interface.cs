using System;

namespace Interfaces{

   public class Animal
{
    public void eat()
    {
        Console.WriteLine("\n\tLos Animales: Todos los animales estan comiendo.");
    }
}

public class Kryptonian : Animal{}

public class Vehicle {}

//interface
interface Flyer
{
     void takeOff();
     void land();
     void fly();
 
}

//interface de Superman que va a heredar de kryptonian

class Superman : Kryptonian, Flyer
{
    public void takeOff()
    {
        Console.WriteLine("\n\tLos Animales: Se estan retirando.");
    }

    public void land()
    {
        Console.WriteLine("\n\tLos Animales: Se estan deslizando por tierra");
    }

    public void leapBuilding()
    {
        Console.WriteLine("\n\tLos Animales: Ellos estan saltando");
    }

    public void stopBullet()
    {
        Console.WriteLine("\n\tLos Animales: Se detienen");
    }

    public void fly()
    {
        Console.WriteLine("\n\tLos Animales: Las Aves Vuelan.");
    }
    public void eat()
    {
        Console.WriteLine("\n\tLos Animales: Comen");
    }
}

public class Airplane : Vehicle, Flyer
{
    public void takeOff() { }
    public void land() { }
    public void fly() { }
}

public class Bird : Flyer
{
    public void takeOff() { }
    public void land() { }
    public void fly() { }
    public void buildNest() { }
    public void layEggs() { }
    public void eat() { }
}

public class SeaPlane : Airplane{}

public class Helicopter : Airplane{}

//Clase Tester
public class TesterClass
{
     public static void Main()
    {
        //Animmal
        Animal Object_Animal = new Animal();
        Object_Animal.eat();

        //Superman
        Superman SuperMan = new Superman();
        SuperMan.fly();
        SuperMan.eat();
        SuperMan.land();
        SuperMan.leapBuilding();
        SuperMan.stopBullet();
        SuperMan.takeOff();
    }
}


}

