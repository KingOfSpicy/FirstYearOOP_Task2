using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doYouWant = false;
            bool stillMore = false;
            Console.WriteLine("Here is three little games:");
            Console.WriteLine();
            Console.WriteLine("1 is a simple calculator, you give 2 numbers and one operator, calculator will give you result.");
            Console.WriteLine("2 is guessing number game, to simplily test you are a moron or not.");
            Console.WriteLine("3 is car parking time calculator, you will tell me how long you have parked your car, and I will tell you how much you should pay.");
            Console.WriteLine();

            do
            {
                string gameAnswer;

                Console.Write("Which game you want to play?(Answer: 1, 2 or 3): ");
                gameAnswer = Console.ReadLine();
                while (gameAnswer != "1" && gameAnswer != "2" && gameAnswer != "3")
                {
                    Console.Write("Not valid, try again: ");
                    gameAnswer = Console.ReadLine();
                }
                if (gameAnswer == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok, you chose 1st game, nice choice. Let's start.(type ENTER to start)");
                    Console.ReadLine();

                    double number1;
                    double number2;
                    string operatorWhoKnows;
                    double together;
                    //do
                    //{
                    //Write 所呈現的字會跟在問題後面，但是WriteLine會換行!
                    Console.WriteLine();
                    Console.Write("Enter a first number: ");
                    string storeNumber1 = Console.ReadLine();
                    while (!Double.TryParse(storeNumber1, out number1))
                    {
                        Console.Write("Not valid, try again: ");
                        storeNumber1 = Console.ReadLine();
                    }
                    number1 = Convert.ToDouble(storeNumber1);

                    Console.Write("Enter a your second number: ");
                    string storeNumber2 = Console.ReadLine();
                    while (!Double.TryParse(storeNumber2, out number2))
                    {
                        Console.Write("Not valid, try again: ");
                        storeNumber2 = Console.ReadLine();
                    }
                    number2 = Convert.ToDouble(storeNumber2);

                    Console.Write("What is your operator? ");
                    operatorWhoKnows = Console.ReadLine();

                    while (operatorWhoKnows != "+" && operatorWhoKnows != "-" && operatorWhoKnows != "/" && operatorWhoKnows != "*")
                    {
                        Console.Write("Not valid, try again: ");
                        operatorWhoKnows = Console.ReadLine();
                    }
                    //Jari邏輯: -(p v q)= -p ^ -q

                    if (operatorWhoKnows == "+")
                    {
                        together = number1 + number2;
                        Console.WriteLine(Math.Round(together, 3));
                    }
                    else if (operatorWhoKnows == "-")
                    {
                        together = number1 - number2;
                        Console.WriteLine(Math.Round(together, 3));
                    }
                    else if (operatorWhoKnows == "/")
                    {
                        together = number1 / number2;
                        Console.WriteLine(Math.Round(together, 3));
                    }
                    else
                    {
                        together = number1 * number2;
                        Console.WriteLine(Math.Round(together, 3));
                    }

                }
                else if (gameAnswer == "2")
                {
                    string record1;
                    string record2;
                    //string record3;
                    Console.WriteLine();
                    Console.WriteLine("In this game, I have two numbers from 1 to 30, I will tell you one of it first, what you need to do is guess the second one is lower number or higher number.");
                    Console.WriteLine("These 2 numbers will not be the same. So there is no 'equal'.");
                    Console.WriteLine("And you only have one chance.");
                    Console.WriteLine();
                    Random r = new Random();
                    int x = r.Next(1, 31);
                    int y = r.Next(1, 31);

                    while (x == y)
                    {
                        y = r.Next(1, 31);
                    }
                    Console.WriteLine("Let's start:(press ENTER to continue...)");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("The first number is: " + x);
                    Console.Write("What is your answer: (Higher/Lower)");
                    string guessAnswer1 = Console.ReadLine().ToUpper();
                    while (guessAnswer1 != "HIGHER" && guessAnswer1 != "LOWER")
                    {
                        Console.Write("please answer higher or lower: ");
                        guessAnswer1 = Console.ReadLine().ToUpper();
                    }
                    if (x > y && guessAnswer1 == "LOWER")
                    {
                        Console.WriteLine("Oh wow you won!!");
                        Console.WriteLine("The x is " + x + " and the y is " + y + " and your answer is: " + y + " is " + guessAnswer1 + " than " + x);
                        record1 = "You won round 1";
                    }
                    else if (x < y && guessAnswer1 == "HIGHER")
                    {
                        Console.WriteLine("Oh wow you won!!");
                        Console.WriteLine("The x is " + x + " and the y is " + y + " and your answer is " + y + " is " + guessAnswer1 + " than " + x);
                        record1 = "You won round 1";
                    }
                    else
                    {
                        Console.WriteLine("Haha, you lose");
                        Console.WriteLine("The x is " + x + " and the y is " + y + " and your answer is " + y + " is " + guessAnswer1 + " than " + x);
                        record1 = "You lost round 1";
                    }

                    Console.WriteLine("It was just round one, prepare yourself");
                    Console.WriteLine("press ENTER to continue...");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Round 2 starting: let's simplily play paper-scissors-stone");
                    Console.WriteLine("It is three-game two-win system, who ever got 2 wins, round 2 will be end.");
                    Console.WriteLine("press ENTER to continue...");
                    Console.ReadLine();
                    Console.WriteLine();

                    Random s = new Random();
                    string masterAnswer;

                    s.Next(1, 4);


                    int z = 0;
                    int t = 0;
                    if (s.Next(1, 4) == 1)
                    {
                        masterAnswer = "PAPER";
                    }
                    else if (s.Next(1, 4) == 2)
                    {
                        masterAnswer = "SCISSORS";
                    }
                    else
                    {
                        masterAnswer = "STONE";
                    }
                    while (z < 2 && t < 2)
                    {
                        Console.WriteLine();
                        Console.Write("Now, GO!!! (type Paper/Scissors/Stone)");
                        string playerAnswer = Console.ReadLine().ToUpper();




                        while (playerAnswer != "STONE" && playerAnswer != "PAPER" && playerAnswer != "SCISSORS")
                        {
                            Console.Write("please answer Paper/Scissors/Stone: ");
                            playerAnswer = Console.ReadLine().ToUpper();
                        }
                        if (masterAnswer == "PAPER" && playerAnswer == "STONE")
                        {
                            Console.WriteLine("I win");
                            Console.WriteLine("My is " + masterAnswer + " yours is " + playerAnswer);
                            Console.WriteLine();
                            s.Next(1, 4);
                            if (s.Next(1, 4) == 1)
                            {
                                masterAnswer = "PAPER";
                            }
                            else if (s.Next(1, 4) == 2)
                            {
                                masterAnswer = "SCISSORS";
                            }
                            else
                            {
                                masterAnswer = "STONE";
                            }
                            z++;
                        }

                        else if (masterAnswer == "STONE" && playerAnswer == "SCISSORS")
                        {
                            Console.WriteLine("I win");
                            Console.WriteLine("My is " + masterAnswer + " yours is " + playerAnswer);
                            Console.WriteLine();
                            s.Next(1, 4);
                            if (s.Next(1, 4) == 1)
                            {
                                masterAnswer = "PAPER";
                            }
                            else if (s.Next(1, 4) == 2)
                            {
                                masterAnswer = "SCISSORS";
                            }
                            else
                            {
                                masterAnswer = "STONE";
                            }
                            z++;
                        }
                        else if (masterAnswer == "SCISSORS" && playerAnswer == "PAPER")
                        {
                            Console.WriteLine("I win");
                            Console.WriteLine("My is " + masterAnswer + " yours is " + playerAnswer);
                            Console.WriteLine();
                            s.Next(1, 4);
                            if (s.Next(1, 4) == 1)
                            {
                                masterAnswer = "PAPER";
                            }
                            else if (s.Next(1, 4) == 2)
                            {
                                masterAnswer = "SCISSORS";
                            }
                            else
                            {
                                masterAnswer = "STONE";
                            }
                            z++;
                        }
                        else if (playerAnswer == "STONE" && masterAnswer == "SCISSORS")
                        {
                            Console.WriteLine("You win");
                            Console.WriteLine("My is " + masterAnswer + " yours is " + playerAnswer);
                            Console.WriteLine();
                            s.Next(1, 4);
                            if (s.Next(1, 4) == 1)
                            {
                                masterAnswer = "PAPER";
                            }
                            else if (s.Next(1, 4) == 2)
                            {
                                masterAnswer = "SCISSORS";
                            }
                            else
                            {
                                masterAnswer = "STONE";
                            }
                            t++;
                        }
                        else if (playerAnswer == "SCISSORS" && masterAnswer == "PAPER")
                        {
                            Console.WriteLine("You win");
                            Console.WriteLine("My is " + masterAnswer + " yours is " + playerAnswer);
                            Console.WriteLine();
                            s.Next(1, 4);
                            if (s.Next(1, 4) == 1)
                            {
                                masterAnswer = "PAPER";
                            }
                            else if (s.Next(1, 4) == 2)
                            {
                                masterAnswer = "SCISSORS";
                            }
                            else
                            {
                                masterAnswer = "STONE";
                            }
                            t++;
                        }
                        else if (playerAnswer == "PAPER" && masterAnswer == "STONE")
                        {
                            Console.WriteLine("You win");
                            Console.WriteLine("My is " + masterAnswer + " yours is " + playerAnswer);
                            Console.WriteLine();
                            s.Next(1, 4);
                            if (s.Next(1, 4) == 1)
                            {
                                masterAnswer = "PAPER";
                            }
                            else if (s.Next(1, 4) == 2)
                            {
                                masterAnswer = "SCISSORS";
                            }
                            else
                            {
                                masterAnswer = "STONE";
                            }
                            t++;
                        }
                        else if (playerAnswer != "STONE" && playerAnswer != "SCISSORS" && playerAnswer != "PAPER")
                        {
                            while (playerAnswer != "PAPER" && playerAnswer != "SCISSORS" && playerAnswer != "STONE")
                            {
                                Console.Write("please answer (Paper/Scissors/Stone): ");
                                playerAnswer = Console.ReadLine().ToUpper();
                                s.Next(1, 4);
                                if (s.Next(1, 4) == 1)
                                {
                                    masterAnswer = "PAPER";
                                }
                                else if (s.Next(1, 4) == 2)
                                {
                                    masterAnswer = "SCISSORS";
                                }
                                else
                                {
                                    masterAnswer = "STONE";
                                }
                            }
                        }
                        else
                        {
                            while (masterAnswer == playerAnswer)
                            {
                                s.Next(1, 4);
                                Console.WriteLine("We have same, we both are " + masterAnswer);
                                if (s.Next(1, 4) == 1)
                                {
                                    masterAnswer = "PAPER";
                                }
                                else if (s.Next(1, 4) == 2)
                                {
                                    masterAnswer = "SCISSORS";
                                }
                                else
                                {
                                    masterAnswer = "STONE";
                                }
                                break;
                            }
                        }
                        if (z == 2 || t == 2)
                        {
                            break;
                        }
                    }
                    if (z == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("I won round 2, I got two wins from paper-scissors-stone.");
                        record2 = "You lost round 2";
                        Console.WriteLine("Round 3 starting, type ENTER to continue...");
                        Console.ReadLine();
                    }
                    else if (t == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("you won round 2, you got two wins from paper-scissors-stone");
                        record2 = "You won round 2";
                        Console.WriteLine("Round 3 starting, type ENTER to continue...");
                        Console.ReadLine();
                    }
                    Console.WriteLine();
                    //Console.WriteLine("Round 3 starting, type ENTER to continue...");
                    Console.WriteLine();
                    Console.WriteLine("Alright, let's start, you gonna guess how much fingers I am showing now, from 1-5.");
                    Console.WriteLine("You have 2 chances to guess.");
                    Console.WriteLine();
                    Console.WriteLine("type ENTER to continue...");
                    Console.WriteLine();

                    int 猜的次數 = 0;
                    int j;
                    Random q = new Random();
                    int f = q.Next(1, 6);

                    Console.WriteLine();
                    Console.Write("Now guess(type 1 to 5): ");
                    string u = Console.ReadLine();
                    while(!Int32.TryParse(u, out j))
                    {
                        Console.Write("Invalid(please type 1 to 5): ");
                        u = Console.ReadLine();
                       
                    }
                    while (猜的次數 < 2 && Int32.TryParse(u, out j))//還沒用完兩次機會
                    {

                        j = Convert.ToInt32(u);
                        if (j >= 1 && j <= 5)
                        {
                            猜的次數++;
                        }
                        j = Convert.ToInt32(u);
                        while (猜的次數 <= 2 && j >= 6 || j <= 0 || !Int32.TryParse(u, out j))//寫不等式
                        {
                            Console.WriteLine("Invalid guess");
                            Console.Write("Please try again(1 to 5): ");
                            u = Console.ReadLine();
                            j = Convert.ToInt32(u);
                            if (j >= 1 && j <= 5)
                            {
                                猜的次數++;
                                break;
                            }

                        }
                        if (f == j && 猜的次數==1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Shit you guess right.");

                        }
                        else if (f != j && 猜的次數 < 2)//猜錯一次但還有機會時
                        {
                            while (f != j && 猜的次數 < 2)
                            {
                                Console.WriteLine();
                                Console.Write("you guess wrong try again(1 to 5): ");
                                u = Console.ReadLine();
                                while(!Int32.TryParse(u, out j) || j >= 6 || j <= 0)
                                {
                                    Console.Write("Invalid(please type 1 to 5): ");
                                    u = Console.ReadLine();
                                }
                                j = Convert.ToInt32(u);
                                猜的次數++;
                                if (f == j)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Shit you guess right.");

                                }
                            };
                        }

                        if (f != j && 猜的次數 == 2)//喪失所有機會時
                        {
                            Console.WriteLine();
                            Console.WriteLine("You out of chance, and you did not guess right. My fingers number is " + f);
                        }
                    }

                    //catch (Exception)
                    //{

                    //    Console.WriteLine("Invalid guess");
                    //    Console.Write("Please try again(1 to 5): ");
                    //    u = Console.ReadLine();
                    //    j = Convert.ToInt32(u);



                    //}
                }
                
                else
                {
                    double fee;
                    int payFee;
                    double customerHour;
                    Console.WriteLine();
                    Console.WriteLine("I am gonna calculate how much you need to pay for parking fee.");
                    Console.Write("Tell me how long you have parked your car: (hours)");
                    string customerPark = Console.ReadLine();
                    //customerHour = Convert.ToDouble(customerPark);
                    while (!Double.TryParse(customerPark, out customerHour) || customerHour<0)
                    {
                        Console.Write("Invalid, Tell me how long you have parked your car: (hours)");
                        customerPark = Console.ReadLine();
                    }
                    
                    Math.Round(customerHour, 2);
                    if (customerHour <= 2)
                    {
                        fee = 2 * customerHour;

                        Console.Write("Your parking fee is: {0:F2}", fee);
                        Console.WriteLine(" euro.");
                        Console.ReadLine();
                    }else if (customerHour>2 && customerHour<=5 )
                    {
                        fee = 1.75 * customerHour;

                        Console.Write("Your parking fee is: {0:F2}", fee);
                        Console.WriteLine(" euro.");
                        Console.ReadLine();
                    }
                    else
                    {
                        fee = 1.5 * customerHour;

                        Console.Write("Your parking fee is: {0:F2}", fee);
                        Console.WriteLine(" euro.");
                        Console.ReadLine();
                    }

                    
                }
                Console.Write("Do you want to play again?(Y/N): ");
                string gameRound = Console.ReadLine().ToUpper();
                do
                {
                    if (gameRound.StartsWith("Y"))
                    {
                        doYouWant = false;
                        stillMore = true;
                    }
                    else if (gameRound.StartsWith("N"))
                    {
                        Console.WriteLine("I am waiting for you play next time. hehe");
                        Console.WriteLine();
                        //Console.ReadLine();
                        stillMore = false;
                        doYouWant = false;
                    }
                    else
                    {
                        while (gameRound != "Y" && gameRound != "N")
                        {
                        Console.Write("Y or N please: ");
                        gameRound = Console.ReadLine().ToUpper();
                        doYouWant = true;
                        }
                    }
                }
                while (doYouWant);
                
            }
            while (stillMore);

            //Random r = new Random();
            //r.Next(1, 20);

            //Console.Write(r.Next(1, 20));
            //Console.ReadLine();
        }
    }
}
