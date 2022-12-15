using System;

namespace Program{
    abstract class Animal{

        //Atributte
        protected int legs = 0;
        
        //Constructors
        protected Animal(int legs){}
        
        //Methods
        public void walk(){}

        public void eat(){}

    }

    public class Cat : Pet{

        //Atributte
        private string name = "Hola, soy un Pastor Aleman y me llamo Snoopy";

        //Constructors
        public Cat (string n){}
        public Cat (){}

        //Methods
        public string getName(){
           
            return this.name;
        }

        public void setName(string n){}

        public void play(){}

        public void eat(){}
    }

    public class Spider{

        //Constructors
        public Spider(){}

        public void eat(){}
    }

    interface Pet{

        string getName();
        void setName(string n);
        void play();
        
    }

    public class Fish : Pet{
        

        // Explicit interface member implementation:
        string Pet.getName(){

            return this.name;
        }

        // Explicit interface member implementation:
        void Pet.setName(string n){

           n = "Snooby";
           this.name = n;
        }

        void Pet.play(){
              Console.WriteLine("\n\tQuiero Jugar !");
        }


        //Atributte
        private string name = "Soy Snooby";
 
        //Constructors
        public Fish(){}

        //Methods
        //public string getName(){}
        public void setName(string n){}
        public void play(){}
        public void walk(){}
        public void eat(){}
    }

    public class TesterClass{
        public static void Main(){
              Cat animal = new Cat();

              Console.WriteLine("\n\t"+animal.getName());
              Console.ReadKey();

        }
    }

}