using System;

namespace Bank.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liquidity liquidity = new Liquidity(1000, FIAT.EURO); 
            //Bank ing = new Bank();
            //ing.Manage(liquidity);  
            Person person = new Person();
            Buildapp(person);
        }
        public static void Buildapp(Person person)
        {
            Worker worker = new Worker(person);
        }
    }  

    public class Worker
    {
        public Person _person;
        public Worker(Person person)
        {
            _person=person;
        }
    }
    public class Person
    {

    }
}
