using System;
using System.Text;

namespace RockPaperScisors
{
    class Program
    {
        static void Main(string[] args)
        {
            // score macth
            int roundwinhuman = 0;
            int roundwincpu = 0;

            // score ROUND   
            int scoreCPU = 0;
            int scoreHuman = 0;
            int DRAW = 0;

            //Number MAX of round
            for (int t = 0; t < 5; t++)
            {
                // start || reste the round.
                scoreHuman = 0;
                scoreCPU = 0;


                for (int i = 0; i < 99; i++)
                {



                    // gener random num who attribut the swich statment (rock || paper || scissor)
                    Random r = new Random();
                    int n = r.Next(1, 4);

                    System.Console.WriteLine("Make your choose SCISSOR || ROCK || paper ");

                    string inputeplayer = Console.ReadLine();
                    inputeplayer = inputeplayer.ToUpper();


                    //round possibility 
                    switch (n)
                    {

                        case 1:
                            //n = "ROCK";
                            if (inputeplayer == "ROCK")
                            {
                                System.Console.WriteLine("CPU choose ROCK it is a DRAW !!! ");
                                DRAW++;

                            }

                            else if (inputeplayer == "SCISSORS")
                            {
                                System.Console.WriteLine("CPU choose ROCK The CPU WIN !!!! ");
                                scoreCPU++;
                            }

                            else if (inputeplayer == "PAPER")
                            {

                                System.Console.WriteLine("CPU choose ROCK CONGRAT you WIN");
                                scoreHuman++;
                            }
                            break;

                        case 2:
                            //n = "SCISSORS";

                            if (inputeplayer == "SCISSORS")
                            {
                                System.Console.WriteLine("CPU choose SCISSORS it is a DRAW !!! ");
                                DRAW++;
                            }
                            else if (inputeplayer == "ROCK")
                            {
                                System.Console.WriteLine("CPU choose SCISSORS  CONGRAT you WIN");
                                scoreHuman++;
                            }
                            else if (inputeplayer == "PAPER")
                            {
                                System.Console.WriteLine("CPU choose SCISSORS The CPU WIN !!!! ");
                                scoreCPU++;
                            }
                            break;

                        case 3:
                            //n = "PAPER";

                            if (inputeplayer == "PAPER")
                            {
                                System.Console.WriteLine("CPU choose PAPER it is a DRAW !!!");
                                DRAW++;
                            }
                            else if (inputeplayer == "SCISSORS")
                            {
                                System.Console.WriteLine("CPU choose PAPER CONGRAT you WIN");
                                scoreHuman++;
                            }
                            else if (inputeplayer == "ROCK")
                            {
                                System.Console.WriteLine("CPU choose PAPER The CPU WIN !!!! ");
                                scoreCPU++;
                            }
                            break;

                        default:
                            System.Console.WriteLine("invalide commande");
                            break;

                    }



                    System.Console.WriteLine("human == " + scoreHuman);
                    System.Console.WriteLine("CPU == " + scoreCPU);
                    System.Console.WriteLine("TOTAL DRAW== " + DRAW);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine(" ");

                    //stop si CPU a 3 win
                    if (scoreCPU == 3)
                    {
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Felicitation CPU WIN THE ROUND");
                        roundwincpu++;

                        break;
                    }
                    //stop si Human a 3 win
                    if (scoreHuman == 3)
                    {
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Felicitation HUMAN WIN THE ROUND");
                        roundwinhuman++;

                        break;
                    }

                }

                // Stop if human win 3 ROUND.  
                if (roundwinhuman == 3)
                {
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Humman win the war VS the IA");
                }

                //Stop if CPU win 3 ROUND
                if (roundwincpu == 3)
                {
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("THE world be conquer by the  MEGA Computer ");
                }
            }
        }
    }
}

