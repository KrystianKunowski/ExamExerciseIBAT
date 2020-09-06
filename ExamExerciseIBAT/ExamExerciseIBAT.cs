using System;

namespace ExamExerciseIBAT
{
    class ExamExerciseIBAT
    { 
            static void Main(string[] args)
            {
                int[] arrayOfUserInput = new int[10];
                int i;

                //-------------------------------------------------------- Array and variable declaration

                Console.WriteLine("Please enter 10 integers : ");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("array element = {0} : ", i);
                    arrayOfUserInput[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
                //-------------------------------------------------------- User input of 10 integers


                Console.Write("Please enter your magic number : ");
                int magicNumberInput = Convert.ToInt32(Console.ReadLine());

                if (magicNumberInput >= 0 && magicNumberInput <= 9)
                {
                    Console.WriteLine($"Your magic number is : {magicNumberInput}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Sorry, but please enter single digit number!");
                }
                Console.WriteLine("");

                //-------------------------------------------------------- User input & displaying of magic number

                Console.WriteLine("Your integers are : ");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("{0}  ", arrayOfUserInput[i]);
                }
                Console.WriteLine("");

                //-------------------------------------------------------- Displaying user input of 10 integers

                var sumOfNumbers = 0;
                foreach (var input in arrayOfUserInput)
                {
                    if (input.ToString().Contains(magicNumberInput.ToString()))
                        sumOfNumbers += input;
                }

                Console.WriteLine($"Sum of integers that contain the Magic Number :  {sumOfNumbers}");
                Console.WriteLine("");

                //---------------------------------------------------------- Displaying of sum integers that contain the "magic digit"


                Console.Write("Please enter the number to Filtr an array  : ");
                int userIputForSearch = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < arrayOfUserInput.Length; j++)
                {
                    if (arrayOfUserInput[j] >= userIputForSearch)
                    {
                        Console.Write(arrayOfUserInput[j] + " ");
                        Console.WriteLine("");
                    }
                }

                //-------------------------------------------------------- User input & displaying array of number entered
            }
        }

    }






