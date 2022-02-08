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

                            
                            
                            if (ordning == "stigande")
                            {
                                if (svar == "förnamn")
                                {
                                    Console.Clear();
                                    var a = from s in context.Elev orderby s.Fnamn ascending select s;
                                    foreach (var item in a)
                                    {
                                        Console.WriteLine(item.Fnamn);
                                    }
                                    Console.WriteLine("");
                                }
                                else if (svar == "efternamn")
                                {
                                    Console.Clear();
                                    var b = from s in context.Elev orderby s.Lnamn ascending select s;
                                    foreach (var item in b)
                                    {
                                        Console.WriteLine(item.Lnamn);
                                    }
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                if (svar == "förnamn")
                                {
                                    Console.Clear();
                                    var c = from s in context.Elev orderby s.Fnamn descending select s;
                                    foreach (var item in c)
                                    {
                                        Console.WriteLine(item.Fnamn);
                                    }
                                    Console.WriteLine("");
                                    
                                }
                                else if (svar == "efternamn")
                                {
                                    Console.Clear();
                                    var d = from s in context.Elev orderby s.Lnamn descending select s;
                                    foreach (var item in d)
                                    {
                                        Console.WriteLine(item.Lnamn);
                                    }
                                    Console.WriteLine("");
                                }
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                           

                            var e = from k in context.Klass orderby k.KlassId ascending select k;
                            foreach (var item in e)
                            {
                                Console.WriteLine(item.KlassNamn);
                            }
                            Console.WriteLine("");

                            Console.WriteLine("Välj en klass");

                            string selection = Console.ReadLine();
                            Console.Clear();

                            switch (selection)
                            {
                                case "AB":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 1
                                            select c;
                                            
                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }
                                       
                                        Console.WriteLine("");
                                        break;
                                    }
                                case "CD":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 2
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "SQ":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 3
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "PR":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 4
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "YT":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 5
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "KJ":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 6
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "PA":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 7
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "RE":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 8
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                            }





                            break;
                        }
                    case "3":
                        {
                            Console.Clear();

                            Console.WriteLine("Förnamn?");
                            string förnamn = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Efternamn?");
                            string efternamn = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("PersonNr?");
                            string personnr = Console.ReadLine();
                            Console.Clear();
                            
                            
                            Console.WriteLine("BefattningsId?");
                            int befattningsid = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            var personal = new Personal { Fnamn = förnamn, Lnamn = efternamn, PrsNr = personnr, BefattningsId = befattningsid};
                            context.Add<Personal>(personal);
                            context.SaveChanges();

                            Console.Clear();
                            Console.WriteLine("Ny personal sparad");



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
