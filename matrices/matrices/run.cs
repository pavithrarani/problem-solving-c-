using System;

namespace ProblemSolving
{
    public interface problem

    {
        bool Solution();
    }




    class run
    {

        private static void Main(string[] args)
        {
            Console.WriteLine(" Problem 1:SpiralMatrix\n problem 2:FindPoint\n ");
            var input = int.Parse(Console.ReadLine());
            // Convert.ToInt16(input);
            switch (input)
            {
                case 1:
                    problem myProblem1 = new SpiralMatrix();
                    myProblem1.Solution();
                    Console.ReadLine();
                    break;
                case 2:
                    problem myProblem2 = new FindPoint();
                    myProblem2.Solution();
                    Console.ReadLine();
                    break;
            }




        }
    }
}
