using System;

namespace CheckUnitTensPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,text="";
            int num1, num2, place,temp;
            Console.WriteLine("Enter a number");
            str = Console.ReadLine();
            num1 = Convert.ToInt32(str);
            Console.WriteLine("Enter a digit");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str);
            place = 1;
            while (num1 > 0)
            {
                temp = num1 % 10;
                num1 = num1 / 10;
                place++;
                if (temp == num2)
                {
                    switch (place)
                    {
                        case 1:
                            text = "unit's place";
                            break;
                        case 2:
                            text = "ten's place";
                            break;
                        case 3:
                            text = "hundreds place";
                            break;
                        case 4:
                            text = "thousands place";
                            break;
                        case 5:
                            text = "ten thousands place";
                            break;
                    }
                }
            }

            Console.WriteLine(num2+" present on "+text);

        }
    }
}
