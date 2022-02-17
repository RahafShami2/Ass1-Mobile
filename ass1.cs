using System;

namespace ConsoleApp1
{
    class Menu
    {
        static void Main(string[] args)
        {
            bool Finished = false;
            Console.WriteLine("\n                  Welcome! ");
            do
            {
                Console.WriteLine("\n__________________________________________________ \n");
                Console.WriteLine(" Main Menu:- \n");
                Console.WriteLine("1) Find the Largest Number \n");
                Console.WriteLine("2) Reverse a given number \n");
                Console.WriteLine("3) Find the largest digit of a number \n");
                Console.WriteLine("4) search for the first int number \n");
                Console.WriteLine("choose the number of operation: ");
                int operate = int.Parse(Console.ReadLine());

                if (operate == 1)
                {
                    var large = new LargestNum();
                    large.LargeNum();
                }
                else if (operate == 2)
                {
                    var reverse = new Reverse();
                    reverse.ReverseNumber();
                }
                else if (operate == 3)
                {
                    Console.Write("Enter a number:");
                    int num = int.Parse(Console.ReadLine());
                    var big = new DigitAnalyzer();
                    Console.WriteLine("Largest digit:" + big.GetLargestDigit(num));

                }
                else if (operate == 4)
                {
                     SearchNum.GetNumber();
                }
                else
                {
                    Console.WriteLine("exit!");
                    Finished = true;
                }
            } while (!Finished);
        }
    }
    class LargestNum
    {
        public void LargeNum()
        {
            int count = 0;
            Console.WriteLine("\n Entre the number of digit :");
            count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            for (int num = 0; num < count; num++)
            {
                Console.Write("Enter the Number  " + (num + 1) + ":");
                numbers[num] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            for (int large = 1; large < numbers.Length; large++)
            {
                if (max < numbers[large])
                {
                    max = numbers[large];
                }
            }
            Console.WriteLine("the largest number is:" + max);
            Console.ReadKey();
        }

    }

    class Reverse
    {
        public void ReverseNumber(){
        int reverse = 0;
        Console.Write("Enter a number: ");      
       int num= int.Parse(Console.ReadLine());     
       while(num!=0)      
       {      
        int remainder=num%10;        
        reverse=reverse*10+ remainder;      
        num=num/10;      
       }
    Console.Write("Reverse Number: "+reverse);  
        }
    }

    public class DigitAnalyzer
    {
        public  int GetLargestDigit(int num)
        {
            int large = 0;
            while (num > 0)
                {
                    int remainder = num % 10;
                    if (large < remainder)
                    {
                        large = remainder;
                    }
                    num = num / 10;
                }
            return large;
        }
    }

    public static class SearchNum
    {
        public static void GetNumber()
        {
            int num = 0;
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch >= '0' && ch <= '9')
                {
                    num = (num*10) +(ch - 48);
                }
            }
            Console.WriteLine("The total of numbers :" + num);
        }
    }
}
