using System;

namespace Adressbok2
{
    class Program
    {
        public class Person
        {
            public string Name, Adress, Telephone, Email;

            public Person(string name, string adress, string telephone, string email)
            {
                this.Name = name;
                this.Adress = adress;
                this.Telephone = telephone;
                this.Email = email;
            }
            public Person()
            {

            }
        }
        
        
        
        static void Main(string[] args)
        {
            string nameInput;
            string adressInput;
            string telephoneInput;
            string emailInput;
            Console.WriteLine("Hej hopp skriv in ditt namn!");           
            nameInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nu skriv in din adress!");
            adressInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Skriv nu in ditt telefonnummer!");
            telephoneInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Skriv nu in din email!");
            emailInput = Console.ReadLine();
            Console.Clear();
            Person p1 = new Person(nameInput, adressInput,  telephoneInput, emailInput);
            Console.WriteLine("Namn: " + p1.Name);
            Console.WriteLine("Adress: " + p1.Adress);
            Console.WriteLine("Telefonnummer: " + p1.Telephone);
            Console.WriteLine("Email: " + p1.Email);
            Console.ReadKey();
            

        }
    }
}
