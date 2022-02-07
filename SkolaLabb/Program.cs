using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SkolaLabb.Models;

namespace SkolaLabb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuoption = Console.ReadLine();
           
            switch (menuoption)
            {
                case "1":
                    {
                        Console.Clear();
                        //Hämta ut alla elever
                        //Användaren får välja om de vill se eleverna sorterade på -
                        //för - eller efternamn och om det ska vara stigande eller fallande sortering.
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        //Hämta ut alla elever i en viss klass
                        //Användaren ska först få se en lista med alla klasser som finns,
                        //sen får användaren välja en av klasserna och då skrivs alla elever i den klassen ut.

                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        //Lägga till ny personal
                        //Användaren får möjlighet att mata in uppgifter om en ny anställd och dessa sparas ner i databasen


                        break;

                    }
            }
        
        
             
        }
    }
}
