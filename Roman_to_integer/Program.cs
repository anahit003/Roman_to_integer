using System;


namespace Roman_to_integer
{
    internal class Program
    {
            static void Main(string[] args)
            {
               Console.Write("s= ");
               string s = Convert.ToString(Console.ReadLine());
               Console.WriteLine("integer= "+ roman_to_int(s));


            }
             static int roman_to_int(string str)
            {
                var num = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (i > 0 && value(str[i]) > value(str[i - 1]))
                    {
                        num += value(str[i]) - value(str[i - 1]) * 2;
                    }
                    else
                    {
                        num += value(str[i]);
                    }
                }

                return num;
            }

             static int value(char chr)
            {
                switch (chr)
                {
                    case 'I': return 1;
                    case 'V': return 5;
                    case 'X': return 10;
                    case 'L': return 50;
                    case 'C': return 100;
                    case 'D': return 500;
                    case 'M': return 1000;
                    default: return 0;
                }
            }
        }
    }


