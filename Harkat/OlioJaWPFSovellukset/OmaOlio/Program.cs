using System;
//Robert Kajanti
namespace OmaOlio
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Boolean lopeta = false;
                Console.WriteLine("Tämä on aviomies simulaattori, pelaa vain jos et ole heikko hermoinen!");
                while (lopeta != true)
                {
                    Helvetti();
                    Console.ResetColor();
                    Console.WriteLine("Haluatko takaisin helvettiin? ");
                    if (Console.ReadLine().ToUpper() == "E") lopeta = true;

                }
                Console.ReadLine();

                static void Helvetti()
                {
                    bool jatka = true;
                    bool hieronta = false;
                    bool vaipanvaihto = false;
                    bool poliisi = false;
                    bool tiskaus = false;
                    bool siivous = false;
                    bool lapsetulos = false;
                    bool roskat = false;
                    bool rahaa = false;
                    bool kukat = false;
                    bool vuosipäivä = false;
                    bool synttärit = false;
                    bool matka = false;
                    bool muisto = false;
                    bool tappelu = false;

                    Console.WriteLine();
                    Mies Mies1 = new Mies(false, 100, 0);
                    Console.Write("Anna nimesi, mut älä jos se on Yrjö!: ");
                    Mies1.NäytäInfo();
                    while (jatka == true && Mies1.Kuollut != true)
                    {
                        try
                        {
                            if (number(1, 10) == 1 && hieronta != false)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e? ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    hieronta = true;
                                    Console.WriteLine("Et antanut vaimollesi hierontaa jota hän kovasti kaipasi, hän heittää sinut saksalaisella suplexilla kanveesiin! ");
                                    Mies1.OtaLämää(10);                                   
                                }

                            else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen");
                                }
                            }
                            else if (number(1, 10) == 2)
                            {
                                Console.WriteLine("Vaimosi kysyy vaihdatko vauvan paska vaipan? k/e? ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    vaipanvaihto = true;
                                    Console.WriteLine("Kieltäydyt vaihtamasta vaippaa, vaimosi hakkaa päätäsi paskaiseen pöntön reunaan ja huutaa PASKAPÄÄ!");
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Vaihdat vauvan paska vaipan mukisematta ja vaimosi kiittää sinua suudelmalla");
                                }
                            }
                            else if (number(1, 10) == 3)
                            {
                                Console.WriteLine("Vaimosi huutaa sinulle jostain mistä sinulla ei ole mitään hajua, huudatko takaisin? k/e?");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    poliisi = true;
                                    Console.WriteLine("Huudat takaisin, ja vaimosi soittaa poliisin paikalla, poliisit mukiloivat sinut");
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Olet kuin kivi, hiljainen ja tunteeton, vaimosi kiukunpuuska laantuu lopulta");
                                }
                            }
                            else if (number(1, 10) == 4)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }
                            else if (number(1, 10) == 5)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }
                            else if (number(1, 10) == 6)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }
                            else if (number(1, 10) == 7)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }
                            else if (number(1, 10) == 8)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }
                            else if (number(1, 10) == 9)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }
                            else if (number(1, 10) == 10)
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                                string asetus = Console.ReadLine();
                                if (asetus.Equals("e"))
                                {
                                    Mies1.OtaLämää(10);
                                }

                                else if (asetus.Equals("k"))
                                {
                                    Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä uneen ");
                                }
                            }

                            else
                            {
                                Mies1.NäytäInfo();
                            }


                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Älä mumise häslääjä! Valitse Oikein!");
                        }

                    }

                    static int number(int min, int max)
                    {
                        Random random = new Random();
                        return random.Next(min, max);
                    }
                }
            }
            
        }
    }
}
