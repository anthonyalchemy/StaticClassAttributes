using System;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //static attribute contains on class itself instead of the object
            //normal attribute will have different values for each object 
            //static attribute will be about the class

            Song holiday = new Song ("Holiday", "Green Day", 200); //duration is in seconds 
            Console.WriteLine(Song.songCount);//one way of doing static
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());//another way of doing it by creating a method in song class 


            Console.ReadLine();
        }
    }
}
