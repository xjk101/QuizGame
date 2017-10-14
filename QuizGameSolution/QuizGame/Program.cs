using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rng = new Random();
            int selected = rng.Next(0, 9);
            string[] question = new string[9];
            string[] answer = new string[9];
            int[] track = new int[6];
            string playeranswer;
            int score = 0;
            int round = 1;
            int tracking = 0;
            track[tracking] = selected;

            Console.WriteLine("Nerdy Quiz Game");
            Console.WriteLine("Answer the 5 Questions and see how you rank.");

            question[0] = "Who wants to be King of the Pirates?\nA. Luffy\nB. Ichigo\nC. Naruto";
            answer[0] = "A. Luffy";
            question[1] = "Who is Iron Man?\nA. Clint Barton\nB. Tony Stark\nC. Peter Parker";
            answer[1] = "B. Tony Stark";
            question[2] = "Who killed Frieza in Dragon Ball Z?\nA. Goku\nB. Krillin\nC. Trunks";
            answer[2] = "C. Trunks";
            question[3] = "Who is the leader of the X-Men?\nA. Charles Xavier\nB. Magneto\nC. Wolverine";
            answer[3] = "A. Charles Xavier";
            question[4] = "How long did Oliver Queeen stay on the island?\nA. 3 Months\nB. 5 Years\nC. 10 Years";
            answer[4] = "B. 5 Years";
            question[5] = "Who is not a Jedi?\nA. Obiwan Kenobi\nB. Luke Skywalker\nC. Finn";
            answer[5] = "C. Finn";
            question[6] = "In the Super Mario Bros, What level do you finally defeat Koopa?\nA. 8\nB. 9\nC. 7";
            answer[6] = "A. 8";
            question[7] = "Who is the fastet man alive in the DCEU?\nA. Batman\nB. The Flash\nC. Aquaman";
            answer[7] = "B. The Flash";
            question[8] = "Who killed Cell in Dragon Ball Z?\nA. Goku\nB. Vegeta\nC. Gohan";
            answer[8] = "C. Gohan";

            while (round < 6)
            {
                Console.WriteLine();
                Console.WriteLine("Question #{0}", round);

                Console.WriteLine(question[selected]);
                Console.Write("Please type your answer: ");
                playeranswer = Console.ReadLine().ToUpper();

                if (playeranswer == answer[selected].Substring(0, 1))
                {
                    Console.WriteLine("You are correct. The answer is {0}.", answer[selected]);
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry my friend. The answer is {0}.", answer[selected]);
                }
                round++;
                selected = rng.Next(0, 9);

                while (track.Contains(selected))
                {
                    selected = rng.Next(0, 9);
                }
                tracking++;
                track[tracking] = selected;
            }

            Console.WriteLine();
            Console.WriteLine("You got {0} out of {1} questions right.", score, round-1);
            Console.ReadKey();
        }
    }
}
