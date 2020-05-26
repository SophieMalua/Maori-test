using System;
using System.Collections.Generic;
namespace Maori_test
{
    class Program
    {
        public static string Paku { get; private set; }

        static void Main(string[] args)
        {


                Console.WriteLine("Welcome to the Te Reo Maori quiz");
                Console.WriteLine("please type your name");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
                Console.WriteLine("There Will be 3 levels and in each level there will be 4 questions");
                Console.WriteLine("Press enter to begin");
                Console.ReadLine();


                {
                    Console.WriteLine("Level 1 , Question 1 of level 1 " +
                      ("does Kuaha mean door or mat in English"));
                }
                string Kuaha = Console.ReadLine();
                {

                    if (Kuaha == "door")

                        Console.WriteLine("Correct , press enter to continue");



                    else

                        Console.WriteLine("That is incorrect" +
                          " please press enter to continue");
                    Console.ReadLine();

                    bool answered = false;
                    while (answered != false)
                        Console.WriteLine("");
                    Console.WriteLine("Level 1 , Question 2 of level 1, True or False , 'Whanau' means 'child'");
                    answered = bool.Parse(Console.ReadLine());
                    if (answered != false)
                        Console.WriteLine("You are Correct , press enter to continue");
                    Console.ReadLine();

                //aaa
                    if (answered == true)
                    {
                        Console.WriteLine("You are inncorrect, press enter to continue");
                        Console.ReadLine();
                    }


                    Console.WriteLine
                     ("Level 1, Question 3 of level 1, True or False, does 'kai' mean 'food' ?");
                    string food = Console.ReadLine();

                    if (food == "true")
                    {
                        Console.WriteLine("Correct , press enter to continue");
                        Console.ReadLine();
                    }
                    if (food == "false")
                        Console.WriteLine
                         ("that is incorrect , please press enter to continue");
                    Console.ReadLine();

                    Console.WriteLine
                     ("Question 4 of level 1  , 'ngeru' means 'dog' , true or false ? ");
                    string dog = Console.ReadLine();

                    if (dog == "false")
                        Console.WriteLine("correct , press enter to continue");

                    if (dog == "true")
                        Console.WriteLine("that is incorrect , press enter to continue");
                    Console.ReadLine();


                    bool answers = false;
                    while (answers != false)
                        Console.WriteLine("");
                    Console.
                     WriteLine
                     ("Level 2 , Question 1 of level 2 , True or False , 'Morena?' means 'Good morning?'");
                    answers = bool.Parse(Console.ReadLine());
                    if (answers != true)
                        Console.WriteLine("Correct , press enter to continue");
                    Console.ReadLine();

                    if (answers == false)
                    {
                        Console.WriteLine("That is incorrect , press enter to continue");
                        Console.ReadLine();
                    }
                    {
                        Console.WriteLine("Question 2 of level 2 , does 'whare' mean house or car?");
                        string hello = Console.ReadLine();
                        if (hello == "house")
                            Console.WriteLine("Correct , press enter to continue");
                        Console.ReadLine();

                        if (hello == "car")
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();
                        }

                        Console.WriteLine("Question 3 of level 3 , What does 'Kahurangi' mean. Is it Brown or Blue");
                        string yellow = Console.ReadLine();
                        if (yellow == "Blue")
                        {
                            Console.WriteLine("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else if (yellow == "Blue")
                        {
                            Console.WriteLine("Correct press enter to continue");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();

                        }

                        Console.WriteLine("Level 3, Question 1 is 'Ko ..... toku ingoa' what goes in the blank space. ?");
                        Console.WriteLine("type either 'Name' or 'bed' as an answer. ");
                        string group = Console.ReadLine();

                        if (group == "Name")
                            Console.WriteLine("Correct press enter to continue");
                        Console.ReadLine();

                        if (group == "bed")
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();
                        }
                    /*
                     []-these mean that they can only have a certain amount of data inside.
                     
                     */
             
                    string[] Qusetions = new string[3] { "Kakariki" , "Whero" , "Ma"};
                         


                        foreach (string question in Qusetions)
                        {
                            Console.WriteLine(question);
                        }
                        Console.WriteLine(" Question 2 of level 3 , Which one of these mean Red");

                        string ma = Console.ReadLine();

                        if (ma == "Whero")
                        {
                            Console.Write("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else if (ma == "Whero")
                        {
                            Console.WriteLine("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();
                        }

                    string[] Qusetioned = new string[3] { "Toilet", "Bathroom", "libary" };
                         


                        foreach (string question in Qusetioned)
                        {
                            Console.WriteLine(question);
                        }
                        Console.WriteLine(" Question 3 of level 3, Which one of these , when translated to maori means 'Whare paku'");

                        string Wharepaku = Console.ReadLine();

                        if (Wharepaku == "Toilet")
                        {
                            Console.Write("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else if (Wharepaku == "Toilet")
                        {
                            Console.WriteLine("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();
                        }

                        Console.WriteLine("Level 4 , Question 1");
                        List<int> numbers = new List<int>();

                        numbers.Add(1);
                        numbers.Add(5);
                        numbers.Add(10);

                        Console.WriteLine(numbers[0]);
                        Console.WriteLine(numbers[1]);
                        Console.WriteLine(numbers[2]);
                        Console.WriteLine("Which one of these numbers , when translated to maori , means 'Tekau ma rua' ");
                        int numbered = int.Parse(Console.ReadLine());

                        if (numbered == 12)
                        {
                            Console.WriteLine("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();
                        }
                        Console.WriteLine("Question 2 of level 4");
                        List<int> number = new List<int>();

                        number.Add(1);
                        number.Add(5);
                        number.Add(10);

                        Console.WriteLine(number[0]);
                        Console.WriteLine(number[1]);
                        Console.WriteLine(number[2]);
                        Console.WriteLine("Which one of these numbers , when translated to maori , means 'ono' ");
                        int numb = int.Parse(Console.ReadLine());

                        if (numb == 6)
                        {
                            Console.WriteLine("Correct press enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect press enter to continue");
                            Console.ReadLine();
                        }
                        Console.WriteLine("Question 3 of level 4");
                        Console.WriteLine("What does 'Kapati' mean in English ?");
                        string Cupboard = Console.ReadLine();
                        if ( Cupboard == "cupboard")
                        {
                            Console.WriteLine("Correct press enter to finish the Quiz");
                            Console.ReadLine();
                        }
                        else if (Cupboard == "cupboard")
                        {
                            Console.WriteLine("Correct please press enter to finish the Quiz");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect please press enter to finish the Quiz");
                            Console.ReadLine();
                        }
                        Console.WriteLine("CONGRATULATIONS QIUZ MASTER!!!!!");
                        Console.WriteLine("You have officially finished the Te Reo Maori Quiz");
                        Console.ReadLine();


                    }

















                }




























                Console.ReadKey();
            }
        }







    
}

