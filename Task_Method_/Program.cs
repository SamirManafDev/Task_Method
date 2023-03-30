using System;
using System.Threading;

namespace Task_Method
    {
        class Program
        {
            static void Main(string[] args)
            {   //Task 1.1
                //Sum(12,12);

            ////Task 1.2
            //int[] numbers = { 2, 3, 4, 52, -12, 12 };
            //Array(numbers);

            ////Task 1.3
            //float rounding = 12.211f;
            //digit(rounding);

            ////Task 1.4
            //bool result = Number(11);
            //if(result)
            //{
            //    Console.WriteLine("Number even");
            //}
            //else
            //{
            //    Console.WriteLine("Number odd");
            //}


            ////Task 1.5
            //Console.WriteLine(Hello(true));


            ////Task 1.6

            //Console.Write("Your name: ");
            //string name=Console.ReadLine();
            //Console.Write("Your surnname: ");
            //string surname=Console.ReadLine();
            //GamerInfo(name, surname);


            ////Task 1.7
            //Console.Write("Decimal number input:");
            //decimal number = decimal.Parse(Console.ReadLine());
            //MoneySqr(number);


            //Task 1.8
            ////Task 1.8
            //bool result = Number(37);
            //if (result)
            //{
            //    Console.WriteLine("Number simple");
            //}
            //else
            //{
            //    Console.WriteLine("Number compound");
            //}


            //Task 1.9
            //Console.Write("Input Number :");
            //string Number=Console.ReadLine();
            //int number=int.Parse(Number);
            //Console.Write("Input Power :");
            //string Power=Console.ReadLine();
            //int power=int.Parse(Power);
            //numberPower(number, power);


        }



        ////1.1
        //static void Sum(int number1,int number2)
        //{   
        //    Console.WriteLine(number1+number2);
        //}


        ////1.2
        //static void Array (int[] numbers)
        //{
        //    float sum = 0;
        //    float average;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum+= numbers[i];
        //    }
        //    average=sum/numbers.Length;
        //    Console.WriteLine(average);
        //}


        ////1.3
        //static void digit(float rounding)
        //{
        //    Console.WriteLine(Math.Round(rounding));
        //}


        ////1.4
        //public static bool Number(int number)
        //{
        //    if (number % 2 == 0 && number != 0)
        //    {
        //        return true;
        //    }
        //    return false;

        //}



        ////1.5
        //static string Hello(bool result)
        //{
        //    if (result)
        //        return "Beli";
        //    else
        //        return "Xeyir";
        //}





        ////1.6
        //static void GamerInfo(string name, string surname)
        //{
        //    Console.WriteLine($"Welcome to the game {name} {surname}");
        //}

        ////1.7
        //static void MoneySqr(decimal number) 
        //{
        //    decimal square=number * number;
        //    Console.WriteLine(square);
        //}


        
        ////1.8
        //static bool Number (int number)
        //{
        //    int num1 = 0;
        //    for(int i = 0; i < number; i++)
        //    {
        //        num1=number%i;
        //        if (num1 == 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //   }


        ////1.9
        //static void numberPower(int number,int power) 
        //{
        //    int numpower=1;
        //    int step = 1;
        //  while(step <= power)
        //    {
        //        numpower=numpower*number;
        //        step++;
        //    }

        //    Console.WriteLine(numpower);
        //}   
    }

}
