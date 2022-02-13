using System;

namespace ifelseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour ;
            switch (hour)
            {
                case 13 :
                case 14 :
                case 15 :
                case 16 :
                Console.WriteLine("oglen zamanindasin!");
                break;
                case 7 :
                case 8 :
                case 9 :
                case 10 :
                case 11:
                case 12:
                Console.WriteLine("sabah zamanindasin!");
                break;
                case 19 :
                case 20 :
                case 21 :
                case 22 :
                case 23 :
                case 24 :
                Console.WriteLine("aksam zamanindasin!");
                break;
                default:
                break;
            }
        }
    }
}