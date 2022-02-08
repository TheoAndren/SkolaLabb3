using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SkolaLabb.Models;


namespace SkolaLabb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SkolaDbContext context = new SkolaDbContext();
            //var test = from e in context.Elev select e;
            //foreach (Elev item in test)
            //{
            //    Console.WriteLine("Fnamn" + item.Fnamn);
            //}
            bool logout = false;
            while (logout == false)
            {
                
                Console.WriteLine("1: Hämta ut alla elever");
                Console.WriteLine("2: Hämta ut alla elever i en viss klass");
                Console.WriteLine("3: Lägga till ny personal");
                string menuoption = Console.ReadLine();
                switch (menuoption)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Vill du se alla elever sorterade på förnamn eller efternamn");
                            Console.WriteLine("Mata in förnamn / efternamn");
                            string svar = Console.ReadLine();
                            
                            if (svar != "förnamn" && svar != "efternamn")
                            {
                                throw new Exception("Du mata in nått könstigt");
                            }

                            Console.WriteLine("Vill du ha stigande eller fallande ordning");
                            Console.WriteLine("Mata in stigande / fallande");
                            string ordning = Console.ReadLine();
                            if (ordning != "stigande" && ordning != "fallande")
                            {
                                throw new Exception("Du mata in nått könstigt");
                            }

                            List<Elev> Elever = null;
                            
                            if (ordning == "stigande")
                            {
                                if (svar == "förnamn")
                                {
                                    Console.WriteLine("Här sorterar vi på förnamn");
                                    var a = from s in context.Elev orderby s.Fnamn ascending select s;
                                    foreach (var item in a)
                                    {
                                        Console.WriteLine(item.Fnamn);
                                    }
                                }
                                else if (svar == "efternamn")
                                {
                                    Console.WriteLine("Här sorterar vi på efternamn");
                                    var b = from s in context.Elev orderby s.Lnamn ascending select s;
                                    foreach (var item in b)
                                    {
                                        Console.WriteLine(item.Lnamn);
                                    }
                                }
                            }
                            else
                            {
                                if (svar == "förnamn")
                                {
                                    Console.WriteLine("Här sorterar vi på förnamn");
                                    var c = from s in context.Elev orderby s.Fnamn descending select s;
                                    foreach (var item in c)
                                    {
                                        Console.WriteLine(item.Fnamn);
                                    }
                                    
                                }
                                else if (svar == "efternamn")
                                {
                                    Console.WriteLine("Här sorterar vi på efternamn");
                                    var d = from s in context.Elev orderby s.Lnamn descending select s;
                                    foreach (var item in d)
                                    {
                                        Console.WriteLine(item.Lnamn);
                                    }
                                }
                            }


                            //Elever.ForEach(delegate (Elev elev)
                            //{
                            //    Console.WriteLine(elev.Fnamn + " " + elev.Lnamn);
                            //});




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
                            //sen får användaren välja en av klasserna och då skrivs alla elever i den klassen ut

                            List<Klass> klasser = null;
                            var db = new SkolaDbContext();

                            

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
