using System;

namespace arrleapYearmiduim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int tmrrDay;
            int toDay = Convert.ToInt32(Console.ReadLine());
            int mtDay = Convert.ToInt32(Console.ReadLine());
            int numYear = Convert.ToInt32(Console.ReadLine());
            if (numYear > 0)
            {
                if (numYear % 4 == 0 && numYear % 100 == 0 && numYear % 400 == 0)
                {
                    if (mtDay == 1)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 2)
                    {
                        if (toDay == 29)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("3");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 3)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("4");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 4)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("5");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 5)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("6");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 6)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("7");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 7)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("8");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 8)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("9");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 9)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("10");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 10)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("11");
                            Console.WriteLine(numYear);
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 11)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("12");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 12)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay + 1);
                        }
                    }

                }
                else if (numYear % 4 == 0 && numYear % 100 == 0)
                {
                    if (mtDay == 1)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 2)
                    {
                        if (toDay == 28)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("3");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 3)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("4");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 4)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("5");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 5)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("6");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 6)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("7");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    if (mtDay == 7)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("8");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 8)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("9");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 9)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("10");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 10)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("11");
                            Console.WriteLine(numYear);
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 11)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("12");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 12)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("1");
                            Console.WriteLine(numYear + 1);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay + 1);
                        }
                    }

                }
                else if (numYear % 4 == 0)
                {
                    if (mtDay == 1)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 2)
                    {
                        if (toDay == 29)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("3");
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 3)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("4");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 4)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("5");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 5)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("6");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 6)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("7");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 7)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("8");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 8)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("9");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 9)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("10");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 10)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("11");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 11)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("12");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 12)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("1");
                            Console.WriteLine(numYear + 1);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay + 1);
                        }
                    }
                }
                else if (numYear % 4 != 0)
                {
                    if (mtDay == 1)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 2)
                    {
                        if (toDay == 28)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("3");
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 3)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("4");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 4)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("5");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 5)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("6");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 6)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("7");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 7)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("8");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 8)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("9");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 9)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("10");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 10)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("11");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 11)
                    {
                        if (toDay == 30)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("12");
                            Console.WriteLine(numYear);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay);
                            Console.WriteLine(numYear);
                        }
                    }
                    else if (mtDay == 12)
                    {
                        if (toDay == 31)
                        {
                            Console.WriteLine("1");
                            Console.WriteLine("1");
                            Console.WriteLine(numYear + 1);
                        }
                        else
                        {
                            tmrrDay = toDay + 1;
                            Console.WriteLine(tmrrDay);
                            Console.WriteLine(mtDay + 1);
                        }
                    }

                }
            }
            else
                    {
                        Console.WriteLine("Error");
                    }
                    Console.ReadKey();
            }

    }
}
