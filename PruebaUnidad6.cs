using System;

namespace Herencia{

    class Animal{
        public void eat(){}
    

    }

    class Bird:Animal{
        public void takeOff(){

        }

        public void land(){

        }3

        public void fly(){

        }

        public void buildNest(){

        }

        public void layEggs(){

        }

        public void eat(){

        }

    }

    class Kryptonian:Animal{

    }

    class Superman:Kryptonian{
        public void takeOff(){

        }

        public void land(){

        }

        public void fly(){

        }

        public void leapBuilding(){

        }

        public void stopBullet(){

        }

        public void eat(){

        }

    }

    class testerClass{

        public static void Main(){
            
            Console.WriteLine("\n\tEsto es una pruena de Herencia !");
            Console.ReadKey();
        }
    }
}