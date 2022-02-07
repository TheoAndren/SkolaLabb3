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
            bool logout = false;
            while (logout == false)
            {
                Console.WriteLine("1. Hämta ut alla elever\n2.Hämta elever klassvis\n3.Lägg till ny personal\n4.Avsluta");
                string menuoption = Console.ReadLine();
                switch (menuoption)
                {
                    case "1":
                        {
                            Console.Clear();
                            //Hämta ut alla elever
                            //Användaren får välja om de vill se eleverna sorterade på -
                            //för - eller efternamn och om det ska vara stigande eller fallande sortering.

                            Console.WriteLine("1.Sort by first name or last name? (First/Last)");
                            string sort1 = Console.ReadLine();

                            if (sort1.ToUpper() == "First")
                            {
                                Console.WriteLine("1.Sort by ascending or descending? (asc/des)");
                                string sort2 = Console.ReadLine();

                                if (sort2.ToUpper() == "asc")
                                {
                                    Console.WriteLine("stigande förnamn");
                                }
                                else if (sort2.ToUpper() == "des")
                                {
                                    Console.WriteLine("fallande förnamn");
                                }
                            }
                            else if (sort1.ToUpper() == "Last")
                            {
                                Console.WriteLine("1.Sort by ascending or descending? (asc/des)");
                                string sort2 = Console.ReadLine();

                                if (sort2.ToUpper() == "asc")
                                {
                                    Console.WriteLine("stigande efternamn");
                                }
                                else if (sort2.ToUpper() == "des")
                                {
                                    Console.WriteLine("Fallande efternamn");
                                }
                            }

                    
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            //Hämta ut alla elever i en viss klass
                            //Användaren ska först få se en lista med alla klasser som finns,
                            //sen får användaren välja en av klasserna och då skrivs alla elever i den klassen ut

                            foreach (var k in klasslista)
                            {
                                for (int j = 0; j < klass.Count; j++)
                                {
                                    Console.WriteLine($"{j + 1}. {klass[j]}");
                                }
                            }
                            
                                break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            //Lägga till ny personal
                            //Användaren får möjlighet att mata in uppgifter om en ny anställd och dessa sparas ner i databasen

                            Console.WriteLine("Förnamn?");
                            string förnamn = Console.ReadLine();
                            Console.WriteLine("Efternamn?");
                            string efternamn = Console.ReadLine();
                            Console.WriteLine("PersonNr?");
                            string personnr = Console.ReadLine();
                            Console.WriteLine("AnställningsNr?");
                            string anställningsnr = Console.ReadLine();
                            Console.WriteLine("BefattningsId?");
                            string befattningsid = Console.ReadLine();

                            break;

                        }
                    case "4":
                        {
                            Environment.Exit(0);
                            break;

                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ogilitgt val.\nSkriv en siffra i menyn.\n\n");

                            break;
                        }
                }
          
            }
        
        
             
        }
    }
}
