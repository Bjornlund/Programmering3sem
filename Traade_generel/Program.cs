using System.Threading;
namespace Traade_generel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instans of Animal class (see bottom of program)
            Animal cat = new Animal("Garfield", 10);

            //Main program tråd - kører ikke nødvendigvis først, bare fordi det er main
            Console.WriteLine("Main thread");

            //Tråd uden parameter
            Thread threadNoParam = new Thread(ThreadMessage);
            threadNoParam.Start();

            //Tråd med et object parameter - mere end ét parameter(object o), lav en klasse og giv med som object
            Thread threadOneParam = new Thread(ThreadMessageParam);
            string msg = "Hello world";
            threadOneParam.Start(msg);

            //Tråd med klasse som object parameter - mere end ét parameter(object o), lav en klasse og giv med som object
            Thread threadClassParam = new Thread(ThreadClassParam);
            //Animal cat = (Animal) o ;
            threadClassParam.Start(cat);

            //Lambda tråd, kan tage flere parametre uden casting eller klasser
            //ThreadLambdaMethod();
            Thread lambdaThread = new Thread(() => ThreadLambdaMethod("Gurfield", 10000));
            lambdaThread.Start();

            Console.ReadKey();
        }

        private static void ThreadMessage()
        {
            Console.WriteLine("Thread 1");
        }

        private static void ThreadMessageParam(object o)
        { 
            string msg = (string)o; //caster til string
            Console.WriteLine($"Thread with param: {msg}");
        }

        private static void ThreadClassParam(object o)
        {
            Animal cat = (Animal)o; 
            Console.WriteLine($"Animal class: {cat.Name}, {cat.Age}");
        }

        private static void ThreadLambdaMethod(string name, int age)
        {
            Console.WriteLine($"Lambda Thread {name}, {age}");
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;
        }
    }
}
