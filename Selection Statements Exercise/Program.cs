using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SelectionExercise

{
	class Program
	{
		static void Main(string[] args)
		{
			var favNumber = 6;

			Console.WriteLine("Guess my favorite number");

			var userInput = int.Parse(Console.ReadLine());

			if (userInput == favNumber)
			{
				Console.WriteLine("You guessed the correct number");
			}

			else if (userInput > favNumber)
			{

				Console.WriteLine("Too high");
			}

			else if (userInput < favNumber)
			{

				Console.WriteLine("Too Low");

			}

			else
			{
				Console.WriteLine("Nevermind");
			}


			Console.WriteLine("Whats your favorite subject?");

			var favSubject = (Console.ReadLine());

            switch (favSubject)
            {
				case "Science": 
			    Console.WriteLine("Science is fun ");
					break;

				case "Math":
					Console.WriteLine("Math is fun");
					break ;
				case "History":
					Console.WriteLine("History is fun");
					break ;
				case "English":
					Console.WriteLine("English is fun");
					break;
				default: Console.WriteLine("Ive never heard of that subject but sounds like fun");
					break;
            }

        }
    }
}