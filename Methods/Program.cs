using System;
using System.Diagnostics;

namespace Methods
{
   class myMethods
   {

      static void Main(string[] args)
      {
            string multiply = "+";
            string add = "+";
            string Fede= "fede";
            string play = "play";
            
            Console.WriteLine("What do you want to do? multiply *, add +, Fede type Fede");
            string answer = Console.ReadLine();
            if(answer == Fede )
            {

                Greeting();

            }
            else if(answer == add)
            {

                addNumbers();

            }
            else if(answer == multiply)
            {

                Multiple();
            
            }
            else if (answer == play)
            {

                Play();

            }
            else 
            {

                Console.WriteLine("aii kau");
            
            }
            Console.ReadLine();


            Greeting();
            addNumbers();
            Multiple();
      }

        static void Greeting()
        {

            Console.WriteLine("What is your name");
            string myname = Console.ReadLine();
            Console.WriteLine($"Hello {myname}");
            Console.ReadLine();
            Console.WriteLine("--------------------------");

        }

        static void addNumbers() 
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine($"Your results are {result}");
            Console.WriteLine("--------------------------");
        }
        static void Multiple()
        {

            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine($"Your results are {result}");
            Console.WriteLine("--------------------------");
        }
        static void Play()
        {

            Console.WriteLine("nada");

        }

   }


}

