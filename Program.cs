using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Adressbok2
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Adress { get; set; }
            public int PhoneNumber { get; set; }
            public string Email { get; set; }

            


            static void Main(string[] args)
            {
                string fileName = "C:\\Users\\ÄGARE\\Desktop\\AdressBok.txt";


                string command;
                
                List<Person> myPeople = new List<Person>();
                do
                {

                    Console.WriteLine("Hej och välkommen!");
                    Console.WriteLine("Vill du lägga till en person tryck på 1");
                    Console.WriteLine("Vill du skriva ut listan på alla personer skriv 2");
                    Console.WriteLine("Vill du ta bort en person ifrån listan skriv 3");
                    Console.WriteLine("Vill du avsluta programmet så skriv Avsluta");
                    command = Console.ReadLine();
                    if (command == "1")
                    {

                        //declring strings/ints
                        string nameInput;
                        string adressInput;
                        string telephoneInput;
                        string emailInput;
                        int telephoneInputNumber;
                        

                        //reading input to put into class
                        Console.WriteLine("Hej hopp skriv in ditt namn!");
                        nameInput = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Nu skriv in din adress!");
                        adressInput = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Skriv nu in ditt telefonnummer!");
                        telephoneInput = Console.ReadLine();
                        telephoneInputNumber = Convert.ToInt32(telephoneInput);
                        Console.Clear();
                        Console.WriteLine("Skriv nu in din email!");
                        emailInput = Console.ReadLine();
                        Console.Clear();
                        //adding my new person in the list
                        myPeople.Add(new Person()
                        {
                            Name = nameInput,
                            Adress = adressInput,
                            PhoneNumber = telephoneInputNumber,
                            Email = emailInput
                        });
                      //writing every class to textfile
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\\ÄGARE\\Desktop\\AdressBok.txt", true))
                        {
                            foreach (var Person in myPeople) 
                        {
                                
                                file.WriteLine(Person.Name);        
                                file.WriteLine(Person.Adress);
                                file.WriteLine(Person.PhoneNumber); 
                                file.WriteLine(Person.Email);
                                file.WriteLine("************************");
                            }
                        }


                    }
                    //read textfile and display the information

                    if (command == "2")
                    {
                        string readText = (File.ReadAllText(fileName));
                        Console.WriteLine(readText);

                    }

                    else if (command == "3") 
                    {
                        //clearing the file, asking for index to remove
                        int deleteindex;
                        File.WriteAllText(fileName, String.Empty);
                        Console.WriteLine("Vilket index vill du ta bort?");
                        //removing the object at specified index
                        deleteindex = int.Parse(Console.ReadLine());
                        //rewriting to the empty file 
                        myPeople.RemoveAt(deleteindex);
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\\ÄGARE\\Desktop\\AdressBok.txt", true))
                        {
                            foreach (var Person in myPeople)
                            {

                                file.WriteLine(Person.Name);
                                file.WriteLine(Person.Adress);
                                file.WriteLine(Person.PhoneNumber);
                                file.WriteLine(Person.Email);
                                file.WriteLine("************************");
                            }
                        }

                    }
                    


                } while (command != "Avsluta");

            }





        }
    }
}        
        

    

