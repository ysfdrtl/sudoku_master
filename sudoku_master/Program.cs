using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku_master
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] sayi = new int[9, 9];
            int deger1;
            int deger2;
            Random rnd = new Random();

            Console.WriteLine("+---+---+---+");
            // burası atama yeri

            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                satir:

                    sayi[a, b] = rnd.Next(1, 10);
                    for (int c = 0; c < 9; c++)
                    {
                        if (sayi[a, b] == sayi[a, c])
                        {
                            goto satir;
                        }
                    }


                    for (int d = 0; d < 9; d++)
                    {
                        if (sayi[a, b] == sayi[d, b])
                        {
                            goto satir;
                        }
                    }
                    deger1 = a / 3;
                    deger2 = b / 3;
                    
                    //0,0
                    if (deger1 == 0 & deger2 == 0)
                    {
                        for (int e = 0; e < 3; e++)
                        {
                            for (int f = 0; f < 3; f++)
                            {
                                if (sayi[a,b]== sayi[e,f] & a != e & b != f)
                                {
                                    goto satir;
                                }
                                
                            }
                        }
                    }
                    
                    //0,1
                    if (deger1 == 0 & deger2 == 1)
                    {
                        for (int e = 0; e < 3; e++)
                        {
                            for (int f = 3; f < 6; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f)
                                {
                                    goto satir;
                                }
                            }
                        }
                    }
                    
                    //0,2
                    if (deger1 == 0 & deger2 == 2)
                    {
                        for (int e = 0; e < 3; e++)
                        {
                            for (int f = 6; f < 9; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f  )
                                {
                                    goto satir;
                                }
                            }
                        }
                    }
                    
                    //1,0
                    if (deger1 == 1 & deger2 == 0)
                    {
                        for (int e = 3; e < 6; e++)
                        {
                            for (int f = 0; f < 3; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f  )
                                {
                                    goto satir;
                                }
                            }
                        }
                    }
                    
                    //1,1
                    if (deger1 == 1 & deger2 == 1)
                    {
                        for (int e = 3; e < 6; e++)
                        {
                            for (int f = 3; f < 6; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f  )
                                {
                                    goto satir;
                                }
                            }
                        }
                    }

                    //1,2
                    if (deger1 == 1 & deger2 == 2)
                    {
                        for (int e = 3; e < 6; e++)
                        {
                            for (int f = 6; f < 9; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f  )
                                {
                                    goto satir;
                                }
                            }
                        }
                    }

                    //2,0
                    if (deger1 == 2 & deger2 == 0)
                    {
                        for (int e = 6; e < 9; e++)
                        {
                            for (int f = 0; f < 3; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f)
                                {
                                    goto satir;
                                }
                            }
                        }
                    }

                    //2,1
                    if (deger1 == 2 & deger2 == 1)
                    {
                        for (int e = 6; e < 9; e++)
                        {
                            for (int f = 3; f < 9; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f  )
                                {
                                    goto satir;
                                }
                            }
                        }
                    }

                    //2,2
                    if (deger1 == 2 & deger2 == 2)
                    {
                        for (int e = 6; e < 9; e++)
                        {
                            for (int f = 6; f < 9; f++)
                            {
                                if (sayi[a, b] == sayi[e, f] & a != e & b != f  )
                                {
                                    goto satir;
                                }
                            }
                        }
                    }

                }
            }

            // burası yazdırma yeri
            for (int a = 3; a < 12; a++)
            {
                for (int b = 3; b < 12; b++)
                {
                    if (b % 3 == 0)
                    {
                        Console.Write("|");
                    }
                    Console.Write(sayi[a - 3, b - 3]);

                }
                Console.WriteLine("|");

                if (a % 3 == 2)
                {
                    Console.WriteLine("+---+---+---+");
                }
            }



            Console.ReadLine();
        }
    }
}
